using System;
using System.Threading;
using System.Threading.Tasks;
using bot.Entity;
using bot.HttpClients;
using bot.Services;
using Microsoft.Extensions.Logging;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using bot.Dto.V2;

namespace bot
{
    public class Handlers
    {
        private readonly ILogger<Handlers> _logger;
        private readonly IStorageService _storage;
        private readonly ICacheService _cache;
        private static float _longitude;
        private static float _latitude;

        public Handlers(
            ILogger<Handlers> logger, 
            IStorageService storage,
            ICacheService cache)
        {
            _logger = logger;
            _storage = storage;
            _cache = cache;
        }

        public Task HandleErrorAsync(ITelegramBotClient client, Exception exception, CancellationToken ctoken)
        {
            var errorMessage = exception switch
            {
                ApiRequestException => $"Error occured with Telegram Client: {exception.Message}",
                _ => exception.Message
            };

            _logger.LogCritical(errorMessage);

            return Task.CompletedTask;
        }

        public async Task HandleUpdateAsync(ITelegramBotClient client, Update update, CancellationToken ctoken)
        {
            var handler = update.Type switch
            {
                UpdateType.Message => BotOnMessageReceived(client, update.Message),
                UpdateType.EditedMessage => BotOnMessageEdited(client, update.EditedMessage),
                UpdateType.CallbackQuery => BotOnCallbackQueryReceived(client, update.CallbackQuery),
                UpdateType.InlineQuery => BotOnInlineQueryReceived(client, update.InlineQuery),
                UpdateType.ChosenInlineResult => BotOnChosenInlineResultReceived(client, update.ChosenInlineResult),
                _ => UnknownUpdateHandlerAsync(client, update)
            };

            try
            {
                await handler;
            }
            catch(Exception e)
            {

            }
        }

        private async Task BotOnMessageEdited(ITelegramBotClient client, Message editedMessage)
        {
            throw new NotImplementedException();
        }

        private async Task UnknownUpdateHandlerAsync(ITelegramBotClient client, Update update)
        {
            throw new NotImplementedException();
        }

        private async Task BotOnChosenInlineResultReceived(ITelegramBotClient client, ChosenInlineResult chosenInlineResult)
        {
            throw new NotImplementedException();
        }

        private async Task BotOnInlineQueryReceived(ITelegramBotClient client, InlineQuery inlineQuery)
        {
            throw new NotImplementedException();
        }

        private async Task BotOnCallbackQueryReceived(ITelegramBotClient client, CallbackQuery callbackQuery)
        {
            throw new NotImplementedException();
        }

        private async Task BotOnMessageReceived(ITelegramBotClient client, Message message)
        {
            if(message.Location != null)
            {
                await _cache.GetOrUpdatePrayerTimeAsync(message.Chat.Id, message.Location.Longitude, message.Location.Latitude);
                await client.SendTextMessageAsync(
                    message.Chat.Id,
                    "Location successfully accepted\nNow you can get your timezone prayertime",
                    replyToMessageId: message.MessageId,
                    replyMarkup: MessageBuilder.MenuShow()
                );
                _longitude = message.Location.Longitude;
                _latitude = message.Location.Latitude;
                        var user = new BotUser(
                            chatId: message.Chat.Id,
                            username: message.From.Username,
                            fullname: $"{message.From.FirstName} {message.From.LastName}",
                            longitude: _longitude,
                            latitude: _latitude,
                            address: string.Empty);
                        if(await _storage.ExistsAsync(message.Chat.Id))
                        {
                            await _storage.UpdateUserAsync(user);
                        }
                        else
                            await _storage.InsertUserAsync(user);
                            var result=await _storage.InsertUserAsync(user);

                        if(result.IsSuccess)
                        {
                            _logger.LogInformation($"New user added: {message.Chat.Id}");
                        }

                Console.WriteLine($"{_latitude} {_longitude}");
                Console.WriteLine($"{message.From.Username} --> {message.From.FirstName} {message.From.LastName}");
            }
            else
            { 
                Console.WriteLine($"{message.Text}");
                if(message.Text=="/start"){
                    await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Welcome to our Prayer Time bot\nIn order to get Namaz times please share your Location...",
                    parseMode: ParseMode.Markdown,
                    replyMarkup: MessageBuilder.LocationRequestButton());}
                else if(message.Text=="Change Location") await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "Change Location",
                    parseMode: ParseMode.Markdown,
                    replyMarkup: MessageBuilder.LocationRequestButton());
                else if(message.Text=="Settings") await client.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "Settings",
                            parseMode: ParseMode.Markdown,
                            replyMarkup: MessageBuilder.SettingsProperty());
                else if(message.Text=="Back to menu")
                            await client.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "Menu",
                            parseMode: ParseMode.Markdown,
                            replyMarkup: MessageBuilder.MenuShow());         
                else if(message.Text=="Cancel")
                            await client.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text:"Cancel",
                            parseMode: ParseMode.Markdown,
                            replyMarkup: MessageBuilder.MenuShow());
                else if(message.Text=="Today")
                {
                    if(await _storage.ExistsAsync(message.Chat.Id))
                    {
                        var res = await _storage.GetUserAsync(message.Chat.Id);
                        var result = await _cache.GetOrUpdatePrayerTimeAsync(res.ChatId, res.Longitude, res.Latitude);
                        var times = result.prayerTime;
                    await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: @$"
*Fajr*: {times.Fajr}
*Sunrise*: {times.Sunrise}
*Dhuhr*: {times.Dhuhr}
*Asr*: {times.Asr}
*Maghrib*: {times.Maghrib}
*Isha*: {times.Isha}
*Midnight*: {times.Midnight}
                    
*Method*: {times.CalculationMethod}
                    ",
                    parseMode: ParseMode.Markdown,
                    replyMarkup: MessageBuilder.MenuShow());
                    }
                    else{
                         await client.SendTextMessageAsync(
                    chatId: message.Chat.Id,
                    text: "In order to get Namaz times please share your Location...",
                    parseMode: ParseMode.Markdown,
                    replyMarkup: MessageBuilder.LocationRequestButton());
                    }

                }
                else await client.SendTextMessageAsync(
                            chatId: message.Chat.Id,
                            text: "Error occured!\nPlease try again.");
            }
        }
    }
}
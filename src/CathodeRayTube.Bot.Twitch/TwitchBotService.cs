using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CathodeRayTube.Bot.Twitch
{
    public class TwitchBotService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<TwitchBotService> _logger;

        public TwitchBotService(IServiceProvider serviceProvider, ILogger<TwitchBotService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogDebug("Executing asynchronusly");

            return Task.CompletedTask;
        }
    }
}

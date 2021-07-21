using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using CoronaApiService.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace CoronaApiService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                
                using(WebClient webClient = new WebClient())
                {
                    string json = webClient.DownloadString("https://coronavirus-tracker-api.herokuapp.com/v2/locations");
                    CoronaApiData apiData = JsonConvert.DeserializeObject<CoronaApiData>(json);
                    _logger.LogInformation("{@Latest}",apiData.Latest);
                }

                await Task.Delay(2000, stoppingToken);
            }
        }
    }
}

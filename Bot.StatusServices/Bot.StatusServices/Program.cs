using DataAccessLayer;
using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.EFRepositories;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;

namespace Bot.StatusServices
{
    public class Program
    {
        private readonly static string token = "2057477144:AAFhXqP7-6bI5tE1PdVEKVdYUjZC4oTAWLw";
        private readonly static string connectionStringSQL31 = "Data Source=SQL31,1433;Initial Catalog=Avrora37; Integrated Security=false; User ID=rpitvInfo; Password=QQQqqq123";

        private readonly static string creatorId = "309516361";
        private readonly static string chatId = "-654506272";

        private static TelegramBotClient botClient;

        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.start();
        }

        public async Task start()
        {
            IServiceCollection serviceCollection = new ServiceCollection()
            .AddLogging()
            .AddDbContext<Avrora37Context>(opts => opts.UseSqlServer(connectionStringSQL31))
            .AddScoped<IServiceStatusesRepository, ServiceStatusesRepository>();        

            IServiceProvider services = serviceCollection.BuildServiceProvider();

            IServiceStatusesRepository serviceStatusesRepository = services.GetService<IServiceStatusesRepository>();

            botClient = new TelegramBotClient(token);

            await getStatus(serviceStatusesRepository);
        }

        private async Task getStatus(IServiceStatusesRepository serviceStatusesRepository)
        {
            try
            {
                if (DateTime.Now.Hour == 8 && DateTime.Now.Minute == 0)
                {

                    List<ServiceStatus> serviceStatuses = await serviceStatusesRepository.getStatuses();

                    string notification = "";

                    foreach (ServiceStatus serviceStatus in serviceStatuses)
                    {
                        if (DateTime.Now.Date == serviceStatus.Date && serviceStatus.Status == 0)
                        {
                            notification += $"\U00002757 {serviceStatus.Date.ToShortDateString()} есть ошибки по сервису {serviceStatus.Service} \n";
                        }
                    }

                    if (notification != "")
                    {
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: notification
                            );
                    }
                }
            }
            catch (Exception e)
            {
                string not = e.Message;

                await botClient.SendTextMessageAsync(
                    chatId: creatorId,
                    text: not
                    );
            }
        }
    }
}

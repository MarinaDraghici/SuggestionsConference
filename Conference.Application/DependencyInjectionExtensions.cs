using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Conference.Application
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection RegisterBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddTransient<EnrollCustomerOperation>();
            //services.AddTransient<CreateAccount>();
            //services.AddTransient<DepositMoney>();
            //services.AddTransient<WithdrawMoney>();
            //services.AddTransient<PurchaseProduct>();
            //services.AddTransient<QueryHandler>();
            
           // services.AddSingleton<NewIban>();

            services.AddSingleton<Data.ConferenceDbContext>();

           

            return services;
        }
    }
}

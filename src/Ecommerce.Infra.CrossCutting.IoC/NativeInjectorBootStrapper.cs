using Ecommerce.Domain.CommandHandlers.Persons.Customers;
using Ecommerce.Domain.Commands.Persons.Customers;
using Ecommerce.Domain.Core.Bus.Interfaces;
using Ecommerce.Domain.Core.Events.Interfaces;
using Ecommerce.Domain.Core.Notifications;
using Ecommerce.Domain.EventHandlers.Persons.Customers;
using Ecommerce.Domain.Events.Persons.Customers;
using Ecommerce.Domain.Interfaces.Persons.Customers;
using Ecommerce.Domain.Interfaces.Persons.Users;
using Ecommerce.Domain.Interfaces.UoW;
using Ecommerce.Infra.CrossCotting.Identity.Authorizations;
using Ecommerce.Infra.CrossCotting.Identity.Models;
using Ecommerce.Infra.CrossCotting.Identity.Services;
using Ecommerce.Infra.CrossCotting.Identity.Services.Interfaces;
using Ecommerce.Infra.CrossCutting.Bus;
using Ecommerce.Infra.Data.Contexts;
using Ecommerce.Infra.Data.EventSourcings;
using Ecommerce.Infra.Data.Repositories.EventSourcing;
using Ecommerce.Infra.Data.Repositories.EventSourcing.Iterfaces;
using Ecommerce.Infra.Data.Repositories.Persons.Customers;
using Ecommerce.Infra.Data.UoW;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Ecommerce.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
            services.AddSingleton<IAuthorizationHandler, ClaimRequirementHandler>();

            // Application
            // services.AddScoped<ICustomerAppService, CustomerAppService>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<INotificationHandler<CustomerRegisteredEvent>, CustomerEventHandler>();
            services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
            services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<RegisterNewCustomerCommand, bool>, CustomerCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateCustomerCommand, bool>, CustomerCommandHandler>();
            services.AddScoped<IRequestHandler<RemoveCustomerCommand, bool>, CustomerCommandHandler>();

            // Infra - Data
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<EcommerceDbContext>();

            // Infra - Data EventSourcing
            services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            services.AddScoped<IEventStore, SqlEventStore>();
            services.AddScoped<EventStoreSqlContext>();

            // Infra - Identity Services
            services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            // Infra - Identity
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
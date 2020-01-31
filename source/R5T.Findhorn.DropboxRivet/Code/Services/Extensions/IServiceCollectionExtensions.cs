using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Dalkeith.Standard;
using R5T.Dimitrios.DropboxRivet;
using R5T.Findhorn.Dimitrios;
using R5T.Lombardy.Standard;


namespace R5T.Findhorn.DropboxRivet
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IDataDirectoryPathProvider"/> service.
        /// </summary>
        public static IServiceCollection AddDataDirectoryPathProvider(this IServiceCollection services)
        {
            services.AddOrganizationDataDirectoryPathProvider(
                services.AddDropboxRivetOrganizationDirectoryPathProviderAction(),
                services.AddDataDirectoryNameConventionAction(),
                services.AddStringlyTypedPathOperatorAction())
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IDataDirectoryPathProvider"/> service.
        /// </summary>
        public static ServiceAction<IDataDirectoryPathProvider> AddDataDirectoryPathProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IDataDirectoryPathProvider>(() => services.AddDataDirectoryPathProvider());
            return serviceAction;
        }
    }
}

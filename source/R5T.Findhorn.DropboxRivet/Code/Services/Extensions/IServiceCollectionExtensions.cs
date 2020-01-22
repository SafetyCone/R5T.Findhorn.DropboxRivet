using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dalkeith.Standard;
using R5T.Dimitrios.DropboxRivet;
using R5T.Findhorn.Dimitrios;
using R5T.Lombardy.Standard;


namespace R5T.Findhorn.DropboxRivet
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDataDirectoryPathProvider(this IServiceCollection services)
        {
            services
                .AddSingleton<IDataDirectoryPathProvider, OrganizationDataDirectoryPathProvider>()
                .AddDataDirectoryNameConvention()
                .AddDropboxRivetOrganizationDirectoryPathProvider()
                .AddStringlyTypedPathOperator()
                ;

            return services;
        }
    }
}

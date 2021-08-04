

using Adapter.Interfaces;
using Adapter.Map;
using Services.Services;
using Autofac;
using Core.Interface.Services;
using Repository.Repositories;
using Core.Interface.Repository;
using Application.Interface;
using Application.Service;


namespace IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC SERVICE
            builder.RegisterType<ServiceCmcconciliamastercredito>().As<IServiceCmcconciliamastercredito>();

            #endregion

            #region IOC REPOSITORY
            builder.RegisterType<RepositoryCmcconciliamastercredito>().As<IRepositoryCmcconciliamastercredito>();

            #endregion

            #region IOC MAPPER
            builder.RegisterType<MapperCmcconciliamastercredito>().As<IMapperCmcconciliamastercredito>();
            builder.RegisterType<MapperListaParcelas>().As<IMapperListaParcelas>();
            #endregion

            #region IOC APPLICATION
            builder.RegisterType<ApplicationServiceAlertaChargeback>().As<IApplicationAlertaChargeback>();
            builder.RegisterType<ApplicationServiceListaParcelas>().As<IApplicationListaParcelas>();
            builder.RegisterType<ApplicationServiceAtualizaChargeback>().As<IApplicationAtualizaChargeback>();
            #endregion



        }
    }
}




using Autofac;
using Dominio.Interfaces;
using Dominio.Modelos;
using Infra.Repositorio;
using Servico.Servicos;

namespace IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ContaRepositorio>().As<IRepositoryConta>();

            builder.RegisterType<contaServico>().As<IContaServico>();

          





        }
    }
}

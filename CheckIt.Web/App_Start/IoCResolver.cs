using Autofac;
using Autofac.Integration.Mvc;
using CheckIt.Domain;
using CheckIt.Entities;
using CheckIt.Web.Controllers;
using CheckIt.Web.Infras.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Web.Mvc;

namespace CheckIt.Web
{
    public class IoCResolver : Module
    {
        internal class IdentityModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                
                builder.Register(c => new CheckItContext("CheckItContext"));
                builder.Register(c => new UserStore<User>(c.Resolve<CheckItContext>()));
                builder.Register(c => new UserManager<User>(c.Resolve<UserStore<User>>()));
            }
        }

        internal class RepositoriesModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                builder.RegisterType<AccountRepository>().As<IAccountRepository>().InstancePerHttpRequest();
                builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerHttpRequest();
                builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerHttpRequest();
                builder.RegisterType<ChecklistRepository>().As<IChecklistRepository>().InstancePerHttpRequest();
                builder.RegisterType<SectionRepository>().As<ISectionRepository>().InstancePerHttpRequest();
                builder.RegisterType<ItemRepository>().As<IItemRepository>().InstancePerHttpRequest();
                builder.RegisterType<KeywordRepository>().As<IKeywordRepository>().InstancePerHttpRequest();
                builder.RegisterType<FolderRepository>().As<IFolderRepository>().InstancePerHttpRequest();
            }
        }

        internal class InfrastructureModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                ///TODO: nlog
            }
        }
    }
}
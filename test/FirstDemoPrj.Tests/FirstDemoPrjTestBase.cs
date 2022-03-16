using System;
using System.Threading.Tasks;
using Abp.TestBase;
using FirstDemoPrj.EntityFrameworkCore;
using FirstDemoPrj.Tests.TestDatas;

namespace FirstDemoPrj.Tests
{
    public class FirstDemoPrjTestBase : AbpIntegratedTestBase<FirstDemoPrjTestModule>
    {
        public FirstDemoPrjTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<FirstDemoPrjDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<FirstDemoPrjDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<FirstDemoPrjDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<FirstDemoPrjDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<FirstDemoPrjDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<FirstDemoPrjDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<FirstDemoPrjDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<FirstDemoPrjDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}

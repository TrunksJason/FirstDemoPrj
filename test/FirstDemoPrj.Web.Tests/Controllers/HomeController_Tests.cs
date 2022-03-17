using System.Threading.Tasks;
using FirstDemoPrj.Web.Controllers;
using Shouldly;
using Xunit;

namespace FirstDemoPrj.Web.Tests.Controllers
{
    public class HomeController_Tests: FirstDemoPrjWebTestBase
    {
        [Fact]
        public async System.Threading.Tasks.Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}

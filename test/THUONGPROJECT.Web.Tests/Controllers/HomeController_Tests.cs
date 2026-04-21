using System.Threading.Tasks;
using THUONGPROJECT.Models.TokenAuth;
using THUONGPROJECT.Web.Controllers;
using Shouldly;
using Xunit;

namespace THUONGPROJECT.Web.Tests.Controllers
{
    public class HomeController_Tests: THUONGPROJECTWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
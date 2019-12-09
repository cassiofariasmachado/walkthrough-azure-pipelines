using Echo.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Echo.Api.Test
{
    public class EchoControllerTest
    {
        [Fact]
        public void GetPassingEchoShouldReturnOk()
        {
            var controller = new EchoController();

            var response = controller.Get("Testing");

            var okResult = Assert.IsType<OkObjectResult>(response);
            Assert.Equal("Testing", okResult.Value);
        }

        [Fact]
        public void GetNotPassingEchoShouldReturnBadRequest()
        {
            var controller = new EchoController();

            var response = controller.Get(null);

            Assert.IsType<BadRequestResult>(response);
        }
    }
}

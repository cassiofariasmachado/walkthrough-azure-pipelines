using Echo.Api.Controllers;
using Xunit;

namespace Echo.Api.Test
{
    public class HealthCheckControllerTest
    {
        [Fact]
        public void GetShouldReturnPulsing()
        {
            var controller = new HealthCheckController();

            var response = controller.Get();

            Assert.Equal("Pulsing", response);
        }
    }
}

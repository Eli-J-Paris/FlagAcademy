using Microsoft.AspNetCore.Mvc.Testing;

namespace FlagAcademy.FeatureTests
{
    public class HomeControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {

        private readonly WebApplicationFactory<Program> _factory;

        public HomeControllerTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Index_ShowsMainMenuPage()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/");
            var html = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            Assert.Contains("<h1>MainMenu</h1>", html);
        }

        [Fact]
        public async Task Play_ShowsGuessingGamePage()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/play");
            var html = await response.Content.ReadAsStringAsync();

            response.EnsureSuccessStatusCode();
            Assert.Contains("<h1>Play game</h1>", html);
        }
    }
}
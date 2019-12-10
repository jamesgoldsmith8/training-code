using Devops.Client.Controllers;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Devops.Test
{
    public class ClientTest
    {
        // private readonly ILogger logger = new LoggerFactory.Create();
        private readonly ILogger<HomeController> logger = LoggerFactory.Create(o => o.SetMinimumLevel(LogLevel.Debug)).CreateLogger<HomeController>();
        [Fact]
        public void Test_IndexPage()
        {
            var home = new HomeController(logger);

            var index = home.Index();
            
            Assert.NotNull(index);
        }

        [Fact]
        public void Test_PrivacyPage()
        {
            var home = new HomeController(logger);

            var privacy = home.Privacy();
            
            Assert.NotNull(privacy);
        }
    }
}
// needed to reload omnisharp
// needed to add logger to HomeController
// install coverlet.collector
// 
// dotnet test --collect:"XPlat Code Coverage"
// add <DebugType>Full</DebugType> in csproj

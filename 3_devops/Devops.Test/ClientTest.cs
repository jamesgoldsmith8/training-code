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
// dotnet add Devops.Test/Devops.Test.csproj package coverlet.collector
// add <DebugType>Full</DebugType> in csproj
// dotnet test --collect:"XPlat Code Coverage"
// change csproj to netcoreapp3.0


// '**/TestResults/coverage.cobertura.xml'

        //   - task: DotNetCoreCLI@2
        //     inputs:
        //       command: 'test'
        //       projects: '3_devops/Devops.sln'
        //       arguments: '--logger trx --collect:"XPlat Code Coverage"'
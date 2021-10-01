using Microsoft.Extensions.Configuration;
using TestsProject.Mocks;

namespace TestsProject
{
    public class MockObjects
    {
        protected readonly IConfiguration ConfigurationMock;

        public MockObjects()
        {
            ConfigurationMock = new IConfigurationMock().Create() as IConfiguration;
        }
    }
}

using Moq;
using Microsoft.Extensions.Configuration;

namespace TestsProject.Mocks
{
    public class IConfigurationMock : MockObject
    {
        public override object Create()
        {
            var mockObject = new Mock<IConfiguration>();
            mockObject.SetupGet(m => m[It.Is<string>(s => s == "TestAppSettings")]).Returns("MockTestSettings");

            return mockObject.Object;
        }
    }
}

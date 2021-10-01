using JenkinsASPCoreProject.Controllers;
using Xunit;

namespace TestsProject
{
    public class TestAppSettingControllerTests : MockObjects
    {
        [Fact]
        public void ControllerShouldBeReturnStringValue()
        {
            //Arrange
            var controller = new TestAppSettingsController(ConfigurationMock);

            //Act
            var result = controller.GetAppSettingsValue();

            //Asserts
            Assert.NotNull(result);
        }
    }
}

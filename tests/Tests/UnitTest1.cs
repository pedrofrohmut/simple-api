using WebApi.Controllers;
using Xunit;

namespace Tests
{
  public class UnitTest1
  {
    private ValuesController controller;

    public UnitTest1()
    {
      this.controller = new ValuesController();
    }

    [Fact]
    public void Get_ReturnsMyName()
    {
      var returnValue = this.controller.Get(1);
      Assert.Equal("get_value", returnValue.Value);
    }
  }
}

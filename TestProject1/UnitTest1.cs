using Moq;
using WebApplication2;
using WebApplication2.Controllers;

namespace TestProject1
{
  public class UnitTest1
  {   
    private readonly Mock<IProductService> _productServiceMock;
    public UnitTest1()
    {
      _productServiceMock = new Mock<IProductService>();
    }
  
    [Fact]
    public void Test1()
    {
      var controller = new ProductController(_productServiceMock.Object);
      var content = controller.GetAll();
    }
  }
}
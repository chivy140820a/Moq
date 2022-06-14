namespace WebApplication2
{
  public class ProductService : IProductService
  {
    public List<Product> GetAll()
    {
      var list = new List<Product>();
      for(int i = 0; i < 10; i++)
      {
        list.Add(new Product()
        {
          Id = i,
          Name = $"Product{i}"
        });

      }
      return list;
    }
  }
}

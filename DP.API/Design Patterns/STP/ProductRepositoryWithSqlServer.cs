namespace DP.API.Design_Patterns.STP
{
    public class ProductRepositoryWithSqlServer:IProductRepository
    {

        public List<string> GetList()
        {
            return new List<string>() { "value1", "value2" };
        }

        public string GetById(int id)
        {
            return "value";
        }
    }
}

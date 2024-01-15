namespace DP.API.Design_Patterns.STP
{
    public class ProductRepositoryWithOracle : IProductRepository
    {

        public List<string> GetList()
        {
            return new List<string>() { "Oracle value1", "Oracle value2" };
        }

        public string GetById(int id)
        {
            return "value";
        }
    }
}

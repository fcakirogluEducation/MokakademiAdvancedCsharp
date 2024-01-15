namespace DP.API.Design_Patterns.STP
{
    public interface IProductRepository
    {
        List<string> GetList();
        string GetById(int id);


    }
}

namespace DP.API.Design_Patterns.ODP
{
    public class NotificationService:IUserObserver
    {
        public void UserCreated(User user)
        {
            Console.WriteLine("notification gönderildi");
        }
    }
   
}

namespace DP.API.Design_Patterns.ODP
{
    public class SmsService:IUserObserver
    {
        public void UserCreated(User user)
        {
            Console.WriteLine("Sms gönderildi");
        }
    }
   
}

namespace ConsoleApp.SOLID.LSP;

public interface ITakePhoto
{
    void TakePhoto();
}

public abstract class Phone
{
    public void Call()
    {
        Console.WriteLine("Call to phone");
    }

    //public abstract void TakePhoto();
}

public class IPhone12 : Phone, ITakePhoto
{
    //public override void TakePhoto()
    //{
    //    Console.WriteLine("Take a photo");
    //}
    public void TakePhoto()
    {
        Console.WriteLine("Take a photo");
    }
}

public class Nokia : Phone
{
    //public override void TakePhoto()
    //{
    //    throw new NotImplementedException();
    //}
}
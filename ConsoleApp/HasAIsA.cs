namespace ConsoleApp
{

    public abstract class Vehicle
    {
        protected IBackwardBehavior backwardBehavior { get; set; }

        protected IRightOrLeftBehavior RightOrLeftBehavior { get; set; }
        public void Forward()
        {
            Console.WriteLine("Forward");
        }

        public void ChangeLeftOrRightBehavior(IRightOrLeftBehavior leftOrRightBehavior)
        {
            RightOrLeftBehavior = leftOrRightBehavior;
        }

    }


    public interface IBackwardBehavior
    {
        public void Backward();
    }

    public interface IRightOrLeftBehavior
    {
        public void Left();
        public void Right();
    }


    public class CarBackwardBehavior : IBackwardBehavior
    {
        public void Backward()
        {
            Console.WriteLine("Car backward");
        }
    }

    public class SuperCarBackwardBehavior : IBackwardBehavior
    {
        public void Backward()
        {
            Console.WriteLine("SuperCar backward");
        }
    }
    public class Car50BackwardBehavior : IBackwardBehavior
    {
        public void Backward()
        {
            Console.WriteLine("car50 backward");
        }
    }


    public class CarLeftOrRightBehavior : IRightOrLeftBehavior
    {
        public void Left()
        {
            Console.WriteLine("car left");
        }

        public void Right()
        {
            Console.WriteLine("car right");
        }
    }

    public class SuperCarLeftOrRightBehavior : IRightOrLeftBehavior
    {
        public void Left()
        {
            Console.WriteLine("SuperCar left");
        }

        public void Right()
        {
            Console.WriteLine("SuperCar right");
        }
    }

    public class Car50LeftOrRightBehavior : IRightOrLeftBehavior
    {
        public void Left()
        {
            Console.WriteLine("Car50 left");
        }

        public void Right()
        {
            Console.WriteLine("Car50 right");
        }
    }



    public class Car : Vehicle, IBackwardBehavior, IRightOrLeftBehavior
    {
        public Car()
        {
            backwardBehavior = new CarBackwardBehavior();
            RightOrLeftBehavior = new CarLeftOrRightBehavior();
        }



        public void Backward()
        {
            backwardBehavior.Backward();
        }

        public void Left()
        {
            RightOrLeftBehavior.Left();
        }

        public void Right()
        {
            RightOrLeftBehavior.Right();
        }
    }


    public class SuperCar : Vehicle, IBackwardBehavior, IRightOrLeftBehavior
    {

        public SuperCar()
        {
            backwardBehavior = new SuperCarBackwardBehavior();
            RightOrLeftBehavior = new SuperCarLeftOrRightBehavior();
        }

        public void Backward()
        {
            backwardBehavior.Backward();
        }

        public void Left()
        {
            RightOrLeftBehavior.Left();
        }

        public void Right()
        {
            RightOrLeftBehavior.Right();
        }

    }

    public class Car50 : Vehicle, IBackwardBehavior, IRightOrLeftBehavior
    {

        public Car50()
        {
            backwardBehavior = new CarBackwardBehavior();
            RightOrLeftBehavior = new SuperCarLeftOrRightBehavior();
        }
        public void Backward()
        {
            backwardBehavior.Backward();
        }

        public void Left()
        {
            RightOrLeftBehavior.Left();
        }

        public void Right()
        {
            RightOrLeftBehavior.Right();
        }

    }

    public class Train : Vehicle
    {

    }

    public class SuperTrain : Vehicle
    {

    }

}

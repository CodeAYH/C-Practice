using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08장
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run");
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
    internal class MultipleInterfaceInheritance
    {
        static void MainMultipleInterfaceInheritance()
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runable = car as IRunnable;
            runable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}

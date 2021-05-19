using System;
using System.Threading.Tasks;

namespace CarEvent
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Car myCar = new()
            {
                Name = "Camry",
                Model = "2021",
                Color = "Red",
                Company = "Toyota"
            };
            myCar.OnCarSpeedChanged += FirstCarSpeedWatcher;
            myCar.OnCarSpeedChanged += SecondCarSpeedWatcher;

            await Task.Delay(2000);
            myCar.Accelerate();

            await Task.Delay(5000);
            myCar.Accelerate();

            await Task.Delay(6000);
            myCar.Brake();
        }

        private static void FirstCarSpeedWatcher(object sender, CarSpeedChangedEventArgs e) // Event Handler
        {
            Console.WriteLine($"Operation: {sender}\tFirst Watcher: speed went from {e.PreviousSpeed} km/h to {e.CurrentSpeed} km/h");
         
        }

        private static void SecondCarSpeedWatcher(object sender, CarSpeedChangedEventArgs e) // Event Handler
        {
            Console.WriteLine($"Operation: {sender}\tSecond Watcher: Current Speed is {e.CurrentSpeed}");
        }

    }
}

using System;

namespace CarEvent
{
    public class Car
    {
        public event EventHandler<CarSpeedChangedEventArgs> OnCarSpeedChanged;
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Company { get; set; }
        protected uint CurrentSpeed { get; private set; }

        public void Accelerate()
        {
            uint previousSpeed = CurrentSpeed;
            CurrentSpeed += 5;
            if (OnCarSpeedChanged is not null)
            {
                OnCarSpeedChanged(nameof(Accelerate), new CarSpeedChangedEventArgs { CurrentSpeed = CurrentSpeed, PreviousSpeed = previousSpeed });
            }

        }

        public void Brake()
        {
            uint previousSpeed = CurrentSpeed;
            CurrentSpeed -= 5;
            if (OnCarSpeedChanged is not null)
            {
                OnCarSpeedChanged(nameof(Brake), new CarSpeedChangedEventArgs { CurrentSpeed = CurrentSpeed, PreviousSpeed = previousSpeed });
            }

        }
    }
}

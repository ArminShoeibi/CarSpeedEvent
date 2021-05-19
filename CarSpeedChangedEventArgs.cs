using System;

namespace CarEvent
{
    public class CarSpeedChangedEventArgs : EventArgs
    {
        public uint CurrentSpeed { get; set; }
        public uint PreviousSpeed { get; set; }
    }
}

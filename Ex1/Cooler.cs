﻿namespace Ex1
{
    public class Cooler
    {
        public Cooler(float temperature)
        {
            Temperature = temperature;
        }

        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }
        private float _Temperature;

        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature > Temperature)
            {
                System.Console.WriteLine("cooler: on");
            }
            else
            {
                System.Console.WriteLine("Cooler: off");
            }
        }
    }
}
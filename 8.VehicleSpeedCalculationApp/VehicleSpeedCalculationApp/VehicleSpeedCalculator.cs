namespace VehicleSpeedCalculationApp
{
    internal class VehicleSpeedCalculator
    {
        private string vehicleName;
        private string vehicleRegNo;
        private double vehicleSpeed;
        private double minSpeed;
        private double maxSpeed;
        private double avgSpeed;
        private double avg;
        private int i;

        public string VehicleName
        {
            set { vehicleName = value; }
        }

        public string VehicleRegNo
        {
            set { vehicleRegNo = value; }
        }

        public double VehicleSpeed
        {
            set
            {
                vehicleSpeed = value;

                if (minSpeed == 0)
                    minSpeed = vehicleSpeed;
                if (minSpeed > vehicleSpeed)
                    minSpeed = vehicleSpeed;
                if (maxSpeed == 0)
                    maxSpeed = vehicleSpeed;
                if (maxSpeed < vehicleSpeed)
                    maxSpeed = vehicleSpeed;

                    i++;
                avgSpeed += vehicleSpeed;
                avg = avgSpeed/i;

            }
        }


        public string GetMinSpeed()
        {
            
            return minSpeed.ToString();
        }

        public string GetMaxSpeed()
        {
           
            return maxSpeed.ToString();
        }

        public string GetAvgSpeed()
        {
           
            return avg.ToString();
        }
    }
}
namespace ResultCalculationApp
{
    internal class ResultCalculator
    {
        private int physicsNumber;
        private int chemistryNumber;
        private int mathNumber;
        private double average=0;

        public int PhysicsNumber
        {
            //get { return physicsNumber; }
            set { physicsNumber = value; }
        }

        public int ChemistryNumber
        {
           // get { return chemistryNumber; }
            set { chemistryNumber = value; }
        }

        public int MathNumber
        {
           // get { return mathNumber; }
            set { mathNumber = value; }
        }


        public string GetAvgMark()
        {
            average = (physicsNumber + chemistryNumber + mathNumber)/3;
            return average.ToString();
        }

        public string GetGread()
        {
            if (average >= 80)
                return "A+";

            if (average >= 70 & average < 80)
                return "B+";
            if (average >= 60 & average<70)
                return "C+";
            if (average >= 50 & average < 60)
                return "D+";
            else
            {
                return "F";
            }

        }
    }
}
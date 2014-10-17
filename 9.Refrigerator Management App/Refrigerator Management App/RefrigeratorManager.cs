using System;
using System.Windows.Forms;

namespace Refrigerator_Management_App
{
    public class RefrigeratorManager
    {
        private double refrigeratorMaximumWeightHolder;
        private int numberOfUnit;
        private double weightPerUnit;
        private double currentWeight;
        private double remainingWeight;

       

        public double RefrigeratorMaximumWeightHolder
        {
            set { refrigeratorMaximumWeightHolder = value; }
        }
        
        public int NumberOfUnit
        {
            set { numberOfUnit = value; }
        }
     
        public double WeightPerUnit
        {
            set { weightPerUnit = value; }
        }

        public double CurrentWeight
        {
           
            get { return numberOfUnit*weightPerUnit; }
        }
      
     
        public double RemainingWeight
        {
            get { return refrigeratorMaximumWeightHolder-(numberOfUnit*weightPerUnit); }
            
        }

       //public  void CheckCondition()
       //{
       //    double weightToBeAdded = numberOfUnit*weightPerUnit;
       //    if (CurrentWeight + weightToBeAdded <= RefrigeratorMaximumWeightHolder)
       //    {
       //      return  CurrentWeight += weightToBeAdded;
       //      return RemainingWeight = RefrigeratorMaximumWeightHolder - CurrentWeight;
       //    }

       //    else
       //    {
       //        throw new Exception();
       //    }
       //}
    }

  }

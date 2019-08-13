using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        private decimal cost;
        private bool healthyOption;


        public int NumberOfPeople { get; set; }             //properties
        public bool FancyDecorations { get; set; }          //properties
        public bool HealthyOption { get; set; }             //properties

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)   //CONSTRUCTOR
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;
        }

        private decimal CalculateCostOfBeveragesPerPreson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.0M;
            }
            return costOfBeveragesPerPerson;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPreson()
                    + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }
    }
}


/*        public decimal costOfBeveragePerPerson;
        public decimal costOfDecorations = 0;
        public const int costOfFoodPerPerson = 25;*/
/*        public void SetHealthyOption(bool healthyOption) //if boolean value is true, run the if statement, if false, the else statement is run.
    {
        if (healthyOption)
        {
            costOfBeveragePerPerson = 5.00M;
        } else
        {
            costOfBeveragePerPerson = 20.00M;
        }
    }

    public void CalculateCostOfDecorations(bool decorationCostToCalculate)
    {
        if (decorationCostToCalculate)
        {
            costOfDecorations = (numberOfPeople * 15.00M) + 50M;
        } else
        {
            costOfDecorations = (numberOfPeople * 7.50M) + 30M;
        }
    }

    internal decimal CalculateCost(bool healthyOption)
    {
        decimal totalCost = costOfDecorations +
            ((costOfBeveragePerPerson + costOfFoodPerPerson) * numberOfPeople);

        if (healthyOption)
        {
            return totalCost * .95M;            //this is the discount if the healthy option was  taken, if not taken, the else statement will give the cost w/out discount
        } else
        {
            return totalCost;
        }

        throw new NotImplementedException();
    }
}*/

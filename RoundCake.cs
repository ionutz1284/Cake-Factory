using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Factory_New
{
    class RoundCake : Cake
    {
        private bool fruitOption;
        

        public RoundCake(bool fruitOption, int orderSize,
            bool chocoIce, 
            DateTime orderDate)
            : base(orderSize, chocoIce, orderDate) 
        {
            FruitOption = fruitOption;
        }

        public virtual bool FruitOption 
        {
            get { return fruitOption; }
            set { fruitOption = value; }
        }

        public decimal CalculateTotalCost() 
        {
            decimal c1 = 25.00M;

            decimal c2 = ((OrderSize - 8) / 2) * 3.00M;

            decimal costOfChocoIce = 0.0M;

            if (ChocoIce)
            {
                costOfChocoIce = 10.00M + ((OrderSize - 8) / 2) * 1.50M;
            }
            else 
            {
                costOfChocoIce = 0M;
            }

            decimal costOfFruitOption = 0;

            if (FruitOption)
            {
                costOfFruitOption = (c1 + c2) * 5 / 100;
            }
            else 
            {
                costOfFruitOption = 0M;
            }

            decimal TotalCost = 0;

            TotalCost = c1 + c2 + costOfChocoIce + costOfFruitOption;
            return TotalCost;
        }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,2}{2,20}", orderDate.ToShortDateString(), "Round", 
                OrderSize.ToString());
        }
    }
}

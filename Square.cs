using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Factory_New
{
    class Square : Cake
    {
        private string cakeWriting;

        public Square (string cakeWriting, 
            int numberOfLetters, 
            int orderSize, 
            bool chocoIce, 
            DateTime orderDate)
            : base(orderSize, chocoIce, orderDate) 
        {
            CakeWriting = cakeWriting;
        }

        public virtual string CakeWriting 
        {
            get { return cakeWriting; }
            set { cakeWriting = value; }
        }

        public decimal CalculateTotalCost() 
        {
            decimal s1 = 30.00M;

            decimal s2 = ((OrderSize - 10) / 2) * 4.00M;
            
            decimal costOfChocoIce = 0.0M;

            if (ChocoIce)
            {
                costOfChocoIce = 10.00M + ((OrderSize - 10) / 2) * 1.50M;
            }
            else
            {
                costOfChocoIce = 0M;
            }

            int numberOfLetters = cakeWriting.Length;

            decimal TotalCost = 0M;
            TotalCost = s1 + s2 + costOfChocoIce + (numberOfLetters * 0.15M);
            return TotalCost;
        }

        public override string ToString()
        {
            return String.Format("{0,-20}{1,2}{2,20}", orderDate.ToShortDateString(), "Square",
                OrderSize.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Factory_New
{
    class Cake
    {
        private int orderSize;
        private bool chocoIce;
        protected DateTime orderDate;

        public virtual bool ChocoIce 
        {
            get { return chocoIce; }
            set { chocoIce = value; }
        }

        public virtual int OrderSize 
        {
            get { return orderSize; }
            set { orderSize = value; }
        }

        //Is this needed
        public DateTime OrderDate 
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public Cake(int orderSize, bool chocoIce, DateTime orderDate) 
        { 
            this.orderSize = orderSize;
            this.chocoIce = chocoIce;
            this.orderDate = orderDate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Furniture
    {
        private string name;
        private string color;
        private string price;
        public Furniture(string name, string color, string price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

		public Furniture()
		{
		}

		public string getName()
        {
            return this.name;
        }
        public string getColor()
        {
			return this.color;
        }
        public string getPrice()
        {
            return this.price;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public void setPrice(string Price)
        {
            this.price = price;
        }

		public static explicit operator Furniture(int v)
		{
			throw new NotImplementedException();
		}
	}
}
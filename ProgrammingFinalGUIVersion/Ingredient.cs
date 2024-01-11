using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinalGUIVersion
{
    public class Ingredient
    {
        //Member variables
        private string name;
        private float quantity;
        private string unit;


        //Member functions
        public void IncreaseAmount(float amountToAdd)
        {
            Quantity = Quantity + amountToAdd;
        }

        //get and set
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public float Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }

        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingFinalGUIVersion
{
    public partial class AddIngredientToPantry : Form
    {
        public AddIngredientToPantry()
        {
            InitializeComponent();
        }

        //Event functions
        private void btnSave_Click(object sender, EventArgs e)
        {
            //validate theres no empty input
            if (txtNewPantryIngredientName.Text == "" || Convert.ToSingle(nudNewPantryIngredientQty.Value) == 0 || txtNewPantryIngredientUnit.Text == "")
            {
                string message = "Please enter a valid input";
                MessageBox.Show(message);
                return;
            }
            else
            {
                string newIngName = txtNewPantryIngredientName.Text;
                float newIngQty = Convert.ToSingle(nudNewPantryIngredientQty.Value);
                string newIngUnit = txtNewPantryIngredientUnit.Text;

                var ingInList = false;      //validate the ingredient doesnt already exist

                foreach (Ingredient ing in Data.pantryList.GetList())
                {
                    if (newIngName == ing.Name)     //if exists, add amount onto it
                    {
                        ingInList = true;
                        ing.IncreaseAmount(newIngQty);
                        Data.SavePantry();
                    }
                }

                if (ingInList)
                {
                    Close();
                }
                else
                {
                    Data.pantryList.AddIngredient(newIngName, newIngQty, newIngUnit);
                    Data.SavePantry();
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

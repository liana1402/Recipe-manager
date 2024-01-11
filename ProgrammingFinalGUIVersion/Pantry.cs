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
    public partial class Pantry : Form
    {
        public Pantry()
        {
            InitializeComponent();
            updateListBox();
        }

        //Event functions
        private void lstPantryItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //view selected ingredient's quantity and unit
            foreach (Ingredient ing in Data.pantryList.GetList())
            {
                if (lstPantryItems.SelectedItem == ing.Name)
                {
                    txtSelectedItemQuantity.Text = ing.Quantity.ToString();
                    txtSelectedItemUnit.Text = ing.Unit;
                }
            }
        }

        private void btnAddIngredientToPantry_Click(object sender, EventArgs e)
        {
            AddIngredientToPantry addIngredientToPantry = new AddIngredientToPantry();
            addIngredientToPantry.ShowDialog();
            updateListBox();
        }

        private void btnRemoveIngredientFromPantry_Click(object sender, EventArgs e)
        {
            int index = lstPantryItems.SelectedIndex;
            if (index == -1) return;
            Data.pantryList.RemoveIngredient(index);
            Data.SavePantry();
            updateListBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Close();
        }

        private void updateListBox()
        {
            lstPantryItems.Items.Clear();
            foreach (Ingredient ing in Data.pantryList.GetList())
            {
                lstPantryItems.Items.Add(ing.Name);
            }
        }
    }
}

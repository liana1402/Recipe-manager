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
    public partial class Recipes : Form
    {
        //Member variables
        private Recipe selectedRecipe = default;

        public Recipes()
        {
            InitializeComponent();
            updateListBox();
        }

        //Event functions
        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            AddRecipe addRecipe = new AddRecipe();
            addRecipe.ShowDialog();
            updateListBox();
        }

        private void btnRemoveRecipe_Click(object sender, EventArgs e)
        {
            int index = lstRecipeNames.SelectedIndex;
            if (index == -1) return; //validate that something is selected

            foreach (var r in Data.recipesList) //find selected recipe
            {
                if (r.Name == lstRecipeNames.SelectedItem.ToString())
                {
                    selectedRecipe = r;
                }
            }
            Data.recipesList.RemoveAt(index);
            selectedRecipe.DeleteRecipe();
            updateListBox();
        }

        private void lstRecipeNames_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //opens detailed page of recipe
            if (lstRecipeNames.SelectedItem != null)
            {
                foreach (var recipe in Data.recipesList) //find selected recipe
                {
                    if (recipe.Name == lstRecipeNames.SelectedItem.ToString())
                    {
                        selectedRecipe = recipe;
                    }
                }
                ViewRecipe vr = new ViewRecipe(selectedRecipe);
                vr.ShowDialog();
                updateListBox();
            }
            else
            {
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            Close();
        }

        private void updateListBox()
        {
            lstRecipeNames.Items.Clear();
            foreach (var item in Data.recipesList)
            {
                lstRecipeNames.Items.Add(item.Name);
            }
        }
    }
}

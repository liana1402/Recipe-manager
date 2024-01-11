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
    public partial class CrossCheck : Form
    {
        //Member variables
        private List<Recipe> recipesConfirmedFromCheck = new List<Recipe>();

        public CrossCheck()
        {
            InitializeComponent();

            //goes through each ingredient of each recipe and compares its name to each ingredient name in the pantry
            foreach (var recipe in Data.recipesList)
            {
                var found = false;
                foreach (Ingredient recipeIng in recipe.Ingredients.GetList())
                {
                    foreach (Ingredient pantryIng in Data.pantryList.GetList())
                    {
                        if (pantryIng.Name == recipeIng.Name)
                        {
                            recipesConfirmedFromCheck.Add(recipe);
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }
            }
            foreach (var item in recipesConfirmedFromCheck)
            {
                lstRecipiesAfterCrossCheck.Items.Add(item.Name);
            }
        }

        //Event functions
        private void lstRecipiesAfterCrossCheck_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //show detailed recipe page
            if (lstRecipiesAfterCrossCheck.SelectedItem != null)
            {
                Recipe selectedRecipe = default;
                foreach (var recipe in Data.recipesList)
                {
                    if (recipe.Name == lstRecipiesAfterCrossCheck.SelectedItem.ToString())
                    {
                        selectedRecipe = recipe;
                    }
                }
                ViewRecipe vr = new ViewRecipe(selectedRecipe);
                vr.ShowDialog();
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
    }
}

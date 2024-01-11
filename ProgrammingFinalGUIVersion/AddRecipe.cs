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
    public partial class AddRecipe : Form
    {
        //Member variables
        private Recipe newRecipe;
        private IngredientList newRecipeIngList = new IngredientList();

        public AddRecipe()
        {
            InitializeComponent();
        }

        //Event functions
        private void btnAddIngToList_Click(object sender, EventArgs e)
        {
            //validate theres no empty input
            if (txtNewRecipeIngredientName.Text == "" || Convert.ToSingle(nudNewRecipeIngredientQty.Value) == 0 || txtNewRecipeIngredientUnit.Text == "")
            {
                string message = "Please enter a valid input";
                MessageBox.Show(message);
                return;
            }
            else
            {
                //create new ingredient
                Ingredient ingredientToAdd = new Ingredient();
                ingredientToAdd.Name = txtNewRecipeIngredientName.Text;
                ingredientToAdd.Quantity = Convert.ToSingle(nudNewRecipeIngredientQty.Value);
                ingredientToAdd.Unit = txtNewRecipeIngredientUnit.Text;

                var ingInList = false;      //validate the ingredient doesnt already exist

                foreach (Ingredient ing in newRecipeIngList.GetList())
                {
                    if (ingredientToAdd.Name == ing.Name)
                    {
                        ingInList = true;
                    }
                }

                if (ingInList)
                {
                    string message = "An ingredient with the same name has already been added";
                    MessageBox.Show(message);
                }
                else
                {
                    newRecipeIngList.AddIngredient(ingredientToAdd.Name, ingredientToAdd.Quantity, ingredientToAdd.Unit);
                    lstNewRecipeIngredientToSave.Items.Add(ingredientToAdd.Name);
                    ResetTextBox();
                }
            }
        }

        private void btnRemoveIng_Click(object sender, EventArgs e)
        {
            if (lstNewRecipeIngredientToSave.SelectedIndex == -1) return;
            int indexToRemoveAt = -1;
            foreach (Ingredient ing in newRecipeIngList.GetList())
            {
                if (ing.Name == lstNewRecipeIngredientToSave.SelectedItem.ToString())
                {
                    indexToRemoveAt = lstNewRecipeIngredientToSave.SelectedIndex;
                }
            }
            if (indexToRemoveAt == -1) return;
            newRecipeIngList.RemoveIngredient(indexToRemoveAt);
            updateListBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //adds recipe to Data recipe list and saves the file
            if (txtNewRecipeName.Text != "" && lstNewRecipeIngredientToSave.Items.Count > 0)
            {
                var isLetter = true;
                foreach (char letter in txtNewRecipeName.Text) //validation to not interupt future code
                {
                    if (Path.GetInvalidFileNameChars().Contains(letter)) //////
                    {
                        isLetter = false;
                    }
                }

                if (isLetter == false)
                {
                    string message = "Please only enter letters";
                    MessageBox.Show(message);
                    return;
                }
                else if (txtNewRecipeDescription.Text.Length == 0)
                {
                    newRecipe = new Recipe(txtNewRecipeName.Text, newRecipeIngList);
                }
                else
                {
                    newRecipe = new Recipe(txtNewRecipeName.Text, txtNewRecipeDescription.Text, newRecipeIngList);
                }
                Data.recipesList.Add(newRecipe);
                newRecipe.SaveRecipeToFile();
                Close();
            }
            else
            {
                string message = "Please make sure the recipe name and ingredients are filled";
                MessageBox.Show(message);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateListBox()
        {
            lstNewRecipeIngredientToSave.Items.Clear();
            foreach (Ingredient ing in newRecipeIngList.GetList())
            {
                lstNewRecipeIngredientToSave.Items.Add(ing.Name);
            }
        }
        private void ResetTextBox()
        {
            txtNewRecipeIngredientName.Text = "";
            nudNewRecipeIngredientQty.Value = 0;
            txtNewRecipeIngredientUnit.Text = "";
        }
    }
}

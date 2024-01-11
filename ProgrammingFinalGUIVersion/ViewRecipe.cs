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
    public partial class ViewRecipe : Form
    {
        //Member Variables
        private Recipe recipe;
        private Ingredient selectedIngredient = new Ingredient();

        public ViewRecipe(Recipe r)
        {
            //inserts the data of the recipe being viewed
            recipe = r;
            InitializeComponent();
            txtViewingRecipeName.Text = recipe.Name;
            txtRecipeDescription.Text = recipe.Description;
            UpdateListBox();
        }

        //Event functions
        private void lstViewingRecipeIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSaveIngChanges.Enabled = true;
            //inserts data on selected ingredient from list into the ingredient text boxes
            //finding the selected item from the list in  recipe ingredients list
            if (lstViewingRecipeIngredients.SelectedItem != null)
            {
                foreach (Ingredient ing in recipe.Ingredients.GetList())
                {
                    if (ing.Name == lstViewingRecipeIngredients.SelectedItem.ToString())
                    {
                        selectedIngredient = ing;
                    }
                }
            }
            else
            {
                return;
            }
            //takes the text from texts boxes and assigns it to the ingredient object
            txtViewingRecipeIngredientName.Text = selectedIngredient.Name;
            nudViewingRecipeIngredientQty.Value = Convert.ToDecimal(selectedIngredient.Quantity);
            Convert.ToSingle(nudViewingRecipeIngredientQty.Value);
            txtViewingRecipeIngredientUnit.Text = selectedIngredient.Unit;
        }
        private void btnSaveIngChanges_Click(object sender, EventArgs e)
        {

            if (txtViewingRecipeIngredientName.Text == "" || Convert.ToSingle(nudViewingRecipeIngredientQty.Value) == 0 || txtViewingRecipeIngredientUnit.Text == "")     //validate theres no empty input
            {
                string message = "Please enter a valid input";
                MessageBox.Show(message);
                return;
            }
            else
            {
                //saves the ingredient to recipe ingredient list
                selectedIngredient.Name = txtViewingRecipeIngredientName.Text;
                selectedIngredient.Quantity = Convert.ToSingle(nudViewingRecipeIngredientQty.Value);
                selectedIngredient.Unit = txtViewingRecipeIngredientUnit.Text;

                recipe.Ingredients.RemoveIngredient(lstViewingRecipeIngredients.SelectedIndex);
                recipe.Ingredients.AddIngredient(selectedIngredient.Name, selectedIngredient.Quantity, selectedIngredient.Unit);
                UpdateListBox();
                ResetTextBox();
                btnSaveIngChanges.Enabled = false;
            }
        }

        private void btnAddNewIngredient_Click(object sender, EventArgs e)
        {
            //validate theres no empty input
            if (txtViewingRecipeIngredientName.Text == "" || Convert.ToSingle(nudViewingRecipeIngredientQty.Value) == 0 || txtViewingRecipeIngredientUnit.Text == "")
            {
                string message = "Please enter a valid input";
                MessageBox.Show(message);
                return;
            }
            else
            {
                //create new ingredient
                Ingredient ingredientToAdd = new Ingredient();
                ingredientToAdd.Name = txtViewingRecipeIngredientName.Text;
                ingredientToAdd.Quantity = Convert.ToSingle(nudViewingRecipeIngredientQty.Value);
                ingredientToAdd.Unit = txtViewingRecipeIngredientUnit.Text;

                var ingInList = false;      //validate the ingredient doesnt already exist

                foreach (Ingredient ing in recipe.Ingredients.GetList())
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
                    recipe.Ingredients.AddIngredient(ingredientToAdd.Name, ingredientToAdd.Quantity, ingredientToAdd.Unit);
                    lstViewingRecipeIngredients.Items.Add(ingredientToAdd.Name);
                    ResetTextBox();
                }
            }
        }
        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (lstViewingRecipeIngredients.SelectedIndex == -1) return;
            int indexToRemoveAt = -1;
            foreach (Ingredient ing in recipe.Ingredients.GetList())
            {
                if (ing.Name == lstViewingRecipeIngredients.SelectedItem.ToString())
                {
                    indexToRemoveAt = lstViewingRecipeIngredients.SelectedIndex;
                }
            }
            if (indexToRemoveAt == -1) return;
            recipe.Ingredients.RemoveIngredient(indexToRemoveAt);
            UpdateListBox();
            ResetTextBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtViewingRecipeName.Text != "" && lstViewingRecipeIngredients.Items.Count > 0)
            {
                var isLetter = true;
                foreach (char letter in txtViewingRecipeName.Text) //validation to not interupt future code
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
                else
                {
                    //saves a new recipe file and removes previous version
                    recipe.Description = txtRecipeDescription.Text;
                    Data.recipesList.Remove(recipe);
                    Data.recipesList.Add(recipe);
                    recipe.DeleteRecipe();
                    recipe.SaveRecipeToFile();
                    Close();
                }
            }
            else
            {
                string message = "Please make sure the recipe name and ingredients are filled";
                MessageBox.Show(message);
                return;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateListBox()
        {
            lstViewingRecipeIngredients.Items.Clear();
            foreach (Ingredient ing in recipe.Ingredients.GetList())
            {
                lstViewingRecipeIngredients.Items.Add(ing.Name);
            }
        }
        private void ResetTextBox()
        {
            txtViewingRecipeIngredientName.Text = "";
            nudViewingRecipeIngredientQty.Value = 0;
            txtViewingRecipeIngredientUnit.Text = "";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinalGUIVersion
{
    public class Recipe
    {
        //Member variables 
        private string name;
        private string description;
        private IngredientList ingredients;


        //constructors
        public Recipe(string name, string description, IngredientList ingredients)
        {
            Name = name;
            Description = description;
            Ingredients = ingredients;
        }

        public Recipe(string name, IngredientList ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }


        //Member functions
        public void SaveRecipeToFile()
        {
            //assigning data from the recipe being saved
            string ingredientsText = "";
            foreach (Ingredient ing in ingredients.GetList())
            {
                ingredientsText += ing.Name + "," + ing.Quantity + "," + ing.Unit + ";";
            }

            string text;
            if (description == String.Empty)
            {
                text = this.Name + "\n" + ingredientsText.TrimEnd(';');
            }
            else
            {
                text = this.Name + "\n" + this.Description + "\n" + ingredientsText.TrimEnd(';');
            }

            //find recipe path and save
            Data.recipePath = this.Name + ".txt";
            File.WriteAllText(Path.Combine(Data.recipesDirectoryPath, Data.recipePath), text);                            //https://stackoverflow.com/questions/4244446/creating-a-new-folder-and-a-text-file-inside-that-folder
        }

        public void DeleteRecipe()
        {
            Data.recipePath = "recipes\\" + this.Name + ".txt";

            //find recipe path and delete
            string[] recipeFiles = Directory.GetFiles(Data.recipesDirectoryPath);
            foreach (string recipeFileName in recipeFiles)
            {
                if (recipeFileName == Data.recipePath)
                {
                    File.Delete(Data.recipePath);
                }
            }
        }

        //get and set
        public string Name
        {
            get { return name; }
            set
            {

                { name = value; }
            }
        }

        public string Description
        {
            get { return description; }
            set { description = value.Trim(); }
        }

        public IngredientList Ingredients
        {
            get { return ingredients; }
            set
            {
                ingredients = value;
            }
        }
    }
}

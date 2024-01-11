namespace ProgrammingFinalGUIVersion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //load the file, parse the data, create a recipe object, add it to the recipesList
            if (Directory.Exists(Data.recipesDirectoryPath))
            {
                string[] recipeFiles = Directory.GetFiles(Data.recipesDirectoryPath);       //recipeFiles (list of files in folder)
                foreach (string recipeFileName in recipeFiles)                              //recipeFileName (file in list of files)
                {
                    if (File.Exists(recipeFileName))
                    {
                        //taking data from the recipe text file and assigning to a recipe object
                        List<String> recipeData = File.ReadAllLines(recipeFileName).ToList();

                        string newRecipeName = recipeData[0];
                        string newRecipeDescription = "";
                        IngredientList newRecipeIngredients = new IngredientList();
                        if (recipeData.Count() == 3)    //if there is a description
                        {
                            newRecipeDescription = recipeData[1];
                            string[] ing = recipeData[2].Split(';');
                            foreach (string item in ing)
                            {
                                string[] ingComponent = item.Split(',');
                                float ingQty = Convert.ToSingle(ingComponent[1]);
                                newRecipeIngredients.AddIngredient(ingComponent[0], ingQty, ingComponent[2]);
                            }
                            Recipe savedRecipeLoad = new Recipe(newRecipeName, newRecipeDescription, newRecipeIngredients);
                            Data.recipesList.Add(savedRecipeLoad);
                        }
                        else if (recipeData.Count() == 2)   //if there is no description
                        {
                            string[] ing = recipeData[1].Split(';');
                            foreach (string item in ing)
                            {
                                string[] ingComponent = item.Split(',');
                                float ingQty = Convert.ToSingle(ingComponent[1]);
                                newRecipeIngredients.AddIngredient(ingComponent[0], ingQty, ingComponent[2]);
                            }
                            Recipe savedRecipeLoad = new Recipe(newRecipeName, newRecipeDescription, newRecipeIngredients);
                            Data.recipesList.Add(savedRecipeLoad);
                        }
                    }
                }
            }
            else Directory.CreateDirectory(Data.recipesDirectoryPath);

            if (File.Exists(Data.pantryPath))
            {
                List<string> PantryTextList = File.ReadAllLines(Data.pantryPath).ToList();
                foreach (string ingredient in PantryTextList)
                {
                    string[] ingComponent = ingredient.Split(',');
                    float ingQuantity = Convert.ToSingle(ingComponent[1]);
                    Data.pantryList.AddIngredient(ingComponent[0], ingQuantity, ingComponent[2]);
                }
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }

    public static class Data
    {
        public static List<Recipe> recipesList = new List<Recipe>();
        public static IngredientList pantryList = new IngredientList();
        public static string recipesDirectoryPath = "recipes";
        public static string pantryPath = "pantry.txt";
        public static string recipePath = "";

        public static void SavePantry()
        {
            string text = "";

            foreach (Ingredient ing in pantryList.GetList())
            {
                text += $"{ing.Name},{ing.Quantity},{ing.Unit}\n";
            }
            text = text.TrimEnd(Environment.NewLine.ToCharArray());
            File.WriteAllText(pantryPath, text);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFinalGUIVersion
{
    public class IngredientList
    {
        //Member variables
        private List<Ingredient> ingredients = new List<Ingredient>();


        //Member functions
        public IReadOnlyCollection<Ingredient> GetList()
        {
            return ingredients.AsReadOnly();
        }

        public void AddIngredient(string name, float qty, string unit)
        {
            Ingredient newIngredient = new Ingredient();
            newIngredient.Name = name;
            newIngredient.Quantity = qty;
            newIngredient.Unit = unit;
            ingredients.Add(newIngredient);
        }

        public void RemoveIngredient(int indexToRemoveAt)
        {
            ingredients.RemoveAt(indexToRemoveAt);
        }
    }
}

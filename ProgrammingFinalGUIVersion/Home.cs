namespace ProgrammingFinalGUIVersion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Event functions
        private void btnViewRecipes_Click(object sender, EventArgs e)
        {
            Recipes viewRecipesPage = new Recipes();
            viewRecipesPage.Show();
            Visible = false;
        }

        private void btnViewPantry_Click(object sender, EventArgs e)
        {
            Pantry viewPantryPage = new Pantry();
            viewPantryPage.Show();
            Visible = false;
        }

        private void btnCrossCheck_Click(object sender, EventArgs e)
        {
            CrossCheck viewCrossCheckPage = new CrossCheck();
            viewCrossCheckPage.Show();
            Visible = false;
        }
    }
}
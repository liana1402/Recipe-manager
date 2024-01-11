namespace ProgrammingFinalGUIVersion
{
    partial class Recipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRecipeNames = new System.Windows.Forms.ListBox();
            this.recipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveRecipe = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here are all the current recipes saved:";
            // 
            // lstRecipeNames
            // 
            this.lstRecipeNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.lstRecipeNames.FormattingEnabled = true;
            this.lstRecipeNames.ItemHeight = 20;
            this.lstRecipeNames.Location = new System.Drawing.Point(24, 44);
            this.lstRecipeNames.Name = "lstRecipeNames";
            this.lstRecipeNames.Size = new System.Drawing.Size(249, 344);
            this.lstRecipeNames.TabIndex = 1;
            this.lstRecipeNames.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstRecipeNames_MouseDoubleClick);
            // 
            // recipeBindingSource
            // 
            this.recipeBindingSource.DataSource = typeof(ProgrammingFinalGUIVersion.Recipe);
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(206)))), ((int)(((byte)(120)))));
            this.btnAddRecipe.Location = new System.Drawing.Point(325, 44);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(157, 29);
            this.btnAddRecipe.TabIndex = 2;
            this.btnAddRecipe.Text = "Add a recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = false;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "More choices:";
            // 
            // btnRemoveRecipe
            // 
            this.btnRemoveRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.btnRemoveRecipe.Location = new System.Drawing.Point(325, 89);
            this.btnRemoveRecipe.Name = "btnRemoveRecipe";
            this.btnRemoveRecipe.Size = new System.Drawing.Size(157, 48);
            this.btnRemoveRecipe.TabIndex = 4;
            this.btnRemoveRecipe.Text = "Remove selected recipe";
            this.btnRemoveRecipe.UseVisualStyleBackColor = false;
            this.btnRemoveRecipe.Click += new System.EventHandler(this.btnRemoveRecipe_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.btnBack.Location = new System.Drawing.Point(313, 359);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(157, 29);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(178)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(499, 413);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveRecipe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.lstRecipeNames);
            this.Controls.Add(this.label1);
            this.Name = "Recipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recipes";
            ((System.ComponentModel.ISupportInitialize)(this.recipeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstRecipeNames;
        private Button btnAddRecipe;
        private Label label2;
        private Button btnRemoveRecipe;
        private Button btnBack;
        private BindingSource recipeBindingSource;
    }
}
namespace ProgrammingFinalGUIVersion
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewRecipes = new System.Windows.Forms.Button();
            this.btnViewPantry = new System.Windows.Forms.Button();
            this.btnCrossCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewRecipes
            // 
            this.btnViewRecipes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.btnViewRecipes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnViewRecipes.Location = new System.Drawing.Point(42, 46);
            this.btnViewRecipes.Name = "btnViewRecipes";
            this.btnViewRecipes.Size = new System.Drawing.Size(130, 67);
            this.btnViewRecipes.TabIndex = 0;
            this.btnViewRecipes.Text = "Recipes";
            this.btnViewRecipes.UseVisualStyleBackColor = false;
            this.btnViewRecipes.Click += new System.EventHandler(this.btnViewRecipes_Click);
            // 
            // btnViewPantry
            // 
            this.btnViewPantry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.btnViewPantry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnViewPantry.Location = new System.Drawing.Point(213, 46);
            this.btnViewPantry.Name = "btnViewPantry";
            this.btnViewPantry.Size = new System.Drawing.Size(130, 67);
            this.btnViewPantry.TabIndex = 1;
            this.btnViewPantry.Text = "Pantry";
            this.btnViewPantry.UseVisualStyleBackColor = false;
            this.btnViewPantry.Click += new System.EventHandler(this.btnViewPantry_Click);
            // 
            // btnCrossCheck
            // 
            this.btnCrossCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(206)))), ((int)(((byte)(120)))));
            this.btnCrossCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCrossCheck.Location = new System.Drawing.Point(126, 135);
            this.btnCrossCheck.Name = "btnCrossCheck";
            this.btnCrossCheck.Size = new System.Drawing.Size(130, 36);
            this.btnCrossCheck.TabIndex = 2;
            this.btnCrossCheck.Text = "What can I cook";
            this.btnCrossCheck.UseVisualStyleBackColor = false;
            this.btnCrossCheck.Click += new System.EventHandler(this.btnCrossCheck_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(178)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(379, 191);
            this.Controls.Add(this.btnCrossCheck);
            this.Controls.Add(this.btnViewPantry);
            this.Controls.Add(this.btnViewRecipes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnViewRecipes;
        private Button btnViewPantry;
        private Button btnCrossCheck;
    }
}
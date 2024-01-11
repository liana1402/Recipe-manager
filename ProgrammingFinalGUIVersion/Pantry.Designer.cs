namespace ProgrammingFinalGUIVersion
{
    partial class Pantry
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstPantryItems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddIngredientToPantry = new System.Windows.Forms.Button();
            this.btnRemoveIngredientFromPantry = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSelectedItemQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSelectedItemUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here are the current ingredients in your pantry:";
            // 
            // lstPantryItems
            // 
            this.lstPantryItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.lstPantryItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lstPantryItems.FormattingEnabled = true;
            this.lstPantryItems.ItemHeight = 20;
            this.lstPantryItems.Location = new System.Drawing.Point(24, 44);
            this.lstPantryItems.Name = "lstPantryItems";
            this.lstPantryItems.Size = new System.Drawing.Size(249, 344);
            this.lstPantryItems.TabIndex = 1;
            this.lstPantryItems.SelectedIndexChanged += new System.EventHandler(this.lstPantryItems_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(336, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "More choices:";
            // 
            // btnAddIngredientToPantry
            // 
            this.btnAddIngredientToPantry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(206)))), ((int)(((byte)(120)))));
            this.btnAddIngredientToPantry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAddIngredientToPantry.Location = new System.Drawing.Point(300, 88);
            this.btnAddIngredientToPantry.Name = "btnAddIngredientToPantry";
            this.btnAddIngredientToPantry.Size = new System.Drawing.Size(168, 29);
            this.btnAddIngredientToPantry.TabIndex = 3;
            this.btnAddIngredientToPantry.Text = "Add an ingredient";
            this.btnAddIngredientToPantry.UseVisualStyleBackColor = false;
            this.btnAddIngredientToPantry.Click += new System.EventHandler(this.btnAddIngredientToPantry_Click);
            // 
            // btnRemoveIngredientFromPantry
            // 
            this.btnRemoveIngredientFromPantry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.btnRemoveIngredientFromPantry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRemoveIngredientFromPantry.Location = new System.Drawing.Point(300, 123);
            this.btnRemoveIngredientFromPantry.Name = "btnRemoveIngredientFromPantry";
            this.btnRemoveIngredientFromPantry.Size = new System.Drawing.Size(168, 48);
            this.btnRemoveIngredientFromPantry.TabIndex = 4;
            this.btnRemoveIngredientFromPantry.Text = "Remove selected ingredient";
            this.btnRemoveIngredientFromPantry.UseVisualStyleBackColor = false;
            this.btnRemoveIngredientFromPantry.Click += new System.EventHandler(this.btnRemoveIngredientFromPantry_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnBack.Location = new System.Drawing.Point(316, 359);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 29);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to home";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSelectedItemQuantity
            // 
            this.txtSelectedItemQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(178)))), ((int)(((byte)(146)))));
            this.txtSelectedItemQuantity.Location = new System.Drawing.Point(367, 223);
            this.txtSelectedItemQuantity.Name = "txtSelectedItemQuantity";
            this.txtSelectedItemQuantity.ReadOnly = true;
            this.txtSelectedItemQuantity.Size = new System.Drawing.Size(102, 27);
            this.txtSelectedItemQuantity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(300, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity:";
            // 
            // txtSelectedItemUnit
            // 
            this.txtSelectedItemUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(178)))), ((int)(((byte)(146)))));
            this.txtSelectedItemUnit.Location = new System.Drawing.Point(367, 265);
            this.txtSelectedItemUnit.Name = "txtSelectedItemUnit";
            this.txtSelectedItemUnit.ReadOnly = true;
            this.txtSelectedItemUnit.Size = new System.Drawing.Size(102, 27);
            this.txtSelectedItemUnit.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label4.Location = new System.Drawing.Point(329, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unit:";
            // 
            // Pantry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(178)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(499, 413);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSelectedItemUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSelectedItemQuantity);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRemoveIngredientFromPantry);
            this.Controls.Add(this.btnAddIngredientToPantry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPantryItems);
            this.Controls.Add(this.label1);
            this.Name = "Pantry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lstPantryItems;
        private Label label2;
        private Button btnAddIngredientToPantry;
        private Button btnRemoveIngredientFromPantry;
        private Button btnBack;
        private TextBox txtSelectedItemQuantity;
        private Label label3;
        private TextBox txtSelectedItemUnit;
        private Label label4;
    }
}
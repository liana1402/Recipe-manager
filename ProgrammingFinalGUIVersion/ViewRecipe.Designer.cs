namespace ProgrammingFinalGUIVersion
{
    partial class ViewRecipe
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtViewingRecipeName = new System.Windows.Forms.TextBox();
            this.lstViewingRecipeIngredients = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecipeDescription = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtViewingRecipeIngredientName = new System.Windows.Forms.TextBox();
            this.txtViewingRecipeIngredientUnit = new System.Windows.Forms.TextBox();
            this.nudViewingRecipeIngredientQty = new System.Windows.Forms.NumericUpDown();
            this.btnSaveIngChanges = new System.Windows.Forms.Button();
            this.btnAddNewIngredient = new System.Windows.Forms.Button();
            this.btnRemoveIngredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudViewingRecipeIngredientQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingredients:";
            // 
            // txtViewingRecipeName
            // 
            this.txtViewingRecipeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.txtViewingRecipeName.Location = new System.Drawing.Point(100, 20);
            this.txtViewingRecipeName.Name = "txtViewingRecipeName";
            this.txtViewingRecipeName.Size = new System.Drawing.Size(125, 27);
            this.txtViewingRecipeName.TabIndex = 2;
            // 
            // lstViewingRecipeIngredients
            // 
            this.lstViewingRecipeIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.lstViewingRecipeIngredients.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstViewingRecipeIngredients.FormattingEnabled = true;
            this.lstViewingRecipeIngredients.ItemHeight = 20;
            this.lstViewingRecipeIngredients.Location = new System.Drawing.Point(14, 156);
            this.lstViewingRecipeIngredients.Name = "lstViewingRecipeIngredients";
            this.lstViewingRecipeIngredients.Size = new System.Drawing.Size(211, 264);
            this.lstViewingRecipeIngredients.TabIndex = 3;
            this.lstViewingRecipeIngredients.SelectedIndexChanged += new System.EventHandler(this.lstViewingRecipeIngredients_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // txtRecipeDescription
            // 
            this.txtRecipeDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.txtRecipeDescription.Location = new System.Drawing.Point(414, 136);
            this.txtRecipeDescription.Multiline = true;
            this.txtRecipeDescription.Name = "txtRecipeDescription";
            this.txtRecipeDescription.Size = new System.Drawing.Size(236, 284);
            this.txtRecipeDescription.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.btnBack.Location = new System.Drawing.Point(663, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(206)))), ((int)(((byte)(120)))));
            this.btnSave.Location = new System.Drawing.Point(663, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtViewingRecipeIngredientName
            // 
            this.txtViewingRecipeIngredientName.BackColor = System.Drawing.Color.Linen;
            this.txtViewingRecipeIngredientName.Location = new System.Drawing.Point(100, 55);
            this.txtViewingRecipeIngredientName.Name = "txtViewingRecipeIngredientName";
            this.txtViewingRecipeIngredientName.PlaceholderText = "Name";
            this.txtViewingRecipeIngredientName.Size = new System.Drawing.Size(125, 27);
            this.txtViewingRecipeIngredientName.TabIndex = 8;
            // 
            // txtViewingRecipeIngredientUnit
            // 
            this.txtViewingRecipeIngredientUnit.BackColor = System.Drawing.Color.Linen;
            this.txtViewingRecipeIngredientUnit.Location = new System.Drawing.Point(100, 121);
            this.txtViewingRecipeIngredientUnit.Name = "txtViewingRecipeIngredientUnit";
            this.txtViewingRecipeIngredientUnit.PlaceholderText = "Unit";
            this.txtViewingRecipeIngredientUnit.Size = new System.Drawing.Size(125, 27);
            this.txtViewingRecipeIngredientUnit.TabIndex = 9;
            // 
            // nudViewingRecipeIngredientQty
            // 
            this.nudViewingRecipeIngredientQty.BackColor = System.Drawing.Color.Linen;
            this.nudViewingRecipeIngredientQty.DecimalPlaces = 2;
            this.nudViewingRecipeIngredientQty.Location = new System.Drawing.Point(100, 88);
            this.nudViewingRecipeIngredientQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudViewingRecipeIngredientQty.Name = "nudViewingRecipeIngredientQty";
            this.nudViewingRecipeIngredientQty.Size = new System.Drawing.Size(125, 27);
            this.nudViewingRecipeIngredientQty.TabIndex = 10;
            // 
            // btnSaveIngChanges
            // 
            this.btnSaveIngChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(206)))), ((int)(((byte)(120)))));
            this.btnSaveIngChanges.Enabled = false;
            this.btnSaveIngChanges.Location = new System.Drawing.Point(244, 55);
            this.btnSaveIngChanges.Name = "btnSaveIngChanges";
            this.btnSaveIngChanges.Size = new System.Drawing.Size(147, 60);
            this.btnSaveIngChanges.TabIndex = 11;
            this.btnSaveIngChanges.Text = "save changes made to ingredient";
            this.btnSaveIngChanges.UseVisualStyleBackColor = false;
            this.btnSaveIngChanges.Click += new System.EventHandler(this.btnSaveIngChanges_Click);
            // 
            // btnAddNewIngredient
            // 
            this.btnAddNewIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(206)))), ((int)(((byte)(120)))));
            this.btnAddNewIngredient.Location = new System.Drawing.Point(250, 121);
            this.btnAddNewIngredient.Name = "btnAddNewIngredient";
            this.btnAddNewIngredient.Size = new System.Drawing.Size(137, 48);
            this.btnAddNewIngredient.TabIndex = 12;
            this.btnAddNewIngredient.Text = "Add new ingredient";
            this.btnAddNewIngredient.UseVisualStyleBackColor = false;
            this.btnAddNewIngredient.Click += new System.EventHandler(this.btnAddNewIngredient_Click);
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.btnRemoveIngredient.Location = new System.Drawing.Point(250, 175);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(137, 49);
            this.btnRemoveIngredient.TabIndex = 13;
            this.btnRemoveIngredient.Text = "Remove selected ingredient";
            this.btnRemoveIngredient.UseVisualStyleBackColor = false;
            this.btnRemoveIngredient.Click += new System.EventHandler(this.btnRemoveIngredient_Click);
            // 
            // ViewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(178)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(769, 435);
            this.Controls.Add(this.btnRemoveIngredient);
            this.Controls.Add(this.btnAddNewIngredient);
            this.Controls.Add(this.btnSaveIngChanges);
            this.Controls.Add(this.nudViewingRecipeIngredientQty);
            this.Controls.Add(this.txtViewingRecipeIngredientUnit);
            this.Controls.Add(this.txtViewingRecipeIngredientName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtRecipeDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstViewingRecipeIngredients);
            this.Controls.Add(this.txtViewingRecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.nudViewingRecipeIngredientQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtViewingRecipeName;
        private ListBox lstViewingRecipeIngredients;
        private Label label3;
        private TextBox txtRecipeDescription;
        private Button btnBack;
        private Button btnSave;
        private TextBox txtViewingRecipeIngredientName;
        private TextBox txtViewingRecipeIngredientUnit;
        private NumericUpDown nudViewingRecipeIngredientQty;
        private Button btnSaveIngChanges;
        private Button btnAddNewIngredient;
        private Button btnRemoveIngredient;
    }
}
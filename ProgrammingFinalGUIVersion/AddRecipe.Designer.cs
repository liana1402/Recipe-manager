namespace ProgrammingFinalGUIVersion
{
    partial class AddRecipe
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
            this.txtNewRecipeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewRecipeIngredientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewRecipeDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lstNewRecipeIngredientToSave = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtNewRecipeIngredientUnit = new System.Windows.Forms.TextBox();
            this.nudNewRecipeIngredientQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddIngToList = new System.Windows.Forms.Button();
            this.btnRemoveIng = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewRecipeIngredientQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write down the information for your new recipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // txtNewRecipeName
            // 
            this.txtNewRecipeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.txtNewRecipeName.Location = new System.Drawing.Point(106, 59);
            this.txtNewRecipeName.Name = "txtNewRecipeName";
            this.txtNewRecipeName.Size = new System.Drawing.Size(125, 27);
            this.txtNewRecipeName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingredients:";
            // 
            // txtNewRecipeIngredientName
            // 
            this.txtNewRecipeIngredientName.BackColor = System.Drawing.Color.Linen;
            this.txtNewRecipeIngredientName.Location = new System.Drawing.Point(106, 97);
            this.txtNewRecipeIngredientName.Name = "txtNewRecipeIngredientName";
            this.txtNewRecipeIngredientName.PlaceholderText = "Name";
            this.txtNewRecipeIngredientName.Size = new System.Drawing.Size(125, 27);
            this.txtNewRecipeIngredientName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label4.Location = new System.Drawing.Point(303, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description(optional):";
            // 
            // txtNewRecipeDescription
            // 
            this.txtNewRecipeDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.txtNewRecipeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNewRecipeDescription.Location = new System.Drawing.Point(302, 193);
            this.txtNewRecipeDescription.Multiline = true;
            this.txtNewRecipeDescription.Name = "txtNewRecipeDescription";
            this.txtNewRecipeDescription.Size = new System.Drawing.Size(260, 346);
            this.txtNewRecipeDescription.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(206)))), ((int)(((byte)(120)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSave.Location = new System.Drawing.Point(589, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lstNewRecipeIngredientToSave
            // 
            this.lstNewRecipeIngredientToSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(210)))));
            this.lstNewRecipeIngredientToSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lstNewRecipeIngredientToSave.FormattingEnabled = true;
            this.lstNewRecipeIngredientToSave.ItemHeight = 20;
            this.lstNewRecipeIngredientToSave.Location = new System.Drawing.Point(23, 295);
            this.lstNewRecipeIngredientToSave.Name = "lstNewRecipeIngredientToSave";
            this.lstNewRecipeIngredientToSave.Size = new System.Drawing.Size(247, 244);
            this.lstNewRecipeIngredientToSave.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnCancel.Location = new System.Drawing.Point(589, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNewRecipeIngredientUnit
            // 
            this.txtNewRecipeIngredientUnit.BackColor = System.Drawing.Color.Linen;
            this.txtNewRecipeIngredientUnit.Location = new System.Drawing.Point(106, 165);
            this.txtNewRecipeIngredientUnit.Name = "txtNewRecipeIngredientUnit";
            this.txtNewRecipeIngredientUnit.PlaceholderText = "Unit";
            this.txtNewRecipeIngredientUnit.Size = new System.Drawing.Size(125, 27);
            this.txtNewRecipeIngredientUnit.TabIndex = 11;
            // 
            // nudNewRecipeIngredientQty
            // 
            this.nudNewRecipeIngredientQty.BackColor = System.Drawing.Color.Linen;
            this.nudNewRecipeIngredientQty.DecimalPlaces = 2;
            this.nudNewRecipeIngredientQty.Location = new System.Drawing.Point(106, 132);
            this.nudNewRecipeIngredientQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNewRecipeIngredientQty.Name = "nudNewRecipeIngredientQty";
            this.nudNewRecipeIngredientQty.Size = new System.Drawing.Size(125, 27);
            this.nudNewRecipeIngredientQty.TabIndex = 12;
            // 
            // btnAddIngToList
            // 
            this.btnAddIngToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(206)))), ((int)(((byte)(120)))));
            this.btnAddIngToList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnAddIngToList.Location = new System.Drawing.Point(116, 198);
            this.btnAddIngToList.Name = "btnAddIngToList";
            this.btnAddIngToList.Size = new System.Drawing.Size(103, 29);
            this.btnAddIngToList.TabIndex = 13;
            this.btnAddIngToList.Text = "Add";
            this.btnAddIngToList.UseVisualStyleBackColor = false;
            this.btnAddIngToList.Click += new System.EventHandler(this.btnAddIngToList_Click);
            // 
            // btnRemoveIng
            // 
            this.btnRemoveIng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(132)))), ((int)(((byte)(103)))));
            this.btnRemoveIng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnRemoveIng.Location = new System.Drawing.Point(96, 233);
            this.btnRemoveIng.Name = "btnRemoveIng";
            this.btnRemoveIng.Size = new System.Drawing.Size(146, 56);
            this.btnRemoveIng.TabIndex = 14;
            this.btnRemoveIng.Text = "Remove selected ingredient";
            this.btnRemoveIng.UseVisualStyleBackColor = false;
            this.btnRemoveIng.Click += new System.EventHandler(this.btnRemoveIng_Click);
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(178)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(699, 554);
            this.Controls.Add(this.btnRemoveIng);
            this.Controls.Add(this.btnAddIngToList);
            this.Controls.Add(this.nudNewRecipeIngredientQty);
            this.Controls.Add(this.txtNewRecipeIngredientUnit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lstNewRecipeIngredientToSave);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewRecipeDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewRecipeIngredientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewRecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.nudNewRecipeIngredientQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNewRecipeName;
        private Label label3;
        private TextBox txtNewRecipeIngredientName;
        private Label label4;
        private TextBox txtNewRecipeDescription;
        private Button btnSave;
        private ListBox lstNewRecipeIngredientToSave;
        private Button btnCancel;
        private TextBox txtNewRecipeIngredientUnit;
        private NumericUpDown nudNewRecipeIngredientQty;
        private Button btnAddIngToList;
        private Button btnRemoveIng;
    }
}
namespace Програмування_ПР1
{
    partial class AddTransactionForm
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
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.rbIncome = new System.Windows.Forms.RadioButton();
            this.rbExpense = new System.Windows.Forms.RadioButton();
            this.gbTransType = new System.Windows.Forms.GroupBox();
            this.gbTransType.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputNumber
            // 
            this.inputNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.inputNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumber.Location = new System.Drawing.Point(91, 56);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(175, 29);
            this.inputNumber.TabIndex = 0;
            this.inputNumber.Text = "Сума";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Одяг",
            "Їжа",
            "Ресторан",
            "Розваги",
            "Зарплатня",
            "Кишенькові гроші"});
            this.comboBox1.Location = new System.Drawing.Point(91, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Категорія";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Location = new System.Drawing.Point(188, 134);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 30);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Створити";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // rbIncome
            // 
            this.rbIncome.AutoSize = true;
            this.rbIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbIncome.Location = new System.Drawing.Point(6, 12);
            this.rbIncome.Name = "rbIncome";
            this.rbIncome.Size = new System.Drawing.Size(113, 20);
            this.rbIncome.TabIndex = 3;
            this.rbIncome.TabStop = true;
            this.rbIncome.Text = "Надходження";
            this.rbIncome.UseVisualStyleBackColor = false;
            // 
            // rbExpense
            // 
            this.rbExpense.AutoSize = true;
            this.rbExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbExpense.Location = new System.Drawing.Point(6, 32);
            this.rbExpense.Name = "rbExpense";
            this.rbExpense.Size = new System.Drawing.Size(80, 20);
            this.rbExpense.TabIndex = 4;
            this.rbExpense.TabStop = true;
            this.rbExpense.Text = "Витрата";
            this.rbExpense.UseVisualStyleBackColor = false;
            // 
            // gbTransType
            // 
            this.gbTransType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.gbTransType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbTransType.Controls.Add(this.rbIncome);
            this.gbTransType.Controls.Add(this.rbExpense);
            this.gbTransType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbTransType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTransType.ForeColor = System.Drawing.Color.Black;
            this.gbTransType.Location = new System.Drawing.Point(279, 54);
            this.gbTransType.Name = "gbTransType";
            this.gbTransType.Size = new System.Drawing.Size(124, 58);
            this.gbTransType.TabIndex = 5;
            this.gbTransType.TabStop = false;
            // 
            // AddTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(441, 238);
            this.Controls.Add(this.gbTransType);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.inputNumber);
            this.Name = "AddTransactionForm";
            this.Text = "AddTransactionForm";
            this.gbTransType.ResumeLayout(false);
            this.gbTransType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RadioButton rbIncome;
        private System.Windows.Forms.RadioButton rbExpense;
        private System.Windows.Forms.GroupBox gbTransType;
    }
}
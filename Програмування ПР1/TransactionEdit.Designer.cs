namespace Програмування_ПР1
{
    partial class TransactionEdit
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
            this.gbTransType = new System.Windows.Forms.GroupBox();
            this.rbIncomeEdit = new System.Windows.Forms.RadioButton();
            this.rbExpenseEdit = new System.Windows.Forms.RadioButton();
            this.buttonSaveEdit = new System.Windows.Forms.Button();
            this.catEdit = new System.Windows.Forms.ComboBox();
            this.sumEdit = new System.Windows.Forms.TextBox();
            this.gbTransType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTransType
            // 
            this.gbTransType.BackColor = System.Drawing.Color.DarkKhaki;
            this.gbTransType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbTransType.Controls.Add(this.rbIncomeEdit);
            this.gbTransType.Controls.Add(this.rbExpenseEdit);
            this.gbTransType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbTransType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTransType.ForeColor = System.Drawing.Color.Black;
            this.gbTransType.Location = new System.Drawing.Point(288, 65);
            this.gbTransType.Name = "gbTransType";
            this.gbTransType.Size = new System.Drawing.Size(124, 58);
            this.gbTransType.TabIndex = 9;
            this.gbTransType.TabStop = false;
            // 
            // rbIncomeEdit
            // 
            this.rbIncomeEdit.AutoSize = true;
            this.rbIncomeEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbIncomeEdit.Location = new System.Drawing.Point(6, 12);
            this.rbIncomeEdit.Name = "rbIncomeEdit";
            this.rbIncomeEdit.Size = new System.Drawing.Size(113, 20);
            this.rbIncomeEdit.TabIndex = 3;
            this.rbIncomeEdit.TabStop = true;
            this.rbIncomeEdit.Text = "Надходження";
            this.rbIncomeEdit.UseVisualStyleBackColor = false;
            // 
            // rbExpenseEdit
            // 
            this.rbExpenseEdit.AutoSize = true;
            this.rbExpenseEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbExpenseEdit.Location = new System.Drawing.Point(6, 32);
            this.rbExpenseEdit.Name = "rbExpenseEdit";
            this.rbExpenseEdit.Size = new System.Drawing.Size(80, 20);
            this.rbExpenseEdit.TabIndex = 4;
            this.rbExpenseEdit.TabStop = true;
            this.rbExpenseEdit.Text = "Витрата";
            this.rbExpenseEdit.UseVisualStyleBackColor = false;
            // 
            // buttonSaveEdit
            // 
            this.buttonSaveEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.buttonSaveEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveEdit.Location = new System.Drawing.Point(197, 145);
            this.buttonSaveEdit.Name = "buttonSaveEdit";
            this.buttonSaveEdit.Size = new System.Drawing.Size(86, 30);
            this.buttonSaveEdit.TabIndex = 8;
            this.buttonSaveEdit.Text = "Зберегти";
            this.buttonSaveEdit.UseVisualStyleBackColor = false;
            this.buttonSaveEdit.Click += new System.EventHandler(this.buttonSaveEdit_Click);
            // 
            // catEdit
            // 
            this.catEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.catEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catEdit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.catEdit.FormattingEnabled = true;
            this.catEdit.Items.AddRange(new object[] {
            "Одяг",
            "Їжа",
            "Ресторан",
            "Розваги",
            "Зарплатня",
            "Кишенькові гроші"});
            this.catEdit.Location = new System.Drawing.Point(100, 102);
            this.catEdit.Name = "catEdit";
            this.catEdit.Size = new System.Drawing.Size(175, 21);
            this.catEdit.TabIndex = 7;
            this.catEdit.Text = "Категорія";
            // 
            // sumEdit
            // 
            this.sumEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sumEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.sumEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumEdit.Location = new System.Drawing.Point(100, 67);
            this.sumEdit.Name = "sumEdit";
            this.sumEdit.Size = new System.Drawing.Size(175, 29);
            this.sumEdit.TabIndex = 6;
            this.sumEdit.Text = "Сума";
            // 
            // TransactionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(507, 238);
            this.Controls.Add(this.gbTransType);
            this.Controls.Add(this.buttonSaveEdit);
            this.Controls.Add(this.catEdit);
            this.Controls.Add(this.sumEdit);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "TransactionEdit";
            this.Text = "TransactionEdit";
            this.gbTransType.ResumeLayout(false);
            this.gbTransType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTransType;
        private System.Windows.Forms.RadioButton rbIncomeEdit;
        private System.Windows.Forms.RadioButton rbExpenseEdit;
        private System.Windows.Forms.Button buttonSaveEdit;
        private System.Windows.Forms.ComboBox catEdit;
        private System.Windows.Forms.TextBox sumEdit;
    }
}
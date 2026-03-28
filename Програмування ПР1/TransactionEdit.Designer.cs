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
            this.rbIncomeEdit = new System.Windows.Forms.RadioButton();
            this.rbExpenseEdit = new System.Windows.Forms.RadioButton();
            this.buttonSaveEdit = new System.Windows.Forms.Button();
            this.catEdit = new System.Windows.Forms.ComboBox();
            this.sumEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbIncomeEdit
            // 
            this.rbIncomeEdit.AutoSize = true;
            this.rbIncomeEdit.BackColor = System.Drawing.Color.Transparent;
            this.rbIncomeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbIncomeEdit.ForeColor = System.Drawing.Color.LightGreen;
            this.rbIncomeEdit.Location = new System.Drawing.Point(3, 3);
            this.rbIncomeEdit.Name = "rbIncomeEdit";
            this.rbIncomeEdit.Size = new System.Drawing.Size(124, 20);
            this.rbIncomeEdit.TabIndex = 3;
            this.rbIncomeEdit.TabStop = true;
            this.rbIncomeEdit.Text = "Надходження";
            this.rbIncomeEdit.UseVisualStyleBackColor = false;
            // 
            // rbExpenseEdit
            // 
            this.rbExpenseEdit.AutoSize = true;
            this.rbExpenseEdit.BackColor = System.Drawing.Color.Transparent;
            this.rbExpenseEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbExpenseEdit.ForeColor = System.Drawing.Color.Crimson;
            this.rbExpenseEdit.Location = new System.Drawing.Point(3, 23);
            this.rbExpenseEdit.Name = "rbExpenseEdit";
            this.rbExpenseEdit.Size = new System.Drawing.Size(87, 20);
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
            this.buttonSaveEdit.Location = new System.Drawing.Point(202, 180);
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
            this.catEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catEdit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.catEdit.FormattingEnabled = true;
            this.catEdit.Items.AddRange(new object[] {
            "Одяг",
            "Їжа",
            "Ресторан",
            "Розваги",
            "Зарплатня",
            "Кишенькові гроші"});
            this.catEdit.Location = new System.Drawing.Point(100, 120);
            this.catEdit.Name = "catEdit";
            this.catEdit.Size = new System.Drawing.Size(149, 24);
            this.catEdit.TabIndex = 7;
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
            this.sumEdit.Size = new System.Drawing.Size(59, 29);
            this.sumEdit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(269, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Тип";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(100, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Категорія";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(97, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Сума";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbExpenseEdit);
            this.panel1.Controls.Add(this.rbIncomeEdit);
            this.panel1.Location = new System.Drawing.Point(272, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 49);
            this.panel1.TabIndex = 13;
            // 
            // TransactionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(494, 286);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveEdit);
            this.Controls.Add(this.catEdit);
            this.Controls.Add(this.sumEdit);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "TransactionEdit";
            this.Text = "TransactionEdit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbIncomeEdit;
        private System.Windows.Forms.RadioButton rbExpenseEdit;
        private System.Windows.Forms.Button buttonSaveEdit;
        private System.Windows.Forms.ComboBox catEdit;
        private System.Windows.Forms.TextBox sumEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
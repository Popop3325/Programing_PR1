namespace Програмування_ПР1
{
    partial class FinanceTracker
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceTracker));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.transHis = new System.Windows.Forms.ListBox();
            this.newTransaction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.mainPanel.Controls.Add(this.transHis);
            this.mainPanel.Controls.Add(this.newTransaction);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.UpperPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(645, 410);
            this.mainPanel.TabIndex = 0;
            // 
            // transHis
            // 
            this.transHis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.transHis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transHis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transHis.FormattingEnabled = true;
            this.transHis.ItemHeight = 30;
            this.transHis.Location = new System.Drawing.Point(259, 118);
            this.transHis.Name = "transHis";
            this.transHis.Size = new System.Drawing.Size(348, 182);
            this.transHis.TabIndex = 5;
            // 
            // newTransaction
            // 
            this.newTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.newTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newTransaction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.newTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.newTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.newTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newTransaction.Location = new System.Drawing.Point(0, 356);
            this.newTransaction.Name = "newTransaction";
            this.newTransaction.Size = new System.Drawing.Size(645, 54);
            this.newTransaction.TabIndex = 4;
            this.newTransaction.Text = "Нова транзакція";
            this.newTransaction.UseVisualStyleBackColor = false;
            this.newTransaction.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelCurrentBalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(88, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 62);
            this.panel1.TabIndex = 2;
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentBalance.Location = new System.Drawing.Point(2, 30);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(24, 25);
            this.labelCurrentBalance.TabIndex = 0;
            this.labelCurrentBalance.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Баланс:";
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.mainLabel);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(645, 84);
            this.UpperPanel.TabIndex = 0;
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.mainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(244)))));
            this.mainLabel.Location = new System.Drawing.Point(0, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(645, 84);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "FINANCE TRACKER";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinanceTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 410);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinanceTracker";
            this.Text = "FinanceTracker";
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.UpperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCurrentBalance;
        private System.Windows.Forms.Button newTransaction;
        private System.Windows.Forms.ListBox transHis;
    }
}


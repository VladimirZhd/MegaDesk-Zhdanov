namespace MegaDesk_Zhdanov
{
    partial class ViewAllQuotes
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
            this.returnToMainBtn = new System.Windows.Forms.Button();
            this.viewAllQuotesLabel = new System.Windows.Forms.Label();
            this.viewAllQuotesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // returnToMainBtn
            // 
            this.returnToMainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainBtn.Location = new System.Drawing.Point(316, 378);
            this.returnToMainBtn.Name = "returnToMainBtn";
            this.returnToMainBtn.Size = new System.Drawing.Size(188, 42);
            this.returnToMainBtn.TabIndex = 5;
            this.returnToMainBtn.Text = "Main Menu";
            this.returnToMainBtn.UseVisualStyleBackColor = true;
            this.returnToMainBtn.Click += new System.EventHandler(this.returnToMainBtn_Click);
            // 
            // viewAllQuotesLabel
            // 
            this.viewAllQuotesLabel.AutoSize = true;
            this.viewAllQuotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllQuotesLabel.Location = new System.Drawing.Point(346, 20);
            this.viewAllQuotesLabel.Name = "viewAllQuotesLabel";
            this.viewAllQuotesLabel.Size = new System.Drawing.Size(124, 24);
            this.viewAllQuotesLabel.TabIndex = 8;
            this.viewAllQuotesLabel.Text = "Quote History";
            // 
            // viewAllQuotesGrid
            // 
            this.viewAllQuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAllQuotesGrid.Location = new System.Drawing.Point(12, 67);
            this.viewAllQuotesGrid.Name = "viewAllQuotesGrid";
            this.viewAllQuotesGrid.Size = new System.Drawing.Size(776, 291);
            this.viewAllQuotesGrid.TabIndex = 6;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnToMainBtn);
            this.Controls.Add(this.viewAllQuotesLabel);
            this.Controls.Add(this.viewAllQuotesGrid);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewAllQuotes_FormClosed);
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAllQuotesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnToMainBtn;
        private System.Windows.Forms.Label viewAllQuotesLabel;
        private System.Windows.Forms.DataGridView viewAllQuotesGrid;
    }
}
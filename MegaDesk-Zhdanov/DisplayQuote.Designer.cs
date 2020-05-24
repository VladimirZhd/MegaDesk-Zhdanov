namespace MegaDesk_Zhdanov
{
    partial class DisplayQuote
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
            this.customerNameLabel = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deskQuoteDeliveryOption = new System.Windows.Forms.ComboBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.deskQuoteSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.deskQuoteDrawers = new System.Windows.Forms.NumericUpDown();
            this.numOfDrawers = new System.Windows.Forms.Label();
            this.deskSize = new System.Windows.Forms.GroupBox();
            this.deskQuoteDepth = new System.Windows.Forms.NumericUpDown();
            this.deskDepth = new System.Windows.Forms.Label();
            this.deskQuoteWidth = new System.Windows.Forms.NumericUpDown();
            this.deskWidth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.priceQuoteTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteDrawers)).BeginInit();
            this.deskSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteWidth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Location = new System.Drawing.Point(186, 104);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.ReadOnly = true;
            this.customerNameLabel.Size = new System.Drawing.Size(423, 20);
            this.customerNameLabel.TabIndex = 24;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(318, 384);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(188, 42);
            this.cancelButton.TabIndex = 23;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deskQuoteDeliveryOption
            // 
            this.deskQuoteDeliveryOption.FormattingEnabled = true;
            this.deskQuoteDeliveryOption.Location = new System.Drawing.Point(546, 236);
            this.deskQuoteDeliveryOption.Margin = new System.Windows.Forms.Padding(4);
            this.deskQuoteDeliveryOption.Name = "deskQuoteDeliveryOption";
            this.deskQuoteDeliveryOption.Size = new System.Drawing.Size(195, 21);
            this.deskQuoteDeliveryOption.TabIndex = 21;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(470, 236);
            this.deliveryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(68, 20);
            this.deliveryLabel.TabIndex = 20;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // deskQuoteSurfaceMaterial
            // 
            this.deskQuoteSurfaceMaterial.FormattingEnabled = true;
            this.deskQuoteSurfaceMaterial.Location = new System.Drawing.Point(546, 192);
            this.deskQuoteSurfaceMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.deskQuoteSurfaceMaterial.Name = "deskQuoteSurfaceMaterial";
            this.deskQuoteSurfaceMaterial.Size = new System.Drawing.Size(195, 21);
            this.deskQuoteSurfaceMaterial.TabIndex = 19;
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(409, 192);
            this.surfaceMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(129, 20);
            this.surfaceMaterialLabel.TabIndex = 18;
            this.surfaceMaterialLabel.Text = "Surface Material:";
            // 
            // deskQuoteDrawers
            // 
            this.deskQuoteDrawers.Location = new System.Drawing.Point(547, 158);
            this.deskQuoteDrawers.Margin = new System.Windows.Forms.Padding(4);
            this.deskQuoteDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.deskQuoteDrawers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deskQuoteDrawers.Name = "deskQuoteDrawers";
            this.deskQuoteDrawers.ReadOnly = true;
            this.deskQuoteDrawers.Size = new System.Drawing.Size(63, 20);
            this.deskQuoteDrawers.TabIndex = 17;
            this.deskQuoteDrawers.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numOfDrawers
            // 
            this.numOfDrawers.AutoSize = true;
            this.numOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawers.Location = new System.Drawing.Point(389, 157);
            this.numOfDrawers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(150, 20);
            this.numOfDrawers.TabIndex = 16;
            this.numOfDrawers.Text = "Number of Drawers:";
            // 
            // deskSize
            // 
            this.deskSize.Controls.Add(this.deskQuoteDepth);
            this.deskSize.Controls.Add(this.deskDepth);
            this.deskSize.Controls.Add(this.deskQuoteWidth);
            this.deskSize.Controls.Add(this.deskWidth);
            this.deskSize.Location = new System.Drawing.Point(59, 160);
            this.deskSize.Margin = new System.Windows.Forms.Padding(4);
            this.deskSize.Name = "deskSize";
            this.deskSize.Padding = new System.Windows.Forms.Padding(4);
            this.deskSize.Size = new System.Drawing.Size(297, 123);
            this.deskSize.TabIndex = 15;
            this.deskSize.TabStop = false;
            this.deskSize.Text = "Desk Size";
            // 
            // deskQuoteDepth
            // 
            this.deskQuoteDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskQuoteDepth.Location = new System.Drawing.Point(115, 73);
            this.deskQuoteDepth.Margin = new System.Windows.Forms.Padding(4);
            this.deskQuoteDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.deskQuoteDepth.Name = "deskQuoteDepth";
            this.deskQuoteDepth.ReadOnly = true;
            this.deskQuoteDepth.Size = new System.Drawing.Size(148, 23);
            this.deskQuoteDepth.TabIndex = 3;
            // 
            // deskDepth
            // 
            this.deskDepth.AutoSize = true;
            this.deskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepth.Location = new System.Drawing.Point(35, 76);
            this.deskDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(57, 20);
            this.deskDepth.TabIndex = 2;
            this.deskDepth.Text = "Depth:";
            // 
            // deskQuoteWidth
            // 
            this.deskQuoteWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskQuoteWidth.Location = new System.Drawing.Point(115, 28);
            this.deskQuoteWidth.Margin = new System.Windows.Forms.Padding(4);
            this.deskQuoteWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.deskQuoteWidth.Name = "deskQuoteWidth";
            this.deskQuoteWidth.ReadOnly = true;
            this.deskQuoteWidth.Size = new System.Drawing.Size(148, 23);
            this.deskQuoteWidth.TabIndex = 1;
            // 
            // deskWidth
            // 
            this.deskWidth.AutoSize = true;
            this.deskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidth.Location = new System.Drawing.Point(35, 32);
            this.deskWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(54, 20);
            this.deskWidth.TabIndex = 0;
            this.deskWidth.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Customer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Quote";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceQuoteTxt);
            this.groupBox1.Location = new System.Drawing.Point(232, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 59);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price Quote";
            // 
            // priceQuoteTxt
            // 
            this.priceQuoteTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceQuoteTxt.Location = new System.Drawing.Point(86, 16);
            this.priceQuoteTxt.Name = "priceQuoteTxt";
            this.priceQuoteTxt.Size = new System.Drawing.Size(188, 23);
            this.priceQuoteTxt.TabIndex = 0;
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deskQuoteDeliveryOption);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.deskQuoteSurfaceMaterial);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.deskQuoteDrawers);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.deskSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteDrawers)).EndInit();
            this.deskSize.ResumeLayout(false);
            this.deskSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteWidth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox deskQuoteDeliveryOption;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.ComboBox deskQuoteSurfaceMaterial;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.NumericUpDown deskQuoteDrawers;
        private System.Windows.Forms.Label numOfDrawers;
        private System.Windows.Forms.GroupBox deskSize;
        private System.Windows.Forms.NumericUpDown deskQuoteDepth;
        private System.Windows.Forms.Label deskDepth;
        private System.Windows.Forms.NumericUpDown deskQuoteWidth;
        private System.Windows.Forms.Label deskWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label priceQuoteTxt;
    }
}
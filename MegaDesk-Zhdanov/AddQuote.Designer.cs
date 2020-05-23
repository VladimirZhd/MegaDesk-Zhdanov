namespace MegaDesk_Zhdanov
{
    partial class AddQuote
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
            this.deskSize = new System.Windows.Forms.GroupBox();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.deskDepth = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.deskWidth = new System.Windows.Forms.Label();
            this.numOfDrawers = new System.Windows.Forms.Label();
            this.numericUpDownDrawers = new System.Windows.Forms.NumericUpDown();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.materialListDrop = new System.Windows.Forms.ComboBox();
            this.deliveryListLabel = new System.Windows.Forms.ComboBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.getQuoteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.deskSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Quote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // deskSize
            // 
            this.deskSize.Controls.Add(this.numericUpDownDepth);
            this.deskSize.Controls.Add(this.deskDepth);
            this.deskSize.Controls.Add(this.numericUpDownWidth);
            this.deskSize.Controls.Add(this.deskWidth);
            this.deskSize.Location = new System.Drawing.Point(55, 156);
            this.deskSize.Margin = new System.Windows.Forms.Padding(4);
            this.deskSize.Name = "deskSize";
            this.deskSize.Padding = new System.Windows.Forms.Padding(4);
            this.deskSize.Size = new System.Drawing.Size(297, 123);
            this.deskSize.TabIndex = 3;
            this.deskSize.TabStop = false;
            this.deskSize.Text = "Desk Size";
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDepth.Location = new System.Drawing.Point(115, 73);
            this.numericUpDownDepth.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDownDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(148, 23);
            this.numericUpDownDepth.TabIndex = 3;
            this.numericUpDownDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
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
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownWidth.Location = new System.Drawing.Point(115, 28);
            this.numericUpDownWidth.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(148, 23);
            this.numericUpDownWidth.TabIndex = 1;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownWidth.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDownWidth_Validating);
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
            // numOfDrawers
            // 
            this.numOfDrawers.AutoSize = true;
            this.numOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfDrawers.Location = new System.Drawing.Point(385, 153);
            this.numOfDrawers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numOfDrawers.Name = "numOfDrawers";
            this.numOfDrawers.Size = new System.Drawing.Size(150, 20);
            this.numOfDrawers.TabIndex = 4;
            this.numOfDrawers.Text = "Number of Drawers:";
            // 
            // numericUpDownDrawers
            // 
            this.numericUpDownDrawers.Location = new System.Drawing.Point(543, 154);
            this.numericUpDownDrawers.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownDrawers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDrawers.Name = "numericUpDownDrawers";
            this.numericUpDownDrawers.Size = new System.Drawing.Size(63, 23);
            this.numericUpDownDrawers.TabIndex = 5;
            this.numericUpDownDrawers.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(405, 188);
            this.surfaceMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(129, 20);
            this.surfaceMaterialLabel.TabIndex = 6;
            this.surfaceMaterialLabel.Text = "Surface Material:";
            // 
            // materialListDrop
            // 
            this.materialListDrop.FormattingEnabled = true;
            this.materialListDrop.Location = new System.Drawing.Point(542, 188);
            this.materialListDrop.Margin = new System.Windows.Forms.Padding(4);
            this.materialListDrop.Name = "materialListDrop";
            this.materialListDrop.Size = new System.Drawing.Size(195, 24);
            this.materialListDrop.TabIndex = 7;
            // 
            // deliveryListLabel
            // 
            this.deliveryListLabel.FormattingEnabled = true;
            this.deliveryListLabel.Location = new System.Drawing.Point(542, 232);
            this.deliveryListLabel.Margin = new System.Windows.Forms.Padding(4);
            this.deliveryListLabel.Name = "deliveryListLabel";
            this.deliveryListLabel.Size = new System.Drawing.Size(195, 24);
            this.deliveryListLabel.TabIndex = 9;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLabel.Location = new System.Drawing.Point(466, 232);
            this.deliveryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(68, 20);
            this.deliveryLabel.TabIndex = 8;
            this.deliveryLabel.Text = "Delivery:";
            // 
            // getQuoteButton
            // 
            this.getQuoteButton.BackColor = System.Drawing.SystemColors.Control;
            this.getQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getQuoteButton.Location = new System.Drawing.Point(222, 333);
            this.getQuoteButton.Margin = new System.Windows.Forms.Padding(4);
            this.getQuoteButton.Name = "getQuoteButton";
            this.getQuoteButton.Size = new System.Drawing.Size(188, 42);
            this.getQuoteButton.TabIndex = 10;
            this.getQuoteButton.Text = "Get Quote";
            this.getQuoteButton.UseVisualStyleBackColor = false;
            this.getQuoteButton.Click += new System.EventHandler(this.getQuoteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(418, 333);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(188, 42);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(182, 100);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(423, 23);
            this.customerNameTextBox.TabIndex = 12;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.getQuoteButton);
            this.Controls.Add(this.deliveryListLabel);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.materialListDrop);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(this.numericUpDownDrawers);
            this.Controls.Add(this.numOfDrawers);
            this.Controls.Add(this.deskSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.deskSize.ResumeLayout(false);
            this.deskSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox deskSize;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Label deskDepth;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label deskWidth;
        private System.Windows.Forms.Label numOfDrawers;
        private System.Windows.Forms.NumericUpDown numericUpDownDrawers;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.ComboBox materialListDrop;
        private System.Windows.Forms.ComboBox deliveryListLabel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.Button getQuoteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
    }
}
namespace MegaDesk_Zhdanov
{
    partial class SearchQuotes
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
            this.materialListDrop = new System.Windows.Forms.ComboBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surfaceMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialListDrop
            // 
            this.materialListDrop.FormattingEnabled = true;
            this.materialListDrop.Location = new System.Drawing.Point(161, 28);
            this.materialListDrop.Name = "materialListDrop";
            this.materialListDrop.Size = new System.Drawing.Size(184, 21);
            this.materialListDrop.TabIndex = 0;
            this.materialListDrop.SelectedValueChanged += new System.EventHandler(this.materialListDrop_SelectedValueChanged);
            // 
            // materialLabel
            // 
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(12, 28);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(143, 21);
            this.materialLabel.TabIndex = 1;
            this.materialLabel.Text = "Search by Material";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.quoteDate,
            this.deskWidth,
            this.deskDepth,
            this.surfaceMaterial,
            this.drawers,
            this.deliveryType,
            this.totalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 357);
            this.dataGridView1.TabIndex = 2;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // quoteDate
            // 
            this.quoteDate.HeaderText = "Quote Date";
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.ReadOnly = true;
            // 
            // deskWidth
            // 
            this.deskWidth.HeaderText = "Width";
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.ReadOnly = true;
            this.deskWidth.Width = 80;
            // 
            // deskDepth
            // 
            this.deskDepth.HeaderText = "Depth";
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.ReadOnly = true;
            this.deskDepth.Width = 80;
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.HeaderText = "Material";
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.ReadOnly = true;
            // 
            // drawers
            // 
            this.drawers.HeaderText = "Drawers";
            this.drawers.Name = "drawers";
            this.drawers.ReadOnly = true;
            // 
            // deliveryType
            // 
            this.deliveryType.HeaderText = "Delivery";
            this.deliveryType.Name = "deliveryType";
            this.deliveryType.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Price";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.materialListDrop);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchQuotes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox materialListDrop;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn surfaceMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}
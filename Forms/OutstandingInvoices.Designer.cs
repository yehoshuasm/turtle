namespace turtle.Forms
{
    partial class OutstandingInvoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.outstandingInvoicesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(3, 76);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(240, 200);
            this.dataGrid1.TabIndex = 0;
            // 
            // outstandingInvoicesLabel
            // 
            this.outstandingInvoicesLabel.Location = new System.Drawing.Point(19, 21);
            this.outstandingInvoicesLabel.Name = "outstandingInvoicesLabel";
            this.outstandingInvoicesLabel.Size = new System.Drawing.Size(203, 20);
            this.outstandingInvoicesLabel.Text = "Facturas pendientes para Envío";
            // 
            // OutstandingInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(247, 292);
            this.Controls.Add(this.outstandingInvoicesLabel);
            this.Controls.Add(this.dataGrid1);
            this.Menu = this.mainMenu1;
            this.Name = "OutstandingInvoices";
            this.Text = "OutstandingInvoices";
            this.Load += new System.EventHandler(this.OutstandingInvoices_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Label outstandingInvoicesLabel;
    }
}
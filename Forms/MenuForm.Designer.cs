﻿namespace turtle
{
    partial class MenuForm
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
            this.invoicingButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invoicingButton
            // 
            this.invoicingButton.Location = new System.Drawing.Point(3, 3);
            this.invoicingButton.Name = "invoicingButton";
            this.invoicingButton.Size = new System.Drawing.Size(247, 27);
            this.invoicingButton.TabIndex = 0;
            this.invoicingButton.Text = "Generar Factura";
            this.invoicingButton.Click += new System.EventHandler(this.invoicingButton_Click);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(3, 36);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(247, 27);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "Ver facturas guardadas";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(253, 175);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.invoicingButton);
            this.Menu = this.mainMenu1;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button invoicingButton;
        private System.Windows.Forms.Button viewButton;
    }
}
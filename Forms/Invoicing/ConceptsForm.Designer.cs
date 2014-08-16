namespace turtle.Forms.Invoicing
{
    partial class ConceptsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.ivaRateLabel = new System.Windows.Forms.Label();
            this.ivaRateTextBox = new System.Windows.Forms.TextBox();
            this.ivaTextBox = new System.Windows.Forms.TextBox();
            this.ivaLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.conceptsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.conceptsLabel = new System.Windows.Forms.Label();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.conceptsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.unitComboBox);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Controls.Add(this.ivaRateLabel);
            this.panel1.Controls.Add(this.ivaRateTextBox);
            this.panel1.Controls.Add(this.ivaTextBox);
            this.panel1.Controls.Add(this.ivaLabel);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.unitLabel);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(387, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 220);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.descriptionLabel.Location = new System.Drawing.Point(1, 88);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(115, 20);
            this.descriptionLabel.Text = "Descripción";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(118, 85);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 23);
            this.descriptionTextBox.TabIndex = 32;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(80, 189);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(72, 20);
            this.addbutton.TabIndex = 1;
            this.addbutton.Text = "Añadir";
            this.addbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // ivaRateLabel
            // 
            this.ivaRateLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.ivaRateLabel.Location = new System.Drawing.Point(1, 163);
            this.ivaRateLabel.Name = "ivaRateLabel";
            this.ivaRateLabel.Size = new System.Drawing.Size(115, 20);
            this.ivaRateLabel.Text = "Tasa de IVA";
            // 
            // ivaRateTextBox
            // 
            this.ivaRateTextBox.Location = new System.Drawing.Point(118, 160);
            this.ivaRateTextBox.MaxLength = 10;
            this.ivaRateTextBox.Name = "ivaRateTextBox";
            this.ivaRateTextBox.Size = new System.Drawing.Size(100, 23);
            this.ivaRateTextBox.TabIndex = 14;
            // 
            // ivaTextBox
            // 
            this.ivaTextBox.Location = new System.Drawing.Point(118, 135);
            this.ivaTextBox.MaxLength = 10;
            this.ivaTextBox.Name = "ivaTextBox";
            this.ivaTextBox.Size = new System.Drawing.Size(100, 23);
            this.ivaTextBox.TabIndex = 11;
            // 
            // ivaLabel
            // 
            this.ivaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.ivaLabel.Location = new System.Drawing.Point(1, 138);
            this.ivaLabel.Name = "ivaLabel";
            this.ivaLabel.Size = new System.Drawing.Size(115, 20);
            this.ivaLabel.Text = "IVA";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(118, 110);
            this.priceTextBox.MaxLength = 30;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 23);
            this.priceTextBox.TabIndex = 10;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.priceLabel.Location = new System.Drawing.Point(1, 113);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(115, 20);
            this.priceLabel.Text = "Precio Unitario";
            // 
            // unitLabel
            // 
            this.unitLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.unitLabel.Location = new System.Drawing.Point(1, 63);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(115, 20);
            this.unitLabel.Text = "Unidad";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(118, 35);
            this.quantityTextBox.MaxLength = 13;
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.quantityTextBox.TabIndex = 2;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.quantityLabel.Location = new System.Drawing.Point(1, 38);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(115, 20);
            this.quantityLabel.Text = "Cantidad";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(5, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(220, 20);
            this.label14.Text = "Concepto";
            // 
            // conceptsPanel
            // 
            this.conceptsPanel.Controls.Add(this.button1);
            this.conceptsPanel.Controls.Add(this.textBox12);
            this.conceptsPanel.Controls.Add(this.label7);
            this.conceptsPanel.Controls.Add(this.conceptsLabel);
            this.conceptsPanel.Location = new System.Drawing.Point(0, 0);
            this.conceptsPanel.Name = "conceptsPanel";
            this.conceptsPanel.Size = new System.Drawing.Size(225, 452);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Añadir";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(118, 35);
            this.textBox12.MaxLength = 13;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 23);
            this.textBox12.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(1, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.Text = "Cantidad";
            // 
            // conceptsLabel
            // 
            this.conceptsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.conceptsLabel.Location = new System.Drawing.Point(5, 5);
            this.conceptsLabel.Name = "conceptsLabel";
            this.conceptsLabel.Size = new System.Drawing.Size(220, 20);
            this.conceptsLabel.Text = "Conceptos";
            // 
            // unitComboBox
            // 
            this.unitComboBox.Location = new System.Drawing.Point(118, 60);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(100, 23);
            this.unitComboBox.TabIndex = 39;
            // 
            // ConceptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.conceptsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ConceptsForm";
            this.Text = "Concepts";
            this.panel1.ResumeLayout(false);
            this.conceptsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label ivaRateLabel;
        private System.Windows.Forms.TextBox ivaRateTextBox;
        private System.Windows.Forms.TextBox ivaTextBox;
        private System.Windows.Forms.Label ivaLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel conceptsPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label conceptsLabel;
        private System.Windows.Forms.ComboBox unitComboBox;
    }
}
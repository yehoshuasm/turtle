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
            this.conceptPanel = new System.Windows.Forms.Panel();
            this.ivaRatecomboBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.ivaRateLabel = new System.Windows.Forms.Label();
            this.ivaTextBox = new System.Windows.Forms.TextBox();
            this.ivaLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.conceptsPanel = new System.Windows.Forms.Panel();
            this.conceptsDataGrid = new System.Windows.Forms.DataGrid();
            this.addConceptButton = new System.Windows.Forms.Button();
            this.conceptsLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.conceptPanel.SuspendLayout();
            this.conceptsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // conceptPanel
            // 
            this.conceptPanel.Controls.Add(this.ivaRatecomboBox);
            this.conceptPanel.Controls.Add(this.cancelButton);
            this.conceptPanel.Controls.Add(this.deleteButton);
            this.conceptPanel.Controls.Add(this.unitComboBox);
            this.conceptPanel.Controls.Add(this.descriptionLabel);
            this.conceptPanel.Controls.Add(this.descriptionTextBox);
            this.conceptPanel.Controls.Add(this.addButton);
            this.conceptPanel.Controls.Add(this.ivaRateLabel);
            this.conceptPanel.Controls.Add(this.ivaTextBox);
            this.conceptPanel.Controls.Add(this.ivaLabel);
            this.conceptPanel.Controls.Add(this.priceTextBox);
            this.conceptPanel.Controls.Add(this.priceLabel);
            this.conceptPanel.Controls.Add(this.unitLabel);
            this.conceptPanel.Controls.Add(this.quantityTextBox);
            this.conceptPanel.Controls.Add(this.quantityLabel);
            this.conceptPanel.Controls.Add(this.label14);
            this.conceptPanel.Location = new System.Drawing.Point(0, 0);
            this.conceptPanel.Name = "conceptPanel";
            this.conceptPanel.Size = new System.Drawing.Size(225, 305);
            this.conceptPanel.Visible = false;
            // 
            // ivaRatecomboBox
            // 
            this.ivaRatecomboBox.Items.Add("16");
            this.ivaRatecomboBox.Items.Add("0");
            this.ivaRatecomboBox.Location = new System.Drawing.Point(118, 135);
            this.ivaRatecomboBox.Name = "ivaRatecomboBox";
            this.ivaRatecomboBox.Size = new System.Drawing.Size(100, 23);
            this.ivaRatecomboBox.TabIndex = 56;
            this.ivaRatecomboBox.SelectedIndexChanged += new System.EventHandler(this.ivaRateSelectItem);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(118, 189);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 20);
            this.cancelButton.TabIndex = 48;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(118, 189);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(72, 20);
            this.deleteButton.TabIndex = 47;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // unitComboBox
            // 
            this.unitComboBox.Items.Add("Pieza");
            this.unitComboBox.Items.Add("Litro");
            this.unitComboBox.Items.Add("Kilo");
            this.unitComboBox.Items.Add("Metro");
            this.unitComboBox.Items.Add("Tonelada");
            this.unitComboBox.Items.Add("Decimetro");
            this.unitComboBox.Items.Add("Centimetro");
            this.unitComboBox.Items.Add("Gramo");
            this.unitComboBox.Items.Add("Onza");
            this.unitComboBox.Items.Add("Libra");
            this.unitComboBox.Items.Add("Servicio");
            this.unitComboBox.Items.Add("N/A");
            this.unitComboBox.Location = new System.Drawing.Point(118, 60);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(100, 23);
            this.unitComboBox.TabIndex = 39;
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
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(40, 189);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 20);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Añadir";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ivaRateLabel
            // 
            this.ivaRateLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.ivaRateLabel.Location = new System.Drawing.Point(3, 138);
            this.ivaRateLabel.Name = "ivaRateLabel";
            this.ivaRateLabel.Size = new System.Drawing.Size(115, 20);
            this.ivaRateLabel.Text = "Tasa de IVA";
            // 
            // ivaTextBox
            // 
            this.ivaTextBox.Location = new System.Drawing.Point(118, 161);
            this.ivaTextBox.MaxLength = 10;
            this.ivaTextBox.Name = "ivaTextBox";
            this.ivaTextBox.Size = new System.Drawing.Size(100, 23);
            this.ivaTextBox.TabIndex = 11;
            // 
            // ivaLabel
            // 
            this.ivaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.ivaLabel.Location = new System.Drawing.Point(3, 164);
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
            this.conceptsPanel.Controls.Add(this.conceptsDataGrid);
            this.conceptsPanel.Controls.Add(this.addConceptButton);
            this.conceptsPanel.Controls.Add(this.conceptsLabel);
            this.conceptsPanel.Location = new System.Drawing.Point(0, 0);
            this.conceptsPanel.Name = "conceptsPanel";
            this.conceptsPanel.Size = new System.Drawing.Size(225, 308);
            // 
            // conceptsDataGrid
            // 
            this.conceptsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.conceptsDataGrid.Location = new System.Drawing.Point(0, 63);
            this.conceptsDataGrid.Name = "conceptsDataGrid";
            this.conceptsDataGrid.Size = new System.Drawing.Size(225, 200);
            this.conceptsDataGrid.TabIndex = 3;
            // 
            // addConceptButton
            // 
            this.addConceptButton.Location = new System.Drawing.Point(53, 38);
            this.addConceptButton.Name = "addConceptButton";
            this.addConceptButton.Size = new System.Drawing.Size(110, 20);
            this.addConceptButton.TabIndex = 1;
            this.addConceptButton.Text = "Añadir concepto";
            this.addConceptButton.Click += new System.EventHandler(this.addConceptButton_Click);
            // 
            // conceptsLabel
            // 
            this.conceptsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.conceptsLabel.Location = new System.Drawing.Point(5, 5);
            this.conceptsLabel.Name = "conceptsLabel";
            this.conceptsLabel.Size = new System.Drawing.Size(220, 20);
            this.conceptsLabel.Text = "Conceptos";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(53, 269);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(110, 20);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Listo";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ConceptsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(229, 311);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.conceptPanel);
            this.Controls.Add(this.conceptsPanel);
            this.Name = "ConceptsForm";
            this.Text = "Concepts";
            this.conceptPanel.ResumeLayout(false);
            this.conceptsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel conceptPanel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label ivaRateLabel;
        private System.Windows.Forms.TextBox ivaTextBox;
        private System.Windows.Forms.Label ivaLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel conceptsPanel;
        private System.Windows.Forms.Button addConceptButton;
        private System.Windows.Forms.Label conceptsLabel;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.DataGrid conceptsDataGrid;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox ivaRatecomboBox;
    }
}
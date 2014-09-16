namespace turtle.Forms
{
    partial class ConfigForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.configTabControl = new System.Windows.Forms.TabControl();
            this.folioTabPage = new System.Windows.Forms.TabPage();
            this.configFolioCancel_button = new System.Windows.Forms.Button();
            this.configFolioAcept_button = new System.Windows.Forms.Button();
            this.currentFoliolabel = new System.Windows.Forms.Label();
            this.finalFoliolabel = new System.Windows.Forms.Label();
            this.initialFoliolabel = new System.Windows.Forms.Label();
            this.serielabel = new System.Windows.Forms.Label();
            this.currentFoliotextBox = new System.Windows.Forms.TextBox();
            this.finalFoliotextBox = new System.Windows.Forms.TextBox();
            this.initialFoliotextBox = new System.Windows.Forms.TextBox();
            this.serietextBox = new System.Windows.Forms.TextBox();
            this.adminTabPage = new System.Windows.Forms.TabPage();
            this.newPasswordlabel = new System.Windows.Forms.Label();
            this.newUserlabel = new System.Windows.Forms.Label();
            this.actualPasswordlabel = new System.Windows.Forms.Label();
            this.actualUserlabel = new System.Windows.Forms.Label();
            this.configUserCancel_button = new System.Windows.Forms.Button();
            this.configChangeUser_button = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.newUsertextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.actualusertextBox = new System.Windows.Forms.TextBox();
            this.addendatabPage = new System.Windows.Forms.TabPage();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.configDeleteAddenda_button = new System.Windows.Forms.Button();
            this.configAddAddenda_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addendalabel = new System.Windows.Forms.Label();
            this.configTabControl.SuspendLayout();
            this.folioTabPage.SuspendLayout();
            this.adminTabPage.SuspendLayout();
            this.addendatabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // configTabControl
            // 
            this.configTabControl.Controls.Add(this.folioTabPage);
            this.configTabControl.Controls.Add(this.adminTabPage);
            this.configTabControl.Controls.Add(this.addendatabPage);
            this.configTabControl.Location = new System.Drawing.Point(0, 0);
            this.configTabControl.Name = "configTabControl";
            this.configTabControl.SelectedIndex = 0;
            this.configTabControl.Size = new System.Drawing.Size(238, 275);
            this.configTabControl.TabIndex = 0;
            // 
            // folioTabPage
            // 
            this.folioTabPage.Controls.Add(this.configFolioCancel_button);
            this.folioTabPage.Controls.Add(this.configFolioAcept_button);
            this.folioTabPage.Controls.Add(this.currentFoliolabel);
            this.folioTabPage.Controls.Add(this.finalFoliolabel);
            this.folioTabPage.Controls.Add(this.initialFoliolabel);
            this.folioTabPage.Controls.Add(this.serielabel);
            this.folioTabPage.Controls.Add(this.currentFoliotextBox);
            this.folioTabPage.Controls.Add(this.finalFoliotextBox);
            this.folioTabPage.Controls.Add(this.initialFoliotextBox);
            this.folioTabPage.Controls.Add(this.serietextBox);
            this.folioTabPage.Location = new System.Drawing.Point(4, 25);
            this.folioTabPage.Name = "folioTabPage";
            this.folioTabPage.Size = new System.Drawing.Size(230, 246);
            this.folioTabPage.Text = "Folios";
            // 
            // configFolioCancel_button
            // 
            this.configFolioCancel_button.Location = new System.Drawing.Point(25, 195);
            this.configFolioCancel_button.Name = "configFolioCancel_button";
            this.configFolioCancel_button.Size = new System.Drawing.Size(72, 20);
            this.configFolioCancel_button.TabIndex = 11;
            this.configFolioCancel_button.Text = "Cancelar";
            // 
            // configFolioAcept_button
            // 
            this.configFolioAcept_button.Location = new System.Drawing.Point(112, 195);
            this.configFolioAcept_button.Name = "configFolioAcept_button";
            this.configFolioAcept_button.Size = new System.Drawing.Size(72, 20);
            this.configFolioAcept_button.TabIndex = 10;
            this.configFolioAcept_button.Text = "Aceptar";
            this.configFolioAcept_button.Click += new System.EventHandler(this.configFolioAcept_button_Click);
            // 
            // currentFoliolabel
            // 
            this.currentFoliolabel.Location = new System.Drawing.Point(4, 154);
            this.currentFoliolabel.Name = "currentFoliolabel";
            this.currentFoliolabel.Size = new System.Drawing.Size(78, 23);
            this.currentFoliolabel.Text = "Folio Actual";
            // 
            // finalFoliolabel
            // 
            this.finalFoliolabel.Location = new System.Drawing.Point(4, 115);
            this.finalFoliolabel.Name = "finalFoliolabel";
            this.finalFoliolabel.Size = new System.Drawing.Size(74, 23);
            this.finalFoliolabel.Text = "Folio Final";
            // 
            // initialFoliolabel
            // 
            this.initialFoliolabel.Location = new System.Drawing.Point(4, 73);
            this.initialFoliolabel.Name = "initialFoliolabel";
            this.initialFoliolabel.Size = new System.Drawing.Size(74, 23);
            this.initialFoliolabel.Text = "Folio Inicial";
            // 
            // serielabel
            // 
            this.serielabel.Location = new System.Drawing.Point(4, 32);
            this.serielabel.Name = "serielabel";
            this.serielabel.Size = new System.Drawing.Size(74, 23);
            this.serielabel.Text = "Serie";
            // 
            // currentFoliotextBox
            // 
            this.currentFoliotextBox.Location = new System.Drawing.Point(84, 154);
            this.currentFoliotextBox.MaxLength = 10;
            this.currentFoliotextBox.Name = "currentFoliotextBox";
            this.currentFoliotextBox.ReadOnly = true;
            this.currentFoliotextBox.Size = new System.Drawing.Size(100, 23);
            this.currentFoliotextBox.TabIndex = 3;
            // 
            // finalFoliotextBox
            // 
            this.finalFoliotextBox.Location = new System.Drawing.Point(84, 115);
            this.finalFoliotextBox.MaxLength = 10;
            this.finalFoliotextBox.Name = "finalFoliotextBox";
            this.finalFoliotextBox.Size = new System.Drawing.Size(100, 23);
            this.finalFoliotextBox.TabIndex = 2;
            // 
            // initialFoliotextBox
            // 
            this.initialFoliotextBox.Location = new System.Drawing.Point(84, 73);
            this.initialFoliotextBox.MaxLength = 10;
            this.initialFoliotextBox.Name = "initialFoliotextBox";
            this.initialFoliotextBox.Size = new System.Drawing.Size(100, 23);
            this.initialFoliotextBox.TabIndex = 1;
            // 
            // serietextBox
            // 
            this.serietextBox.Location = new System.Drawing.Point(84, 32);
            this.serietextBox.MaxLength = 25;
            this.serietextBox.Name = "serietextBox";
            this.serietextBox.Size = new System.Drawing.Size(100, 23);
            this.serietextBox.TabIndex = 0;
            // 
            // adminTabPage
            // 
            this.adminTabPage.Controls.Add(this.newPasswordlabel);
            this.adminTabPage.Controls.Add(this.newUserlabel);
            this.adminTabPage.Controls.Add(this.actualPasswordlabel);
            this.adminTabPage.Controls.Add(this.actualUserlabel);
            this.adminTabPage.Controls.Add(this.configUserCancel_button);
            this.adminTabPage.Controls.Add(this.configChangeUser_button);
            this.adminTabPage.Controls.Add(this.textBox5);
            this.adminTabPage.Controls.Add(this.newUsertextBox);
            this.adminTabPage.Controls.Add(this.textBox3);
            this.adminTabPage.Controls.Add(this.actualusertextBox);
            this.adminTabPage.Location = new System.Drawing.Point(4, 25);
            this.adminTabPage.Name = "adminTabPage";
            this.adminTabPage.Size = new System.Drawing.Size(230, 246);
            this.adminTabPage.Text = "Administracion";
            // 
            // newPasswordlabel
            // 
            this.newPasswordlabel.Location = new System.Drawing.Point(0, 133);
            this.newPasswordlabel.Name = "newPasswordlabel";
            this.newPasswordlabel.Size = new System.Drawing.Size(100, 23);
            this.newPasswordlabel.Text = "Nuevo Pass";
            // 
            // newUserlabel
            // 
            this.newUserlabel.Location = new System.Drawing.Point(0, 104);
            this.newUserlabel.Name = "newUserlabel";
            this.newUserlabel.Size = new System.Drawing.Size(100, 23);
            this.newUserlabel.Text = "Nuevo Usuario";
            // 
            // actualPasswordlabel
            // 
            this.actualPasswordlabel.Location = new System.Drawing.Point(0, 60);
            this.actualPasswordlabel.Name = "actualPasswordlabel";
            this.actualPasswordlabel.Size = new System.Drawing.Size(100, 23);
            this.actualPasswordlabel.Text = "Password ";
            // 
            // actualUserlabel
            // 
            this.actualUserlabel.Location = new System.Drawing.Point(0, 31);
            this.actualUserlabel.Name = "actualUserlabel";
            this.actualUserlabel.Size = new System.Drawing.Size(100, 23);
            this.actualUserlabel.Text = "Usuario Actual";
            // 
            // configUserCancel_button
            // 
            this.configUserCancel_button.Location = new System.Drawing.Point(33, 185);
            this.configUserCancel_button.Name = "configUserCancel_button";
            this.configUserCancel_button.Size = new System.Drawing.Size(72, 20);
            this.configUserCancel_button.TabIndex = 5;
            this.configUserCancel_button.Text = "Cancelar";
            // 
            // configChangeUser_button
            // 
            this.configChangeUser_button.Location = new System.Drawing.Point(130, 185);
            this.configChangeUser_button.Name = "configChangeUser_button";
            this.configChangeUser_button.Size = new System.Drawing.Size(72, 20);
            this.configChangeUser_button.TabIndex = 4;
            this.configChangeUser_button.Text = "Cambiar";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(102, 133);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 3;
            // 
            // newUsertextBox
            // 
            this.newUsertextBox.Location = new System.Drawing.Point(102, 104);
            this.newUsertextBox.Name = "newUsertextBox";
            this.newUsertextBox.Size = new System.Drawing.Size(100, 23);
            this.newUsertextBox.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 1;
            // 
            // actualusertextBox
            // 
            this.actualusertextBox.Location = new System.Drawing.Point(102, 31);
            this.actualusertextBox.Name = "actualusertextBox";
            this.actualusertextBox.Size = new System.Drawing.Size(100, 23);
            this.actualusertextBox.TabIndex = 0;
            // 
            // addendatabPage
            // 
            this.addendatabPage.Controls.Add(this.dataGrid1);
            this.addendatabPage.Controls.Add(this.configDeleteAddenda_button);
            this.addendatabPage.Controls.Add(this.configAddAddenda_button);
            this.addendatabPage.Controls.Add(this.textBox2);
            this.addendatabPage.Controls.Add(this.addendalabel);
            this.addendatabPage.Location = new System.Drawing.Point(4, 25);
            this.addendatabPage.Name = "addendatabPage";
            this.addendatabPage.Size = new System.Drawing.Size(230, 246);
            this.addendatabPage.Text = "Adendas";
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(4, 83);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(223, 160);
            this.dataGrid1.TabIndex = 4;
            // 
            // configDeleteAddenda_button
            // 
            this.configDeleteAddenda_button.Location = new System.Drawing.Point(46, 57);
            this.configDeleteAddenda_button.Name = "configDeleteAddenda_button";
            this.configDeleteAddenda_button.Size = new System.Drawing.Size(72, 20);
            this.configDeleteAddenda_button.TabIndex = 3;
            this.configDeleteAddenda_button.Text = "Borrar";
            // 
            // configAddAddenda_button
            // 
            this.configAddAddenda_button.Location = new System.Drawing.Point(136, 57);
            this.configAddAddenda_button.Name = "configAddAddenda_button";
            this.configAddAddenda_button.Size = new System.Drawing.Size(72, 20);
            this.configAddAddenda_button.TabIndex = 2;
            this.configAddAddenda_button.Text = "Agregar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addendalabel
            // 
            this.addendalabel.Location = new System.Drawing.Point(4, 18);
            this.addendalabel.Name = "addendalabel";
            this.addendalabel.Size = new System.Drawing.Size(68, 20);
            this.addendalabel.Text = "Nombre:";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 275);
            this.Controls.Add(this.configTabControl);
            this.Menu = this.mainMenu1;
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.configTabControl.ResumeLayout(false);
            this.folioTabPage.ResumeLayout(false);
            this.adminTabPage.ResumeLayout(false);
            this.addendatabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl configTabControl;
        private System.Windows.Forms.TabPage folioTabPage;
        private System.Windows.Forms.TabPage adminTabPage;
        private System.Windows.Forms.Label serielabel;
        private System.Windows.Forms.TextBox currentFoliotextBox;
        private System.Windows.Forms.TextBox finalFoliotextBox;
        private System.Windows.Forms.TextBox initialFoliotextBox;
        private System.Windows.Forms.TextBox serietextBox;
        private System.Windows.Forms.Button configFolioCancel_button;
        private System.Windows.Forms.Button configFolioAcept_button;
        private System.Windows.Forms.Label currentFoliolabel;
        private System.Windows.Forms.Label finalFoliolabel;
        private System.Windows.Forms.Label initialFoliolabel;
        private System.Windows.Forms.Label newPasswordlabel;
        private System.Windows.Forms.Label newUserlabel;
        private System.Windows.Forms.Label actualPasswordlabel;
        private System.Windows.Forms.Label actualUserlabel;
        private System.Windows.Forms.Button configUserCancel_button;
        private System.Windows.Forms.Button configChangeUser_button;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox newUsertextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox actualusertextBox;
        private System.Windows.Forms.TabPage addendatabPage;
        private System.Windows.Forms.Button configAddAddenda_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label addendalabel;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button configDeleteAddenda_button;
    }
}
namespace Login
{
    partial class Form_Settings
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_MSSQLServers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_MSSQL_Databases = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_MSSQL = new System.Windows.Forms.TabPage();
            this.tabPage_MySQL = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMySQLConnect = new System.Windows.Forms.Button();
            this.listBox_MySQL_Databases = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MySQL_Password = new System.Windows.Forms.TextBox();
            this.textBox_MySQL_User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MySQL_Port = new System.Windows.Forms.TextBox();
            this.textBox_MySQL_Server = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.radioButtonSQLServer = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioButtonMySQL = new System.Windows.Forms.RadioButton();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_MSSQL.SuspendLayout();
            this.tabPage_MySQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_MSSQLServers
            // 
            this.comboBox_MSSQLServers.FormattingEnabled = true;
            this.comboBox_MSSQLServers.Location = new System.Drawing.Point(6, 23);
            this.comboBox_MSSQLServers.Name = "comboBox_MSSQLServers";
            this.comboBox_MSSQLServers.Size = new System.Drawing.Size(191, 24);
            this.comboBox_MSSQLServers.TabIndex = 4;
            this.comboBox_MSSQLServers.SelectedIndexChanged += new System.EventHandler(this.comboBox_Servers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servidores";
            // 
            // listBox_MSSQL_Databases
            // 
            this.listBox_MSSQL_Databases.FormattingEnabled = true;
            this.listBox_MSSQL_Databases.ItemHeight = 16;
            this.listBox_MSSQL_Databases.Location = new System.Drawing.Point(9, 89);
            this.listBox_MSSQL_Databases.Name = "listBox_MSSQL_Databases";
            this.listBox_MSSQL_Databases.Size = new System.Drawing.Size(313, 244);
            this.listBox_MSSQL_Databases.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bases de datos";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Status,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 388);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(527, 25);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Status
            // 
            this.toolStripStatusLabel_Status.Name = "toolStripStatusLabel_Status";
            this.toolStripStatusLabel_Status.Size = new System.Drawing.Size(18, 20);
            this.toolStripStatusLabel_Status.Text = "...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_MSSQL);
            this.tabControl.Controls.Add(this.tabPage_MySQL);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(336, 372);
            this.tabControl.TabIndex = 9;
            // 
            // tabPage_MSSQL
            // 
            this.tabPage_MSSQL.Controls.Add(this.label2);
            this.tabPage_MSSQL.Controls.Add(this.comboBox_MSSQLServers);
            this.tabPage_MSSQL.Controls.Add(this.label3);
            this.tabPage_MSSQL.Controls.Add(this.listBox_MSSQL_Databases);
            this.tabPage_MSSQL.Location = new System.Drawing.Point(4, 25);
            this.tabPage_MSSQL.Name = "tabPage_MSSQL";
            this.tabPage_MSSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MSSQL.Size = new System.Drawing.Size(328, 343);
            this.tabPage_MSSQL.TabIndex = 0;
            this.tabPage_MSSQL.Text = "SQL Server";
            this.tabPage_MSSQL.UseVisualStyleBackColor = true;
            // 
            // tabPage_MySQL
            // 
            this.tabPage_MySQL.Controls.Add(this.label6);
            this.tabPage_MySQL.Controls.Add(this.buttonMySQLConnect);
            this.tabPage_MySQL.Controls.Add(this.listBox_MySQL_Databases);
            this.tabPage_MySQL.Controls.Add(this.label5);
            this.tabPage_MySQL.Controls.Add(this.textBox_MySQL_Password);
            this.tabPage_MySQL.Controls.Add(this.textBox_MySQL_User);
            this.tabPage_MySQL.Controls.Add(this.label4);
            this.tabPage_MySQL.Controls.Add(this.label1);
            this.tabPage_MySQL.Controls.Add(this.textBox_MySQL_Port);
            this.tabPage_MySQL.Controls.Add(this.textBox_MySQL_Server);
            this.tabPage_MySQL.Location = new System.Drawing.Point(4, 25);
            this.tabPage_MySQL.Name = "tabPage_MySQL";
            this.tabPage_MySQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MySQL.Size = new System.Drawing.Size(328, 343);
            this.tabPage_MySQL.TabIndex = 1;
            this.tabPage_MySQL.Text = "MySQL";
            this.tabPage_MySQL.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bases de datos";
            // 
            // buttonMySQLConnect
            // 
            this.buttonMySQLConnect.Enabled = false;
            this.buttonMySQLConnect.Location = new System.Drawing.Point(204, 67);
            this.buttonMySQLConnect.Name = "buttonMySQLConnect";
            this.buttonMySQLConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonMySQLConnect.TabIndex = 8;
            this.buttonMySQLConnect.Text = "Conectar";
            this.buttonMySQLConnect.UseVisualStyleBackColor = true;
            // 
            // listBox_MySQL_Databases
            // 
            this.listBox_MySQL_Databases.Enabled = false;
            this.listBox_MySQL_Databases.FormattingEnabled = true;
            this.listBox_MySQL_Databases.ItemHeight = 16;
            this.listBox_MySQL_Databases.Location = new System.Drawing.Point(9, 131);
            this.listBox_MySQL_Databases.Name = "listBox_MySQL_Databases";
            this.listBox_MySQL_Databases.Size = new System.Drawing.Size(313, 196);
            this.listBox_MySQL_Databases.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Clave:";
            // 
            // textBox_MySQL_Password
            // 
            this.textBox_MySQL_Password.Enabled = false;
            this.textBox_MySQL_Password.Location = new System.Drawing.Point(77, 67);
            this.textBox_MySQL_Password.Name = "textBox_MySQL_Password";
            this.textBox_MySQL_Password.PasswordChar = '*';
            this.textBox_MySQL_Password.Size = new System.Drawing.Size(100, 22);
            this.textBox_MySQL_Password.TabIndex = 5;
            // 
            // textBox_MySQL_User
            // 
            this.textBox_MySQL_User.Enabled = false;
            this.textBox_MySQL_User.Location = new System.Drawing.Point(77, 38);
            this.textBox_MySQL_User.Name = "textBox_MySQL_User";
            this.textBox_MySQL_User.Size = new System.Drawing.Size(100, 22);
            this.textBox_MySQL_User.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servidor:";
            // 
            // textBox_MySQL_Port
            // 
            this.textBox_MySQL_Port.Enabled = false;
            this.textBox_MySQL_Port.Location = new System.Drawing.Point(241, 9);
            this.textBox_MySQL_Port.Name = "textBox_MySQL_Port";
            this.textBox_MySQL_Port.Size = new System.Drawing.Size(38, 22);
            this.textBox_MySQL_Port.TabIndex = 1;
            this.textBox_MySQL_Port.Text = "3306";
            // 
            // textBox_MySQL_Server
            // 
            this.textBox_MySQL_Server.Enabled = false;
            this.textBox_MySQL_Server.Location = new System.Drawing.Point(77, 9);
            this.textBox_MySQL_Server.Name = "textBox_MySQL_Server";
            this.textBox_MySQL_Server.Size = new System.Drawing.Size(158, 22);
            this.textBox_MySQL_Server.TabIndex = 0;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(354, 348);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(80, 23);
            this.button_Save.TabIndex = 10;
            this.button_Save.Text = "Guardar";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(435, 348);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(80, 23);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancelar";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // radioButtonSQLServer
            // 
            this.radioButtonSQLServer.AutoSize = true;
            this.radioButtonSQLServer.Checked = true;
            this.radioButtonSQLServer.Location = new System.Drawing.Point(354, 41);
            this.radioButtonSQLServer.Name = "radioButtonSQLServer";
            this.radioButtonSQLServer.Size = new System.Drawing.Size(103, 21);
            this.radioButtonSQLServer.TabIndex = 14;
            this.radioButtonSQLServer.TabStop = true;
            this.radioButtonSQLServer.Text = "SQL Server";
            this.radioButtonSQLServer.UseVisualStyleBackColor = true;
            this.radioButtonSQLServer.CheckedChanged += new System.EventHandler(this.radioButtonSQLServer_CheckedChanged);
            // 
            // radioButtonMySQL
            // 
            this.radioButtonMySQL.AutoSize = true;
            this.radioButtonMySQL.Location = new System.Drawing.Point(355, 68);
            this.radioButtonMySQL.Name = "radioButtonMySQL";
            this.radioButtonMySQL.Size = new System.Drawing.Size(75, 21);
            this.radioButtonMySQL.TabIndex = 15;
            this.radioButtonMySQL.Text = "MySQL";
            this.radioButtonMySQL.UseVisualStyleBackColor = true;
            this.radioButtonMySQL.CheckedChanged += new System.EventHandler(this.radioButtonMySQL_CheckedChanged);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 413);
            this.Controls.Add(this.radioButtonMySQL);
            this.Controls.Add(this.radioButtonSQLServer);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Name = "Form_Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage_MSSQL.ResumeLayout(false);
            this.tabPage_MSSQL.PerformLayout();
            this.tabPage_MySQL.ResumeLayout(false);
            this.tabPage_MySQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_MSSQLServers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_MSSQL_Databases;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_MSSQL;
        private System.Windows.Forms.TabPage tabPage_MySQL;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MySQL_Port;
        private System.Windows.Forms.TextBox textBox_MySQL_Server;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_MySQL_Password;
        private System.Windows.Forms.TextBox textBox_MySQL_User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_MySQL_Databases;
        private System.Windows.Forms.Button buttonMySQLConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonSQLServer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioButtonMySQL;
    }
}


using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form_Settings : Form
    {
        // Lista de base de datos a ignorar.
        private List<string> _excludeDatabases = new List<string>(new string[] { "master", "tempdb", "model", "msdb" });
        private SqlConnection _mssqlConn; // Conexion a la base de datos.
        private string _dbms = "SQLServer";

        public Form_Settings()
        {
            InitializeComponent();
        }

        private void Form_Settings_Load(object sender, EventArgs e) // Queremos buscar los servidores cuando la pantalla cargue.
        {
            this.BeginInvoke(new Action(()=>{
                toolStripStatusLabel_Status.Text = "Buscando servidores, por favor espere...";
                DataTable dataTable = SmoApplication.EnumAvailableSqlServers(false); // Buscamos todos los servidores.
                // Rows contiene la lista de servidores
                if (dataTable.Rows.Count > 0) // Si encontramos servidores procedemos a listarlos
                {
                    // Por cada servidor encontrado lo agreamos al ComboBox de servidores
                    foreach (DataRow server in dataTable.Rows)
                    {
                        comboBox_MSSQLServers.Items.Add(server.ItemArray[0] as string); // El nombre del servidor esta alojado en la posicion 0 de ItemArray
                    }
                    // Habilitamos las listas.
                    comboBox_MSSQLServers.BeginInvoke(new Action(delegate ()
                    {
                        comboBox_MSSQLServers.SelectedIndex = 0;
                    }));
                }
                toolStripStatusLabel_Status.Text = ""; // Limpiamos la barra de estado.
            }));
        }

        #region desglozar lista de base de datos
        private void comboBox_Servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_MSSQL_Databases.Items.Clear(); // Limpiamos la lista.
            try
            {
                ComboBox combo = (ComboBox)sender;
                using (var con = new SqlConnection("Data Source=" + (combo.SelectedItem as string) + "; Integrated Security=True;"))
                {
                    con.Open();
                    DataTable databases = con.GetSchema("Databases");
                    foreach (DataRow database in databases.Rows)
                    {
                        string databaseName = database.Field<string>("database_name");
                        if (!_excludeDatabases.Contains(databaseName)) // Ignoramos las bases de datos del sistema operativo.
                        {
                            // Cada base de datos la agregamos a la lista.
                            listBox_MSSQL_Databases.Items.Add(databaseName);
                        }
                    }
                    listBox_MSSQL_Databases.SelectedIndex = 0;
                    _mssqlConn = con;
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel_Status.Text = "Error: " + ex.Message;
            }
        }
        #endregion desglozar lista de base de datos

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (_dbms == "SQLServer")
            {
                // Verificamos si pudimos conectaranos a alguna base de datos
                if (_mssqlConn != null)
                {
                    // Guardamos en la variable statica publica la conexion a la base de datos. 
                    Program.mssqlConn = _mssqlConn;
                    Program.mssqlConn.ConnectionString = "Data Source=" + (comboBox_MSSQLServers.SelectedItem as string)
                                                       + "; Integrated Security=True; Database="
                                                       + (listBox_MSSQL_Databases.SelectedItem as string);
                }
            }
            else if (_dbms == "MySQLServer")
            {
                // Tomar MySQL
            }
            this.Close();
        }

        private void radioButtonSQLServer_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    textBox_MySQL_Server.Enabled = false;
                    textBox_MySQL_Port.Enabled = false;
                    textBox_MySQL_User.Enabled = false;
                    textBox_MySQL_Password.Enabled = false;
                    listBox_MySQL_Databases.Enabled = false;
                    buttonMySQLConnect.Enabled = false;
                    comboBox_MSSQLServers.Enabled = true;
                    listBox_MSSQL_Databases.Enabled = true;

                    _dbms = "SQLServer";
                }
            }
        }

        private void radioButtonMySQL_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    comboBox_MSSQLServers.Enabled = false;
                    listBox_MSSQL_Databases.Enabled = false;
                    textBox_MySQL_Server.Enabled = true;
                    textBox_MySQL_Port.Enabled = true;
                    textBox_MySQL_User.Enabled = true;
                    textBox_MySQL_Password.Enabled = true;
                    listBox_MySQL_Databases.Enabled = true;
                    buttonMySQLConnect.Enabled = true;

                    _dbms = "MySQLServer";
                }
            }
        }

    }
}

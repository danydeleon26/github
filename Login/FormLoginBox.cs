using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form_LoginBox : Form
    {
        public Form_LoginBox()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (Program.mssqlConn == null) // Verificamos si existe una conexion valida establecida.
            {
                DialogResult result = MessageBox.Show("No se ha establecido conexion con la base de datos ¿Desea hacer la configuracion ahora? ", "Error", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        (new Form_Settings()).ShowDialog();
                        break;
                    default:
                        break;
                }  
            }
            else // Si tenemos conexion a la base de datos, precedemos.
            {
                if (textBoxUsername.Text != null && textBoxPassword.Text != null) // Confirmamos que los datos esten escritos.
                {
                    if (textBoxUsername.Text.Length > 0 && textBoxPassword.Text.Length > 0)
                    {
                        Boolean loginSuccess = false; // Guardamos si el login es correcto.
                        try
                        {
                            // Configuramos el comando sql.
                            SqlCommand cmd = new SqlCommand()
                            {
                                Connection = Program.mssqlConn,
                                CommandType = CommandType.Text,
                                CommandText = "SELECT COUNT(*) FROM DatosLogin WHERE user='" + textBoxUsername.Text + "' AND password='" + textBoxPassword.Text + "' "
                            };
                            
                            Program.mssqlConn.Open(); // Abrimos conexion.

                            using (SqlDataReader reader = cmd.ExecuteReader()) // Ejecutamos comando de login
                            {
                                if (reader.HasRows)
                                {
                                    loginSuccess = true;
                                }
                            }

                            Program.mssqlConn.Close(); // Luego de cada query lo correcto es cerrar la conexion a la base de datos.
                        } catch(Exception ex)
                        {
                            // Si hay un error del sistema no lo mostramos.
                        }
                        // Verificamos si el login es correcto o no.
                        if (loginSuccess)
                        {
                            // Se hizo login correctamente.
                        }
                        else
                        {
                            MessageBox.Show("Veririque usuario y contraseña.", "Error"); // Credenciales no validas.
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar los campos de usuario y contraseña.");
                    }
                }
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            (new Form_Settings()).ShowDialog(); // Abrimos configuracion.
        }
    }
}

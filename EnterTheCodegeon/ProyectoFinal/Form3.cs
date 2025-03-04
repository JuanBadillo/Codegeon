using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Juan Manuel Badillo Flores 19100148
 * Hector Samuel Machado Aguilar 19100208*/


namespace ProyectoFinal
{
    public partial class Form3 : Form
    {
        int PuntosJugador;
        int id;
        public Form3(int Puntos, int IDJugador)
        {
            InitializeComponent();
            id = IDJugador;
            lblPuntuacion.Text = "Has Obtenido una Puntuacion de: " + Puntos + " !";
            lblID.Text = "#" + id;
            PuntosJugador = Puntos;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource = localhost; port = 3306; username = root; password = Mysqljuan";
            string query = "SELECT * FROM puntos.puntuacion"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dgvPuntos.DataSource = ds.Tables[0];
                }
            }
        }

        //Subir Puntuacion del Usuario a DB
        private void btnSubirPuntuacion_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Escribe un nombre!");
            }
            else
            {
                string connection = "datasource=localhost;port=3306;username=root;password=Mysqljuan";
                string iQuery = "INSERT INTO Puntos.puntuacion (ID, Nombre, Puntos) VALUES('" + id + "','" + this.txtNombre.Text + "','" + PuntosJugador + "')";
                MySqlConnection dataBase = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(iQuery, dataBase);
                MySqlDataReader r;
                try
                {
                    dataBase.Open();
                    r = cmd.ExecuteReader();
                    //dgvPuntos.DataSource = r;
                    //dgvPuntos.DataBindingComplete();
                    MessageBox.Show("Puntuacion Subida!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "Error");
                }
            }

        }

        //Recargar DGV
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource = localhost; port = 3306; username = root; password = Mysqljuan";
                string query = "SELECT * FROM puntos.puntuacion"; // set query to fetch data "Select * from  tabelname"; 
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dgvPuntos.DataSource = ds.Tables[0];
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }




        private void dgvPuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str = "";
        }

    }
}

using MySql.Data.MySqlClient;
using System.Data;

namespace E4ADRI

{
    public partial class Form1 : Form
    {
        conexion conex;
        public Form1()
        {
            InitializeComponent();
            conex = new conexion();
            mostrarDatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void mostrarDatos()
        {
            //mostrar de la base de datos en data grid view
            MySqlConnection conexion = conex.AbrirConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM persona", conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar persona a la bd
            MySqlConnection conexion = conex.AbrirConexion();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO persona (nombre, apellido,ci,correo,contrasenia,departamento) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            mostrarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //elmiminar persona de la bd seleccionado del data grid view   
            MySqlConnection conexion = conex.AbrirConexion();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM persona WHERE id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            mostrarDatos();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ver la cuenta bancaria de la persona seleccionada en el datagrid view y mostrar en el otro data grid view
            MySqlConnection conexion = conex.AbrirConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM cuentabancaria WHERE persona_id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(), conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView2.DataSource = dt;
            conexion.Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //editar persona de la bd seleccionado del data grid view y poder cambiar el valor en el mismo data grid view
            MySqlConnection conexion = conex.AbrirConexion();
            MySqlCommand cmd = new MySqlCommand("UPDATE persona SET nombre='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "',apellido='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "',ci='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "',correo='" + dataGridView1.CurrentRow.Cells[4].Value.ToString() + "',contrasenia='" + dataGridView1.CurrentRow.Cells[5].Value.ToString() + "',departamento='" + dataGridView1.CurrentRow.Cells[6].Value.ToString() + "' WHERE id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            mostrarDatos();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            //eliminar cuenta bancaria de la persona seleccionada en el data grid view
            MySqlConnection conexion = conex.AbrirConexion();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM cuentabancaria WHERE id=" + dataGridView2.CurrentRow.Cells[0].Value.ToString(), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            mostrarDatosCuenta();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //agregar cuenta bancaria a la persona seleccionada en el data grid view
            MySqlConnection conexion = conex.AbrirConexion();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO cuentabancaria (persona_id,nroCuenta, tipo_cuenta, saldo) VALUES ('" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

            mostrarDatosCuenta();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //editar cuenta bancaria de la persona seleccionada en el data grid view
            MySqlConnection conexion = conex.AbrirConexion();
            MySqlCommand cmd = new MySqlCommand("UPDATE cuentabancaria SET nroCuenta='" + dataGridView2.CurrentRow.Cells[2].Value.ToString() + "',tipo_cuenta='" + dataGridView2.CurrentRow.Cells[3].Value.ToString() + "',saldo='" + dataGridView2.CurrentRow.Cells[4].Value.ToString() + "' WHERE id=" + dataGridView2.CurrentRow.Cells[0].Value.ToString(), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            mostrarDatosCuenta();
        }

        public void mostrarDatosCuenta()
        {
               //mostrar de la base de datos en data grid view de cuentas bancarias de la persona seleccionada
               MySqlConnection conexion = conex.AbrirConexion();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM cuentabancaria WHERE persona_id=" + dataGridView1.CurrentRow.Cells[0].Value.ToString(), conexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView2.DataSource = dt;
            conexion.Close();

            
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Gestor_de_usuarios5
{
     partial class Form1 : Form
    {
        private SqlConnection Conexion = new SqlConnection("Server=.; Database = Basededatoscrud; Integrated Security =true");
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //btn nuevo
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            TxtBx_Codigo.Clear();
            TxtBx_Edad.Clear();
            TxtBx_Nombre.Clear();
            TxtBx_Telefono.Clear();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Usuarios usuarios = new CN_Usuarios();
                usuarios.InsertarUsu(TxtBx_Nombre.Text, TxtBx_Telefono.Text, TxtBx_Edad.Text);
                MessageBox.Show("Usuario insertado correctamente.");
                // Actualizar el DataGridView
                dataGridView1.DataSource = usuarios.MostrarUsu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
 

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Usuarios usuarios = new CN_Usuarios();
                usuarios.EliminarUsu(int.Parse(TxtBx_Codigo.Text));
                MessageBox.Show("Usuario eliminado correctamente.");
                // Actualizar el DataGridView
                dataGridView1.DataSource = usuarios.MostrarUsu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Usuarios usuarios = new CN_Usuarios();
                usuarios.EditarUsu(int.Parse(TxtBx_Codigo.Text), TxtBx_Nombre.Text, TxtBx_Telefono.Text, TxtBx_Edad.Text);
                MessageBox.Show("Usuario editado correctamente.");
                // Actualizar el DataGridView
                dataGridView1.DataSource = usuarios.MostrarUsu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Ver_Click(object sender, EventArgs e)
        {
            {
                CN_Usuarios usuarios = new CN_Usuarios();
                dataGridView1.DataSource = usuarios.MostrarUsu();
            }
        }
    }
}
*/

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Capa_Negocios;

namespace Gestor_de_usuarios5
{
    partial class Form1 : Form
    {
        private SqlConnection Conexion = new SqlConnection("Server=.; Database = Basededatoscrud; Integrated Security =true");

        public Form1()
        {
            InitializeComponent();

            // Asignar eventos KeyPress a los TextBox para validar solo números
            TxtBx_Codigo.KeyPress += new KeyPressEventHandler(TextBox_KeyPress_Numeric);
            TxtBx_Edad.KeyPress += new KeyPressEventHandler(TextBox_KeyPress_Numeric);
            TxtBx_Telefono.KeyPress += new KeyPressEventHandler(TextBox_KeyPress_Numeric);
        }

        // Evento KeyPress para validar solo números
        private void TextBox_KeyPress_Numeric(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        //btn nuevo
        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            TxtBx_Codigo.Clear();
            TxtBx_Edad.Clear();
            TxtBx_Nombre.Clear();
            TxtBx_Telefono.Clear();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo "Código" esté vacío al guardar
                if (!string.IsNullOrWhiteSpace(TxtBx_Codigo.Text))
                {
                    MessageBox.Show("El campo 'Código' no debe estar lleno al guardar un nuevo usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar entradas
                if (string.IsNullOrWhiteSpace(TxtBx_Nombre.Text) || string.IsNullOrWhiteSpace(TxtBx_Telefono.Text) || string.IsNullOrWhiteSpace(TxtBx_Edad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(TxtBx_Edad.Text, out int edad))
                {
                    MessageBox.Show("La edad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CN_Usuarios usuarios = new CN_Usuarios();
                usuarios.InsertarUsu(TxtBx_Nombre.Text, TxtBx_Telefono.Text, TxtBx_Edad.Text);
                MessageBox.Show("Usuario insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar el DataGridView
                dataGridView1.DataSource = usuarios.MostrarUsu();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de base de datos: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Error de formato: " + formatEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entradas
                if (!int.TryParse(TxtBx_Codigo.Text, out int codigo))
                {
                    MessageBox.Show("El código debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CN_Usuarios usuarios = new CN_Usuarios();
                usuarios.EliminarUsu(codigo);
                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar el DataGridView
                dataGridView1.DataSource = usuarios.MostrarUsu();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de base de datos: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Error de formato: " + formatEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar entradas
                if (!int.TryParse(TxtBx_Codigo.Text, out int codigo))
                {
                    MessageBox.Show("El código debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtBx_Nombre.Text) || string.IsNullOrWhiteSpace(TxtBx_Telefono.Text) || string.IsNullOrWhiteSpace(TxtBx_Edad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(TxtBx_Edad.Text, out int edad))
                {
                    MessageBox.Show("La edad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CN_Usuarios usuarios = new CN_Usuarios();
                usuarios.EditarUsu(codigo, TxtBx_Nombre.Text, TxtBx_Telefono.Text, TxtBx_Edad.Text);
                MessageBox.Show("Usuario editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar el DataGridView
                dataGridView1.DataSource = usuarios.MostrarUsu();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de base de datos: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show("Error de formato: " + formatEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Ver_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Usuarios usuarios = new CN_Usuarios();
                dataGridView1.DataSource = usuarios.MostrarUsu();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Error de base de datos: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class MantNave : Form
    {
        public string valorparametro = "", mensaje = "";

        public MantNave()
        {
            InitializeComponent(); }

        private void MantNave_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MantNave_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario! \n Seguro que desea hacerlo?",
                                "Mensaje de SIDEPE",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bNuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos();
            Program.nuevo = true;
            Program.modificar = false;
            HabilitaBotones();
            tbNombre.Focus();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Nombre de la Nave !");
                tbNombre.Focus();
            }
            else
            if (tbCategoria.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la Categoria de la Nave!");
                tbCategoria.Focus();
            }
            else
            if (tbUbicacion.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la Ubicacion de !");
                tbUbicacion.Focus();
            }

            else
            if (tbEncargado.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Nombre del Encargado!");
                tbEncargado.Focus();
            }
            else
            if (tbTelefono.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el Telefono de la Nave!");
                tbTelefono.Focus();
            }
            else
            if (tbEmpresa.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar la Empresa de la Nave!");
                tbEmpresa.Focus();
            }
            else
            if (tbEstado.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar el estado de la Nave!");
                tbEstado.Focus();
            }
            else
            {

                if (Program.nuevo)
                {
                    mensaje = CNNave.Insertar(Program.vidNave, tbNombre.Text, tbCategoria.Text,
                    tbUbicacion.Text, Program.vidEmpleado, tbTelefono.Text, Program.vidEmpresa, tbEstado.Text);
                }
                else
                {
                    mensaje = CNNave.Actualizar(Program.vidNave, tbNombre.Text, tbCategoria.Text,
                    tbUbicacion.Text, Program.vidEmpleado, tbTelefono.Text, Program.vidEmpresa, tbEstado.Text);
                }
                MessageBox.Show(mensaje, "Mensaje de SIDEPE", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();

            }

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();
            LimpiaObjetos();
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (!tbIdNave.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Suplidor para poder Modificar sus datos!");
            }
        }

        private void MantNave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (Program.modificar)
            {
                RecuperaDatos();
                bEditar_Click(sender, e);
            }
            else
            {
                LimpiaObjetos();
                bBuscar.Focus();
                FBuscarNave fBuscarSuplidor = new FBuscarNave();
                fBuscarSuplidor.ShowDialog();
                if (Program.modificar)
                {
                    RecuperaDatos();
                    bEditar_Click(sender, e);
                }
                else
                {
                    LimpiaObjetos();
                    bBuscar.Focus();
                }
            }
        }
            public void RecuperaDatos()
            {
                string vparametro = Program.vidNave.ToString();
                CNNave cNNave = new CNNave();
                DataTable dt = new DataTable();
                dt = cNNave.ObtenerNave(vparametro);

                foreach (DataRow row in dt.Rows)
                {
                    tbIdNave.Text = row["IdNave"].ToString();
                    tbNombre.Text = row["Nombre"].ToString();
                    tbCategoria.Text = row["Categoria"].ToString();
                    tbUbicacion.Text = row["Ubicacion"].ToString();
                    tbEncargado.Text = row["Encargado"].ToString();
                    tbTelefono.Text = row["Telefono"].ToString();
                    tbEmpresa.Text = row["Empresa"].ToString();
                    tbEstado.Text = row["Estado"].ToString();
                }
            }
        

        public void LimpiaObjetos()
        {
            tbIdNave.Clear();
            tbNombre.Clear();
            tbCategoria.Clear();
            tbUbicacion.Clear();
            tbEncargado.Clear();
            tbTelefono.Clear();
            tbEmpresa.Clear();
            tbEstado.Clear();
        }
        private void HabilitaControles(bool valor)
        {
            tbIdNave.ReadOnly = true;
            tbNombre.Enabled = valor;
            tbCategoria.Enabled = valor;
            tbUbicacion.Enabled = valor;
            tbEncargado.Enabled = valor;
            tbTelefono.Enabled = valor;
            tbEmpresa.Enabled = valor;
            tbEstado.Enabled = valor;


            //if (Program.nuevo)
              //  cbEstado.SelectedIndex = 0;
        }

        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true);
                bNuevo.Enabled = false;
                bGuardar.Enabled = true;
                bEditar.Enabled = false;
                bBuscar.Enabled = false;
                bCancelar.Enabled = true;
            }
            else
            {
                HabilitaControles(false);
                bNuevo.Enabled = true;
                bGuardar.Enabled = false;
                bEditar.Enabled = false;
                bBuscar.Enabled = true;
                bCancelar.Enabled = false;

            }
        }
    }
}



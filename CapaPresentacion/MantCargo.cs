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
    public partial class MantCargo : Form
    {
        public string valorparametro = "", mensaje = "";
        public MantCargo()
        {
            InitializeComponent();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MantCargo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
                               "Mensaje de SIDEPE",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        public void LimpiaObjetos()
        {
            tbNombre.Clear();
            tbFunciones.Clear();
            cbEstado.SelectedItem = 0;
        }
        private void HabilitaControles(bool valor)
        {
            tbNombre.Enabled = valor;
            tbFunciones.Enabled = valor;
            cbEstado.Enabled = valor;
            if (Program.nuevo)
                cbEstado.SelectedIndex = 0;
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
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbNombre.Focus();
            }
            else
            
            if (tbFunciones.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar las Funciones del Cargo!");
                tbFunciones.Focus();
            }
            else
            if (cbEstado.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar el estado del Cargo!");
                cbEstado.Focus();
            }
            else
            {
                if (Program.nuevo)
               
                {
                    mensaje= CNCargo.Insertar(tbNombre.Text, tbFunciones.Text, cbEstado.Text);
                }
                else
                {
                    mensaje = CNCargo.Actualizar(Program.vidCargo, tbNombre.Text, tbFunciones.Text, cbEstado.Text);
                }
                MessageBox.Show(mensaje, "Mensage de SIDEPE", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones();
                LimpiaObjetos();
            }
        }

        private void MantCargo_Load(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones();

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

            if (!tbIDCargo.Equals(""))
            {
                Program.modificar = true;
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Cargo para poder Modificar sus datos!");
            }
        }

        private void MantCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
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
            }
            FBuscarCargo fBuscarCargo = new FBuscarCargo();
            fBuscarCargo.ShowDialog();
          

        }
        public void RecuperaDatos()
        {
            string vparametro = Program.vidCargo.ToString();
            CNCargo cNCargo = new CNCargo();
            DataTable dt = new DataTable();
            dt = cNCargo.CargoConsultar(vparametro);

            foreach (DataRow row in dt.Rows)
            {
                tbIDCargo.Text = row["IdCargo"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbFunciones.Text = row["Funciones"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }
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
           /* foreach (DataRow row in dt.Rows)
            {
                tbIDCargo.Text = row["IDCargo"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbFunciones.Text = row["Funciones"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }*/
        }
    }
}

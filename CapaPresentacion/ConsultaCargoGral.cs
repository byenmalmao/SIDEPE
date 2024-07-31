using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ConsultaCargoGral : Form
    {
        public int vidCargo = 0, vtieneparametro = 0, indice = 1;
        public string valorparametro = "", mensaje = "";

        private void ConsultaCargoGral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hará salir del formulario! \n Seguro que desea hacerlo?",
                     "Mensaje de SIDDEPE",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

        private void ConsultaCargoGral_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) 
                indice = DGVDatos.CurrentRow.Index;
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bConsultar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty) 
            {
                vtieneparametro = 1;  
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
            }
            else 
            {
                vtieneparametro = 0; 
                valorparametro = ""; 
            }
            MostrarDatos(); 
            tbBuscar.Focus();
        }

        private void bPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1) 
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }

        private void bAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0) 
            {
                indice = indice - 1;
                DGVDatos.CurrentCell =
                DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) 
            {
                indice++;
                DGVDatos.CurrentCell =
               DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) 
            {
                indice = DGVDatos.Rows.Count - 1; 
                DGVDatos.CurrentCell =
               DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        CNCargo objCargo = new CNCargo();

        public ConsultaCargoGral()
        {
            InitializeComponent();
        }
        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (objCargo.ObtenerCargo(valorparametro) != null)
            {
                DGVDatos.DataSource = objCargo.ObtenerCargo(valorparametro);
                DGVDatos.Columns[0].Width = 80; //IDCargo
                DGVDatos.Columns[1].Width = 200; //Nombre
                DGVDatos.Columns[2].Width = 225; //Funciones
                DGVDatos.Columns[8].Width = 90; //Estado
            }
            else 
            {
                MessageBox.Show("No se retornó ningún valor!");
            }
            DGVDatos.Refresh(); 
            lCantCargo.Text = Convert.ToString(DGVDatos.RowCount); 
            if (DGVDatos.RowCount <= 0) //
            {
                MessageBox.Show("Ningún dato que mostrar!"); 
            }
        }



    }
}

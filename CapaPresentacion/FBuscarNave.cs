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
    public partial class FBuscarNave : Form
    {
        public int indice = 0, vtieneparametro = 0;
        public string valorparametro = "";

        CNNave cNNave = new CNNave();

        public FBuscarNave()
        {
            InitializeComponent();
        }

        private void FBuscarNave_Load(object sender, EventArgs e)
        {
            valorparametro = "";
            vtieneparametro = 0;
            Program.vidCargo = 0;
            MostrarDatos();
            tbBuscar.Focus(); valorparametro = "";
            vtieneparametro = 0;
            Program.vidCargo = 0;
            MostrarDatos();
            tbBuscar.Focus();
        }

        private void FBuscarNave_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)                
                indice = DGVDatos.CurrentRow.Index;   
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Program.modificar = false;
            Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null)  
            {
                Program.modificar = true;
                Program.vidNave = Convert.ToInt32(DGVDatos.CurrentRow.Cells[0].Value);
            }
            Close();
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
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void bSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) 
            {
                indice++;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void bUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1)  
            {
                indice = DGVDatos.Rows.Count - 1;       
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void DGVDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(e.RowIndex > -1))
            {
                return;
            }
            bAceptar_Click(sender, e);  
        }

        private void bBuscarDato_Click(object sender, EventArgs e)
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
        }

        private void FBuscarNave_FormClosing(object sender, FormClosingEventArgs e)
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

        private void MostrarDatos()
        {
            valorparametro = tbBuscar.Text.Trim();
            if (cNNave.ObtenerNave(valorparametro) != null)
            {
                DGVDatos.DataSource = cNNave.ObtenerNave(valorparametro);
                DGVDatos.Columns[0].Width = 80; //IDNave
                DGVDatos.Columns[1].Width = 200; //Nombre
                DGVDatos.Columns[2].Width = 225; //Categoria
                DGVDatos.Columns[3].Width = 100;  //Ubicacion 
                DGVDatos.Columns[4].Width = 125;  //Encargado
                DGVDatos.Columns[5].Width = 125;  //telefono
                DGVDatos.Columns[6].Width = 150;  //Empresa 
                DGVDatos.Columns[7].Width = 90;  //Estado
            }
            else
                MessageBox.Show("No se retornó ningún valor!");

            DGVDatos.Refresh();

        }
    }
}

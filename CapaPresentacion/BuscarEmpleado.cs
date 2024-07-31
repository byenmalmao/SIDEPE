using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class BuscarEmpleado : Form
    {
        public BuscarEmpleado()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void BuscarEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSIDEPEDataSet.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.dBSIDEPEDataSet.Empleado);

        }
    }
}

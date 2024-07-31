using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//para poder utilizar las instrucciones de SQL
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//Para acceder a la capa de negocio
using CapaNegocio;


namespace CapaPresentacion
{ 


    public partial class MantEmpleado : Form
    {

        public string valorparametro = "", mensaje = "";

        public void LimpiaObjetos()
        {
            tb_idempleado.Clear();
            tbNombre.Clear(); //Para limpiar TextBox.
            tbCedula.Clear();
            tbGenero.Clear();
            tbDireccion.Clear();
            tbTelefono.Clear();
            tbDireccion.Clear();
            tbCondicionMedica.Clear();
            tbNumeroEmergencia.Clear();
            tbtipodesangre.Clear();
            tbArs.Clear();
            tbNumeroArs.Clear();
            cbCargo.SelectedItem = 0;
            cbNave.SelectedItem = 0;
             //Establece el valor por defecto del Combobox
        } //Fin del método LimpiaObjetos

        private void HabilitaControles(bool valor)
        {

            tb_idempleado.ReadOnly = true;
            tbNombre.Enabled = valor; //Para limpiar TextBox.
            tbCedula.Enabled = valor;
            tbGenero.Enabled = valor;
            tbTelefono.Enabled = valor;
            tbCondicionMedica.Enabled = valor;
            tbDireccion.Enabled = valor;
            tbNumeroEmergencia.Enabled = valor;
            tbtipodesangre.Enabled = valor;
            tbArs.Enabled = valor;
            tbNumeroArs.Enabled = valor;
            cbCargo.SelectedItem = 0;
            cbNave.SelectedItem = 0;

            if(Program.nuevo)
            {
                cbCargo.SelectedIndex = 0; // Establece el valor por defecto
                cbNave.SelectedIndex = 0;  // Establece el valor por defecto
            }
            //else
            //{
                //cbCargo.SelectedIndex = -1; // Deselecciona cualquier elemento en cbCargo
                //cbNave.SelectedIndex = -1;  // Deselecciona cualquier elemento en cbNave
            //}

        }
        private void HabilitaBotones()
        {
            if (Program.nuevo || Program.modificar)
            {
                HabilitaControles(true); //Llamada al método para habilitar los objetos
                btNuevo.Enabled = false;
                btGuardar.Enabled = true;
                btEditar.Enabled = false;
                btBuscar.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                HabilitaControles(true); //Llamada al método para habilitar los objetos
                btNuevo.Enabled = true;
                btGuardar.Enabled = false;
                btEditar.Enabled = true;
                btBuscar.Enabled = false;
                button1.Enabled = true;
            }
        }

        public MantEmpleado()
        {
            InitializeComponent();
        }

        private void MantEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSIDEPEDataSet.Empleado' table. You can move, or remove it, as needed.
            this.empleadoTableAdapter.Fill(this.dBSIDEPEDataSet.Empleado);

            string vparametro = "";  //variable que espera el método ObtenerCargo de la capa de negocio

            CNCargo objCargo = new CNCargo();  //instanciamos un objeto de la clase CNCargo

            cbCargo.DataSource = objCargo.ObtenerCargo(vparametro);

            cbCargo.DisplayMember = "Cargo";  //Indicamos el campo cuyo contenido se mostrará

            cbCargo.ValueMember = "IdCargo"; //Indicamos el campo clave que es el valor necesitado

            cbCargo.SelectedIndex = 0;   //el primer dato del combobox será el mostrado por defecto


            CNNave objNave = new CNNave();  //instanciamos un objeto de la clase CNCargo

            cbNave.DataSource = objNave.ObtenerNave(vparametro);

            cbNave.DisplayMember = "Nave";  //Indicamos el campo cuyo contenido se mostrará

            cbNave.ValueMember = "IdNave"; //Indicamos el campo clave que es el valor necesitado

            cbNave.SelectedIndex = 0;

            Program.nuevo = false; //Valores de las variables globales nuevo y modificar
            Program.modificar = false;
            HabilitaBotones();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MantEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto le hara salir del formulario! \n Seguro que desea hacerlo?",
                                "Mensaje de SIGEMP",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void tbNumeroEmergencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTipoSangre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            LimpiaObjetos(); //LLama al método LimpiaObjetos para prepararlos para la nueva entrada
            Program.nuevo = true; //Se especifica que se agregará un nuevo registro
            Program.modificar = false;
            HabilitaBotones(); //Se habilitan solo aquellos botones que sean necesarios
            tbNombre.Focus(); //Coloca el cursor en el TextBox indicado

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbNombre.Focus();
            }
            else
            if (tbCedula.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el la ceddula del Empleado!");
                tbCedula.Focus();
            }
            else
            if (tbGenero.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbGenero.Focus();
            }
            else
            if (tbTelefono.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbTelefono.Focus();
            }
            else
                if (tbNumeroEmergencia.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbNumeroEmergencia.Focus();
            }
            else
            if (tbCondicionMedica.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbCondicionMedica.Focus(); 
            }
            else
            if (tbtipodesangre.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbtipodesangre.Focus();
            }
            else
            if (tbArs.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbArs.Focus();
            }
            else
            if (tbNumeroArs.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbNumeroArs.Focus();
            }
            else
            
            if (tbDireccion.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                tbDireccion.Focus();
            }
            else
            if (cbCargo.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                cbCargo.Focus();
            }
            else
            if (cbNave.Text == String.Empty)
            {
                MessageBox.Show("Debe indicar el nombre del Cargo!");
                cbNave.Focus();
            }
            else
            {
                if (Program.nuevo)
                {
                    try
                    {
                        mensaje = CNEmpleado.Insertar(Program.vidEmpleado, tbNombre.Text, tbCedula.Text, tbGenero.Text, tbTelefono.Text, tbNumeroEmergencia.Text, tbtipodesangre.Text, tbArs.Text, tbNumeroArs.Text, tbCondicionMedica.Text, tbDireccion.Text, cbCargo.Text, cbNave.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                else
                {
                    mensaje = CNEmpleado.Actualizar(Program.vidEmpleado, tbNombre.Text, tbCedula.Text, tbGenero.Text, tbTelefono.Text, tbNumeroEmergencia.Text, tbtipodesangre.Text, tbArs.Text, tbNumeroArs.Text, tbCondicionMedica.Text, tbDireccion.Text, cbCargo.Text, cbNave.Text);

                }
                MessageBox.Show(mensaje, "Mensage de SIDEPE", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                Program.nuevo = false;
                Program.modificar = false;
                HabilitaBotones(); //Habilita los objetos y botones correspondientes
                LimpiaObjetos(); 


            }





        }

        private void tbtipodesangre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.nuevo = false;
            Program.modificar = false;
            HabilitaBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjeto
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Suplidor no se puede modificar
            if (!tb_idempleado.Equals(""))
            {
                Program.modificar = true; //el formulaario se prepara para modificar datos
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Empleado para poder Modificar sus datos!");
            }

        }

        private void MantEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (Program.modificar)
            {
                RecuperaDatos(); //Llamo al método para recuperar el Depto seleccionado
                btEditar_Click(sender, e); //Llamo al método editar
            }
            else
            {
                LimpiaObjetos(); //Llama al método LimpiaObjetos
                btBuscar.Focus();
            }

        } //Fin del método Click del botón Buscar

        public void RecuperaDatos()
        {
            string miparametro = Program.vidEmpleado.ToString();
            CNEmpleado cNEmpleado = new CNEmpleado();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = cNEmpleado.EmpleadoConsultar(miparametro); //Llenamos el DataTable

            foreach (DataRow row in dt.Rows)
            {
                tb_idempleado.Text = row["IdEmpleado"].ToString();
                tbNombre.Text = row["Nombre_Completo"].ToString();
                tbCedula.Text = row["Cedula"].ToString();
                tbGenero.Text = row["Genero"].ToString();
                tbTelefono.Text = row["Telefono"].ToString();
                tbNumeroEmergencia.Text = row["Contacto_de_emergencia"].ToString();
                tbArs.Text = row["Nombre_Ars"].ToString();
                tbtipodesangre.Text = row["Tipo_de_sangre"].ToString();
                tbNumeroArs.Text = row["Numero_Afiliado_ARS"].ToString();
                tbCondicionMedica.Text = row["Condicion_Medica"].ToString();
                tbDireccion.Text = row["Direccion"].ToString();
                cbCargo.Text = row["Cargo"].ToString();
                cbNave.Text = row["Nave"].ToString();
                


            }


        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cbNave_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


using System;

namespace CapaPresentacion
{
    partial class MantEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactodeemergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodesangreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroAfiliadoARSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionesmedicasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBSIDEPEDataSet = new CapaPresentacion.DBSIDEPEDataSet();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tb_idempleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbtipodesangre = new System.Windows.Forms.TextBox();
            this.cbNave = new System.Windows.Forms.ComboBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCondicionMedica = new System.Windows.Forms.TextBox();
            this.tbNumeroArs = new System.Windows.Forms.TextBox();
            this.tbArs = new System.Windows.Forms.TextBox();
            this.tbNumeroEmergencia = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbGenero = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.empleadoTableAdapter = new CapaPresentacion.DBSIDEPEDataSetTableAdapters.EmpleadoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSIDEPEDataSet)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 685);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Location = new System.Drawing.Point(83, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(952, 107);
            this.panel7.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleadoDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.contactodeemergenciaDataGridViewTextBoxColumn,
            this.tipodesangreDataGridViewTextBoxColumn,
            this.nombreArsDataGridViewTextBoxColumn,
            this.numeroAfiliadoARSDataGridViewTextBoxColumn,
            this.condicionesmedicasDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.naveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empleadoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(952, 107);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idEmpleadoDataGridViewTextBoxColumn
            // 
            this.idEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.HeaderText = "IdEmpleado";
            this.idEmpleadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idEmpleadoDataGridViewTextBoxColumn.Name = "idEmpleadoDataGridViewTextBoxColumn";
            this.idEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEmpleadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre_Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoDataGridViewTextBoxColumn.Width = 150;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaDataGridViewTextBoxColumn.Width = 150;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactodeemergenciaDataGridViewTextBoxColumn
            // 
            this.contactodeemergenciaDataGridViewTextBoxColumn.DataPropertyName = "Contacto_de_emergencia";
            this.contactodeemergenciaDataGridViewTextBoxColumn.HeaderText = "Contacto_de_emergencia";
            this.contactodeemergenciaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactodeemergenciaDataGridViewTextBoxColumn.Name = "contactodeemergenciaDataGridViewTextBoxColumn";
            this.contactodeemergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactodeemergenciaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipodesangreDataGridViewTextBoxColumn
            // 
            this.tipodesangreDataGridViewTextBoxColumn.DataPropertyName = "Tipo_de_sangre";
            this.tipodesangreDataGridViewTextBoxColumn.HeaderText = "Tipo_de_sangre";
            this.tipodesangreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipodesangreDataGridViewTextBoxColumn.Name = "tipodesangreDataGridViewTextBoxColumn";
            this.tipodesangreDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipodesangreDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreArsDataGridViewTextBoxColumn
            // 
            this.nombreArsDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Ars";
            this.nombreArsDataGridViewTextBoxColumn.HeaderText = "Nombre_Ars";
            this.nombreArsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreArsDataGridViewTextBoxColumn.Name = "nombreArsDataGridViewTextBoxColumn";
            this.nombreArsDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreArsDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroAfiliadoARSDataGridViewTextBoxColumn
            // 
            this.numeroAfiliadoARSDataGridViewTextBoxColumn.DataPropertyName = "Numero_Afiliado_ARS";
            this.numeroAfiliadoARSDataGridViewTextBoxColumn.HeaderText = "Numero_Afiliado_ARS";
            this.numeroAfiliadoARSDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeroAfiliadoARSDataGridViewTextBoxColumn.Name = "numeroAfiliadoARSDataGridViewTextBoxColumn";
            this.numeroAfiliadoARSDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroAfiliadoARSDataGridViewTextBoxColumn.Width = 150;
            // 
            // condicionesmedicasDataGridViewTextBoxColumn
            // 
            this.condicionesmedicasDataGridViewTextBoxColumn.DataPropertyName = "Condiciones_medicas";
            this.condicionesmedicasDataGridViewTextBoxColumn.HeaderText = "Condiciones_medicas";
            this.condicionesmedicasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.condicionesmedicasDataGridViewTextBoxColumn.Name = "condicionesmedicasDataGridViewTextBoxColumn";
            this.condicionesmedicasDataGridViewTextBoxColumn.ReadOnly = true;
            this.condicionesmedicasDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 150;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cargoDataGridViewTextBoxColumn.Width = 150;
            // 
            // naveDataGridViewTextBoxColumn
            // 
            this.naveDataGridViewTextBoxColumn.DataPropertyName = "Nave";
            this.naveDataGridViewTextBoxColumn.HeaderText = "Nave";
            this.naveDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.naveDataGridViewTextBoxColumn.Name = "naveDataGridViewTextBoxColumn";
            this.naveDataGridViewTextBoxColumn.ReadOnly = true;
            this.naveDataGridViewTextBoxColumn.Width = 150;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.dBSIDEPEDataSet;
            // 
            // dBSIDEPEDataSet
            // 
            this.dBSIDEPEDataSet.DataSetName = "DBSIDEPEDataSet";
            this.dBSIDEPEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btBuscar);
            this.panel6.Controls.Add(this.tb_idempleado);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(83, 75);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(453, 55);
            this.panel6.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscar.BackgroundImage")));
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscar.Location = new System.Drawing.Point(389, 6);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(47, 40);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // tb_idempleado
            // 
            this.tb_idempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_idempleado.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idempleado.Location = new System.Drawing.Point(76, 13);
            this.tb_idempleado.Name = "tb_idempleado";
            this.tb_idempleado.Size = new System.Drawing.Size(281, 30);
            this.tb_idempleado.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(18, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 26);
            this.label11.TabIndex = 9;
            this.label11.Text = "ID: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.tbDireccion);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.tbtipodesangre);
            this.panel5.Controls.Add(this.cbNave);
            this.panel5.Controls.Add(this.cbCargo);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.tbCondicionMedica);
            this.panel5.Controls.Add(this.tbNumeroArs);
            this.panel5.Controls.Add(this.tbArs);
            this.panel5.Controls.Add(this.tbNumeroEmergencia);
            this.panel5.Controls.Add(this.tbTelefono);
            this.panel5.Controls.Add(this.tbGenero);
            this.panel5.Controls.Add(this.tbCedula);
            this.panel5.Controls.Add(this.tbNombre);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(83, 308);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(952, 349);
            this.panel5.TabIndex = 1;
            // 
            // tbDireccion
            // 
            this.tbDireccion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbDireccion.Location = new System.Drawing.Point(682, 262);
            this.tbDireccion.Multiline = true;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(199, 44);
            this.tbDireccion.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(533, 262);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 22);
            this.label14.TabIndex = 25;
            this.label14.Text = "Direccion:";
            // 
            // tbtipodesangre
            // 
            this.tbtipodesangre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbtipodesangre.Location = new System.Drawing.Point(681, 75);
            this.tbtipodesangre.Name = "tbtipodesangre";
            this.tbtipodesangre.Size = new System.Drawing.Size(199, 26);
            this.tbtipodesangre.TabIndex = 24;
            this.tbtipodesangre.TextChanged += new System.EventHandler(this.tbtipodesangre_TextChanged);
            // 
            // cbNave
            // 
            this.cbNave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbNave.FormattingEnabled = true;
            this.cbNave.Location = new System.Drawing.Point(183, 284);
            this.cbNave.Name = "cbNave";
            this.cbNave.Size = new System.Drawing.Size(199, 28);
            this.cbNave.TabIndex = 23;
            this.cbNave.SelectedIndexChanged += new System.EventHandler(this.cbNave_SelectedIndexChanged);
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(183, 235);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(199, 28);
            this.cbCargo.TabIndex = 22;
            this.cbCargo.SelectedIndexChanged += new System.EventHandler(this.cbCargo_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(100, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 22);
            this.label13.TabIndex = 20;
            this.label13.Text = "Nave: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(94, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 22);
            this.label12.TabIndex = 18;
            this.label12.Text = "Cargo: ";
            // 
            // tbCondicionMedica
            // 
            this.tbCondicionMedica.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCondicionMedica.Location = new System.Drawing.Point(681, 203);
            this.tbCondicionMedica.Multiline = true;
            this.tbCondicionMedica.Name = "tbCondicionMedica";
            this.tbCondicionMedica.Size = new System.Drawing.Size(199, 44);
            this.tbCondicionMedica.TabIndex = 17;
            // 
            // tbNumeroArs
            // 
            this.tbNumeroArs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNumeroArs.Location = new System.Drawing.Point(681, 156);
            this.tbNumeroArs.Name = "tbNumeroArs";
            this.tbNumeroArs.Size = new System.Drawing.Size(199, 26);
            this.tbNumeroArs.TabIndex = 16;
            // 
            // tbArs
            // 
            this.tbArs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbArs.Location = new System.Drawing.Point(681, 122);
            this.tbArs.Name = "tbArs";
            this.tbArs.Size = new System.Drawing.Size(199, 26);
            this.tbArs.TabIndex = 15;
            // 
            // tbNumeroEmergencia
            // 
            this.tbNumeroEmergencia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNumeroEmergencia.Location = new System.Drawing.Point(681, 23);
            this.tbNumeroEmergencia.Name = "tbNumeroEmergencia";
            this.tbNumeroEmergencia.Size = new System.Drawing.Size(199, 26);
            this.tbNumeroEmergencia.TabIndex = 13;
            this.tbNumeroEmergencia.TextChanged += new System.EventHandler(this.tbNumeroEmergencia_TextChanged);
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbTelefono.Location = new System.Drawing.Point(183, 178);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(199, 26);
            this.tbTelefono.TabIndex = 12;
            // 
            // tbGenero
            // 
            this.tbGenero.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbGenero.Location = new System.Drawing.Point(183, 124);
            this.tbGenero.Name = "tbGenero";
            this.tbGenero.Size = new System.Drawing.Size(199, 26);
            this.tbGenero.TabIndex = 11;
            // 
            // tbCedula
            // 
            this.tbCedula.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCedula.Location = new System.Drawing.Point(183, 71);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(199, 26);
            this.tbCedula.TabIndex = 10;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbNombre.Location = new System.Drawing.Point(183, 23);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(199, 26);
            this.tbNombre.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(530, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 44);
            this.label10.TabIndex = 8;
            this.label10.Text = "Condicion\r\n    Medica: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(514, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Numero Ars: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(578, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ars: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(514, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tipo Sangre: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(517, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 44);
            this.label6.TabIndex = 4;
            this.label6.Text = "     Numero   \r\nEmergencia: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(86, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cedula: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(84, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Genero: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(72, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefono: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(78, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.bSalir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1179, 51);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(451, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mantenimiento Empleado";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(51, 51);
            this.panel4.TabIndex = 0;
            // 
            // bSalir
            // 
            this.bSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bSalir.BackgroundImage")));
            this.bSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.bSalir.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.Color.Transparent;
            this.bSalir.Location = new System.Drawing.Point(1126, 0);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(53, 51);
            this.bSalir.TabIndex = 3;
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btNuevo);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btEditar);
            this.panel2.Controls.Add(this.btEliminar);
            this.panel2.Controls.Add(this.btGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 691);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 77);
            this.panel2.TabIndex = 1;
            // 
            // btNuevo
            // 
            this.btNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.ForeColor = System.Drawing.Color.White;
            this.btNuevo.Location = new System.Drawing.Point(1019, 14);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(114, 51);
            this.btNuevo.TabIndex = 6;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(328, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Teal;
            this.btEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(189, 14);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(110, 51);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Location = new System.Drawing.Point(879, 14);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(110, 51);
            this.btEliminar.TabIndex = 1;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.Green;
            this.btGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(41, 14);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(114, 51);
            this.btGuardar.TabIndex = 0;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // MantEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantEmpleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.MantEmpleado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MantEmpleado_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBSIDEPEDataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

     /*   private void btBuscar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBSIDEPEDataSet dBSIDEPEDataSet;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private DBSIDEPEDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactodeemergenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodesangreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroAfiliadoARSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionesmedicasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naveDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tb_idempleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox tbCondicionMedica;
        private System.Windows.Forms.TextBox tbNumeroArs;
        private System.Windows.Forms.TextBox tbArs;
        private System.Windows.Forms.TextBox tbNumeroEmergencia;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbGenero;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.ComboBox cbNave;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbtipodesangre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label14;
    }
}
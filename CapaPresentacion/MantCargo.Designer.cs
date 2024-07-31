
namespace CapaPresentacion
{
    partial class MantCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantCargo));
            this.pTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pBotones = new System.Windows.Forms.Panel();
            this.bSalir = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.tbFunciones = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tbIDCargo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.pTitulo.SuspendLayout();
            this.pBotones.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(937, 35);
            this.pTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO DE CARGO";
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.MidnightBlue;
            this.pBotones.Controls.Add(this.bSalir);
            this.pBotones.Controls.Add(this.bGuardar);
            this.pBotones.Controls.Add(this.bCancelar);
            this.pBotones.Controls.Add(this.bEditar);
            this.pBotones.Controls.Add(this.bNuevo);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotones.Location = new System.Drawing.Point(0, 413);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(937, 35);
            this.pBotones.TabIndex = 1;
            // 
            // bSalir
            // 
            this.bSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSalir.Location = new System.Drawing.Point(803, 9);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 3;
            this.bSalir.Text = "&Salir";
            this.toolTip5.SetToolTip(this.bSalir, "Salir del formulario");
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bGuardar.Location = new System.Drawing.Point(139, 9);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 3;
            this.bGuardar.Text = "&Guardar";
            this.toolTip2.SetToolTip(this.bGuardar, "Guardar Cambios");
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancelar.Location = new System.Drawing.Point(678, 9);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "&Cancelar";
            this.toolTip4.SetToolTip(this.bCancelar, "Cancelar Cambios");
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bEditar
            // 
            this.bEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEditar.Location = new System.Drawing.Point(256, 9);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(75, 23);
            this.bEditar.TabIndex = 3;
            this.bEditar.Text = "&Editar";
            this.toolTip3.SetToolTip(this.bEditar, "Editar Cargo");
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bNuevo.Location = new System.Drawing.Point(24, 9);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 0;
            this.bNuevo.Text = "&Nuevo";
            this.toolTip1.SetToolTip(this.bNuevo, "Nuevo Cargo");
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.cbEstado);
            this.panel3.Controls.Add(this.tbFunciones);
            this.panel3.Controls.Add(this.tbNombre);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(24, 52);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 193);
            this.panel3.TabIndex = 2;
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(171, 122);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(244, 21);
            this.cbEstado.TabIndex = 18;
            // 
            // tbFunciones
            // 
            this.tbFunciones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbFunciones.Font = new System.Drawing.Font("Arial", 10F);
            this.tbFunciones.Location = new System.Drawing.Point(171, 74);
            this.tbFunciones.Margin = new System.Windows.Forms.Padding(2);
            this.tbFunciones.Name = "tbFunciones";
            this.tbFunciones.Size = new System.Drawing.Size(244, 23);
            this.tbFunciones.TabIndex = 17;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.tbNombre.Location = new System.Drawing.Point(171, 36);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(244, 23);
            this.tbNombre.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Funciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(431, 27);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(2, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Cargo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
           // this.panel1.BackgroundImage = global::CapaPresentacion.Properties.Resources.xlzon3us;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel1.Location = new System.Drawing.Point(8, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 27);
            this.panel1.TabIndex = 3;
            // 
            // bBuscar
            // 
            this.bBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bBuscar.BackgroundImage")));
            this.bBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBuscar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bBuscar.Location = new System.Drawing.Point(803, 62);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(41, 33);
            this.bBuscar.TabIndex = 13;
            this.toolTip6.SetToolTip(this.bBuscar, "Buscar Cargo");
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // tbIDCargo
            // 
            this.tbIDCargo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbIDCargo.Font = new System.Drawing.Font("Arial", 10F);
            this.tbIDCargo.Location = new System.Drawing.Point(632, 62);
            this.tbIDCargo.Margin = new System.Windows.Forms.Padding(2);
            this.tbIDCargo.Name = "tbIDCargo";
            this.tbIDCargo.Size = new System.Drawing.Size(150, 23);
            this.tbIDCargo.TabIndex = 17;
            // 
            // MantCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(937, 448);
            this.Controls.Add(this.tbIDCargo);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantCargo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantCargo_FormClosing);
            this.Load += new System.EventHandler(this.MantCargo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MantCargo_KeyDown);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pBotones.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbFunciones;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox tbIDCargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}
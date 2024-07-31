
namespace CapaPresentacion
{
    partial class FBuscarCargo
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bBuscarDato = new System.Windows.Forms.Button();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pInformacion = new System.Windows.Forms.Panel();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pBotones = new System.Windows.Forms.Panel();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.pTitulo.SuspendLayout();
            this.pInformacion.SuspendLayout();
            this.pBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.GhostWhite;
            this.toolTip1.IsBalloon = true;
            // 
            // bBuscarDato
            // 
            this.bBuscarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarDato.Location = new System.Drawing.Point(287, 38);
            this.bBuscarDato.Name = "bBuscarDato";
            this.bBuscarDato.Size = new System.Drawing.Size(99, 23);
            this.bBuscarDato.TabIndex = 2;
            this.bBuscarDato.Text = "Buscar Dato";
            this.toolTip1.SetToolTip(this.bBuscarDato, "Buscar el dato indicado");
            this.bBuscarDato.UseVisualStyleBackColor = true;
            this.bBuscarDato.Click += new System.EventHandler(this.bBuscarDato_Click);
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(800, 100);
            this.pTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSQUEDA DE CARGOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pInformacion
            // 
            this.pInformacion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pInformacion.Controls.Add(this.bBuscarDato);
            this.pInformacion.Controls.Add(this.tbBuscar);
            this.pInformacion.Controls.Add(this.label2);
            this.pInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInformacion.Location = new System.Drawing.Point(0, 100);
            this.pInformacion.Name = "pInformacion";
            this.pInformacion.Size = new System.Drawing.Size(800, 100);
            this.pInformacion.TabIndex = 1;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(165, 38);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DIGITE EL DATO A BUSCAR";
            // 
            // pBotones
            // 
            this.pBotones.BackColor = System.Drawing.Color.MidnightBlue;
            this.pBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBotones.Controls.Add(this.bAceptar);
            this.pBotones.Controls.Add(this.bCancelar);
            this.pBotones.Controls.Add(this.bUltimo);
            this.pBotones.Controls.Add(this.bSiguiente);
            this.pBotones.Controls.Add(this.bAnterior);
            this.pBotones.Controls.Add(this.bPrimero);
            this.pBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBotones.Location = new System.Drawing.Point(0, 398);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(800, 52);
            this.pBotones.TabIndex = 2;
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(699, 15);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 6;
            this.bAceptar.Text = "Acep&tar";
            this.toolTip7.SetToolTip(this.bAceptar, "Aceptar el dato seleccionado");
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(605, 15);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "&Cancelar";
            this.toolTip6.SetToolTip(this.bCancelar, "Cancelar la busqueda y salir");
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bUltimo
            // 
            this.bUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUltimo.Location = new System.Drawing.Point(324, 15);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(75, 23);
            this.bUltimo.TabIndex = 4;
            this.bUltimo.Text = "&Ultimo";
            this.toolTip5.SetToolTip(this.bUltimo, "Ir al ultimo registro");
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSiguiente.Location = new System.Drawing.Point(219, 15);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(75, 23);
            this.bSiguiente.TabIndex = 4;
            this.bSiguiente.Text = "&Siguiente";
            this.toolTip4.SetToolTip(this.bSiguiente, "Ir al registro siguiente");
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnterior.Location = new System.Drawing.Point(115, 15);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(75, 23);
            this.bAnterior.TabIndex = 4;
            this.bAnterior.Text = "&Anterior";
            this.toolTip3.SetToolTip(this.bAnterior, "Ir al registro anterior");
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrimero.Location = new System.Drawing.Point(13, 15);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(75, 23);
            this.bPrimero.TabIndex = 0;
            this.bPrimero.Text = "&Primero";
            this.toolTip2.SetToolTip(this.bPrimero, "Ir al primer registro");
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // DGVDatos
            // 
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDatos.Location = new System.Drawing.Point(0, 200);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(800, 198);
            this.DGVDatos.TabIndex = 3;
            this.DGVDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellContentClick);
            this.DGVDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellDoubleClick);
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // FBuscarCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.pInformacion);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBuscarCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FBuscarCargo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBuscarCargo_FormClosing);
            this.Load += new System.EventHandler(this.FBuscarCargo_Load);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pInformacion.ResumeLayout(false);
            this.pInformacion.PerformLayout();
            this.pBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Panel pInformacion;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Button bBuscarDato;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}
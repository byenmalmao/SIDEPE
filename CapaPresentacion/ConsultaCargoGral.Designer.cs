
namespace CapaPresentacion
{
    partial class ConsultaCargoGral
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
            this.pTitulo = new System.Windows.Forms.Panel();
            this.pInformacion = new System.Windows.Forms.Panel();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.bConsultar = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lCantCargo = new System.Windows.Forms.Label();
            this.bPrimero = new System.Windows.Forms.Button();
            this.pbotones = new System.Windows.Forms.Panel();
            this.bAnterior = new System.Windows.Forms.Button();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.bSiguiente = new System.Windows.Forms.Button();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.bUltimo = new System.Windows.Forms.Button();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.bImprimir = new System.Windows.Forms.Button();
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.bSalir = new System.Windows.Forms.Button();
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.pTitulo.SuspendLayout();
            this.pInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.pbotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(800, 60);
            this.pTitulo.TabIndex = 0;
            // 
            // pInformacion
            // 
            this.pInformacion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pInformacion.Controls.Add(this.bConsultar);
            this.pInformacion.Controls.Add(this.tbBuscar);
            this.pInformacion.Controls.Add(this.label2);
            this.pInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInformacion.Location = new System.Drawing.Point(0, 60);
            this.pInformacion.Name = "pInformacion";
            this.pInformacion.Size = new System.Drawing.Size(800, 112);
            this.pInformacion.TabIndex = 3;
            // 
            // DGVDatos
            // 
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDatos.Location = new System.Drawing.Point(0, 172);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(800, 210);
            this.DGVDatos.TabIndex = 4;
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTA GENERAL DE CARGOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DIGITE EL DATO A BUSCAR";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(165, 34);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(100, 20);
            this.tbBuscar.TabIndex = 1;
            // 
            // bConsultar
            // 
            this.bConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultar.Location = new System.Drawing.Point(281, 34);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(75, 23);
            this.bConsultar.TabIndex = 2;
            this.bConsultar.Text = "&Consultar";
            this.toolTip2.SetToolTip(this.bConsultar, "Realizar la consulta de informacion");
            this.bConsultar.UseVisualStyleBackColor = true;
            this.bConsultar.Click += new System.EventHandler(this.bConsultar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(439, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de Cargos";
            // 
            // lCantCargo
            // 
            this.lCantCargo.AutoSize = true;
            this.lCantCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantCargo.ForeColor = System.Drawing.Color.White;
            this.lCantCargo.Location = new System.Drawing.Point(563, 36);
            this.lCantCargo.Name = "lCantCargo";
            this.lCantCargo.Size = new System.Drawing.Size(41, 13);
            this.lCantCargo.TabIndex = 6;
            this.lCantCargo.Text = "label4";
            // 
            // bPrimero
            // 
            this.bPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrimero.ForeColor = System.Drawing.Color.Black;
            this.bPrimero.Location = new System.Drawing.Point(24, 31);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(75, 23);
            this.bPrimero.TabIndex = 5;
            this.bPrimero.Text = "&Primero";
            this.toolTip3.SetToolTip(this.bPrimero, "Ir al primer registro");
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // pbotones
            // 
            this.pbotones.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbotones.Controls.Add(this.bSalir);
            this.pbotones.Controls.Add(this.bImprimir);
            this.pbotones.Controls.Add(this.bUltimo);
            this.pbotones.Controls.Add(this.bSiguiente);
            this.pbotones.Controls.Add(this.bAnterior);
            this.pbotones.Controls.Add(this.bPrimero);
            this.pbotones.Controls.Add(this.lCantCargo);
            this.pbotones.Controls.Add(this.label3);
            this.pbotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbotones.Location = new System.Drawing.Point(0, 382);
            this.pbotones.Name = "pbotones";
            this.pbotones.Size = new System.Drawing.Size(800, 68);
            this.pbotones.TabIndex = 2;
            // 
            // bAnterior
            // 
            this.bAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnterior.ForeColor = System.Drawing.Color.Black;
            this.bAnterior.Location = new System.Drawing.Point(130, 31);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(75, 23);
            this.bAnterior.TabIndex = 7;
            this.bAnterior.Text = "&Anterior";
            this.toolTip4.SetToolTip(this.bAnterior, "Ir al registro anterior");
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSiguiente.ForeColor = System.Drawing.Color.Black;
            this.bSiguiente.Location = new System.Drawing.Point(236, 31);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(75, 23);
            this.bSiguiente.TabIndex = 8;
            this.bSiguiente.Text = "&Siguiente";
            this.toolTip5.SetToolTip(this.bSiguiente, "Ir al siguiente registro");
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bUltimo
            // 
            this.bUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUltimo.ForeColor = System.Drawing.Color.Black;
            this.bUltimo.Location = new System.Drawing.Point(344, 31);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(75, 23);
            this.bUltimo.TabIndex = 6;
            this.bUltimo.Text = "&Ultimo";
            this.toolTip6.SetToolTip(this.bUltimo, "Ir al ultimo registro");
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bImprimir
            // 
            this.bImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.Color.Black;
            this.bImprimir.Location = new System.Drawing.Point(610, 31);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(75, 23);
            this.bImprimir.TabIndex = 9;
            this.bImprimir.Text = "&Imprimir";
            this.toolTip7.SetToolTip(this.bImprimir, "Generar el reporte correspondiente");
            this.bImprimir.UseVisualStyleBackColor = true;
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.Color.Black;
            this.bSalir.Location = new System.Drawing.Point(711, 31);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 10;
            this.bSalir.Text = "&Salir";
            this.toolTip8.SetToolTip(this.bSalir, "Salir del formulario");
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // ConsultaCargoGral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.pInformacion);
            this.Controls.Add(this.pbotones);
            this.Controls.Add(this.pTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaCargoGral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConsultaCargoGral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultaCargoGral_FormClosing);
            this.Load += new System.EventHandler(this.ConsultaCargoGral_Load);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pInformacion.ResumeLayout(false);
            this.pInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.pbotones.ResumeLayout(false);
            this.pbotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Panel pInformacion;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bConsultar;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCantCargo;
        private System.Windows.Forms.Button bPrimero;
        private System.Windows.Forms.Panel pbotones;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.Button bImprimir;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.ToolTip toolTip8;
    }
}
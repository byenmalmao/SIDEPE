
namespace CapaPresentacion
{
    partial class FBuscarNave
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
            this.pTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pInformacion = new System.Windows.Forms.Panel();
            this.bBuscarDato = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.pBotones = new System.Windows.Forms.Panel();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bUltimo = new System.Windows.Forms.Button();
            this.bSiguiente = new System.Windows.Forms.Button();
            this.bAnterior = new System.Windows.Forms.Button();
            this.bPrimero = new System.Windows.Forms.Button();
            this.pTitulo.SuspendLayout();
            this.pInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.pBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(1176, 71);
            this.pTitulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSQUEDA DE NAVES";
            // 
            // pInformacion
            // 
            this.pInformacion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pInformacion.Controls.Add(this.bBuscarDato);
            this.pInformacion.Controls.Add(this.tbBuscar);
            this.pInformacion.Controls.Add(this.label2);
            this.pInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInformacion.Location = new System.Drawing.Point(0, 71);
            this.pInformacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pInformacion.Name = "pInformacion";
            this.pInformacion.Size = new System.Drawing.Size(1176, 71);
            this.pInformacion.TabIndex = 2;
            // 
            // bBuscarDato
            // 
            this.bBuscarDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarDato.Location = new System.Drawing.Point(420, 18);
            this.bBuscarDato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bBuscarDato.Name = "bBuscarDato";
            this.bBuscarDato.Size = new System.Drawing.Size(148, 35);
            this.bBuscarDato.TabIndex = 2;
            this.bBuscarDato.Text = "Buscar Dato";
            this.bBuscarDato.UseVisualStyleBackColor = true;
            this.bBuscarDato.Click += new System.EventHandler(this.bBuscarDato_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(247, 22);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(148, 26);
            this.tbBuscar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DIGITE EL DATO A BUSCAR";
            // 
            // DGVDatos
            // 
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDatos.Location = new System.Drawing.Point(0, 142);
            this.DGVDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.RowHeadersWidth = 62;
            this.DGVDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDatos.Size = new System.Drawing.Size(1176, 483);
            this.DGVDatos.TabIndex = 4;
            this.DGVDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellDoubleClick);
            this.DGVDatos.CurrentCellChanged += new System.EventHandler(this.DGVDatos_CurrentCellChanged);
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
            this.pBotones.Location = new System.Drawing.Point(0, 547);
            this.pBotones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(1176, 78);
            this.pBotones.TabIndex = 5;
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(1048, 23);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(112, 35);
            this.bAceptar.TabIndex = 6;
            this.bAceptar.Text = "Acep&tar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelar.Location = new System.Drawing.Point(908, 23);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(112, 35);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bUltimo
            // 
            this.bUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUltimo.Location = new System.Drawing.Point(486, 23);
            this.bUltimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bUltimo.Name = "bUltimo";
            this.bUltimo.Size = new System.Drawing.Size(112, 35);
            this.bUltimo.TabIndex = 4;
            this.bUltimo.Text = "&Ultimo";
            this.bUltimo.UseVisualStyleBackColor = true;
            this.bUltimo.Click += new System.EventHandler(this.bUltimo_Click);
            // 
            // bSiguiente
            // 
            this.bSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSiguiente.Location = new System.Drawing.Point(328, 23);
            this.bSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSiguiente.Name = "bSiguiente";
            this.bSiguiente.Size = new System.Drawing.Size(112, 35);
            this.bSiguiente.TabIndex = 4;
            this.bSiguiente.Text = "&Siguiente";
            this.bSiguiente.UseVisualStyleBackColor = true;
            this.bSiguiente.Click += new System.EventHandler(this.bSiguiente_Click);
            // 
            // bAnterior
            // 
            this.bAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnterior.Location = new System.Drawing.Point(172, 23);
            this.bAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAnterior.Name = "bAnterior";
            this.bAnterior.Size = new System.Drawing.Size(112, 35);
            this.bAnterior.TabIndex = 4;
            this.bAnterior.Text = "&Anterior";
            this.bAnterior.UseVisualStyleBackColor = true;
            this.bAnterior.Click += new System.EventHandler(this.bAnterior_Click);
            // 
            // bPrimero
            // 
            this.bPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrimero.Location = new System.Drawing.Point(20, 23);
            this.bPrimero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPrimero.Name = "bPrimero";
            this.bPrimero.Size = new System.Drawing.Size(112, 35);
            this.bPrimero.TabIndex = 0;
            this.bPrimero.Text = "&Primero";
            this.bPrimero.UseVisualStyleBackColor = true;
            this.bPrimero.Click += new System.EventHandler(this.bPrimero_Click);
            // 
            // FBuscarNave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 625);
            this.Controls.Add(this.pBotones);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.pInformacion);
            this.Controls.Add(this.pTitulo);
            this.Name = "FBuscarNave";
            this.Text = "FBuscarNave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBuscarNave_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBuscarNave_FormClosed);
            this.Load += new System.EventHandler(this.FBuscarNave_Load);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pInformacion.ResumeLayout(false);
            this.pInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.pBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pInformacion;
        private System.Windows.Forms.Button bBuscarDato;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bUltimo;
        private System.Windows.Forms.Button bSiguiente;
        private System.Windows.Forms.Button bAnterior;
        private System.Windows.Forms.Button bPrimero;
    }
}
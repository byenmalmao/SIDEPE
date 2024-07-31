
namespace CapaPresentacion
{
    partial class MantNave
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
            this.pBotones = new System.Windows.Forms.Panel();
            this.bSalir = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bNuevo = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.tbEmpresa = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbEncargado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdNave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pBotones.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.SuspendLayout();
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
            this.pBotones.Location = new System.Drawing.Point(0, 747);
            this.pBotones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBotones.Name = "pBotones";
            this.pBotones.Size = new System.Drawing.Size(1335, 54);
            this.pBotones.TabIndex = 2;
            // 
            // bSalir
            // 
            this.bSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bSalir.Location = new System.Drawing.Point(1204, 14);
            this.bSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(112, 35);
            this.bSalir.TabIndex = 3;
            this.bSalir.Text = "&Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bGuardar.Location = new System.Drawing.Point(208, 14);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(112, 35);
            this.bGuardar.TabIndex = 3;
            this.bGuardar.Text = "&Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancelar.Location = new System.Drawing.Point(1017, 14);
            this.bCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(112, 35);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bEditar
            // 
            this.bEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEditar.Location = new System.Drawing.Point(384, 14);
            this.bEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(112, 35);
            this.bEditar.TabIndex = 3;
            this.bEditar.Text = "&Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            this.bEditar.Click += new System.EventHandler(this.bEditar_Click);
            // 
            // bNuevo
            // 
            this.bNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bNuevo.Location = new System.Drawing.Point(36, 14);
            this.bNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(112, 35);
            this.bNuevo.TabIndex = 0;
            this.bNuevo.Text = "&Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBuscar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bBuscar.Location = new System.Drawing.Point(1161, 138);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(62, 51);
            this.bBuscar.TabIndex = 14;
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.tbUbicacion);
            this.panel3.Controls.Add(this.tbEstado);
            this.panel3.Controls.Add(this.tbEmpresa);
            this.panel3.Controls.Add(this.tbTelefono);
            this.panel3.Controls.Add(this.tbEncargado);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbCategoria);
            this.panel3.Controls.Add(this.tbNombre);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(49, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 411);
            this.panel3.TabIndex = 15;
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbUbicacion.Font = new System.Drawing.Font("Arial", 10F);
            this.tbUbicacion.Location = new System.Drawing.Point(191, 153);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(364, 30);
            this.tbUbicacion.TabIndex = 28;
            // 
            // tbEstado
            // 
            this.tbEstado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbEstado.Font = new System.Drawing.Font("Arial", 10F);
            this.tbEstado.Location = new System.Drawing.Point(191, 341);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(364, 30);
            this.tbEstado.TabIndex = 27;
            // 
            // tbEmpresa
            // 
            this.tbEmpresa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbEmpresa.Font = new System.Drawing.Font("Arial", 10F);
            this.tbEmpresa.Location = new System.Drawing.Point(191, 290);
            this.tbEmpresa.Name = "tbEmpresa";
            this.tbEmpresa.Size = new System.Drawing.Size(364, 30);
            this.tbEmpresa.TabIndex = 26;
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbTelefono.Font = new System.Drawing.Font("Arial", 10F);
            this.tbTelefono.Location = new System.Drawing.Point(191, 239);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(364, 30);
            this.tbTelefono.TabIndex = 25;
            // 
            // tbEncargado
            // 
            this.tbEncargado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbEncargado.Font = new System.Drawing.Font("Arial", 10F);
            this.tbEncargado.Location = new System.Drawing.Point(191, 196);
            this.tbEncargado.Name = "tbEncargado";
            this.tbEncargado.Size = new System.Drawing.Size(364, 30);
            this.tbEncargado.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 206);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Encargado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Empresa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 347);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Estado";
            // 
            // tbCategoria
            // 
            this.tbCategoria.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbCategoria.Font = new System.Drawing.Font("Arial", 10F);
            this.tbCategoria.Location = new System.Drawing.Point(191, 108);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(364, 30);
            this.tbCategoria.TabIndex = 17;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbNombre.Font = new System.Drawing.Font("Arial", 10F);
            this.tbNombre.Location = new System.Drawing.Point(191, 59);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(364, 30);
            this.tbNombre.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ubicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(610, 42);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pTitulo.Controls.Add(this.panel1);
            this.pTitulo.Controls.Add(this.label1);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 0);
            this.pTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(1335, 54);
            this.pTitulo.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 51);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANTENIMIENTO DE NAVE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbIdNave
            // 
            this.tbIdNave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbIdNave.Font = new System.Drawing.Font("Arial", 10F);
            this.tbIdNave.Location = new System.Drawing.Point(828, 150);
            this.tbIdNave.Name = "tbIdNave";
            this.tbIdNave.Size = new System.Drawing.Size(307, 30);
            this.tbIdNave.TabIndex = 18;
            this.tbIdNave.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID Nave";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MantNave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 801);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdNave);
            this.Controls.Add(this.pTitulo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.pBotones);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantNave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantNave";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantNave_FormClosing);
            this.Load += new System.EventHandler(this.MantNave_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MantNave_KeyDown);
            this.pBotones.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBotones;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.TextBox tbEmpresa;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbEncargado;
        private System.Windows.Forms.TextBox tbIdNave;
        private System.Windows.Forms.Label label2;
    }
}
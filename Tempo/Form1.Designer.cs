namespace Tempo
{
    partial class frmTemporizador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemporizador));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTemporizador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlComando = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnAtajos = new System.Windows.Forms.Button();
            this.pnlCustom = new System.Windows.Forms.Panel();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.cbxSegundos = new System.Windows.Forms.ComboBox();
            this.cbxMinutos = new System.Windows.Forms.ComboBox();
            this.pnlTiempo = new System.Windows.Forms.Panel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.pnlAtajos = new System.Windows.Forms.Panel();
            this.rbtnDiez = new System.Windows.Forms.RadioButton();
            this.rbtnOcho = new System.Windows.Forms.RadioButton();
            this.rbtnTres = new System.Windows.Forms.RadioButton();
            this.rbtnDos = new System.Windows.Forms.RadioButton();
            this.rbtnUno = new System.Windows.Forms.RadioButton();
            this.pnlTitulo.SuspendLayout();
            this.pnlComando.SuspendLayout();
            this.pnlCustom.SuspendLayout();
            this.pnlTiempo.SuspendLayout();
            this.pnlAtajos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.pnlTitulo.Controls.Add(this.lblAutor);
            this.pnlTitulo.Controls.Add(this.lblTemporizador);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(220, 67);
            this.pnlTitulo.TabIndex = 0;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAutor.Font = new System.Drawing.Font("Roboto Th", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblAutor.Location = new System.Drawing.Point(162, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(58, 14);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "by Mitsuha";
            // 
            // lblTemporizador
            // 
            this.lblTemporizador.AutoSize = true;
            this.lblTemporizador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTemporizador.Font = new System.Drawing.Font("Hack", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemporizador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(204)))), ((int)(((byte)(148)))));
            this.lblTemporizador.Location = new System.Drawing.Point(20, 19);
            this.lblTemporizador.Name = "lblTemporizador";
            this.lblTemporizador.Size = new System.Drawing.Size(181, 29);
            this.lblTemporizador.TabIndex = 0;
            this.lblTemporizador.Text = "Temporizador";
            this.lblTemporizador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pnlComando
            // 
            this.pnlComando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.pnlComando.Controls.Add(this.btnSalir);
            this.pnlComando.Controls.Add(this.btnPausar);
            this.pnlComando.Controls.Add(this.btnIniciar);
            this.pnlComando.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlComando.Location = new System.Drawing.Point(0, 238);
            this.pnlComando.Name = "pnlComando";
            this.pnlComando.Size = new System.Drawing.Size(220, 122);
            this.pnlComando.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(204)))), ((int)(((byte)(148)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.btnSalir.Location = new System.Drawing.Point(0, 80);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(220, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPausar.FlatAppearance.BorderSize = 0;
            this.btnPausar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.btnPausar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(204)))), ((int)(((byte)(148)))));
            this.btnPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPausar.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.btnPausar.Location = new System.Drawing.Point(0, 40);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(220, 40);
            this.btnPausar.TabIndex = 1;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(204)))), ((int)(((byte)(148)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.btnIniciar.Location = new System.Drawing.Point(0, 0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(220, 40);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnAtajos
            // 
            this.btnAtajos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.btnAtajos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAtajos.FlatAppearance.BorderSize = 0;
            this.btnAtajos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.btnAtajos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(204)))), ((int)(((byte)(148)))));
            this.btnAtajos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtajos.Font = new System.Drawing.Font("Hack", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtajos.Location = new System.Drawing.Point(0, 67);
            this.btnAtajos.Name = "btnAtajos";
            this.btnAtajos.Size = new System.Drawing.Size(220, 40);
            this.btnAtajos.TabIndex = 9;
            this.btnAtajos.Text = "Atajos";
            this.btnAtajos.UseVisualStyleBackColor = false;
            this.btnAtajos.Click += new System.EventHandler(this.BtnAtajos_Click);
            // 
            // pnlCustom
            // 
            this.pnlCustom.Controls.Add(this.lblSegundos);
            this.pnlCustom.Controls.Add(this.lblMinutos);
            this.pnlCustom.Controls.Add(this.cbxSegundos);
            this.pnlCustom.Controls.Add(this.cbxMinutos);
            this.pnlCustom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustom.Location = new System.Drawing.Point(0, 107);
            this.pnlCustom.Name = "pnlCustom";
            this.pnlCustom.Size = new System.Drawing.Size(220, 84);
            this.pnlCustom.TabIndex = 10;
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Hack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.Location = new System.Drawing.Point(25, 49);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(99, 19);
            this.lblSegundos.TabIndex = 12;
            this.lblSegundos.Text = "Segundos:";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Hack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.Location = new System.Drawing.Point(25, 12);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(89, 19);
            this.lblMinutos.TabIndex = 11;
            this.lblMinutos.Text = "Minutos:";
            // 
            // cbxSegundos
            // 
            this.cbxSegundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxSegundos.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSegundos.FormattingEnabled = true;
            this.cbxSegundos.Location = new System.Drawing.Point(127, 45);
            this.cbxSegundos.Name = "cbxSegundos";
            this.cbxSegundos.Size = new System.Drawing.Size(69, 27);
            this.cbxSegundos.TabIndex = 10;
            // 
            // cbxMinutos
            // 
            this.cbxMinutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxMinutos.Font = new System.Drawing.Font("Panton", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMinutos.FormattingEnabled = true;
            this.cbxMinutos.Location = new System.Drawing.Point(127, 8);
            this.cbxMinutos.Name = "cbxMinutos";
            this.cbxMinutos.Size = new System.Drawing.Size(69, 27);
            this.cbxMinutos.TabIndex = 9;
            // 
            // pnlTiempo
            // 
            this.pnlTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(102)))));
            this.pnlTiempo.Controls.Add(this.lblTiempo);
            this.pnlTiempo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTiempo.Location = new System.Drawing.Point(0, 191);
            this.pnlTiempo.Name = "pnlTiempo";
            this.pnlTiempo.Size = new System.Drawing.Size(220, 47);
            this.pnlTiempo.TabIndex = 11;
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Panton", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.White;
            this.lblTiempo.Location = new System.Drawing.Point(63, 8);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(95, 32);
            this.lblTiempo.TabIndex = 4;
            this.lblTiempo.Text = "00:00";
            // 
            // pnlAtajos
            // 
            this.pnlAtajos.Controls.Add(this.rbtnDiez);
            this.pnlAtajos.Controls.Add(this.rbtnOcho);
            this.pnlAtajos.Controls.Add(this.rbtnTres);
            this.pnlAtajos.Controls.Add(this.rbtnDos);
            this.pnlAtajos.Controls.Add(this.rbtnUno);
            this.pnlAtajos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAtajos.Location = new System.Drawing.Point(0, 191);
            this.pnlAtajos.Name = "pnlAtajos";
            this.pnlAtajos.Size = new System.Drawing.Size(220, 0);
            this.pnlAtajos.TabIndex = 12;
            // 
            // rbtnDiez
            // 
            this.rbtnDiez.AutoSize = true;
            this.rbtnDiez.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnDiez.Font = new System.Drawing.Font("Hack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDiez.Location = new System.Drawing.Point(104, 32);
            this.rbtnDiez.Name = "rbtnDiez";
            this.rbtnDiez.Size = new System.Drawing.Size(87, 23);
            this.rbtnDiez.TabIndex = 4;
            this.rbtnDiez.TabStop = true;
            this.rbtnDiez.Text = "10 min";
            this.rbtnDiez.UseVisualStyleBackColor = true;
            this.rbtnDiez.CheckedChanged += new System.EventHandler(this.RbtnDiez_CheckedChanged);
            // 
            // rbtnOcho
            // 
            this.rbtnOcho.AutoSize = true;
            this.rbtnOcho.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnOcho.Font = new System.Drawing.Font("Hack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOcho.Location = new System.Drawing.Point(114, 3);
            this.rbtnOcho.Name = "rbtnOcho";
            this.rbtnOcho.Size = new System.Drawing.Size(77, 23);
            this.rbtnOcho.TabIndex = 3;
            this.rbtnOcho.TabStop = true;
            this.rbtnOcho.Text = "8 min";
            this.rbtnOcho.UseVisualStyleBackColor = true;
            this.rbtnOcho.CheckedChanged += new System.EventHandler(this.RbtnOcho_CheckedChanged);
            // 
            // rbtnTres
            // 
            this.rbtnTres.AutoSize = true;
            this.rbtnTres.Font = new System.Drawing.Font("Hack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTres.Location = new System.Drawing.Point(25, 58);
            this.rbtnTres.Name = "rbtnTres";
            this.rbtnTres.Size = new System.Drawing.Size(77, 23);
            this.rbtnTres.TabIndex = 2;
            this.rbtnTres.TabStop = true;
            this.rbtnTres.Text = "3 min";
            this.rbtnTres.UseVisualStyleBackColor = true;
            this.rbtnTres.CheckedChanged += new System.EventHandler(this.RbtnTres_CheckedChanged);
            // 
            // rbtnDos
            // 
            this.rbtnDos.AutoSize = true;
            this.rbtnDos.Font = new System.Drawing.Font("Hack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDos.Location = new System.Drawing.Point(25, 31);
            this.rbtnDos.Name = "rbtnDos";
            this.rbtnDos.Size = new System.Drawing.Size(77, 23);
            this.rbtnDos.TabIndex = 1;
            this.rbtnDos.TabStop = true;
            this.rbtnDos.Text = "2 min";
            this.rbtnDos.UseVisualStyleBackColor = true;
            this.rbtnDos.CheckedChanged += new System.EventHandler(this.RbtnDos_CheckedChanged);
            // 
            // rbtnUno
            // 
            this.rbtnUno.AutoSize = true;
            this.rbtnUno.Font = new System.Drawing.Font("Hack", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUno.Location = new System.Drawing.Point(25, 6);
            this.rbtnUno.Name = "rbtnUno";
            this.rbtnUno.Size = new System.Drawing.Size(77, 23);
            this.rbtnUno.TabIndex = 0;
            this.rbtnUno.TabStop = true;
            this.rbtnUno.Text = "1 min";
            this.rbtnUno.UseVisualStyleBackColor = true;
            this.rbtnUno.CheckedChanged += new System.EventHandler(this.RbtnUno_CheckedChanged);
            // 
            // frmTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(220, 360);
            this.Controls.Add(this.pnlAtajos);
            this.Controls.Add(this.pnlTiempo);
            this.Controls.Add(this.pnlCustom);
            this.Controls.Add(this.btnAtajos);
            this.Controls.Add(this.pnlComando);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTemporizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporizador";
            this.Load += new System.EventHandler(this.FrmTemporizador_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlComando.ResumeLayout(false);
            this.pnlCustom.ResumeLayout(false);
            this.pnlCustom.PerformLayout();
            this.pnlTiempo.ResumeLayout(false);
            this.pnlAtajos.ResumeLayout(false);
            this.pnlAtajos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblTemporizador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlComando;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btnAtajos;
        private System.Windows.Forms.Panel pnlCustom;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.ComboBox cbxSegundos;
        private System.Windows.Forms.ComboBox cbxMinutos;
        private System.Windows.Forms.Panel pnlTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Panel pnlAtajos;
        private System.Windows.Forms.RadioButton rbtnDiez;
        private System.Windows.Forms.RadioButton rbtnOcho;
        private System.Windows.Forms.RadioButton rbtnTres;
        private System.Windows.Forms.RadioButton rbtnDos;
        private System.Windows.Forms.RadioButton rbtnUno;
    }
}


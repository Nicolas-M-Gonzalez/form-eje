namespace eje2
{
    partial class Form1
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.txttextnombre = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.dtpnacimiento = new System.Windows.Forms.DateTimePicker();
            this.chboxhincha = new System.Windows.Forms.CheckBox();
            this.lblperfil = new System.Windows.Forms.Label();
            this.rbestudiante = new System.Windows.Forms.RadioButton();
            this.rboperario = new System.Windows.Forms.RadioButton();
            this.rbprofesional = new System.Windows.Forms.RadioButton();
            this.gbtipo = new System.Windows.Forms.GroupBox();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.lblcolor = new System.Windows.Forms.Label();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.lblnumfavorito = new System.Windows.Forms.Label();
            this.btnperfil = new System.Windows.Forms.Button();
            this.gbtipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(64, 69);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(42, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "nombre";
            // 
            // txttextnombre
            // 
            this.txttextnombre.Location = new System.Drawing.Point(183, 62);
            this.txttextnombre.Name = "txttextnombre";
            this.txttextnombre.Size = new System.Drawing.Size(124, 20);
            this.txttextnombre.TabIndex = 1;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(65, 105);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(103, 13);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "fecha de nacimiento";
            // 
            // dtpnacimiento
            // 
            this.dtpnacimiento.Location = new System.Drawing.Point(183, 98);
            this.dtpnacimiento.Name = "dtpnacimiento";
            this.dtpnacimiento.Size = new System.Drawing.Size(124, 20);
            this.dtpnacimiento.TabIndex = 3;
            // 
            // chboxhincha
            // 
            this.chboxhincha.AutoSize = true;
            this.chboxhincha.Location = new System.Drawing.Point(183, 140);
            this.chboxhincha.Name = "chboxhincha";
            this.chboxhincha.Size = new System.Drawing.Size(120, 17);
            this.chboxhincha.TabIndex = 4;
            this.chboxhincha.Text = "sos hincha del rojo?";
            this.chboxhincha.UseVisualStyleBackColor = true;
            // 
            // lblperfil
            // 
            this.lblperfil.AutoSize = true;
            this.lblperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfil.Location = new System.Drawing.Point(165, 9);
            this.lblperfil.Name = "lblperfil";
            this.lblperfil.Size = new System.Drawing.Size(162, 20);
            this.lblperfil.TabIndex = 5;
            this.lblperfil.Text = "PERFIL PERSONA";
            // 
            // rbestudiante
            // 
            this.rbestudiante.AutoSize = true;
            this.rbestudiante.Checked = true;
            this.rbestudiante.Location = new System.Drawing.Point(8, 19);
            this.rbestudiante.Name = "rbestudiante";
            this.rbestudiante.Size = new System.Drawing.Size(74, 17);
            this.rbestudiante.TabIndex = 6;
            this.rbestudiante.TabStop = true;
            this.rbestudiante.Text = "estudiante";
            this.rbestudiante.UseVisualStyleBackColor = true;
            // 
            // rboperario
            // 
            this.rboperario.AutoSize = true;
            this.rboperario.Location = new System.Drawing.Point(117, 19);
            this.rboperario.Name = "rboperario";
            this.rboperario.Size = new System.Drawing.Size(63, 17);
            this.rboperario.TabIndex = 7;
            this.rboperario.Text = "operario";
            this.rboperario.UseVisualStyleBackColor = true;
            // 
            // rbprofesional
            // 
            this.rbprofesional.AutoSize = true;
            this.rbprofesional.Location = new System.Drawing.Point(232, 19);
            this.rbprofesional.Name = "rbprofesional";
            this.rbprofesional.Size = new System.Drawing.Size(76, 17);
            this.rbprofesional.TabIndex = 8;
            this.rbprofesional.Text = "profesional";
            this.rbprofesional.UseVisualStyleBackColor = true;
            // 
            // gbtipo
            // 
            this.gbtipo.Controls.Add(this.rbprofesional);
            this.gbtipo.Controls.Add(this.rbestudiante);
            this.gbtipo.Controls.Add(this.rboperario);
            this.gbtipo.Location = new System.Drawing.Point(67, 180);
            this.gbtipo.Name = "gbtipo";
            this.gbtipo.Size = new System.Drawing.Size(347, 67);
            this.gbtipo.TabIndex = 9;
            this.gbtipo.TabStop = false;
            this.gbtipo.Text = "tipo";
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Location = new System.Drawing.Point(182, 263);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(156, 21);
            this.cmbcolor.TabIndex = 9;
            this.cmbcolor.SelectedIndexChanged += new System.EventHandler(this.cmbcolor_SelectedIndexChanged);
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(90, 266);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(68, 13);
            this.lblcolor.TabIndex = 10;
            this.lblcolor.Text = "color favorito";
            // 
            // numeric
            // 
            this.numeric.Location = new System.Drawing.Point(182, 290);
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(120, 20);
            this.numeric.TabIndex = 11;
            // 
            // lblnumfavorito
            // 
            this.lblnumfavorito.AutoSize = true;
            this.lblnumfavorito.Location = new System.Drawing.Point(75, 297);
            this.lblnumfavorito.Name = "lblnumfavorito";
            this.lblnumfavorito.Size = new System.Drawing.Size(83, 13);
            this.lblnumfavorito.TabIndex = 12;
            this.lblnumfavorito.Text = "numero favorito:";
            this.lblnumfavorito.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnperfil
            // 
            this.btnperfil.Location = new System.Drawing.Point(436, 325);
            this.btnperfil.Name = "btnperfil";
            this.btnperfil.Size = new System.Drawing.Size(75, 51);
            this.btnperfil.TabIndex = 13;
            this.btnperfil.Text = "ver perfil";
            this.btnperfil.UseVisualStyleBackColor = true;
            this.btnperfil.Click += new System.EventHandler(this.btnperfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 337);
            this.Controls.Add(this.btnperfil);
            this.Controls.Add(this.lblnumfavorito);
            this.Controls.Add(this.numeric);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.cmbcolor);
            this.Controls.Add(this.gbtipo);
            this.Controls.Add(this.lblperfil);
            this.Controls.Add(this.chboxhincha);
            this.Controls.Add(this.dtpnacimiento);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txttextnombre);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbtipo.ResumeLayout(false);
            this.gbtipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txttextnombre;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.DateTimePicker dtpnacimiento;
        private System.Windows.Forms.CheckBox chboxhincha;
        private System.Windows.Forms.Label lblperfil;
        private System.Windows.Forms.RadioButton rbestudiante;
        private System.Windows.Forms.RadioButton rboperario;
        private System.Windows.Forms.RadioButton rbprofesional;
        private System.Windows.Forms.GroupBox gbtipo;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.Label lblnumfavorito;
        private System.Windows.Forms.Button btnperfil;
    }
}


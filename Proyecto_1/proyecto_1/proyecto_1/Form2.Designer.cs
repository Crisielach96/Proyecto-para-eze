namespace proyecto_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFormasdemorir = new System.Windows.Forms.Label();
            this.lblReligion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbReligion = new System.Windows.Forms.ComboBox();
            this.cmbMorir = new System.Windows.Forms.ComboBox();
            this.gpSexo = new System.Windows.Forms.GroupBox();
            this.rbOtros = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.gpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(12, 103);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(100, 20);
            this.txbApellido.TabIndex = 0;
            // 
            // txbDni
            // 
            this.txbDni.Location = new System.Drawing.Point(10, 195);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(100, 20);
            this.txbDni.TabIndex = 1;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(12, 46);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(9, 78);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 13);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido/s";
            // 
            // lblFormasdemorir
            // 
            this.lblFormasdemorir.AutoSize = true;
            this.lblFormasdemorir.Location = new System.Drawing.Point(509, 98);
            this.lblFormasdemorir.Name = "lblFormasdemorir";
            this.lblFormasdemorir.Size = new System.Drawing.Size(48, 13);
            this.lblFormasdemorir.TabIndex = 9;
            this.lblFormasdemorir.Text = "Morir.....:";
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Location = new System.Drawing.Point(9, 228);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(98, 13);
            this.lblReligion.TabIndex = 13;
            this.lblReligion.Text = "Creencia Religiosa ";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 179);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 13);
            this.lblDni.TabIndex = 14;
            this.lblDni.Text = "D.N.I";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre/s";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(264, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(731, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbReligion
            // 
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.Items.AddRange(new object[] {
            "Catolico",
            "Protestante",
            "Evangelico",
            "Indu",
            "Ateo (Iras al infierno)",
            "Budista",
            "Otros (no tan importantes, iras al infierno tambien)"});
            this.cmbReligion.Location = new System.Drawing.Point(10, 255);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(291, 21);
            this.cmbReligion.TabIndex = 21;
            // 
            // cmbMorir
            // 
            this.cmbMorir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMorir.FormattingEnabled = true;
            this.cmbMorir.Items.AddRange(new object[] {
            "Atropellado por un triciclo",
            "De una depresion por no poder ir al baño",
            "Por el chasquido de Thanos",
            "Por un tiburon que salga de un inodoro",
            "Desangrado por flechazo en los testiculo montado en un lobo en el bosque",
            "Decapitado por un ventilador de techo",
            "Por una infeccion por comerse las uñas",
            "Envenenado por tinta de impresora vencida",
            "Asfixiado por un mono el el zoologico",
            "Ahogado por un vaso de agua",
            "Aplastado por una grua que levantaba otra grua",
            "Golpeado hasta la muerte con una almohada",
            "Tras una revision de rutina en el hospital de Berazategui",
            "Envenenado por lamer un sapo",
            "Por no tener bien atado los zapatos",
            "Por el impacto de un meteorito del tamaño de un alfiler",
            "Mordido por un perro sin dientes",
            "En el pogo de La Beriso",
            "Por el susto de un disparo falso en una obra de teatro",
            "Por el pañal sucio de un bebe",
            "Por meter la cabeza dentro de un microondas",
            "De la misma manera que tu personaje en D&D"});
            this.cmbMorir.Location = new System.Drawing.Point(404, 114);
            this.cmbMorir.Name = "cmbMorir";
            this.cmbMorir.Size = new System.Drawing.Size(673, 28);
            this.cmbMorir.TabIndex = 22;
            // 
            // gpSexo
            // 
            this.gpSexo.Controls.Add(this.rbOtros);
            this.gpSexo.Controls.Add(this.rbFemenino);
            this.gpSexo.Controls.Add(this.rbMasculino);
            this.gpSexo.Location = new System.Drawing.Point(10, 129);
            this.gpSexo.Name = "gpSexo";
            this.gpSexo.Size = new System.Drawing.Size(216, 48);
            this.gpSexo.TabIndex = 23;
            this.gpSexo.TabStop = false;
            this.gpSexo.Text = "Sexo";
            // 
            // rbOtros
            // 
            this.rbOtros.AutoSize = true;
            this.rbOtros.Location = new System.Drawing.Point(162, 17);
            this.rbOtros.Name = "rbOtros";
            this.rbOtros.Size = new System.Drawing.Size(50, 17);
            this.rbOtros.TabIndex = 21;
            this.rbOtros.TabStop = true;
            this.rbOtros.Text = "Otros";
            this.rbOtros.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(85, 17);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 20;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(6, 17);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 19;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 466);
            this.Controls.Add(this.gpSexo);
            this.Controls.Add(this.cmbMorir);
            this.Controls.Add(this.cmbReligion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblReligion);
            this.Controls.Add(this.lblFormasdemorir);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.txbApellido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Die Fast";
            this.gpSexo.ResumeLayout(false);
            this.gpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFormasdemorir;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbReligion;
        private System.Windows.Forms.ComboBox cmbMorir;
        private System.Windows.Forms.RadioButton rbOtros;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        public System.Windows.Forms.GroupBox gpSexo;
    }
}
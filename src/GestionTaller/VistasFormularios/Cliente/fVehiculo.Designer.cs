namespace GestionTaller
{
    partial class fVehiculo
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
            this.infoError = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.lMatricula = new System.Windows.Forms.Label();
            this.tbNBastidor = new System.Windows.Forms.TextBox();
            this.lNBastidor = new System.Windows.Forms.Label();
            this.lVehiculo = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lMarca = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lModelo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.bGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoError)).BeginInit();
            this.SuspendLayout();
            // 
            // infoError
            // 
            this.infoError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.infoError.ContainerControl = this;
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(142, 109);
            this.tbContrasenia.MaxLength = 8;
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(181, 20);
            this.tbContrasenia.TabIndex = 4;
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Location = new System.Drawing.Point(81, 112);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(55, 13);
            this.lMatricula.TabIndex = 3;
            this.lMatricula.Text = "Matrícula:";
            // 
            // tbNBastidor
            // 
            this.tbNBastidor.Location = new System.Drawing.Point(142, 69);
            this.tbNBastidor.MaxLength = 17;
            this.tbNBastidor.Name = "tbNBastidor";
            this.tbNBastidor.Size = new System.Drawing.Size(181, 20);
            this.tbNBastidor.TabIndex = 2;
            // 
            // lNBastidor
            // 
            this.lNBastidor.AutoSize = true;
            this.lNBastidor.Location = new System.Drawing.Point(35, 72);
            this.lNBastidor.Name = "lNBastidor";
            this.lNBastidor.Size = new System.Drawing.Size(102, 13);
            this.lNBastidor.TabIndex = 1;
            this.lNBastidor.Text = "Número de bastidor:";
            // 
            // lVehiculo
            // 
            this.lVehiculo.AutoSize = true;
            this.lVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVehiculo.Location = new System.Drawing.Point(29, 21);
            this.lVehiculo.Name = "lVehiculo";
            this.lVehiculo.Size = new System.Drawing.Size(294, 22);
            this.lVehiculo.TabIndex = 0;
            this.lVehiculo.Text = "Introduzca los datos de su vehículo:";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(142, 147);
            this.tbMarca.MaxLength = 50;
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(181, 20);
            this.tbMarca.TabIndex = 6;
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(96, 150);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(40, 13);
            this.lMarca.TabIndex = 5;
            this.lMarca.Text = "Marca:";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(142, 184);
            this.tbModelo.MaxLength = 50;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(181, 20);
            this.tbModelo.TabIndex = 8;
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(91, 187);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(45, 13);
            this.lModelo.TabIndex = 7;
            this.lModelo.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de vehículo:";
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.FormattingEnabled = true;
            this.cbTipoVehiculo.Location = new System.Drawing.Point(142, 224);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(181, 21);
            this.cbTipoVehiculo.TabIndex = 10;
            // 
            // bGuardar
            // 
            this.bGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.Location = new System.Drawing.Point(33, 274);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(290, 32);
            this.bGuardar.TabIndex = 11;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            // 
            // fVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 329);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.cbTipoVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.lVehiculo);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.lMatricula);
            this.Controls.Add(this.tbNBastidor);
            this.Controls.Add(this.lNBastidor);
            this.Name = "fVehiculo";
            this.Text = "Taller: Registrar Vehículo";
            ((System.ComponentModel.ISupportInitialize)(this.infoError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider infoError;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.TextBox tbNBastidor;
        private System.Windows.Forms.Label lNBastidor;
        private System.Windows.Forms.Label lVehiculo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.ComboBox cbTipoVehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGuardar;
    }
}


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
            components = new System.ComponentModel.Container();
            infoError = new ErrorProvider(components);
            tbMatricula = new TextBox();
            lMatricula = new Label();
            tbNBastidor = new TextBox();
            lNBastidor = new Label();
            lVehiculo = new Label();
            tbMarca = new TextBox();
            lMarca = new Label();
            tbModelo = new TextBox();
            lModelo = new Label();
            label1 = new Label();
            cbTipoVehiculo = new ComboBox();
            bGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)infoError).BeginInit();
            SuspendLayout();
            // 
            // infoError
            // 
            infoError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            infoError.ContainerControl = this;
            // 
            // tbMatricula
            // 
            tbMatricula.Location = new Point(166, 126);
            tbMatricula.Margin = new Padding(4, 3, 4, 3);
            tbMatricula.MaxLength = 8;
            tbMatricula.Name = "tbMatricula";
            tbMatricula.Size = new Size(210, 23);
            tbMatricula.TabIndex = 4;
            // 
            // lMatricula
            // 
            lMatricula.AutoSize = true;
            lMatricula.Location = new Point(94, 129);
            lMatricula.Margin = new Padding(4, 0, 4, 0);
            lMatricula.Name = "lMatricula";
            lMatricula.Size = new Size(60, 15);
            lMatricula.TabIndex = 3;
            lMatricula.Text = "Matrícula:";
            // 
            // tbNBastidor
            // 
            tbNBastidor.Location = new Point(166, 80);
            tbNBastidor.Margin = new Padding(4, 3, 4, 3);
            tbNBastidor.MaxLength = 17;
            tbNBastidor.Name = "tbNBastidor";
            tbNBastidor.Size = new Size(210, 23);
            tbNBastidor.TabIndex = 2;
            // 
            // lNBastidor
            // 
            lNBastidor.AutoSize = true;
            lNBastidor.Location = new Point(41, 83);
            lNBastidor.Margin = new Padding(4, 0, 4, 0);
            lNBastidor.Name = "lNBastidor";
            lNBastidor.Size = new Size(116, 15);
            lNBastidor.TabIndex = 1;
            lNBastidor.Text = "Número de bastidor:";
            // 
            // lVehiculo
            // 
            lVehiculo.AutoSize = true;
            lVehiculo.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lVehiculo.Location = new Point(34, 24);
            lVehiculo.Margin = new Padding(4, 0, 4, 0);
            lVehiculo.Name = "lVehiculo";
            lVehiculo.Size = new Size(294, 22);
            lVehiculo.TabIndex = 0;
            lVehiculo.Text = "Introduzca los datos de su vehículo:";
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(166, 170);
            tbMarca.Margin = new Padding(4, 3, 4, 3);
            tbMarca.MaxLength = 50;
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(210, 23);
            tbMarca.TabIndex = 6;
            // 
            // lMarca
            // 
            lMarca.AutoSize = true;
            lMarca.Location = new Point(112, 173);
            lMarca.Margin = new Padding(4, 0, 4, 0);
            lMarca.Name = "lMarca";
            lMarca.Size = new Size(43, 15);
            lMarca.TabIndex = 5;
            lMarca.Text = "Marca:";
            // 
            // tbModelo
            // 
            tbModelo.Location = new Point(166, 212);
            tbModelo.Margin = new Padding(4, 3, 4, 3);
            tbModelo.MaxLength = 50;
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(210, 23);
            tbModelo.TabIndex = 8;
            // 
            // lModelo
            // 
            lModelo.AutoSize = true;
            lModelo.Location = new Point(106, 216);
            lModelo.Margin = new Padding(4, 0, 4, 0);
            lModelo.Name = "lModelo";
            lModelo.Size = new Size(51, 15);
            lModelo.TabIndex = 7;
            lModelo.Text = "Modelo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 262);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 9;
            label1.Text = "Tipo de vehículo:";
            // 
            // cbTipoVehiculo
            // 
            cbTipoVehiculo.FormattingEnabled = true;
            cbTipoVehiculo.Location = new Point(166, 258);
            cbTipoVehiculo.Margin = new Padding(4, 3, 4, 3);
            cbTipoVehiculo.Name = "cbTipoVehiculo";
            cbTipoVehiculo.Size = new Size(210, 23);
            cbTipoVehiculo.TabIndex = 10;
            // 
            // bGuardar
            // 
            bGuardar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            bGuardar.Location = new Point(38, 316);
            bGuardar.Margin = new Padding(4, 3, 4, 3);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(338, 37);
            bGuardar.TabIndex = 11;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // fVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 380);
            Controls.Add(bGuardar);
            Controls.Add(cbTipoVehiculo);
            Controls.Add(label1);
            Controls.Add(tbModelo);
            Controls.Add(lModelo);
            Controls.Add(tbMarca);
            Controls.Add(lMarca);
            Controls.Add(lVehiculo);
            Controls.Add(tbMatricula);
            Controls.Add(lMatricula);
            Controls.Add(tbNBastidor);
            Controls.Add(lNBastidor);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fVehiculo";
            Text = "Taller: Registrar Vehículo";
            Load += fVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)infoError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ErrorProvider infoError;
        private System.Windows.Forms.TextBox tbMatricula;
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


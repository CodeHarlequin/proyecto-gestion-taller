namespace GestionTaller
{
    partial class fLogin
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
            this.lNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lContrasenia = new System.Windows.Forms.Label();
            this.tbContrasenia = new System.Windows.Forms.TextBox();
            this.lBienvenida = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.infoError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.infoError)).BeginInit();
            this.SuspendLayout();
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(26, 83);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(101, 13);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre de Usuario:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(133, 80);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(181, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // lContrasenia
            // 
            this.lContrasenia.AutoSize = true;
            this.lContrasenia.Location = new System.Drawing.Point(66, 133);
            this.lContrasenia.Name = "lContrasenia";
            this.lContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lContrasenia.TabIndex = 3;
            this.lContrasenia.Text = "Contaseña:";
            // 
            // tbContrasenia
            // 
            this.tbContrasenia.Location = new System.Drawing.Point(133, 130);
            this.tbContrasenia.Name = "tbContrasenia";
            this.tbContrasenia.Size = new System.Drawing.Size(181, 20);
            this.tbContrasenia.TabIndex = 4;
            // 
            // lBienvenida
            // 
            this.lBienvenida.AutoSize = true;
            this.lBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBienvenida.Location = new System.Drawing.Point(24, 18);
            this.lBienvenida.Name = "lBienvenida";
            this.lBienvenida.Size = new System.Drawing.Size(290, 25);
            this.lBienvenida.TabIndex = 0;
            this.lBienvenida.Text = "¡¡¡Bienbenid@ a nuestro taller!!!";
            // 
            // bLogin
            // 
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.Location = new System.Drawing.Point(29, 182);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(285, 32);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "Iniciar sesión";
            this.bLogin.UseVisualStyleBackColor = true;
            // 
            // infoError
            // 
            this.infoError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.infoError.ContainerControl = this;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 239);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.lBienvenida);
            this.Controls.Add(this.tbContrasenia);
            this.Controls.Add(this.lContrasenia);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombre);
            this.Name = "fLogin";
            this.Text = "Taller: Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)(this.infoError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lContrasenia;
        private System.Windows.Forms.TextBox tbContrasenia;
        private System.Windows.Forms.Label lBienvenida;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.ErrorProvider infoError;
    }
}


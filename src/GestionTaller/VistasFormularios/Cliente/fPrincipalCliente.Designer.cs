namespace GestionTaller.VistasFormularios.Cliente
{
   partial class fPrincipalCliente
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
            lBienvenida = new Label();
            bCita = new Button();
            bVehiculos = new Button();
            SuspendLayout();
            // 
            // lBienvenida
            // 
            lBienvenida.AutoSize = true;
            lBienvenida.Location = new Point(141, 58);
            lBienvenida.Name = "lBienvenida";
            lBienvenida.Size = new Size(85, 15);
            lBienvenida.TabIndex = 0;
            lBienvenida.Text = "¡¡¡Bienvenid@!!";
            // 
            // bCita
            // 
            bCita.Location = new Point(56, 94);
            bCita.Name = "bCita";
            bCita.Size = new Size(245, 59);
            bCita.TabIndex = 1;
            bCita.Text = "Pedir Cita";
            bCita.UseVisualStyleBackColor = true;
            bCita.Click += Controlador_Click;
            // 
            // bVehiculos
            // 
            bVehiculos.Location = new Point(56, 178);
            bVehiculos.Name = "bVehiculos";
            bVehiculos.Size = new Size(245, 59);
            bVehiculos.TabIndex = 2;
            bVehiculos.Text = "Agregar Vehículo";
            bVehiculos.UseVisualStyleBackColor = true;
            bVehiculos.Click += Controlador_Click;
            // 
            // fPrincipalCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 297);
            Controls.Add(bVehiculos);
            Controls.Add(bCita);
            Controls.Add(lBienvenida);
            Name = "fPrincipalCliente";
            Text = "Taller: Bienvenida al Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lBienvenida;
      private Button bCita;
      private Button bVehiculos;
   }
}
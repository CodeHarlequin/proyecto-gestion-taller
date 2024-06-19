namespace GestionTaller.VistasFormularios.Mecanico
{
   partial class fModificarReparacion
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
         tbMatricula = new TextBox();
         tbModelo = new TextBox();
         tbTipo = new TextBox();
         lTipo = new Label();
         tbMarca = new TextBox();
         lModelo = new Label();
         lMatricula = new Label();
         lMarca = new Label();
         tbNBastidor = new TextBox();
         NBastidor = new Label();
         bGuardar = new Button();
         lOperaciones = new Label();
         lVehiculos = new Label();
         clbOperaciones = new CheckedListBox();
         SuspendLayout();
         // 
         // tbMatricula
         // 
         tbMatricula.Enabled = false;
         tbMatricula.Location = new Point(193, 66);
         tbMatricula.Name = "tbMatricula";
         tbMatricula.Size = new Size(148, 23);
         tbMatricula.TabIndex = 4;
         // 
         // tbModelo
         // 
         tbModelo.Enabled = false;
         tbModelo.Location = new Point(193, 119);
         tbModelo.Name = "tbModelo";
         tbModelo.Size = new Size(148, 23);
         tbModelo.TabIndex = 8;
         // 
         // tbTipo
         // 
         tbTipo.Enabled = false;
         tbTipo.Location = new Point(358, 119);
         tbTipo.Name = "tbTipo";
         tbTipo.Size = new Size(148, 23);
         tbTipo.TabIndex = 10;
         // 
         // lTipo
         // 
         lTipo.AutoSize = true;
         lTipo.Location = new Point(358, 101);
         lTipo.Name = "lTipo";
         lTipo.Size = new Size(30, 15);
         lTipo.TabIndex = 9;
         lTipo.Text = "Tipo";
         // 
         // tbMarca
         // 
         tbMarca.Enabled = false;
         tbMarca.Location = new Point(29, 119);
         tbMarca.Name = "tbMarca";
         tbMarca.Size = new Size(148, 23);
         tbMarca.TabIndex = 6;
         // 
         // lModelo
         // 
         lModelo.AutoSize = true;
         lModelo.Location = new Point(193, 101);
         lModelo.Name = "lModelo";
         lModelo.Size = new Size(48, 15);
         lModelo.TabIndex = 7;
         lModelo.Text = "Modelo";
         // 
         // lMatricula
         // 
         lMatricula.AutoSize = true;
         lMatricula.Location = new Point(193, 48);
         lMatricula.Name = "lMatricula";
         lMatricula.Size = new Size(57, 15);
         lMatricula.TabIndex = 3;
         lMatricula.Text = "Matricula";
         // 
         // lMarca
         // 
         lMarca.AutoSize = true;
         lMarca.Location = new Point(29, 101);
         lMarca.Name = "lMarca";
         lMarca.Size = new Size(40, 15);
         lMarca.TabIndex = 5;
         lMarca.Text = "Marca";
         // 
         // tbNBastidor
         // 
         tbNBastidor.Enabled = false;
         tbNBastidor.Location = new Point(29, 69);
         tbNBastidor.Name = "tbNBastidor";
         tbNBastidor.Size = new Size(148, 23);
         tbNBastidor.TabIndex = 2;
         // 
         // NBastidor
         // 
         NBastidor.AutoSize = true;
         NBastidor.Location = new Point(29, 51);
         NBastidor.Name = "NBastidor";
         NBastidor.Size = new Size(119, 15);
         NBastidor.TabIndex = 1;
         NBastidor.Text = "Numero de bastidor: ";
         // 
         // bGuardar
         // 
         bGuardar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
         bGuardar.Location = new Point(29, 371);
         bGuardar.Margin = new Padding(4, 3, 4, 3);
         bGuardar.Name = "bGuardar";
         bGuardar.Size = new Size(618, 37);
         bGuardar.TabIndex = 13;
         bGuardar.Text = "Guardar";
         bGuardar.UseVisualStyleBackColor = true;
         // 
         // lOperaciones
         // 
         lOperaciones.AutoSize = true;
         lOperaciones.Location = new Point(29, 168);
         lOperaciones.Margin = new Padding(4, 0, 4, 0);
         lOperaciones.Name = "lOperaciones";
         lOperaciones.Size = new Size(103, 15);
         lOperaciones.TabIndex = 11;
         lOperaciones.Text = "Lista Operaciones:";
         // 
         // lVehiculos
         // 
         lVehiculos.AutoSize = true;
         lVehiculos.Location = new Point(29, 23);
         lVehiculos.Margin = new Padding(4, 0, 4, 0);
         lVehiculos.Name = "lVehiculos";
         lVehiculos.Size = new Size(107, 15);
         lVehiculos.TabIndex = 0;
         lVehiculos.Text = "Datos del Vehículo:";
         // 
         // clbOperaciones
         // 
         clbOperaciones.FormattingEnabled = true;
         clbOperaciones.Location = new Point(29, 186);
         clbOperaciones.Name = "clbOperaciones";
         clbOperaciones.Size = new Size(618, 166);
         clbOperaciones.TabIndex = 12;
         // 
         // fModificarReparacion
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(685, 445);
         Controls.Add(clbOperaciones);
         Controls.Add(tbMatricula);
         Controls.Add(tbModelo);
         Controls.Add(tbTipo);
         Controls.Add(lTipo);
         Controls.Add(tbMarca);
         Controls.Add(lModelo);
         Controls.Add(lMatricula);
         Controls.Add(lMarca);
         Controls.Add(tbNBastidor);
         Controls.Add(NBastidor);
         Controls.Add(bGuardar);
         Controls.Add(lOperaciones);
         Controls.Add(lVehiculos);
         Name = "fModificarReparacion";
         Text = "Taller: Modificar Reparaciones";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private TextBox tbMatricula;
      private TextBox tbModelo;
      private TextBox tbTipo;
      private Label lTipo;
      private TextBox tbMarca;
      private Label lModelo;
      private Label lMatricula;
      private Label lMarca;
      private TextBox tbNBastidor;
      private Label NBastidor;
      private Button bGuardar;
      private Label lOperaciones;
      private Label lVehiculos;
      private CheckedListBox clbOperaciones;
   }
}
namespace GestionTaller.VistasFormularios.Propietario
{
   partial class fPresupuesto
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
         bGuardar = new Button();
         tbDescripcion = new TextBox();
         lDescipcion = new Label();
         lVehiculos = new Label();
         lPresupuesto = new Label();
         nudPresupuesto = new NumericUpDown();
         NBastidor = new Label();
         tbNBastidor = new TextBox();
         lMarca = new Label();
         lMatricula = new Label();
         lModelo = new Label();
         tbMarca = new TextBox();
         tbTipo = new TextBox();
         lTipo = new Label();
         tbModelo = new TextBox();
         tbMatricula = new TextBox();
         ((System.ComponentModel.ISupportInitialize)nudPresupuesto).BeginInit();
         SuspendLayout();
         // 
         // bGuardar
         // 
         bGuardar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
         bGuardar.Location = new Point(37, 374);
         bGuardar.Margin = new Padding(4, 3, 4, 3);
         bGuardar.Name = "bGuardar";
         bGuardar.Size = new Size(614, 37);
         bGuardar.TabIndex = 16;
         bGuardar.Text = "Guardar";
         bGuardar.UseVisualStyleBackColor = true;
         // 
         // tbDescripcion
         // 
         tbDescripcion.Enabled = false;
         tbDescripcion.Location = new Point(37, 190);
         tbDescripcion.Margin = new Padding(4, 3, 4, 3);
         tbDescripcion.MaxLength = 300;
         tbDescripcion.Multiline = true;
         tbDescripcion.Name = "tbDescripcion";
         tbDescripcion.Size = new Size(613, 101);
         tbDescripcion.TabIndex = 13;
         // 
         // lDescipcion
         // 
         lDescipcion.AutoSize = true;
         lDescipcion.Location = new Point(33, 171);
         lDescipcion.Margin = new Padding(4, 0, 4, 0);
         lDescipcion.Name = "lDescipcion";
         lDescipcion.Size = new Size(72, 15);
         lDescipcion.TabIndex = 12;
         lDescipcion.Text = "Descripción:";
         // 
         // lVehiculos
         // 
         lVehiculos.AutoSize = true;
         lVehiculos.Location = new Point(33, 26);
         lVehiculos.Margin = new Padding(4, 0, 4, 0);
         lVehiculos.Name = "lVehiculos";
         lVehiculos.Size = new Size(107, 15);
         lVehiculos.TabIndex = 0;
         lVehiculos.Text = "Datos del Vehículo:";
         // 
         // lPresupuesto
         // 
         lPresupuesto.AutoSize = true;
         lPresupuesto.Location = new Point(33, 308);
         lPresupuesto.Margin = new Padding(4, 0, 4, 0);
         lPresupuesto.Name = "lPresupuesto";
         lPresupuesto.Size = new Size(75, 15);
         lPresupuesto.TabIndex = 14;
         lPresupuesto.Text = "Presupuesto:";
         // 
         // nudPresupuesto
         // 
         nudPresupuesto.DecimalPlaces = 2;
         nudPresupuesto.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
         nudPresupuesto.Location = new Point(37, 327);
         nudPresupuesto.Margin = new Padding(4, 3, 4, 3);
         nudPresupuesto.Maximum = new decimal(new int[] { 400000000, 0, 0, 0 });
         nudPresupuesto.Name = "nudPresupuesto";
         nudPresupuesto.Size = new Size(140, 23);
         nudPresupuesto.TabIndex = 15;
         // 
         // NBastidor
         // 
         NBastidor.AutoSize = true;
         NBastidor.Location = new Point(33, 54);
         NBastidor.Name = "NBastidor";
         NBastidor.Size = new Size(119, 15);
         NBastidor.TabIndex = 1;
         NBastidor.Text = "Numero de bastidor: ";
         // 
         // tbNBastidor
         // 
         tbNBastidor.Enabled = false;
         tbNBastidor.Location = new Point(33, 72);
         tbNBastidor.Name = "tbNBastidor";
         tbNBastidor.Size = new Size(148, 23);
         tbNBastidor.TabIndex = 2;
         // 
         // lMarca
         // 
         lMarca.AutoSize = true;
         lMarca.Location = new Point(33, 104);
         lMarca.Name = "lMarca";
         lMarca.Size = new Size(40, 15);
         lMarca.TabIndex = 5;
         lMarca.Text = "Marca";
         // 
         // lMatricula
         // 
         lMatricula.AutoSize = true;
         lMatricula.Location = new Point(197, 51);
         lMatricula.Name = "lMatricula";
         lMatricula.Size = new Size(57, 15);
         lMatricula.TabIndex = 3;
         lMatricula.Text = "Matricula";
         // 
         // lModelo
         // 
         lModelo.AutoSize = true;
         lModelo.Location = new Point(197, 104);
         lModelo.Name = "lModelo";
         lModelo.Size = new Size(48, 15);
         lModelo.TabIndex = 8;
         lModelo.Text = "Modelo";
         // 
         // tbMarca
         // 
         tbMarca.Enabled = false;
         tbMarca.Location = new Point(33, 122);
         tbMarca.Name = "tbMarca";
         tbMarca.Size = new Size(148, 23);
         tbMarca.TabIndex = 6;
         // 
         // tbTipo
         // 
         tbTipo.Enabled = false;
         tbTipo.Location = new Point(362, 122);
         tbTipo.Name = "tbTipo";
         tbTipo.Size = new Size(148, 23);
         tbTipo.TabIndex = 11;
         // 
         // lTipo
         // 
         lTipo.AutoSize = true;
         lTipo.Location = new Point(362, 104);
         lTipo.Name = "lTipo";
         lTipo.Size = new Size(30, 15);
         lTipo.TabIndex = 10;
         lTipo.Text = "Tipo";
         // 
         // tbModelo
         // 
         tbModelo.Enabled = false;
         tbModelo.Location = new Point(197, 122);
         tbModelo.Name = "tbModelo";
         tbModelo.Size = new Size(148, 23);
         tbModelo.TabIndex = 9;
         // 
         // tbMatricula
         // 
         tbMatricula.Enabled = false;
         tbMatricula.Location = new Point(197, 69);
         tbMatricula.Name = "tbMatricula";
         tbMatricula.Size = new Size(148, 23);
         tbMatricula.TabIndex = 4;
         // 
         // fPresupuesto
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(685, 445);
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
         Controls.Add(nudPresupuesto);
         Controls.Add(lPresupuesto);
         Controls.Add(bGuardar);
         Controls.Add(tbDescripcion);
         Controls.Add(lDescipcion);
         Controls.Add(lVehiculos);
         Margin = new Padding(4, 3, 4, 3);
         Name = "fPresupuesto";
         Text = "Taller: Asignación del presupuesto";
         ((System.ComponentModel.ISupportInitialize)nudPresupuesto).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Button bGuardar;
      private TextBox tbDescripcion;
      private Label lDescipcion;
      private Label lVehiculos;
      private Label lPresupuesto;
      private NumericUpDown nudPresupuesto;
      private Label NBastidor;
      private TextBox tbNBastidor;
      private Label lMarca;
      private Label lMatricula;
      private Label lModelo;
      private Label label4;
      private TextBox textBox3;
      private TextBox textBox4;
      private TextBox tbMarca;
      private TextBox tbTipo;
      private Label lTipo;
      private TextBox tbModelo;
      private TextBox tbMatricula;
   }
}
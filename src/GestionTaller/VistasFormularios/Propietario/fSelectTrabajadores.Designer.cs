namespace GestionTaller.VistasFormularios.Propietario
{
   partial class fSelectTrabajadores
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
         lMecanicos = new Label();
         bGuardar = new Button();
         lJefe = new Label();
         cbJefe = new ComboBox();
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
         lVehiculos = new Label();
         clbMecanicos = new CheckedListBox();
         SuspendLayout();
         // 
         // lMecanicos
         // 
         lMecanicos.AutoSize = true;
         lMecanicos.Location = new Point(21, 220);
         lMecanicos.Margin = new Padding(4, 0, 4, 0);
         lMecanicos.Name = "lMecanicos";
         lMecanicos.Size = new Size(144, 15);
         lMecanicos.TabIndex = 4;
         lMecanicos.Text = "Seleccione los Mecánicos:";
         // 
         // bGuardar
         // 
         bGuardar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
         bGuardar.Location = new Point(21, 368);
         bGuardar.Margin = new Padding(4, 3, 4, 3);
         bGuardar.Name = "bGuardar";
         bGuardar.Size = new Size(617, 37);
         bGuardar.TabIndex = 6;
         bGuardar.Text = "Guardar";
         bGuardar.UseVisualStyleBackColor = true;
         bGuardar.Click += bGuardar_Click;
         // 
         // lJefe
         // 
         lJefe.AutoSize = true;
         lJefe.Location = new Point(21, 177);
         lJefe.Margin = new Padding(4, 0, 4, 0);
         lJefe.Name = "lJefe";
         lJefe.Size = new Size(101, 15);
         lJefe.TabIndex = 2;
         lJefe.Text = "Seleccione el Jefe:";
         // 
         // cbJefe
         // 
         cbJefe.DropDownStyle = ComboBoxStyle.DropDownList;
         cbJefe.FormattingEnabled = true;
         cbJefe.Location = new Point(141, 173);
         cbJefe.Margin = new Padding(4, 3, 4, 3);
         cbJefe.Name = "cbJefe";
         cbJefe.Size = new Size(496, 23);
         cbJefe.TabIndex = 3;
         cbJefe.DropDown += cbJefe_DropDown;
         cbJefe.SelectedIndexChanged += cbJefe_SelectedIndexChanged;
         // 
         // tbMatricula
         // 
         tbMatricula.Enabled = false;
         tbMatricula.Location = new Point(188, 70);
         tbMatricula.Name = "tbMatricula";
         tbMatricula.Size = new Size(139, 23);
         tbMatricula.TabIndex = 32;
         // 
         // tbModelo
         // 
         tbModelo.Enabled = false;
         tbModelo.Location = new Point(188, 123);
         tbModelo.Name = "tbModelo";
         tbModelo.Size = new Size(148, 23);
         tbModelo.TabIndex = 31;
         // 
         // tbTipo
         // 
         tbTipo.Enabled = false;
         tbTipo.Location = new Point(353, 123);
         tbTipo.Name = "tbTipo";
         tbTipo.Size = new Size(144, 23);
         tbTipo.TabIndex = 30;
         // 
         // lTipo
         // 
         lTipo.AutoSize = true;
         lTipo.Location = new Point(353, 105);
         lTipo.Name = "lTipo";
         lTipo.Size = new Size(30, 15);
         lTipo.TabIndex = 29;
         lTipo.Text = "Tipo";
         // 
         // tbMarca
         // 
         tbMarca.Enabled = false;
         tbMarca.Location = new Point(24, 123);
         tbMarca.Name = "tbMarca";
         tbMarca.Size = new Size(148, 23);
         tbMarca.TabIndex = 28;
         // 
         // lModelo
         // 
         lModelo.AutoSize = true;
         lModelo.Location = new Point(188, 105);
         lModelo.Name = "lModelo";
         lModelo.Size = new Size(48, 15);
         lModelo.TabIndex = 27;
         lModelo.Text = "Modelo";
         // 
         // lMatricula
         // 
         lMatricula.AutoSize = true;
         lMatricula.Location = new Point(188, 52);
         lMatricula.Name = "lMatricula";
         lMatricula.Size = new Size(57, 15);
         lMatricula.TabIndex = 26;
         lMatricula.Text = "Matricula";
         // 
         // lMarca
         // 
         lMarca.AutoSize = true;
         lMarca.Location = new Point(24, 105);
         lMarca.Name = "lMarca";
         lMarca.Size = new Size(40, 15);
         lMarca.TabIndex = 25;
         lMarca.Text = "Marca";
         // 
         // tbNBastidor
         // 
         tbNBastidor.Enabled = false;
         tbNBastidor.Location = new Point(24, 73);
         tbNBastidor.Name = "tbNBastidor";
         tbNBastidor.Size = new Size(148, 23);
         tbNBastidor.TabIndex = 24;
         // 
         // NBastidor
         // 
         NBastidor.AutoSize = true;
         NBastidor.Location = new Point(24, 55);
         NBastidor.Name = "NBastidor";
         NBastidor.Size = new Size(119, 15);
         NBastidor.TabIndex = 23;
         NBastidor.Text = "Numero de bastidor: ";
         // 
         // lVehiculos
         // 
         lVehiculos.AutoSize = true;
         lVehiculos.Location = new Point(24, 27);
         lVehiculos.Margin = new Padding(4, 0, 4, 0);
         lVehiculos.Name = "lVehiculos";
         lVehiculos.Size = new Size(107, 15);
         lVehiculos.TabIndex = 22;
         lVehiculos.Text = "Datos del Vehículo:";
         // 
         // clbMecanicos
         // 
         clbMecanicos.FormattingEnabled = true;
         clbMecanicos.Location = new Point(21, 238);
         clbMecanicos.Name = "clbMecanicos";
         clbMecanicos.Size = new Size(617, 112);
         clbMecanicos.TabIndex = 33;
         // 
         // fSelectTrabajadores
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(665, 427);
         Controls.Add(clbMecanicos);
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
         Controls.Add(lVehiculos);
         Controls.Add(cbJefe);
         Controls.Add(lMecanicos);
         Controls.Add(bGuardar);
         Controls.Add(lJefe);
         Margin = new Padding(4, 3, 4, 3);
         Name = "fSelectTrabajadores";
         Text = "Taller: Asignación de mecánicos";
         Load += fSelectTrabajadores_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private Label lMecanicos;
      private Button bGuardar;
      private Label lJefe;
      private ComboBox cbJefe;
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
      private Label lVehiculos;
      private CheckedListBox clbMecanicos;
   }
}
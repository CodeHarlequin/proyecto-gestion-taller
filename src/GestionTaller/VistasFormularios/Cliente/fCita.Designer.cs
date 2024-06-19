namespace GestionTaller
{
   partial class fCita
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
         lVehiculos = new Label();
         lbVehiculos = new ListBox();
         lFechaHora = new Label();
         lDescipcion = new Label();
         tbDescripcion = new TextBox();
         dtpFecha = new DateTimePicker();
         bGuardar = new Button();
         mtbHora = new MaskedTextBox();
         ((System.ComponentModel.ISupportInitialize)infoError).BeginInit();
         SuspendLayout();
         // 
         // infoError
         // 
         infoError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
         infoError.ContainerControl = this;
         // 
         // lVehiculos
         // 
         lVehiculos.AutoSize = true;
         lVehiculos.Location = new Point(26, 20);
         lVehiculos.Margin = new Padding(4, 0, 4, 0);
         lVehiculos.Name = "lVehiculos";
         lVehiculos.Size = new Size(103, 15);
         lVehiculos.TabIndex = 0;
         lVehiculos.Text = "Lista de Vehículos:";
         // 
         // lbVehiculos
         // 
         lbVehiculos.FormattingEnabled = true;
         lbVehiculos.HorizontalScrollbar = true;
         lbVehiculos.ItemHeight = 15;
         lbVehiculos.Location = new Point(29, 38);
         lbVehiculos.Margin = new Padding(4, 3, 4, 3);
         lbVehiculos.Name = "lbVehiculos";
         lbVehiculos.ScrollAlwaysVisible = true;
         lbVehiculos.Size = new Size(613, 109);
         lbVehiculos.TabIndex = 1;
         // 
         // lFechaHora
         // 
         lFechaHora.AutoSize = true;
         lFechaHora.Location = new Point(26, 172);
         lFechaHora.Margin = new Padding(4, 0, 4, 0);
         lFechaHora.Name = "lFechaHora";
         lFechaHora.Size = new Size(79, 15);
         lFechaHora.TabIndex = 2;
         lFechaHora.Text = "Fecha y Hora:";
         // 
         // lDescipcion
         // 
         lDescipcion.AutoSize = true;
         lDescipcion.Location = new Point(26, 218);
         lDescipcion.Margin = new Padding(4, 0, 4, 0);
         lDescipcion.Name = "lDescipcion";
         lDescipcion.Size = new Size(72, 15);
         lDescipcion.TabIndex = 4;
         lDescipcion.Text = "Descripción:";
         // 
         // tbDescripcion
         // 
         tbDescripcion.Location = new Point(29, 237);
         tbDescripcion.Margin = new Padding(4, 3, 4, 3);
         tbDescripcion.MaxLength = 300;
         tbDescripcion.Multiline = true;
         tbDescripcion.Name = "tbDescripcion";
         tbDescripcion.Size = new Size(613, 101);
         tbDescripcion.TabIndex = 5;
         // 
         // dtpFecha
         // 
         dtpFecha.CustomFormat = "dd/MM/yyyy";
         dtpFecha.Format = DateTimePickerFormat.Custom;
         dtpFecha.Location = new Point(119, 167);
         dtpFecha.Margin = new Padding(4, 3, 4, 3);
         dtpFecha.Name = "dtpFecha";
         dtpFecha.Size = new Size(114, 23);
         dtpFecha.TabIndex = 3;
         dtpFecha.Value = new DateTime(2024, 6, 18, 0, 0, 0, 0);
         // 
         // bGuardar
         // 
         bGuardar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
         bGuardar.Location = new Point(442, 358);
         bGuardar.Margin = new Padding(4, 3, 4, 3);
         bGuardar.Name = "bGuardar";
         bGuardar.Size = new Size(201, 37);
         bGuardar.TabIndex = 9;
         bGuardar.Text = "Guardar";
         bGuardar.UseVisualStyleBackColor = true;
         // 
         // mtbHora
         // 
         mtbHora.Location = new Point(239, 166);
         mtbHora.Mask = "00:00";
         mtbHora.Name = "mtbHora";
         mtbHora.Size = new Size(30, 23);
         mtbHora.TabIndex = 10;
         mtbHora.ValidatingType = typeof(DateTime);
         // 
         // fCita
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(672, 420);
         Controls.Add(mtbHora);
         Controls.Add(bGuardar);
         Controls.Add(dtpFecha);
         Controls.Add(tbDescripcion);
         Controls.Add(lDescipcion);
         Controls.Add(lFechaHora);
         Controls.Add(lbVehiculos);
         Controls.Add(lVehiculos);
         Margin = new Padding(4, 3, 4, 3);
         Name = "fCita";
         Text = "Taller: Pedir Cita";
         ((System.ComponentModel.ISupportInitialize)infoError).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private ErrorProvider infoError;
      private TextBox tbDescripcion;
      private Label lDescipcion;
      private Label lFechaHora;
      private ListBox lbVehiculos;
      private Label lVehiculos;
      private DateTimePicker dtpFecha;
      private Button bGuardar;
      private MaskedTextBox mtbHora;
   }
}


namespace GestionTaller
{
   partial class fReparaciones
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
         DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
         infoError = new ErrorProvider(components);
         lReparaciones = new Label();
         bPresupuesto = new Button();
         bTrabajadores = new Button();
         dgvReparaciones = new DataGridView();
         ((System.ComponentModel.ISupportInitialize)infoError).BeginInit();
         ((System.ComponentModel.ISupportInitialize)dgvReparaciones).BeginInit();
         SuspendLayout();
         // 
         // infoError
         // 
         infoError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
         infoError.ContainerControl = this;
         // 
         // lReparaciones
         // 
         lReparaciones.AutoSize = true;
         lReparaciones.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
         lReparaciones.Location = new Point(29, 21);
         lReparaciones.Margin = new Padding(4, 0, 4, 0);
         lReparaciones.Name = "lReparaciones";
         lReparaciones.Size = new Size(187, 22);
         lReparaciones.TabIndex = 0;
         lReparaciones.Text = "Lista de reparaciones:";
         // 
         // bPresupuesto
         // 
         bPresupuesto.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
         bPresupuesto.Location = new Point(34, 388);
         bPresupuesto.Margin = new Padding(4, 3, 4, 3);
         bPresupuesto.Name = "bPresupuesto";
         bPresupuesto.Size = new Size(308, 37);
         bPresupuesto.TabIndex = 2;
         bPresupuesto.Text = "Asignar Presupuesto";
         bPresupuesto.UseVisualStyleBackColor = true;
         // 
         // bTrabajadores
         // 
         bTrabajadores.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
         bTrabajadores.Location = new Point(343, 388);
         bTrabajadores.Margin = new Padding(4, 3, 4, 3);
         bTrabajadores.Name = "bTrabajadores";
         bTrabajadores.Size = new Size(308, 37);
         bTrabajadores.TabIndex = 3;
         bTrabajadores.Text = "Asignar Trabajadores";
         bTrabajadores.UseVisualStyleBackColor = true;
         // 
         // dgvReparaciones
         // 
         dgvReparaciones.AllowUserToAddRows = false;
         dgvReparaciones.AllowUserToDeleteRows = false;
         dgvReparaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = SystemColors.Control;
         dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
         dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
         dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
         dgvReparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         dgvReparaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         dgvReparaciones.Location = new Point(34, 59);
         dgvReparaciones.Name = "dgvReparaciones";
         dgvReparaciones.ReadOnly = true;
         dgvReparaciones.RowTemplate.Height = 25;
         dgvReparaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         dgvReparaciones.Size = new Size(617, 304);
         dgvReparaciones.TabIndex = 1;
         // 
         // fReparaciones
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(685, 445);
         Controls.Add(dgvReparaciones);
         Controls.Add(bTrabajadores);
         Controls.Add(bPresupuesto);
         Controls.Add(lReparaciones);
         Margin = new Padding(4, 3, 4, 3);
         Name = "fReparaciones";
         Text = "Taller: Gestión de Reparaciones";
         ((System.ComponentModel.ISupportInitialize)infoError).EndInit();
         ((System.ComponentModel.ISupportInitialize)dgvReparaciones).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
      private ErrorProvider infoError;
      private Label lReparaciones;
      private Button bPresupuesto;
      private Button bTrabajadores;
      private DataGridView dgvReparaciones;
   }
}


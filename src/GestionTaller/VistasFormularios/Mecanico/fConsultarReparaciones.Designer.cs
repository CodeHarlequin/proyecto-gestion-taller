namespace GestionTaller.VistasFormularios.Mecanico
{
   partial class fConsultarReparaciones
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
         DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
         dgvReparaciones = new DataGridView();
         bModificar = new Button();
         lReparaciones = new Label();
         ((System.ComponentModel.ISupportInitialize)dgvReparaciones).BeginInit();
         SuspendLayout();
         // 
         // dgvReparaciones
         // 
         dgvReparaciones.AllowUserToAddRows = false;
         dgvReparaciones.AllowUserToDeleteRows = false;
         dgvReparaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = SystemColors.Control;
         dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
         dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
         dataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue;
         dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
         dgvReparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
         dgvReparaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         dgvReparaciones.Location = new Point(31, 61);
         dgvReparaciones.Name = "dgvReparaciones";
         dgvReparaciones.ReadOnly = true;
         dgvReparaciones.RowTemplate.Height = 25;
         dgvReparaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         dgvReparaciones.Size = new Size(617, 304);
         dgvReparaciones.TabIndex = 1;
         // 
         // bModificar
         // 
         bModificar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
         bModificar.Location = new Point(31, 390);
         bModificar.Margin = new Padding(4, 3, 4, 3);
         bModificar.Name = "bModificar";
         bModificar.Size = new Size(617, 37);
         bModificar.TabIndex = 2;
         bModificar.Text = "Modificar Reparación";
         bModificar.UseVisualStyleBackColor = true;
         // 
         // lReparaciones
         // 
         lReparaciones.AutoSize = true;
         lReparaciones.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
         lReparaciones.Location = new Point(26, 23);
         lReparaciones.Margin = new Padding(4, 0, 4, 0);
         lReparaciones.Name = "lReparaciones";
         lReparaciones.Size = new Size(187, 22);
         lReparaciones.TabIndex = 0;
         lReparaciones.Text = "Lista de reparaciones:";
         // 
         // fConsultarReparaciones
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(685, 445);
         Controls.Add(dgvReparaciones);
         Controls.Add(bModificar);
         Controls.Add(lReparaciones);
         Name = "fConsultarReparaciones";
         Text = "Taller: Modificar Reparaciones";
         ((System.ComponentModel.ISupportInitialize)dgvReparaciones).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private DataGridView dgvReparaciones;
      private Button bModificar;
      private Label lReparaciones;
   }
}
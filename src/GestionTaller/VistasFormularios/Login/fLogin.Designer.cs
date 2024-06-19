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
         components = new System.ComponentModel.Container();
         lUsuario = new Label();
         lContrasenia = new Label();
         tbContrasenia = new TextBox();
         lBienvenida = new Label();
         bLogin = new Button();
         infoError = new ErrorProvider(components);
         mtbUsuario = new MaskedTextBox();
         lTipo = new Label();
         cbTipoUsuario = new ComboBox();
         ((System.ComponentModel.ISupportInitialize)infoError).BeginInit();
         SuspendLayout();
         // 
         // lUsuario
         // 
         lUsuario.AutoSize = true;
         lUsuario.Location = new Point(98, 113);
         lUsuario.Margin = new Padding(4, 0, 4, 0);
         lUsuario.Name = "lUsuario";
         lUsuario.Size = new Size(50, 15);
         lUsuario.TabIndex = 3;
         lUsuario.Text = "Usuario:";
         // 
         // lContrasenia
         // 
         lContrasenia.AutoSize = true;
         lContrasenia.Location = new Point(78, 161);
         lContrasenia.Margin = new Padding(4, 0, 4, 0);
         lContrasenia.Name = "lContrasenia";
         lContrasenia.Size = new Size(66, 15);
         lContrasenia.TabIndex = 5;
         lContrasenia.Text = "Contaseña:";
         // 
         // tbContrasenia
         // 
         tbContrasenia.Location = new Point(156, 158);
         tbContrasenia.Margin = new Padding(4, 3, 4, 3);
         tbContrasenia.MaxLength = 30;
         tbContrasenia.Name = "tbContrasenia";
         tbContrasenia.Size = new Size(210, 23);
         tbContrasenia.TabIndex = 6;
         tbContrasenia.UseSystemPasswordChar = true;
         // 
         // lBienvenida
         // 
         lBienvenida.AutoSize = true;
         lBienvenida.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
         lBienvenida.Location = new Point(114, 18);
         lBienvenida.Margin = new Padding(4, 0, 4, 0);
         lBienvenida.Name = "lBienvenida";
         lBienvenida.Size = new Size(289, 25);
         lBienvenida.TabIndex = 0;
         lBienvenida.Text = "¡¡¡Bienvenid@ a nuestro taller!!!";
         // 
         // bLogin
         // 
         bLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
         bLogin.Location = new Point(88, 212);
         bLogin.Margin = new Padding(4, 3, 4, 3);
         bLogin.Name = "bLogin";
         bLogin.Size = new Size(332, 37);
         bLogin.TabIndex = 7;
         bLogin.Text = "Iniciar sesión";
         bLogin.UseVisualStyleBackColor = true;
         // 
         // infoError
         // 
         infoError.BlinkStyle = ErrorBlinkStyle.NeverBlink;
         infoError.ContainerControl = this;
         // 
         // mtbUsuario
         // 
         mtbUsuario.Location = new Point(156, 110);
         mtbUsuario.Margin = new Padding(4, 3, 4, 3);
         mtbUsuario.Mask = "00000000-L";
         mtbUsuario.Name = "mtbUsuario";
         mtbUsuario.Size = new Size(210, 23);
         mtbUsuario.TabIndex = 4;
         mtbUsuario.TextMaskFormat = MaskFormat.IncludePrompt;
         // 
         // lTipo
         // 
         lTipo.AutoSize = true;
         lTipo.Location = new Point(114, 71);
         lTipo.Name = "lTipo";
         lTipo.Size = new Size(33, 15);
         lTipo.TabIndex = 1;
         lTipo.Text = "Tipo:";
         // 
         // cbTipoUsuario
         // 
         cbTipoUsuario.FormattingEnabled = true;
         cbTipoUsuario.Location = new Point(156, 68);
         cbTipoUsuario.Name = "cbTipoUsuario";
         cbTipoUsuario.Size = new Size(210, 23);
         cbTipoUsuario.TabIndex = 2;
         // 
         // fLogin
         // 
         AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(524, 276);
         Controls.Add(cbTipoUsuario);
         Controls.Add(lTipo);
         Controls.Add(mtbUsuario);
         Controls.Add(bLogin);
         Controls.Add(lBienvenida);
         Controls.Add(tbContrasenia);
         Controls.Add(lContrasenia);
         Controls.Add(lUsuario);
         Margin = new Padding(4, 3, 4, 3);
         Name = "fLogin";
         Text = "Taller: Inicio de sesión";
         ((System.ComponentModel.ISupportInitialize)infoError).EndInit();
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Label lUsuario;
      private Label lContrasenia;
      private TextBox tbContrasenia;
      private Label lBienvenida;
      private Button bLogin;
      private ErrorProvider infoError;
      private MaskedTextBox mtbUsuario;
      private ComboBox cbTipoUsuario;
      private Label lTipo;
   }
}


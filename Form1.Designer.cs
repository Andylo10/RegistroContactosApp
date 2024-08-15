namespace RegistroContactosApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxNombre = new TextBox();
            TextBoxTelefono = new TextBox();
            TextBoxEmail = new TextBox();
            EtiquetaNombre = new Label();
            EtiquetaTelefono = new Label();
            EtiquetaEmail = new Label();
            ButtonLimpiar = new Button();
            ButtonAgregar = new Button();
            ListBoxContactos = new ListBox();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(231, 51);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(289, 23);
            TextBoxNombre.TabIndex = 0;
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(231, 96);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(289, 23);
            TextBoxTelefono.TabIndex = 1;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(231, 140);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(289, 23);
            TextBoxEmail.TabIndex = 2;
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.BackColor = SystemColors.InactiveCaption;
            EtiquetaNombre.ForeColor = SystemColors.ControlText;
            EtiquetaNombre.Location = new Point(136, 54);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(54, 15);
            EtiquetaNombre.TabIndex = 3;
            EtiquetaNombre.Text = "Nombre:";
            // 
            // EtiquetaTelefono
            // 
            EtiquetaTelefono.AutoSize = true;
            EtiquetaTelefono.BackColor = SystemColors.InactiveCaption;
            EtiquetaTelefono.Location = new Point(136, 99);
            EtiquetaTelefono.Name = "EtiquetaTelefono";
            EtiquetaTelefono.Size = new Size(55, 15);
            EtiquetaTelefono.TabIndex = 4;
            EtiquetaTelefono.Text = "Teléfono:";
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.BackColor = SystemColors.InactiveCaption;
            EtiquetaEmail.Location = new Point(117, 143);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(108, 15);
            EtiquetaEmail.TabIndex = 5;
            EtiquetaEmail.Text = "Correo Electrónico:";
            // 
            // ButtonLimpiar
            // 
            ButtonLimpiar.BackColor = Color.Turquoise;
            ButtonLimpiar.Location = new Point(348, 229);
            ButtonLimpiar.Name = "ButtonLimpiar";
            ButtonLimpiar.Size = new Size(122, 46);
            ButtonLimpiar.TabIndex = 6;
            ButtonLimpiar.Text = "Limpiar Campos";
            ButtonLimpiar.UseVisualStyleBackColor = false;
            ButtonLimpiar.Click += ButtonLimpiar_Click;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.BackColor = Color.CornflowerBlue;
            ButtonAgregar.ForeColor = SystemColors.ControlText;
            ButtonAgregar.Location = new Point(189, 229);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(122, 46);
            ButtonAgregar.TabIndex = 7;
            ButtonAgregar.Text = "Agregar Contacto";
            ButtonAgregar.UseVisualStyleBackColor = false;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ListBoxContactos
            // 
            ListBoxContactos.BackColor = Color.Plum;
            ListBoxContactos.FormattingEnabled = true;
            ListBoxContactos.ItemHeight = 15;
            ListBoxContactos.Location = new Point(117, 365);
            ListBoxContactos.Name = "ListBoxContactos";
            ListBoxContactos.Size = new Size(466, 154);
            ListBoxContactos.TabIndex = 8;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Location = new Point(265, 297);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(145, 15);
            LabelEstado.TabIndex = 9;
            LabelEstado.Text = "¿Desea Agregar Contacto?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 545);
            Controls.Add(LabelEstado);
            Controls.Add(ListBoxContactos);
            Controls.Add(ButtonAgregar);
            Controls.Add(ButtonLimpiar);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaTelefono);
            Controls.Add(EtiquetaNombre);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxTelefono);
            Controls.Add(TextBoxNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxNombre;
        private TextBox TextBoxTelefono;
        private TextBox TextBoxEmail;
        private Label EtiquetaNombre;
        private Label EtiquetaTelefono;
        private Label EtiquetaEmail;
        private Button ButtonLimpiar;
        private Button ButtonAgregar;
        private ListBox ListBoxContactos;
        private Label LabelEstado;
    }
}

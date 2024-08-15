namespace RegistroContactosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAgregar_Click(object sender, EventArgs e)
        {

            {

                string nombre = TextBoxNombre.Text.Trim();
                string telefono = TextBoxTelefono.Text.Trim();
                string email = TextBoxEmail.Text.Trim();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(email))
                {
                    LabelEstado.Text = "Por favor, complete todos los campos.";
                    LabelEstado.ForeColor = Color.Red;  
                }
                else
                {
    
                    string contacto = $"{nombre} - {telefono} - {email}";
                    ListBoxContactos.Items.Add(contacto);

                   
                    LabelEstado.Text = "Contacto agregado correctamente.";
                    LabelEstado.ForeColor = Color.Purple;

                   
                    TextBoxNombre.Clear();
                    TextBoxTelefono.Clear();
                    TextBoxEmail.Clear();
                }
            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            TextBoxNombre.Clear();
            TextBoxTelefono.Clear();
            TextBoxEmail.Clear();

            // Restablecer el mensaje de estado
            LabelEstado.Text = "";
        }

    }
 }

    

    
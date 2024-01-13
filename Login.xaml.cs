namespace jestrellaExamen;

public partial class Login : ContentPage
{
    private string[] users = { "estudiante2024", "examen1", "jefferson" };
    private string[] passwords = { "uisrael2024", "parcial1", "2024" };
    public Login()
	{
		InitializeComponent();
	}

    private void btnAcercade_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Presentacion());
    }
    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string enteredUsername = txtUsuario.Text;
        string enteredPassword = txtContrasena.Text;
        // Verificar credenciales
        bool isValidCredentials = CheckCredentials(enteredUsername, enteredPassword);
        if (isValidCredentials)
        {
            // Mostrar mensaje de bienvenida
            DisplayAlert("Bienvenido", $"Hola {enteredUsername}!", "OK");
            Navigation.PushAsync(new Registro(enteredUsername));
        }
        else
        {
            // Mostrar mensaje de error
            DisplayAlert("Error", "Credenciales invalidas", "OK");
        }
    }
    private bool CheckCredentials(string username, string password)
    {
        // Verificar si las credenciales coinciden
        for (int i = 0; i < users.Length; i++)
        {
            if (users[i] == username && passwords[i] == password)
            {
                return true;
            }
        }

        return false;
    }
}
    

    


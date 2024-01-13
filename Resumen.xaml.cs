namespace jestrellaExamen;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario, string fecha, string pais, string ciudad, double monto, double mensual, double total,
            string nombre, string apellido, double edad)
	{
        InitializeComponent();
        lblUsuario.Text = "Usuario Conectado: " + usuario;
        txtfecha.Text = fecha;
        txtapellido.Text = apellido;
        txtpais.Text = pais;
        txtciudad.Text = ciudad;
        txtinicial.Text = Convert.ToString(monto);
        txtmensual.Text = Convert.ToString(mensual);
        txttotal.Text = Convert.ToString(total);
        txtedad.Text = Convert.ToString(edad);
        txtnombre.Text = nombre;
    }

  
    private void btnsalir_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}
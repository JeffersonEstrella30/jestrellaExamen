namespace jestrellaExamen;

public partial class Registro : ContentPage
{
	string usuario1;
	public Registro(string usuario)
	{
		InitializeComponent();
        lblUsuarios.Text = "Usuario Conectado: " + usuario;
        usuario1 = usuario;
    }

    private void txtinicial_TextChanged(object sender, TextChangedEventArgs e)
    {
        try
        {
            double dato = Convert.ToDouble(txtinicial.Text);
            if (dato < 0 || dato > 1500)
            {
                DisplayAlert("Error", "El valor no esta en el rango", "Cerrar");
                txtinicial.Text = "";
            }
            else
            {

            }
        }
        catch (Exception ex)
        {

        }
    }

    private void btnpmensual_Clicked(object sender, EventArgs e)
    {
        double pmensual = (1500 - Convert.ToDouble(txtinicial.Text)) / 4;
        double iva = (1500 * 4) / 100;
        double ptotal = pmensual + iva;
        txtmensual.Text = ptotal.ToString();

    }

    private void btnpresumen_Clicked(object sender, EventArgs e)
    {
        //(pago mensual*4+monto inicial)pago total
        //100/4+4% 1500
        string fecha = Fecha.Date.ToString();
        //Pickpais.Items[Pickpais.SelectedIndex];
        string pais = Pickpais.Items[Pickpais.SelectedIndex];
        string ciudad = PickCiudad.Items[PickCiudad.SelectedIndex];
        double monto = Convert.ToDouble(txtinicial.Text);
        //txtinicial.ToString();
        double mensual = Convert.ToDouble(txtmensual.Text);
        double total = ((Convert.ToDouble(txtmensual.Text) * 4) + Convert.ToDouble(txtinicial.Text));
        string nombre = txtnombre.Text;
        string apellido = txtapellido.Text;
        int edad = Convert.ToInt32(txtedad.Text);
        Navigation.PushAsync(new Resumen(usuario1, fecha, pais, ciudad, monto, mensual, total, nombre, apellido, edad));
    }
}
    

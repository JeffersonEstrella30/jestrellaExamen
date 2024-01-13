namespace jestrellaExamen;

public partial class Presentacion : ContentPage
{
	public Presentacion()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}
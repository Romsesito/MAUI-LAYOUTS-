namespace ProyectoMAUI;

public partial class FlexLayoutJordan : ContentPage
{
	public FlexLayoutJordan()
	{
		InitializeComponent();
	}

    private async void OnImageTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayoutJordan());
    }
}
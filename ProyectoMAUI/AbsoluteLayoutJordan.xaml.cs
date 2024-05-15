namespace ProyectoMAUI;

public partial class AbsoluteLayoutJordan : ContentPage
{
	public AbsoluteLayoutJordan()
	{
		InitializeComponent();
	}
    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
namespace ProyectoMAUI;

public partial class FlexLayoutJordan : ContentPage
{
	public FlexLayoutJordan()
	{
		InitializeComponent();
	}

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayoutJordan());
    }
}
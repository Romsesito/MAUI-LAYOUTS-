namespace ProyectoMAUI;

public partial class StackLayoutJordan : ContentPage
{
	public StackLayoutJordan()
	{
		InitializeComponent();
	}
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayoutJordan());
    }
}
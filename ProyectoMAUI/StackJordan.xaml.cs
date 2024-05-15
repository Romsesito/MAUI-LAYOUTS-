using Microsoft.Maui.Graphics;

using Microsoft.Maui.Controls;
namespace ProyectoMAUI;


public partial class StackJordan : ContentPage
{
	public StackJordan()
	{
        Title = "Vertical StackLayout demo";
        Content = new StackLayout
        {
            Margin = new Thickness(20),
            Children =
            {
                new Label { Text = "Primary colors" },
                new BoxView { Color = Colors.Red },
                new BoxView { Color = Colors.Yellow },
                new BoxView { Color = Colors.Blue },
                new Label { Text = "Secondary colors" },
                new BoxView { Color = Colors.Green },
                new BoxView { Color = Colors.Orange },
                new BoxView { Color = Colors.Purple }

            }
        };
    }
}
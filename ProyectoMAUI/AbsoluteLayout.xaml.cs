namespace ProyectoMAUI;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();

        AbsoluteLayout absoluteLayout = new AbsoluteLayout
        {
            Margin = new Thickness(20)
        };

        absoluteLayout.Add(new BoxView
        {
            Color = Colors.Silver
        }, new Rect(0, 10, 200, 5));
        absoluteLayout.Add(new BoxView
        {
            Color = Colors.Silver
        }, new Rect(0, 20, 200, 5));
        absoluteLayout.Add(new BoxView
        {
            Color = Colors.Silver
        }, new Rect(10, 0, 5, 65));
        absoluteLayout.Add(new BoxView
        {
            Color = Colors.Silver
        }, new Rect(20, 0, 5, 65));

        absoluteLayout.Add(new Label
        {
            Text = "Stylish Header",
            FontSize = 24
        }, new Point(30, 25));

        Title = "Stylish header demo";
        Content = absoluteLayout;
    }
}
	}
}
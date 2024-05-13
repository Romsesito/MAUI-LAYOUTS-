
using Microsoft.Maui.Controls;
using System;

namespace ProyectoMAUI
{
    public partial class MainPage : ContentPage
    {




        public MainPage()
        {

            InitializeComponent();


            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(2, GridUnitType.Star) },
                new RowDefinition(),
                new RowDefinition { Height = new GridLength(100) }
            },
                ColumnDefinitions =
            {
                new ColumnDefinition(),
                new ColumnDefinition()
            }
            };

            //Boton




            // Row 0
            // The BoxView and Label are in row 0 and column 0, and so only need to be added to the
            // Grid to obtain the default row and column settings.
            grid.Add(new BoxView
            {
                Color = Colors.Green
            });
            grid.Add(new Label
            {
                Text = "Row 0, Column 0",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            });

            // This BoxView and Label are in row 0 and column 1, which are specified as arguments
            // to the Add method.
            grid.Add(new BoxView
            {
                Color = Colors.Blue
            }, 1, 0);
            grid.Add(new Label
            {
                Text = "Row 0, Column 1",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }, 1, 0);

            // Row 1
            // This BoxView and Label are in row 1 and column 0, which are specified as arguments
            // to the Add method overload.
            grid.Add(new BoxView
            {
                Color = Colors.Teal
            }, 0, 1);
            grid.Add(new Label
            {
                Text = "Row 1, Column 0",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }, 0, 1);

            // This BoxView and Label are in row 1 and column 1, which are specified as arguments
            // to the Add method overload.
            grid.Add(new BoxView
            {
                Color = Colors.Purple
            }, 1, 1);
            grid.Add(new Label
            {
                Text = "Row1, Column 1",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }, 1, 1);

            // Row 2
            // Alternatively, the BoxView and Label can be positioned in cells with the Grid.SetRow
            // and Grid.SetColumn methods. Here, the Grid.SetColumnSpan method is used to span two columns.
            BoxView boxView = new BoxView { Color = Colors.Red };
            Grid.SetRow(boxView, 2);
            Grid.SetColumnSpan(boxView, 2);
            Label label = new Label
            {
                Text = "Row 2, Column 0 and 1",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            Grid.SetRow(label, 2);
            Grid.SetColumnSpan(label, 2);

            grid.Add(boxView);
            grid.Add(label);




            Button button = new Button
            {
                Text = "Ir a otra página"
            };
            button.Clicked += OnButtonClicked;

            Grid.SetRow(button, 2);
            Grid.SetColumnSpan(button, 2);

            grid.Children.Add(button);

            Title = "Grid Pagina 1 Jordan Aguiar";
            Content = grid;
        }


        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaDos());
        }



    }



    }



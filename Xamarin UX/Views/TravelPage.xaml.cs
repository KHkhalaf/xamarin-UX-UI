using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_UX.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TravelPage : ContentPage
    {
        Button lastButton;

        public TravelPage()
        {
            InitializeComponent();

            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                Button btn = new Button()
                {
                    Text = $"{i}",
                    TextColor = Color.Black,
                    Padding = new Thickness(30, 10),
                    BackgroundColor = Color.FromHex("ffdf9d"),
                    CornerRadius = 15
                };

                btn.Clicked += (sender, EventArgs) =>
                {
                    if (lastButton != null)
                    {
                        VisualStateManager.GoToState(lastButton, "DayUnSelected");
                    }

                    VisualStateManager.GoToState((Button)sender, "DaySelected");

                    lastButton = (Button)sender;
                };

                DaysBlock.Children.Add(btn);
            }
        }

    }
}
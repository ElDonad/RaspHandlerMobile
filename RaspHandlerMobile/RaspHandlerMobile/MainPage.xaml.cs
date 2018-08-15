using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaspHandlerMobile
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        void OnButtonClick(object sender, EventArgs e)
        {
            String truc = ipField.Text;
            ((Button)sender).Text = truc;

        }
	}

}
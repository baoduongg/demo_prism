using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Demo_Prism.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoDependency : ContentPage
	{
		public DemoDependency ()
		{
			InitializeComponent ();
		}
        private void BtnSpeak_click(object sender, EventArgs e)
        {
            if (txt.Text == null)
                DisplayAlert("Thong Bao", "Ban can nhap van ban", "Cancel");
            else
            {
                DependencyService.Get<ITextToSpeech>().Speak(txt.Text);
            }

        }
    }
}
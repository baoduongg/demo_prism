using App_Demo_Prism.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Demo_Prism.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoListView : ContentPage
	{
        ObservableCollection<ListViewModel> obs = new ObservableCollection<ListViewModel>();
        int status = 0;
       
        public DemoListView ()
		{
			InitializeComponent ();
            demolist.ItemsSource = obs;

            demolist.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (ListViewModel)e.SelectedItem;
             //   DisplayAlert("Thong bao", "Item " + item.Id + " da dc chon", "Ok");
             
            };



        }
        private void BtnAdd_Clicker(object sender, EventArgs e)
        {
           
            if(entrystt.Text==null && entryname.Text ==null)
            {
                status++;
                obs.Add(new ListViewModel { Name = "Member " + status, Stt = status, Id = status });
            }
          
            else
            {
                
                obs.Add(new ListViewModel { Name = "Member " + entryname.Text, Stt = int.Parse(entrystt.Text), Id = status });
                entryname.Text = null;
                entrystt.Text = null;

            }
             
        }

        private void BtnClear_Clicker(object sender, EventArgs e)
        {
            obs.Clear();
            status = 0;
        }

        private void BtnDel_Clicker(object sender, EventArgs e)
        {

            if (obs.Count > 0)
            {
                obs.RemoveAt(obs.Count - 1);
                status--;
            }
        }

        private void entry_complete(object sender, EventArgs e)
        {
            BtnAdd_Clicker(null,null);
        }
    }
}
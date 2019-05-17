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
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;
            switch (item.Id)
            {
                case 0:
                    Detail = new NavigationPage(page);
                    IsPresented = false;
                    break;
                case 1:
                    Detail = new NavigationPage(new PageA());
                    IsPresented = false;
                    break;
                case 3:
                    Detail = new NavigationPage(new DemoDependency());
                    IsPresented = false;
                    break;
                case 2:
                    Detail = new NavigationPage(new DemoListView());
                    IsPresented = false;
                    break;
                case 4:
                    Detail = new NavigationPage(new DemoTabbedPage());
                    IsPresented = false;
                    break;
               
                default:
                    break;
            }
            MasterPage.ListView.SelectedItem = null;
        }
    }
}
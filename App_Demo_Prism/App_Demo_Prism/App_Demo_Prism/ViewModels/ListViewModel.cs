using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Demo_Prism.ViewModels
{
   public class ListViewModel :BindableBase
    {
        private string name;
        private int stt;
        private int id;


        public string Name { get => name; set => name = value; }
        public int Stt { get => stt; set => stt = value; }
        public int Id { get => id; set => id = value; }

    }
}

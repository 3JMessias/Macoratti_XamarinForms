using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms_Macoratti
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutPage : ContentPage
    {
        private string likes = "25";
        

        public string Likes
        {
            get { return likes; }
            set { likes = value; }
        }

        public StackLayoutPage()
        {
            InitializeComponent();

        }

    }
}
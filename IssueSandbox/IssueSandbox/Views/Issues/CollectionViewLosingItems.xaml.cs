using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IssueSandbox.Views.Issues
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionViewLosingItems : ContentPage
    {
        public CollectionViewLosingItems()
        {
            InitializeComponent();
        }
    }
}
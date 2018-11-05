using System;
using System.Collections.Generic;
using GroupPerson.ViewModel;
using Xamarin.Forms;

namespace GroupPerson.View
{
    public partial class ViewDisplay : ContentPage
    {
        public ViewDisplay()
        {
            InitializeComponent();
            BindingContext = new ViewModelDisplay(Navigation);
        }
    }
}

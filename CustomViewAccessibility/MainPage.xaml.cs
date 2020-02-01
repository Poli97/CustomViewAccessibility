using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace CustomViewAccessibility
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            ICustomViewRenderer mybutton = new ICustomViewRenderer();
            mybutton.Text = "TEST";
            AutomationProperties.SetIsInAccessibleTree(mybutton, true);
            stacklayout.Children.Add(mybutton);
        }
    }
}
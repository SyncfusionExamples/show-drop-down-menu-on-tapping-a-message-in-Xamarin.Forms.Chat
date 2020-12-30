using Syncfusion.XForms.Chat;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GettingStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        public ChatPage()
        {
            InitializeComponent();
        }

        void OnImageTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            popupLayout.ShowAtTouchPoint();
        }

        void OnLabelTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            popupLayout.Dismiss();
        }
    }
}
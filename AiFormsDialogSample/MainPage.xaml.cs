using AiForms.Dialogs;
using AiFormsDialogSample.Viewmodels;
using AiFormsDialogSample.Views.Dialogs;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace AiFormsDialogSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Show_Green_Alert_Clicked(object sender, EventArgs e)
        {
            var vm = new GradientDialogViewModel
            {
                Content = "Sample text",
                OkText = "OK",
                GradientInitialColor = Color.FromHex("#38EF7D"),
                GradientEndColor = Color.FromHex("#11998E")
            };

            var response = Dialog.Instance.ShowAsync<GradientDialogView>(vm);
        }

        private void Show_Red_Alert_Clicked(object sender, EventArgs e)
        {
            var vm = new GradientDialogViewModel
            {
                Content = "Sample text",
                OkText = "OK",
                GradientInitialColor = Color.FromHex("#ED213A"),
                GradientEndColor = Color.FromHex("#93291E")
            };

            var response = Dialog.Instance.ShowAsync<GradientDialogView>(vm);
        }
    }
}

using AiForms.Dialogs.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AiFormsDialogSample.Views.Dialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GradientDialogView : DialogView
    {
        public GradientDialogView()
        {
            InitializeComponent();

            OverlayColor = new Color(0, 0, 0, 0.5);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext is GradientDialogViewModel vm)
            {
                ContentLabel.Text = vm.Content;
                OkButton.Text = vm.OkText;
                GradientInitial.Color = vm.GradientInitialColor;
                GradientEnd.Color = vm.GradientEndColor;
            }
        }

        void Handle_Ok_Clicked(object sender, System.EventArgs e)
        {
            DialogNotifier.Complete();
        }

        void Handle_Cancel_Clicked(object sender, System.EventArgs e)
        {
            DialogNotifier.Cancel();
        }
    }
}
using System;
using Xamarin.Forms;

namespace MathGame {
    public partial class MathGamePage : ContentPage {

        public MathGamePage() {
            InitializeComponent();
        }

        async void onBtnClicked(object sender, EventArgs e) {
            string text = Nombre.Text;
            var pickerInstance = (Picker) picker;
            int selectedItem = Int32.Parse(pickerInstance.Items[pickerInstance.SelectedIndex]);

            var secondPage = new GamePage(text, selectedItem);
			await Navigation.PushAsync(secondPage);

        }

    }
}

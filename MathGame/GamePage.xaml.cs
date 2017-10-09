using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathGame {
    
    public partial class GamePage : ContentPage {

		private int pageCounter = 3;
		private int activePage = 1;
        private int correctAnswerCount = 0;

        private int randomNumber1;
        private int randomNumber2;

        private Random random;
        
        public GamePage(string nombre, int pageCounter) {
            this.pageCounter = pageCounter;
            InitializeComponent();
            this.random = new Random();

            heading.Text = activePage + " de " + pageCounter;
            randomNumber1 = generateRandomNumber();
            randomNumber2 = generateRandomNumber();
			numero1.Text = randomNumber1.ToString();
			numero2.Text = randomNumber2.ToString();

        }

		async void onBtnClicked(object sender, System.EventArgs e) {
            if (checkRespuesta()) correctAnswerCount++;

            Console.WriteLine(correctAnswerCount);

            if (activePage == pageCounter) {
                await DisplayAlert("Listo!", "Contestaste " + correctAnswerCount + " de " + pageCounter + " correctamente!", "OK");
                await Navigation.PopAsync();
            } else {
                generateNewQuestion();
            }
		}

        private bool checkRespuesta() {
            int respuestaValue = Int32.Parse(respuesta.Text);
            Console.WriteLine(randomNumber1 +"+" +randomNumber2 + "==" + respuestaValue);
            return (randomNumber1 + randomNumber2) == respuestaValue;
        }

        private void generateNewQuestion() {
            activePage++;
            heading.Text = activePage + " de " + pageCounter;

			randomNumber1 = generateRandomNumber();
			randomNumber2 = generateRandomNumber();
			
			numero1.Text = randomNumber1.ToString();
			numero2.Text = randomNumber2.ToString();
			
        }

        private int generateRandomNumber() {
            return this.random.Next(1, 10);
		}
    }
}

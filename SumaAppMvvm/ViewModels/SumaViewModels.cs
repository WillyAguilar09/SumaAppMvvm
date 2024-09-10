using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace SumaAppMvvm.ViewModels
{
    public partial class SumaViewModels : ObservableObject
    {
        [ObservableProperty]
        private double valor1;

        [ObservableProperty]
        private double valor2;

        [ObservableProperty]
        private string suma;

        // Constructor
        public SumaViewModels()
        {
            // Inicializar comandos
            CalcularSumaCommand = new RelayCommand(CalculoSuma);
            LimpiarCommand = new RelayCommand(LimpiarDatos);
        }


        public ICommand CalcularSumaCommand { get; }


        private void CalculoSuma()
        {
            if (Valor1 > 0 && Valor2 > 0)
            {
                double sum = Valor1 + Valor2;
                Suma = $"La sumatoria de ambos números es: {sum:F2}";
            }
            else
            {
                Suma = "Favor ingrese valores válidos para Valor1 y Valor 2";
            }
        }


        public ICommand LimpiarCommand { get; }

        // Método que limpia los datos
        private void LimpiarDatos()
        {
            Valor1 = 0;
            Valor2 = 0;
            Suma = "";
        }
    }
}

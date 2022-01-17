using System;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnBuscar.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = editCEP.Text.Trim();

            if (isValidCEP(cep))
            {
                Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                if (end.ToString().Trim().Length > 0)
                {
                    resultado.Text =
                        $"Endereço: {end.logradouro}\n" +
                        $"Bairro: {end.bairro}\n" +
                        $"Cidade/UF: {end.localidade}/{end.uf}\n" +
                        $"DDD: {end.ddd}\n" +
                        $"CEP: {end.cep}";
                }
            }

            editCEP.Focus();
        }

        private bool isValidCEP(string cep)
        {
            bool result = true;

            if (cep.Length != 8)
            {
                DisplayAlert("Atenção", "CEP Inválido! O Cep deve conter 8 caracteres.", "OK");

                result = false;
            }
            else if(!int.TryParse(cep, out int novoCEP))
            {
                DisplayAlert("Atenção", "CEP Inválido! O Cep deve conter apenas números.", "OK");

                result = false;
            }
            

            return result;
        }
    }
}

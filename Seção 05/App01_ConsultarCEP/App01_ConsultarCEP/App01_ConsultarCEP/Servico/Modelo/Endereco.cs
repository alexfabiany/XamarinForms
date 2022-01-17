using System;
using System.Collections.Generic;
using System.Text;

namespace App01_ConsultarCEP.Servico.Modelo
{
    public class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }

        /*
        "cep": "69033-180",
        "logradouro": "Rua Francisco Carretti",
        "complemento": "",
        "bairro": "São Jorge",
        "localidade": "Manaus",
        "uf": "AM",
        "ibge": "1302603",
        "gia": "",
        "ddd": "92",
        "siafi": "0255"
        */
    }
}

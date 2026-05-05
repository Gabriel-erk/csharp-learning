using System.Diagnostics.Contracts;
using System.IO.Pipes;

namespace ModelTb
{
    class CarroTb
    {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Velocidade { get; set; }
        public int Ano
        {
            get;
            set;
            // {
            //     // ao receber um parametro para o método setter em c#, por padrao  utilizamos a palavra reservada "value" para se referir ao valor que esta sendo passado ao setter dessa propriedade, logo, nao precisamos criar nenhuma variavel, apenas acessar essa palavra reservada "value"
            //     if(value >= 1960 && value <= 2023)
            //     {

            //         Ano = value;
            //     }
            // }
        }
        public string DescricaoDetalhada => $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}";
    }
}
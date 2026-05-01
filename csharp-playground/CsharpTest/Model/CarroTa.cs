namespace ModelTa
{
    class CarroTa
    {
        public string nome;
        public string modelo;
        public string marca;
        private int velocidade;

        public string Acelerar()
        {
            velocidade += 5;
            return $"O carro acelerou! Velocidade atual: {velocidade} km/h";
        }

        public string Desacelerar()
        {
            if(velocidade > 0)
            {
                velocidade -= 5;
                return $"O carro desacelerou! Velocidade atual: {velocidade} km/h";
            }
            return "Carro não está em movimento para desacelerar.";
        }

        public string Frear()
        {
            if (velocidade < 10)
            {
                velocidade = 0;
                return "O carro freou";
            } 
            return "Velocidade muito alta, desacelere para frear.";
        }

        public string Buzinar()
        {
            return "Bi biiiiii";
        }
    }
}
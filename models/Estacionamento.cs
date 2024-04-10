namespace projeto_estacionamento.models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<Veiculo> veiculos;

        public Estacionamento()
        {
            veiculos = new List<Veiculo>();
        }

        public decimal PrecoInicial
        {
            get { return precoInicial; }
            set { precoInicial = value; }
        }

        public decimal PrecoPorHora
        {
            get { return precoPorHora; }
            set { precoPorHora = value; }
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public bool RemoverVeiculo(string placa, int horasEstacionado)
        {
            Veiculo veiculo = veiculos.FirstOrDefault(v => v.Placa == placa);
            if (veiculo != null)
            {
                decimal precoFinal = precoInicial + (horasEstacionado * precoPorHora);
                Console.WriteLine($"Preço final do estacionamento para o veículo {veiculo.Placa}: R${precoFinal}");
                veiculos.Remove(veiculo);
                return true;
            }
            return false;
        }

        public List<Veiculo> ListarVeiculos()
        {
            return veiculos;
        }
    }
}

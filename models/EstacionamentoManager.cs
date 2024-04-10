namespace projeto_estacionamento.models;
public class EstacionamentoManager
{
    public void AdicionarVeiculo(Estacionamento estacionamento)
    {
        Console.Write("Digite a placa do veículo: ");
        string? placa = Console.ReadLine();
        Console.Write("Digite o modelo do veículo: ");
        string? modelo = Console.ReadLine();
        Console.Write("Digite a marca do veículo: ");
        string? marca = Console.ReadLine();

        if (placa != null && modelo != null && marca != null)
        {
            estacionamento.AdicionarVeiculo(new Veiculo(placa, modelo, marca));
            Console.WriteLine("Veículo adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("Algum dos valores inseridos é nulo. O veículo não foi adicionado.");
        }
    }


    public void RemoverVeiculo(Estacionamento estacionamento)
    {
        Console.Write("Digite a placa do veículo a ser removido: ");
        string? placa = Console.ReadLine();

        if (placa != null)
        {
            Console.Write("Digite o número de horas que o veículo permaneceu estacionado: ");
            string? horasEstacionadoStr = Console.ReadLine();

            if (int.TryParse(horasEstacionadoStr, out int horasEstacionado))
            {
                if (estacionamento.RemoverVeiculo(placa, horasEstacionado))
                {
                    Console.WriteLine("Veículo removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Veículo não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Número de horas inválido. Veículo não removido.");
            }
        }
        else
        {
            Console.WriteLine("Placa do veículo inválida. Veículo não removido.");
        }
    }


    public void ListarVeiculos(Estacionamento estacionamento)
    {
        Console.WriteLine("\nVeículos estacionados:");
        foreach (Veiculo veiculo in estacionamento.ListarVeiculos())
        {
            Console.WriteLine($"Placa: {veiculo.Placa}, Modelo: {veiculo.Modelo}, Marca: {veiculo.Marca}");
        }
    }
}

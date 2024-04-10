
using projeto_estacionamento.models;
class Program
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento();
        EstacionamentoManager manager = new EstacionamentoManager();

        Console.WriteLine("Digite o preço inicial do estacionamento: ");
        estacionamento.PrecoInicial = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite o preço por hora do estacionamento: ");
        estacionamento.PrecoPorHora = Convert.ToDecimal(Console.ReadLine());
    

        while (true)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Estacionamento");
            Console.WriteLine("1. Adicionar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos estacionados");
            Console.WriteLine("0. Sair");

            Console.Write("Escolha uma opção: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "0":
                    Console.WriteLine("Obrigado por usar nosso sistema. Adeus!");
                    return;
                case "1":
                    manager.AdicionarVeiculo(estacionamento);
                    break;
                case "2":
                    manager.RemoverVeiculo(estacionamento);
                    break;
                case "3":
                    manager.ListarVeiculos(estacionamento);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

}


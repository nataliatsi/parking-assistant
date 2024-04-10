namespace projeto_estacionamento.models;

public class Veiculo
{

    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }

    public Veiculo(string placa, string modelo, string marca)
    {
        Placa = placa;
        Modelo = modelo;
        Marca = marca;
    }

}
namespace Atv___04
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }

        public Carro(string marca, string modelo, int velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
        }

        public void acelerar()
        {
            Console.WriteLine($"O carro acelerou de {Velocidade}km/h para 120km/h");
        }

        public void desacelerar()
        {
            Console.WriteLine($"O desacelerou de 100km/h para {Velocidade}km/h");
        }
    }
}
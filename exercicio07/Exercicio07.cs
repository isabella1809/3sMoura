using exercicio07;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio07
{
   class Bicicleta : Veiculo
 {
    public void Mover()
    {
        Console.WriteLine("A bicicleta está sendo pedalada.");
    }
 }

    internal class Veiculo
    {
    }
}

class Carro : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("O carro está andando na estrada.");
    }
}

class Bicicleta : Veiculo
{
    public override void Mover()
    {
        Console.WriteLine("A bicicleta está pedalando.");
    }
}

    
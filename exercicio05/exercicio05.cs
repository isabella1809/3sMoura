using exercicio05;


namespace exercicio05
{
    class Pessoa
{
    public string Nome;
    public int Idade;

    public Pessoa(string nome, int idade)
    {
        Nome = nome;

        if (idade > 0)
        {
            Idade = idade;
        }
        else
        {
            Idade = 0;
        }
    }

    public void ExibirDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
    }
}
}
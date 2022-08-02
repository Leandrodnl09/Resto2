// Exercício do site URI "Resto!"
// Esse programa o usuário ira digitar om valor inteiro "N", e em seguida mostrará na tela quais são divisivel pelo numero "N" de 1 até 1000.


int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10000; i++)
{
    if (i % N == 2)
    {
        Console.WriteLine(i);
    }
}

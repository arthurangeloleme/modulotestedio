using Calculadora.Services;

CalculadoraOperacoes calc = new CalculadoraOperacoes();

calc.Somar(1, 2);
calc.Subitrair(5, 2);
calc.Dividir(10, 5);
calc.Somar(8, 1);
calc.Multiplicar(6, 6);

List<string> lista = calc.Historico();

Console.WriteLine(string.Join(", \n", lista));

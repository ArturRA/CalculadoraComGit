namespace CalculadoraComGit
{
    internal class Program
    {
        //1 - Implementar a funcionalidade de somar dois números
        //2 - Implementar a funcionalidade de subtrair dois números
        //3 - Implementar a funcionalidade de multiplicar dois números
        //4 - Implementar a funcionalidade de divisão de dois números
        enum OperacoesMatematicas
        {
            SOMA = 1,
            SUBTRACAO = 2,
            MULTIPLICACAO = 3,
            DIVISAO = 4,
            VISUALIZAR = 5,
            SAIR = 6
        }

        static void Main(string[] args)
        {
            List<string> listaDasOperacoes = new List<string>();

            while(true)
            {
                Console.Clear();

                Console.WriteLine("Calculadora Tabajara 1.0\n"
                                + "Tela Principal\n"
                                + "Digite 1 para Adição\n"
                                + "Digite 2 para Subtração\n"
                                + "Digite 3 para Multiplicação\n"
                                + "Digite 4 para Divisão\n"
                                + "Digite 5 para Visualizar as operações\n"
                                + "Digite 6 para sair\n");

                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor > 6 || valor < 1)
                {
                    Console.WriteLine("Você precisa digitar uma opção válida!");
                    Console.ReadLine();
                    continue;
                }

                OperacoesMatematicas operacao = (OperacoesMatematicas)valor;

                // Se digitar 6 sair do programa
                if (operacao == OperacoesMatematicas.SAIR)
                    break;

                Console.Write("Digite o primeiro valor: ");
                double valor1 = Convert.ToDouble(Console.ReadLine());
                
                double valor2;

                if (operacao == OperacoesMatematicas.DIVISAO)
                {
                    while (true)
                    {
                        Console.Write("Digite o segundo valor: ");
                        valor2 = Convert.ToDouble(Console.ReadLine());
                        if (valor2 == 0)
                        {
                            Console.WriteLine("Divisor não pode ser zero");
                            Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                Console.Write("Digite o segundo valor: ");
                valor2 = Convert.ToDouble(Console.ReadLine());


                double resultado = 0;

                switch (operacao)
                {
                    case OperacoesMatematicas.SOMA:
                        // TODO funcao soma
                        break;
                    case OperacoesMatematicas.SUBTRACAO:
                        // TODO funcao subtracao
                        break;
                    case OperacoesMatematicas.MULTIPLICACAO:
                        // TODO funcao multiplicao
                        break;
                    case OperacoesMatematicas.DIVISAO:
                        // TODO funcao divisao
                        break;
                    case OperacoesMatematicas.VISUALIZAR:
                        listaDasOperacoes.ForEach(conta =>  Console.WriteLine(conta));
                        Console.ReadLine();
                        continue;
                }

                string simbolo = "";

                switch (operacao)
                {
                    case OperacoesMatematicas.SOMA:
                        // TODO
                        break;
                    case OperacoesMatematicas.SUBTRACAO:
                        // TODO
                        break;
                    case OperacoesMatematicas.MULTIPLICACAO:
                        // TODO
                        break;
                    case OperacoesMatematicas.DIVISAO:
                        // TODO
                        break;
                }

                string resultadoDaOperacao = $"{valor1} {simbolo} {valor2} = {resultado}";
                listaDasOperacoes.Add(resultadoDaOperacao);
            }
        }
    }
}
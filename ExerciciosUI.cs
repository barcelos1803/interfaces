using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exercicio_de_interface_01;
using exercicio_de_interface_02;
using exercicio_de_interface_03;
using exercicio_de_interface_04;
using exercicio_de_interface_05;


public class ExerciciosUI
{
    public static void Iniciar()
    {
        while (true)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Exercicio 1");
            Console.WriteLine("2 - Exercicio 2");
            Console.WriteLine("3 - Exercicio 3");
            Console.WriteLine("4 - Exercicio 4");
            Console.WriteLine("5 - Exercicio 5");
            Console.WriteLine("6 - Sair\n");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    IAnimal cachorro = new Cachorro();
                    IAnimal gato = new Gato();
                    IAnimal papagaio = new Papagaio();

                    cachorro.EmitirSom();
                    gato.EmitirSom();
                    papagaio.EmitirSom();

                    Console.WriteLine(" ");
                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    break;
                
                case 2:
                    string textoMaiusculo = new FormatadorMaiusculo().Formatar("exemplo");
                    string textoMinusculo = new FormatadorMinusculo().Formatar("exemplo");
                    string textoInvertido = new FormatadorInvertido().Formatar("exemplo");

                    Console.WriteLine(textoMaiusculo);
                    Console.WriteLine(textoMinusculo);
                    Console.WriteLine(textoInvertido);

                    Console.WriteLine(" ");
                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    break;

                case 3:
                    Dog golias = new Dog("Golias", "João");
                    Cat athena = new Cat("Athena", "Maria");

                    Console.WriteLine($"O(a) cachorro(a) {golias.Nome} é do(a) {golias.Dono}.\n");
                    Console.WriteLine($"O(a) gato(a) {athena.Nome} é do(a) {athena.Dono}.\n");

                    Console.WriteLine(" ");
                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    break;

                case 4:
                    Calculadora minhaCalculadora = new Calculadora();

                    Console.WriteLine("Digite o primeiro numero:\n");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero numero:\n");
                    double b = double.Parse(Console.ReadLine());

                    Console.WriteLine(" ");

                    Console.WriteLine("Selecione uma opção:");
                    Console.WriteLine("1 - Somar os numeros");
                    Console.WriteLine("2 - Subtrair o primeiro numero pelo segundo");
                    Console.WriteLine("3 - multiplicar o primeiro numero pelo segundo");
                    Console.WriteLine("4 - dividir o primeiro numero pelo segundo");
                    Console.WriteLine("5 - sair\n");

                    int escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            minhaCalculadora.Somar(a, b);
                            Console.WriteLine(" ");
                            break;

                        case 2:
                            minhaCalculadora.Subtrair(a, b);
                            Console.WriteLine(" ");
                            break;

                        case 3:
                            minhaCalculadora.Multiplicar(a, b);
                            Console.WriteLine(" ");
                            break;

                        case 4:
                            try
                            {
                                minhaCalculadora.Dividir(a, b);
                                Console.WriteLine(" ");
                            }
                            catch (DivideByZeroException ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine(" ");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Saindo...");
                            return;
                        default:
                        Console.WriteLine("Opção inválida.");
                        break;
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    break;

                case 5:

                    Console.WriteLine("Selecione um tipo de operação:");
                    Console.WriteLine("1 - Cartão");
                    Console.WriteLine("2 - Boleto");
                    Console.WriteLine("3 - Paypal");
                    Console.WriteLine("4 - sair\n");

                    int operacao = int.Parse(Console.ReadLine());

                    Console.WriteLine("o que você deseja Fazer ?");
                    Console.WriteLine("1 - Efetuar Pagamento");
                    Console.WriteLine("2 - Estornar Pagamento");
                    Console.WriteLine("3 - Sair");

                    int S = int.Parse(Console.ReadLine());

                    if (S==3)
                    {
                        return;
                    }

                    Console.WriteLine("Qual o valor ?");

                    double valor = double.Parse(Console.ReadLine());

                    switch (operacao)
                    {
                        case 1:

                            IServicoPagamento pagamentoCartao = new PagamentoCartao();
                            if (S==1)
                            {
                                pagamentoCartao.EfetuarPagamento(valor);
                            }
                            if(S==2)
                                pagamentoCartao.EstornarPagamento(valor);
                            break;

                        case 2:

                            IServicoPagamento pagamentoBoleto = new PagamentoBoleto();
                            if (S==1)
                            {
                                pagamentoBoleto.EfetuarPagamento(valor);
                            }
                            if (S==2)
                            {
                                pagamentoBoleto.EstornarPagamento(valor);
                            }
                            break;
                        case 3:

                            IServicoPagamento pagamentoPaypal = new PagamentoPaypal();
                            if (S==1)
                            {
                                pagamentoPaypal.EfetuarPagamento(valor);
                            }
                            if (S==2)
                            {
                                pagamentoPaypal.EstornarPagamento(valor);
                            }
                            break;
                    
                        case 4:
                            Console.WriteLine("saindo...");
                            return;
                        
                        default:
                        Console.WriteLine("Opção inválida.");
                        break;
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Pressione uma tecla para voltar ao menu.");
                    Console.ReadKey();
                    Console.WriteLine(" ");
                    break;
                
                case 6:
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
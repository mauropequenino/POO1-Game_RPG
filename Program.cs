using Game_RPG;
using Game_RPG.Models;
using System.Collections.Generic;


List<Conta> contas = [];
int opcao;

do
{
    Console.Clear();
    ApresentarMenuInicial();
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Clear();
            Conta conta = BuscarConta(contas);

            if (conta != null)
            {
                int opcaoMenuConta;
                do
                {
                    Console.Clear();
                    MenuConta();
                    opcaoMenuConta = int.Parse(Console.ReadLine());

                    switch (opcaoMenuConta)
                    {
                        case 1:
                            Console.WriteLine($"Email: {conta.email}\n" +
                                  $"Data da criacao: {conta.dataCriacao}\n" +
                                  $"Saldo da conta: {conta.saldoActual}\n");
                            LimparTela();
                            break;
                        case 2:
                            Console.WriteLine("Insira o montante a adicionar no saldo: ");
                            decimal valorCredito = decimal.Parse(Console.ReadLine());
                            conta.AdicionarCredito(valorCredito);
                            conta.VisualizarCreditos();
                            LimparTela();
                            break;
                        case 3:
                            int opcaoMenuPersonagem;
                            do
                            {
                                Console.Clear();
                                MenuPersonagem();
                                opcaoMenuPersonagem = int.Parse(Console.ReadLine());

                                switch (opcaoMenuPersonagem)
                                {
                                    case 1:
                                        Console.WriteLine("Insira o nome do personagem:");
                                        conta.Personagem.nome = Console.ReadLine();
                                        Console.WriteLine("Insira o tipo de personagem:");
                                        conta.Personagem.tipo = Console.ReadLine();
                                        LimparTela();
                                        break;
                                    case 2:
                                        Console.WriteLine($"Conta: {conta.email}");
                                        conta.Personagem.ExibirDadosPersonagem();
                                        LimparTela();
                                        break;
                                    case 3:
                                        Console.WriteLine("Insira a quantidade de experiencia a adicionar:");
                                        int experiencia = int.Parse(Console.ReadLine());
                                        conta.Personagem.AdicionarExperiencia(experiencia);
                                        LimparTela();
                                        break;
                                    case 0:
                                        break;
                                    default:
                                        Console.WriteLine("Tecla invalida");
                                        LimparTela();
                                        break;
                                }

                            } while (opcaoMenuPersonagem != 0);
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Tecla invalida");
                            LimparTela();
                            break;
                    }
                } while (opcaoMenuConta != 0);
            }
            else
            {
                Console.WriteLine("Email incorreto!");
                LimparTela();
            }
            break;

        case 2:
            Console.Clear();
            Console.WriteLine("Insira o email a associar a conta:");
            string email = Console.ReadLine();

            Console.WriteLine("Insira o saldo:");

            decimal saldoActual;

            bool saldoValido = decimal.TryParse(Console.ReadLine(), out saldoActual);

            if (!saldoValido)
            {
                Console.WriteLine("Saldo inválido! Será considerado 0.");
                saldoActual = 0;
            }


            contas.Add(new Conta(email, saldoActual));

            Console.WriteLine("Conta criada com sucesso!");
            LimparTela();
            break;
    }

} while (opcao != 0);



#region Metodos
void ApresentarMenuInicial()
{
    Console.Write("------------------------------\n" +
        "Digite uma opcao:\n" +
        "1 - Conta\n" +
        "2 - Criar Conta\n" +
        "0 - Sair\n" +
        "Opcao: ");
}

void MenuConta()
{
    Console.Write("------------------------------\n" +
     "Digite uma opcao:\n" +
     "1 - Visualizar detalhes da conta\n" +
     "2 - Adicionar credito na conta\n" +
     "3 - Personagem\n" +
     "0 - Voltar\n" +
     "Opcao: ");
}

void MenuPersonagem()
{
    Console.Write("------------------------------\n" +
       "Digite uma opcao:\n" +
       "1 - Criar Personagem\n" +
       "2 - Exibir dados do personagem\n" +
       "3 - Adicionar experiencia ao personagem\n" +
       "0 - Voltar\n" +
       "Opcao: ");
}

void LimparTela()
{
    Console.WriteLine("Pressiona qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

Conta BuscarConta(List<Conta> contas)
{
    Console.WriteLine("Insira o seu email:");
    string email = Console.ReadLine();

    foreach (Conta conta in contas)
    {
        if (conta.email == email)
            return conta;
    }

    return null;
}
#endregion
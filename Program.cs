
using Game_RPG;
using System.Collections.Generic;

#region Metodos
void ApresentarMenuInicial()
{
    Console.Write("------------------------------\n" +
        "Digite uma opcao:\n" +
        "1 - Abrir conta\n" +
        "2 - Visualizar detalhes da conta\n" +
        "3 - Adicionar credito na conta\n" +
        "4 - Criar Personagem\n" +
        "5 - Listar personagens da conta\n"  +
        "0 - Sair\n" +
        "Opcao: ");
    //Console.WriteLine("-------------------------------");
}

/*
void MenuPersonagem()
{
    Console.Write("------------------------------\n" +
       "Digite uma opcao:\n" +
       "1 - Abrir conta\n" +
       "2 - Visualizar detalhes da conta\n" +
       "3 - Adicionar credito na conta\n" +
       "4 - Criar Personagem\n" +
       "5 - Listar personagens da conta\n" +
       "0 - Sair\n" +
       "Opcao: ");
}
*/

void LimparTela()
{
    Console.WriteLine("Pressiona qualquer tecla para continuar...");
    Console.ReadKey();
    Console.Clear();
}

#endregion


#region

string email;
string personagem;
var conta = new Conta();
int opcao;


do
{
    Console.Clear();
    ApresentarMenuInicial();
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Insira o email a associar a conta:");
            conta.email = (Console.ReadLine());
            Console.WriteLine("Insira o saldo:");
            conta.saldoActual = decimal.Parse(Console.ReadLine());
            conta.dataCriacao = DateTime.Now;
            LimparTela();
            break;

        case 2:
            Console.WriteLine($"email: {conta.email}\n" +
            $"data da criacao: {conta.dataCriacao}\n" +
            $"saldo da conta: {conta.saldoActual}\n");
            LimparTela();
            break;

        case 3:
            Console.WriteLine("insira o montante a adicionar no saldo: ");
            decimal valorCredito = decimal.Parse(Console.ReadLine());
            conta.AdicionarCredito(valorCredito);
            conta.VisualizarCreditos();
            LimparTela();
            break;

        case 4:
            Console.WriteLine("Insira o nome do personagem");
            string nomePersonagem = Console.ReadLine();
            Console.WriteLine("Insira o tipo de personagem");
            string tipoPersonagem = Console.ReadLine();
            conta.CriarPersonagem(nomePersonagem, tipoPersonagem);
            LimparTela();
            break;

        case 5:
                conta.ListarPersonagens();
                LimparTela();
            break;

        case 0:
            Console.WriteLine("Fim de execucao...");
            break;

        default:
            Console.WriteLine("tecla invalida");
            break;
    }
} while (opcao != 0);

#endregion


/*
conta.email = "eltonmirona10@gmail.com";
conta.dataCriacao = DateTime.Now;
conta.saldoActual = 0;
//conta.Personagens.Add("Batman");
//conta.Personagens.Add("Ironman");




    conta.ListarPersonagens();

Console.ReadKey();
    Console.Clear();
    conta.AdicionarCredito(1000);
Console.WriteLine($"Saldo Actualizado: {conta.saldoActual}");


*/
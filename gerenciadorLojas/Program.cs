using System;
using gerenciadorLojas;

class Program
{
    static GerenciadorLojas gerenciadorLojas = new GerenciadorLojas();
    static InterfaceUsuario interfaceUsuario = new InterfaceUsuario(gerenciadorLojas);

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nGERENCIADOR DE LOJAS - SHOPPING CENTER");
            Console.WriteLine("[1] Cadastrar Loja");
            Console.WriteLine("[2] Editar Cadastro");
            Console.WriteLine("[3] Buscar Loja");
            Console.WriteLine("[4] Listar Lojas");
            Console.WriteLine("[5] Listar Espaços Disponíveis");
            Console.WriteLine("[6] Listar Espaços Ocupados");
            Console.WriteLine("[7] Excluir Cadastro");
            Console.WriteLine("[0] Sair");
            Console.Write("Opção: ");
            string input = Console.ReadLine() ?? string.Empty;
            int opcao;
            if (int.TryParse(input, out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        interfaceUsuario.CadastrarLoja();
                        break;
                    case 2:
                        interfaceUsuario.EditarCadastro();
                        break;
                    case 3:
                        interfaceUsuario.BuscarLoja();
                        break;
                    case 4:
                        interfaceUsuario.ListarLojas();
                        break;
                    case 5:
                        interfaceUsuario.ListarEspacosDisponiveis();
                        break;
                    case 6:
                        interfaceUsuario.ListarEspacosOcupados();
                        break;
                    case 7:
                        interfaceUsuario.ExcluirCadastro();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using gerenciadorLojas;

public class InterfaceUsuario
{
    private GerenciadorLojas gerenciadorLojas;

    public InterfaceUsuario(GerenciadorLojas gerenciadorLojas)
    {
        this.gerenciadorLojas = gerenciadorLojas;
    }

    public void ExibirMenu()
    {
        Console.WriteLine("\nMENU\n1 - Listar lojas\n2 - Listar espaços disponíveis\n3 - Listar espaços ocupados\n4 - Cadastrar loja\n5 - Editar cadastro\n6 - Excluir cadastro\n7 - Buscar loja\n8 - Sair");
    }

    public void ListarLojas()
    {
        var lojas = gerenciadorLojas.ListarLojas();
        Console.WriteLine("Lojas cadastradas:");
        foreach (var item in lojas)
            Console.Write($"{item.Key}: {item.Value.NomeLoja}, ");
        Console.WriteLine();
    }

    public void ListarEspacosDisponiveis()
    {
        var espacosDisponiveis = gerenciadorLojas.ListarEspacosDisponiveis();
        Console.WriteLine("Espaços disponíveis:");
        foreach (var espaco in espacosDisponiveis)
            Console.Write($"{espaco}, ");
        Console.WriteLine();
    }

    public void ListarEspacosOcupados()
    {
        var espacosOcupados = gerenciadorLojas.ListarEspacosOcupados();
        Console.WriteLine("Espaços ocupados:");
        foreach (var espaco in espacosOcupados)
            Console.Write($"{espaco}, ");
        Console.WriteLine();
    }

    public void CadastrarLoja()
    {
        Console.WriteLine("\nCADASTRAR LOJA");
        Loja novaLoja = PreencherDadosLoja();
        Console.Write("Número do espaço: ");
        if (int.TryParse(Console.ReadLine(), out int espaco))
        {
            gerenciadorLojas.CadastrarLoja(novaLoja, espaco);
            Console.WriteLine("Loja cadastrada com sucesso!");
        }
        else
            Console.WriteLine("Entrada inválida!");
    }

    public void EditarCadastro()
    {
        Console.WriteLine("\nEDITAR CADASTRO");
        Console.Write("Número do espaço da loja: ");
        if (int.TryParse(Console.ReadLine(), out int espaco))
        {
            Loja loja = gerenciadorLojas.BuscarLoja(espaco);
            if (loja != null)
            {
                Console.WriteLine("Loja encontrada. Preencha os novos dados:");
                Loja lojaAtualizada = PreencherDadosLoja();
                gerenciadorLojas.EditarLoja(lojaAtualizada, espaco);
                Console.WriteLine("Cadastro atualizado com sucesso!");
            }
            else
                Console.WriteLine("Não há loja cadastrada nesse espaço!");
        }
        else
            Console.WriteLine("Entrada inválida!");
    }

        public void ExcluirCadastro()
    {
        Console.WriteLine("\nEXCLUIR CADASTRO");
        Console.Write("Número do espaço da loja: ");
        if (int.TryParse(Console.ReadLine(), out int espaco))
        {
            Loja loja = gerenciadorLojas.BuscarLoja(espaco);
            if (loja != null)
            {
                Console.WriteLine("Loja encontrada. Tem certeza que deseja excluí-la? (S/N)");
                if (Console.ReadLine()?.ToUpper() == "S")
                {
                    gerenciadorLojas.ExcluirLoja(espaco);
                    Console.WriteLine("Cadastro excluído com sucesso!");
                }
                else
                    Console.WriteLine("Exclusão cancelada!");
            }
            else
                Console.WriteLine("Não há loja cadastrada nesse espaço!");
        }
        else
            Console.WriteLine("Entrada inválida!");
    }

    public void BuscarLoja()
        {
            Console.WriteLine("\nBUSCAR LOJA");
            Console.Write("Nome da loja: ");
            string nomeLoja = Console.ReadLine();

            Loja loja = gerenciadorLojas.BuscarLojaPorNome(nomeLoja);

            if (loja != null)
            {
                Console.WriteLine($"Loja encontrada: {loja.NomeLoja}, CNPJ: {loja.CnpjLocatario}, Endereço: {loja.EnderecoLocatario}");
            }
            else
            {
                Console.WriteLine("Loja não encontrada.");
            }
        }


    private Loja PreencherDadosLoja()
    {
        Loja novaLoja = new Loja();

        Console.Write("Nome da loja: ");
        novaLoja.NomeLoja = Console.ReadLine();

        Console.Write("CNPJ: ");
        novaLoja.CnpjLocatario = Console.ReadLine();

        Console.Write("Endereço: ");
        novaLoja.EnderecoLocatario = Console.ReadLine();

        return novaLoja;
    }
}
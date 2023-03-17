using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gerenciadorLojas;

namespace gerenciadorLojas
{
    public class Loja
    {
        // Propriedades
        public string NomeLoja { get; set; }
        public string SegmentoLoja { get; set; }
        public string RazaoSocial { get; set; }
        public string CnpjLocatario { get; set; }
        public string EnderecoLocatario { get; set; }
        public string NomeResponsavel { get; set; }
        public string Telefone { get; set; }
        public string EmailNfe { get; set; }
        public string Email { get; set; }

        // Construtor vazio
        public Loja() {
            NomeLoja = string.Empty;
            SegmentoLoja = string.Empty;
            RazaoSocial = string.Empty;
            CnpjLocatario = string.Empty;
            EnderecoLocatario = string.Empty;
            NomeResponsavel = string.Empty;
            Telefone = string.Empty;
            EmailNfe = string.Empty;
            Email = string.Empty;
        }

        // Construtor com 3 argumentos
        public Loja(string nomeLoja, string telefone, string email) {
            NomeLoja = nomeLoja;
            Telefone = telefone;
            Email = email;

            SegmentoLoja = string.Empty;
            RazaoSocial = string.Empty;
            CnpjLocatario = string.Empty;
            EnderecoLocatario = string.Empty;
            NomeResponsavel = string.Empty;
            EmailNfe = string.Empty;
        }

        // Construtor com 5 argumentos
        public Loja(string nomeLoja, string cnpj, string endereco, string telefone, string email) {
            NomeLoja = nomeLoja;
            CnpjLocatario = cnpj;
            EnderecoLocatario = endereco;
            Telefone = telefone;
            Email = email;

            SegmentoLoja = string.Empty;
            RazaoSocial = string.Empty;
            NomeResponsavel = string.Empty;
            EmailNfe = string.Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gerenciadorLojas;

namespace gerenciadorLojas
{
    public class GerenciadorLojas 
    {
        private Dictionary<int, Loja> lojas;

        public GerenciadorLojas() {
            lojas = new Dictionary<int, Loja>();
        }

        public void CadastrarLoja(Loja loja, int espaco) {
            lojas[espaco] = loja;
        }

        public void EditarLoja(Loja loja, int espaco) {
            lojas[espaco] = loja;
        }

        public Loja? BuscarLoja(int espaco) {
            return lojas.ContainsKey(espaco) ? lojas[espaco] : null;
        }

        public Dictionary<int, Loja> ListarLojas() {
            return lojas;
        }

        public List<int> ListarEspacosDisponiveis() {
            List<int> espacosDisponiveis = new List<int>();
            for (int i = 0; i < 20; i++) {
                if (!lojas.ContainsKey(i)) {
                    espacosDisponiveis.Add(i);
                }
            }
            return espacosDisponiveis;
        }

        public List<int> ListarEspacosOcupados() {
            List<int> espacosOcupados = new List<int>();
            for (int i = 0; i < 20; i++) {
                if (lojas.ContainsKey(i)) {
                    espacosOcupados.Add(i);
                }
            }
            return espacosOcupados;
        }

        public void ExcluirLoja(int espaco) {
            lojas.Remove(espaco);
        }
        public Loja? BuscarLojaPorNome(string nomeLoja)
        {
            foreach (var loja in lojas)
            {
                if (loja.Value.NomeLoja.Equals(nomeLoja, StringComparison.OrdinalIgnoreCase))
                {
                    return loja.Value;
                }
            }
            return null;
        }
    }
}
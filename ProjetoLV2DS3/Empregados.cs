using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLV2DS3
{
    public class Empregados
    
    {
        
        public Empregados()
        {
            nome = "";
            idade = 0;
            genero = "";
            datanasc = "";
            telefone = "";
            email = "";
        }
        #region Propriedades
        public string nome;
        public int idade;
        public string genero;
        public string datanasc;
        public string telefone;
        public string email;
        #endregion

       
        public string verificaNome()
        {
            return nome;     
            }

        public bool verificaNome(string nome)

        {
            if (String.IsNullOrEmpty(nome.Trim())) {
                return true;
            }
            else
            {
                return false;

            }
        }


        public int cadastrarIdade()
        {
            return idade;
        }

        public string cadastrarGenero()
        {
            return genero;
        }

        public string cadastrarDatanasc()
        {
            return datanasc;
        }

        public string cadastrarTelefone()
        {
            return telefone;
        }

        public string cadastrarEmail()
        {
            return email;
        }
        
    }
}
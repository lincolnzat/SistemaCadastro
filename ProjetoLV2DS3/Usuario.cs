using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLV2DS3
{
    public class Usuario //Criando a classe
    {
        public Usuario() //Construtor
        {
            nome = "";
            senha = "";
            privilegio = "";
        }

        //Propriedades
        public string nome;
        public string senha;
        public string privilegio;

        //Metodos

        public bool verificaSenha(string usuario, string senha)
        {
           
            if (usuario == "Lincoln" && senha == "12345")
            {
                return true;

            } else
            {
                return false;
            }
        }
        public string mostrarNome()
        {
            return nome;
        }

        public string mostrarSenha()
        {
            return senha;
        }

        public string mostrarPrivilegio()
        {
            return privilegio;
        }

    }
}

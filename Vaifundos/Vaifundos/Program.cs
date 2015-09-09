using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaifundos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clientes> list_cliente = null;
            List<Fundo_de_Investimento>list_fundo;
            Clientes clientecadastro = null;
            int cont = 0;
            int opcaoinicial = 0;
            int opcao = 0;


            Console.WriteLine("*******      Bem Vindo ao Sistema Vai Fundos     *******");
            Console.WriteLine("Se deseja efetuar operações de Banco digite 1, se deseja efetuar operações de Cliente digite 2:");
            if (opcaoinicial == 1)
            {
                Console.WriteLine("Se deseja efetuar cadastro de cliente digite 1.");
                Console.WriteLine("Se deseja efetuar cadastro de fundo digite 2.");
                opcao = Convert.ToInt32(Console.ReadLine());
                while (opcao == 1)
                {
                    clientecadastro = new Clientes();
                    Console.WriteLine("Entre com o nome do Cliente:");
                    clientecadastro.Nome = Console.ReadLine();
                    clientecadastro.Id = cont;
                    cont++;
                    Console.WriteLine("Deseja efetuar novo Cadastro? Se sim insira 1 novamente");
                    Console.WriteLine("Se deseja efetuar cadastro de fundo digite 2.");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    list_cliente.Add(clientecadastro);
                }
                while (opcao == 2)
                {
                    Console.WriteLine("Deseja cadastrar o Fundo em Real ou Dolar? Se Real digite 1 senão digite 2.");

                    
                }
            }
        }
    }
}

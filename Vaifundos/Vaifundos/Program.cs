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
            List<Fundo_de_Investimento>list_fundo = null;
            Fundo_Investimento_Real fundi_real;
            Fundo_Investimento_Dolar fundi_dolar;
            Clientes clientecadastro = null;
            Aplicação aplicationClient = null;
            List<Aplicação> list_aplication = new List<Aplicação>();
            string siglafundo = string.Empty;
            int opcaoaplicacaofundo = 0;
            int idcliente = 0;
            int cont = 0;
            int opcaoinicial = 0;
            int opcaofundo = 0;
            int opcao = 0;
            int opcaocliente = 0;


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
                    clientecadastro.getsetid = cont;
                    cont++;
                    Console.WriteLine("Deseja efetuar novo Cadastro? Se sim insira 1 novamente");
                    Console.WriteLine("Se deseja efetuar cadastro de fundo digite 2.");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    list_cliente.Add(clientecadastro);
                }
                while (opcao == 2)
                {
                    Console.WriteLine("Deseja cadastrar o Fundo em Real ou Dolar? Se Real digite 1 senão digite 2.");
                    while (opcaofundo == 1)
                    {
                        fundi_real = new Fundo_Investimento_Real();
                        Console.WriteLine("Insira o nome do fundo:");
                        fundi_real.Nome = Console.ReadLine();
                        Console.WriteLine("Entre com a Sigla que será usada no Fundo:");
                        siglafundo =  Console.ReadLine();
                        while (Fundo_de_Investimento.VerificaSigla(list_fundo, siglafundo))
                        {
                            Console.WriteLine("Esta Sigla ja está sendo usada! Entre com outra.");
                            siglafundo = Console.ReadLine();
                        }
                        fundi_real.Sigla = siglafundo;
                        Console.WriteLine("Deseja efetuar novo Cadastro? Se sim insira 1 novamente");
                        opcaofundo = Convert.ToInt32(Console.ReadLine());
                        list_fundo.Add(fundi_real);
                    }
                    while (opcaofundo == 2)
                    {
                        fundi_dolar = new Fundo_Investimento_Dolar();
                        Console.WriteLine("Insira o nome do fundo:");
                        fundi_dolar.Nome = Console.ReadLine();
                        Console.WriteLine("Entre com a Sigla que será usada no Fundo:");
                        while (Fundo_de_Investimento.VerificaSigla(list_fundo, siglafundo))
                        {
                            Console.WriteLine("Esta Sigla ja está sendo usada! Entre com outra.");
                            siglafundo = Console.ReadLine();
                        }
                        fundi_dolar.Sigla = siglafundo;
                        Console.WriteLine("Deseja efetuar novo Cadastro? Se sim insira 2 novamente");
                        opcaofundo = Convert.ToInt32(Console.ReadLine());
                        list_fundo.Add(fundi_dolar);
                    }
                    
                }
            }
            if (opcaoinicial == 2)
            {
                Console.WriteLine("Se deseja efetuar Aplicação digite 1.");
                Console.WriteLine("Se deseja efetuar Resgate digite 2.");
                Console.WriteLine("Se deseja transferir de um Fundo para outro digite 3.");
                while (opcaocliente == 1)
                {
                    aplicationClient = new Aplicação();
                    Console.WriteLine("Insira o seu ID:");
                    idcliente = Convert.ToInt32( Console.ReadLine());
                    Clientes.BuscaCliente(list_cliente,idcliente);
                    Console.WriteLine("Insira o valor que deseja aplicar");
                    aplicationClient.Valor = float.Parse(Console.ReadLine());
                    aplicationClient.Data_aplicacao = DateTime.Now;
                    list_aplication.Add(aplicationClient);
                    Console.WriteLine(" Se deseja efetuar a aplicação no Fundo de Investimento Dólar digite 1.");
                    Console.WriteLine(" Se deseja efetuar a aplicação no Fundo de Investimento Real digite 2.");
                    opcaoaplicacaofundo = Convert.ToInt32(Console.ReadLine());
                    if (opcaoaplicacaofundo == 1)
                    {
                        fundi_dolar = new Fundo_Investimento_Dolar();
                        Fundo_de_Investimento.ImprimirFundo(list_fundo);
                        Console.WriteLine("Escolha a Sigla da Lista de Fundos que deseja Aplicar:");
                        siglafundo = Console.ReadLine();
                        Fundo_de_Investimento.BuscaFundo(list_fundo,siglafundo);

                    }
                }
            }

        }
    }
}

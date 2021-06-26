using System;

namespace Sistema_Produtos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool senhaValida, menu;
            string senha;
            int cont = 0;

            int quantidade = 5;
            string[] nome, origemVoo, destinoVoo, horaVoo, dataVoo;

            string sN;


            nome = new string[quantidade];
            origemVoo = new string[quantidade];
            destinoVoo = new string[quantidade];
            dataVoo = new string[quantidade];
            horaVoo = new string[quantidade];

            senhaValida = false;
            menu = false;

            Console.WriteLine("Bem-vindo a Carija's Enterprise\n");

            Console.Write("Digite sua senha para acessar o sistema: ");
            senha = Console.ReadLine();

            
            while (senhaValida == false)
            {
                if (senha == "123456")
                {
                    while(menu == false){
                    
                    int acao;

                    Console.WriteLine(@"
   _______________________________            
   |  Digite o que deseja fazer  |
   |_____________________________|
   |    1 - Cadastrar passagem   |
   |     2 - Listar Passagens    |
   |          0 - Sair           |
   |_____________________________|
");

                    acao = int.Parse(Console.ReadLine());

                    switch (acao)
                    {
                        case 0:
                            menu = true;
                            Console.WriteLine("Programa finalizado");
                            break;
                        case 1:
                            Console.Write(@"
   ________________________________________________
   |  Você pode cadastrar no máximo 5 pessoas     |
   |______________________________________________|");
                            do
                            {

                                Console.Write("\n\nDigite seu nome: ");
                                nome[cont] = Console.ReadLine();

                                Console.Write("Digite a origem do seu voo: ");
                                origemVoo[cont] = Console.ReadLine();

                                Console.Write("Digite o destino do seu voo: ");
                                destinoVoo[cont] = Console.ReadLine();

                                Console.Write("Digite a data do seu voo (DD/MM/AA): ");
                                dataVoo[cont] = Console.ReadLine();

                                Console.Write("Digite o horário do seu voo (Em formato 24hrs): ");
                                horaVoo[cont] = Console.ReadLine();
                                cont++;

                                Console.WriteLine("Deseja cadastrar outra passagem S/N:");
                                sN = Console.ReadLine().ToLower();

                            } while (sN == "s");

                            break;
                        case 2:
                            for (var i = 0; i < cont; i++)
                            {
                                if (nome[i] != null && origemVoo[i] != null && destinoVoo[i] != null && horaVoo[i] != null && dataVoo[i] != null)
                                {
                                    Console.WriteLine($@"
   _________________________________
   |       Passagem {i + 1}
   |________________________________
   |   Nome: {nome[i]}          
   |   Origem do Voo: {origemVoo[i]} 
   |   Destino do Voo: {destinoVoo[i]}
   |   data do Voo: {dataVoo[i]}
   |   Horário do Voo: {horaVoo[i]}
   |________________________________");
                                }
                            }
                            break;
                    }
                    senhaValida = true;
                    }
                }
                else
                {
                    Console.Write(@"Senha incorreta! Digite sua senha para acessar o sistema: ");
                    senha = Console.ReadLine();
                    senhaValida = false;
                }
            }
        }
    }
    }


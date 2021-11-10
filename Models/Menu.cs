using System;
using System.Data.SqlClient;
using PraticandoProjeto.Data.DataCliente;
using PraticandoProjeto.Data.DataProduto;

namespace PraticandoProjeto.Models
{
    public class Menu
    {
        public Menu()
        {
            
        }

        public void TelaInicial()
        {
            Console.Clear();
            Console.WriteLine("=========================");
            Console.WriteLine("SEJA BEM VINDO AO MERCADO");
            Console.WriteLine("=========================");
            Console.WriteLine();
            Console.WriteLine("Digite um número referente a opção que deseja (1/2/3/4):");
            Console.WriteLine("");

            Console.WriteLine("1) Comprar Produtos");
            Console.WriteLine("2) Cadastro De Cliente");
            Console.WriteLine("3) Cadastro De Produtos");
            Console.WriteLine("4) Sair");

            Console.WriteLine();

            Console.WriteLine("=========================");

            Console.Write("Resposta: ");  
            int opcaoUsuario = Convert.ToInt32(Console.ReadLine());
                
                if(opcaoUsuario == 1)
                {
                  Console.WriteLine("Obrigado pela compra, deseja mais alguma coisa?");
                  string resposta = Console.ReadLine();
                  
                  if(resposta == "Sim")
                  {
                      TelaInicial();
                  }
                  else
                  {
                    Console.WriteLine();
                    Console.WriteLine("Volte sempre, obrigado!");
                    Console.WriteLine("=========================");
                  }
                  
                }

                else if(opcaoUsuario == 2)
                {
                  TelaCadastroCliente();
                }
            
            else if(opcaoUsuario == 3)
                {
                  TelaCadastroProduto();
                }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Volte sempre, obrigado!");
                Console.WriteLine("=========================");
                Console.ReadLine();
                Console.Clear(); 
            }
                       
        }

        public void TelaCadastroCliente()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("SEJA BEM VINDO AO MENU DO CLIENTE");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("Digite um número referente a opção que deseja (1/2/3/4/5):");
            Console.WriteLine("");

            Console.WriteLine("1) Cadastro Cliente");
            Console.WriteLine("2) Alterar Dados Do Cliente");
            Console.WriteLine("3) Excluir Cadastro Do Cliente");
            Console.WriteLine("4) Consultar Todos os Clientes Cadastrados");
            Console.WriteLine("5) Voltar Ao Menu");

            Console.WriteLine();

            Console.WriteLine("=========================");

            Console.Write("Resposta: ");  
            int opcaoUsuario = Convert.ToInt32(Console.ReadLine());
                
                if(opcaoUsuario == 1)
                {
                  CadastroCliente();
                }
                else if(opcaoUsuario == 2)
                {
                  AlterarCliente();
                }
                 else if(opcaoUsuario == 3)
                {
                  ExcluirCliente();
                }
                 else if(opcaoUsuario == 4)
                {
                  InformacoesCliente();
                }
                else
                {
                    TelaInicial();
                }
        }

        public void CadastroCliente()
        {
          Cliente cliente = new Cliente();
          SqlConnection conexao = Conexao.ObterConexao();

          try
          {
            
            conexao.Open();
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("Bem Vindo a Tela de Cadastro");
            Console.WriteLine("=============================");
            Console.WriteLine();

            Console.Write("Informe seu nome: ");
            cliente.nome = Console.ReadLine();
            Console.Write("Informe seu cpf: ");
            cliente.cpf = Console.ReadLine();
            Console.Write("Informe seu celular: ");
            cliente.celular = Console.ReadLine();
            Console.Write("Informe seu email: ");
            cliente.email = Console.ReadLine();

            Console.WriteLine("Tem certeza que deseja cadastrar o cliente? Digite: (Sim ou Não)");  
            string resposta = Console.ReadLine();

            if(resposta == "Sim")
            {
              Incluir.Novo(conexao, cliente);
              Console.WriteLine();
              Console.WriteLine("Cliente Cadastrado com sucesso!");
              Console.ReadLine();
              Console.Clear();
              TelaInicial();
            }
            else
            {
              Console.Clear();
              TelaInicial();
            }                        
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Não foi possivel cadastrar o cliente! {ex.Message}");
          }
          finally
          {
            conexao.Close();
          }          
          
        }

        public void AlterarCliente()
        {
          Cliente cliente = new Cliente();
          SqlConnection conexao = Conexao.ObterConexao();

          try
          {
              conexao.Open();
              Console.Clear();
              Console.WriteLine("=============================================");
              Console.WriteLine("Bem Vindo ao Menu de Alterar Cadastro Cliente");
              Console.WriteLine("=============================================");
              Console.WriteLine();

              Console.Write("Informe o Id do cliente que deseja alterar os dados: ");
              cliente.id = Convert.ToInt32(Console.ReadLine());
              Console.Write("Informe seu nome: ");
              cliente.nome = Console.ReadLine();
              Console.Write("Informe seu cpf: ");
              cliente.cpf = Console.ReadLine();
              Console.Write("Informe seu celular: ");
              cliente.celular = Console.ReadLine();
              Console.Write("Informe seu email: ");
              cliente.email = Console.ReadLine();

              Console.WriteLine("Tem certeza que deseja alterar o cadastro do cliente? Digite: (Sim ou Não)");  
              string resposta = Console.ReadLine();

              if(resposta == "Sim")
              {
                Editar.Atualizar(conexao, cliente);
                Console.WriteLine();
                Console.WriteLine("Cliente alterado com sucesso!");
                Console.ReadLine();
                Console.Clear();
                TelaInicial();
              }
              else
              {
                Console.Clear();
                TelaInicial();
              }

          }
          catch (Exception ex)
          {
              Console.WriteLine($"Não foi possivel alterar o cliente! {ex.Message}");
          }
          finally
          {
            conexao.Close();
          }
        }

        public void ExcluirCliente()
        {
           Cliente cliente = new Cliente();
           SqlConnection conexao = Conexao.ObterConexao();

           try
           {
              conexao.Open();
              Console.Clear();
              Console.WriteLine("================================================");
              Console.WriteLine("Bem Vindo ao Menu de Remover Cadastro Do Cliente");
              Console.WriteLine("================================================");
              Console.WriteLine();

              Console.Write("Informe o Id do cliente que deseja excluir: ");
              cliente.id = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Tem certeza que deseja cadastrar o cliente? Digite: (Sim ou Não)");  
              string resposta = Console.ReadLine();

              if(resposta == "Sim")
              {
                Excluir.Remover(conexao, cliente.id);
                Console.WriteLine();
                Console.WriteLine("Cliente excluido com sucesso!");
                Console.ReadLine();
                Console.Clear();
                TelaInicial();
              }
              else
              {
                Console.Clear();
                TelaInicial();
              }

           }
           catch (Exception ex)
           {
              Console.WriteLine($"Não foi possivel excluir o cliente! {ex.Message}");
           }
           finally
           {
             conexao.Close();
           }
        }

        public void InformacoesCliente()
        {
              SqlConnection conexao = Conexao.ObterConexao();

              try
              {
                  conexao.Open();
                  Console.Clear();
                  Console.WriteLine("================================================");
                  Console.WriteLine("Bem Vindo a Lista De Cadastro Dos Clientes");
                  Console.WriteLine("================================================");
                  Console.WriteLine();

                  string dados = Listar.ObterTodasAsInformacoesClientes(conexao);
                  Console.WriteLine(dados);

                  Console.WriteLine();
                  Console.WriteLine("================================================");
                  Console.WriteLine("================================================");
                  Console.WriteLine();

                  Console.ReadLine();
                  TelaInicial();
              }
              catch (Exception ex)
              {
                  Console.WriteLine($"Não foi possivel obter as informações dos clientes! {ex.Message}");
              }
              finally
              {
                conexao.Close();
              }
        }

        public void TelaCadastroProduto()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("SEJA BEM VINDO AO MENU DO PRODUTO");
            Console.WriteLine("=================================");
            Console.WriteLine();
            Console.WriteLine("Digite um número referente a opção que deseja (1/2/3/4/5):");
            Console.WriteLine("");

            Console.WriteLine("1) Cadastro Produto");
            Console.WriteLine("2) Alterar Dados Do Produto");
            Console.WriteLine("3) Excluir Cadastro Do Produto");
            Console.WriteLine("4) Consultar Todos os Produtos Cadastrados");
            Console.WriteLine("5) Voltar Ao Menu");

            Console.WriteLine();

            Console.WriteLine("=========================");

            Console.Write("Resposta: ");  
            int opcaoUsuario = Convert.ToInt32(Console.ReadLine());
                
                if(opcaoUsuario == 1)
                {
                  CadastroProduto();
                }
                else if(opcaoUsuario == 2)
                {
                  AlterarProduto();
                }
                 else if(opcaoUsuario == 3)
                {
                  RemoverProduto();
                }
                 else if(opcaoUsuario == 4)
                {
                  InformacoesDoProduto();
                }
                else
                {
                    TelaInicial();
                }
        }
   
        public void CadastroProduto()
        {
          Compra compra = new Compra();
          SqlConnection conexao = Conexao.ObterConexao();

          try
          {
            
            conexao.Open();
            Console.Clear();
            Console.WriteLine("=============================");
            Console.WriteLine("Bem Vindo a Tela de Cadastro");
            Console.WriteLine("=============================");
            Console.WriteLine();

            Console.Write("Informe a descrição do produto: ");
            compra.descricao = Console.ReadLine();
            Console.Write("Informe o valor unitario do produto: ");
            compra.valorUnitario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o estoque do produto: ");
            compra.estoque = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tem certeza que deseja cadastrar o produto? Digite: (Sim ou Não)");  
            string resposta = Console.ReadLine();

            if(resposta == "Sim")
            {
              IncluirProduto.Novo(conexao, compra);
              Console.WriteLine();
              Console.WriteLine("Produto Cadastrado com sucesso!");
              Console.ReadLine();
              Console.Clear();
              TelaInicial();
            }
            else
            {
              Console.Clear();
              TelaInicial();
            }                        
          }
          catch (Exception ex)
          {
              Console.WriteLine($"Não foi possivel cadastrar o produto! {ex.Message}");
          }
          finally
          {
            conexao.Close();
          }          
        }
    
        public void AlterarProduto()
        {
          Compra compra = new Compra();
          SqlConnection conexao = Conexao.ObterConexao();

          try
          {
              conexao.Open();
              Console.Clear();
              Console.WriteLine("=============================================");
              Console.WriteLine("Bem Vindo ao Menu de Alterar Cadastro Produto");
              Console.WriteLine("=============================================");
              Console.WriteLine();

              Console.Write("Informe o Id do produto que deseja alterar os dados: ");
              compra.id = Convert.ToInt32(Console.ReadLine());
              Console.Write("Informe a descrição do produto: ");
              compra.descricao = Console.ReadLine();
              Console.Write("Informe o valor unitario do produto: ");
              compra.valorUnitario = Convert.ToDouble(Console.ReadLine());
              Console.Write("Informe o estoque do produto: ");
              compra.estoque = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Tem certeza que deseja alterar o cadastro do produto? Digite: (Sim ou Não)");  
              string resposta = Console.ReadLine();

              if(resposta == "Sim")
              {
                EditarProduto.Atualizar(conexao, compra);
                Console.WriteLine();
                Console.WriteLine("Produto alterado com sucesso!");
                Console.ReadLine();
                Console.Clear();
                TelaInicial();
              }
              else
              {
                Console.Clear();
                TelaInicial();
              }

          }
          catch (Exception ex)
          {
              Console.WriteLine($"Não foi possivel alterar o produto! {ex.Message}");
          }
          finally
          {
            conexao.Close();
          }
        }
    
        public void RemoverProduto()
        {
          Compra compra = new Compra();
           SqlConnection conexao = Conexao.ObterConexao();

           try
           {
              conexao.Open();
              Console.Clear();
              Console.WriteLine("================================================");
              Console.WriteLine("Bem Vindo ao Menu de Remover Cadastro Do Produto");
              Console.WriteLine("================================================");
              Console.WriteLine();

              Console.Write("Informe o Id do produto que deseja excluir: ");
              compra.id = Convert.ToInt32(Console.ReadLine());

              Console.WriteLine("Tem certeza que deseja cadastrar o produto? Digite: (Sim ou Não)");  
              string resposta = Console.ReadLine();

              if(resposta == "Sim")
              {
                ExcluirProduto.Remover(conexao, compra.id);
                Console.WriteLine();
                Console.WriteLine("Produto excluido com sucesso!");
                Console.ReadLine();
                Console.Clear();
                TelaInicial();
              }
              else
              {
                Console.Clear();
                TelaInicial();
              }
           }
           catch (Exception ex)
           {
              Console.WriteLine($"Não foi possivel excluir o produto! {ex.Message}");
           }
           finally
           {
             conexao.Close();
           }
        }
   
        public void InformacoesDoProduto()
        {
          SqlConnection conexao = Conexao.ObterConexao();

              try
              {
                  conexao.Open();
                  Console.Clear();
                  Console.WriteLine("================================================");
                  Console.WriteLine("Bem Vindo a Lista De Cadastro Dos Produtos");
                  Console.WriteLine("================================================");
                  Console.WriteLine();

                  string dados = ListarProduto.ObterTodasAsInformacoesCompras(conexao);
                  Console.WriteLine(dados);

                  Console.WriteLine();
                  Console.WriteLine("================================================");
                  Console.WriteLine("================================================");
                  Console.WriteLine();

                  Console.ReadLine();
                  TelaInicial();
              }
              catch (Exception ex)
              {
                  Console.WriteLine($"Não foi possivel obter as informações dos produtos! {ex.Message}");
              }
              finally
              {
                conexao.Close();
              }
        }
    }
}
using ProjetoDOS02_2.Entities;
using ProjetoDOS02_2.Inputs;
using ProjetoDOS02_2.Repositories;
using System;
using System.Collections.Generic;

namespace ProjetoDOS02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ####    EXPORTADOR DE DADOS DE VENDA    ####\n");
            Console.WriteLine("\nEntre com os dados da Venda:\n");

            var venda = new Venda();

            venda.IdVenda = Guid.NewGuid();
            venda.Total = VendaInput.LerTotal();
            venda.Data = DateTime.Parse(VendaInput.LerData());
            venda.Clientes = new List<Cliente>();
            venda.ItensVendas = new List<ItensVenda>();

            var cliente = new Cliente();
            int contador; contador = 1;
            
            cliente.IdCliente = (contador++);
            cliente.Nome = ClienteInput.LerNome();
            cliente.Cpf = ClienteInput.LerCpf();
            cliente.Enderecos = new List<Endereco>();
            
            venda.Clientes.Add(cliente);

            var endereco = new Endereco();

            endereco.IdEndereco = Guid.NewGuid();
            endereco.Logradouro = EnderecoInput.LerLogradouro();
            endereco.Bairro = EnderecoInput.LerBairro();
            endereco.Cidade = EnderecoInput.LerCidade();
            endereco.Estado = EnderecoInput.LerEstado();
            endereco.Cep = EnderecoInput.LerCep();
            
            cliente.Enderecos.Add(endereco);

            Console.Write("Informe a quantidade de Itens....: ");
            var qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                try
                {
                    Console.WriteLine($"\nInforme o {i}º de Item da venda....: \n");

                    var itensVenda = new ItensVenda();

                    itensVenda.IdItensVenda = Guid.NewGuid();
                    itensVenda.Produto = ItensVendaInput.LerProduto();
                    itensVenda.Preco = ItensVendaInput.LerPreco();
                    itensVenda.Categorias = new List<Categoria>();
                    venda.ItensVendas.Add(itensVenda);

                    var categoria = new Categoria();

                    categoria.IdCategoria = Guid.NewGuid();
                    categoria.Descricao = CategoriaInput.LerDescricao();
                    
                    itensVenda.Categorias.Add(categoria);

                }
                catch (Exception e)
                {
                    Console.WriteLine($"\nErro: {e.Message}");
                }
            }
            try
            {
                var vendaRepository = new VendaRepository();
                vendaRepository.ExportaDados(venda);

                Console.WriteLine("\n  --  DADOS GRAVADOS COM SUCESSO!  -- ");
            }

            catch (Exception e)
            {
                Console.WriteLine($"\nErro ao exportar dados: {e.Message}");
            }


            Console.ReadKey();
        }

    }
}

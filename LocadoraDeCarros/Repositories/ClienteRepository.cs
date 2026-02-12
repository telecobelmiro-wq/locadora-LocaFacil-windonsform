using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeCarros.Banco;
using LocadoraDeCarros.Modelo;
using Dapper;
namespace LocadoraDeCarros.Repositories
{
    public class ClienteRepository
    {
        private static readonly ConexaoBanco conexaoBanco = new ConexaoBanco();

        public static async Task<IEnumerable<Cliente>> ObterTodos()
        {
            var clientes = await conexaoBanco.CriarConexao()
                .QueryAsync<Cliente>(
                @"
                    SELECT
                        Id,
                        Nome,
                        Email,
                        Sexo,
                        Cpf,
                        DataNascimento
                    FROM Cliente
                ");

            return clientes;
        }
        public static async Task Adicionar(Cliente cliente)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
                @"
                    INSERT INTO Cliente
                    (Nome, Email, Sexo, Cpf, DataNascimento)
                    VALUES
                    (@Nome, @Email, @Sexo, @Cpf, @DataNascimento)
                ", cliente);
        }

        public static async Task Deletar(int idCliente)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
                @"
                    DELETE FROM Cliente
                    WHERE Id = @Id
                ", new { Id = idCliente });
        }

        public static async Task<Cliente> ObterPorId(int idCliente)
        {
            var cliente = await conexaoBanco.CriarConexao()
                .QueryFirstOrDefaultAsync<Cliente>(
                @"
                    SELECT
                        Id,
                        Nome,
                        Email,
                        Sexo,
                        Cpf,
                        DataNascimento
                    FROM Cliente
                    WHERE Id = @Id
                ", new { Id = idCliente });

            return cliente;
        }

        public static async Task Atualizar(Cliente clienteEdicao)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
                @"
                    UPDATE Cliente
                    SET
                        Nome = @Nome,
                        Email = @Email,
                        Sexo = @Sexo,
                        Cpf = @Cpf,
                        DataNascimento = @DataNascimento
                    WHERE
                        Id = @Id
                ", clienteEdicao);
        }


    }
}

using LocadoraDeCarros.Banco;
using LocadoraDeCarros.Modelo;
using Dapper;

namespace LocadoraDeCarros.Repositories
{
    public class EmprestimosRepository
    {
        private static readonly ConexaoBanco conexaoBanco = new ConexaoBanco();

        public static async Task<IEnumerable<Emprestimos>> ObterTodos()
        {
            var emprestimos = await conexaoBanco.CriarConexao()
                .QueryAsync<Emprestimos>(
                @"
                    SELECT
                        Id,
                        IdCliente,
                        IdCarro,
                        Status,
                        ValorTotal,
                        DataRetirada,
                        DataDevolucao
                    FROM Emprestimos
                ");

            return emprestimos;
        }

        public static async Task Adicionar(Emprestimos emprestimo)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
                @"
                    INSERT INTO Emprestimos
                    (IdCliente, IdCarro, Status, ValorTotal, DataRetirada, DataDevolucao)
                    VALUES
                    (@IdCliente, @IdCarro, @Status, @ValorTotal, @DataRetirada, @DataDevolucao)
                ", emprestimo);
        }

        public static async Task Deletar(int id)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
                @"
                    DELETE FROM Emprestimos
                    WHERE Id = @Id
                ", new { Id = id });
        }

        public static async Task<Emprestimos> ObterPorId(int id)
        {
            var emprestimo = await conexaoBanco.CriarConexao()
                .QueryFirstOrDefaultAsync<Emprestimos>(
                @"
                    SELECT
                        Id,
                        IdCliente,
                        IdCarro,
                        Status,
                        ValorTotal,
                        DataRetirada,
                        DataDevolucao
                    FROM Emprestimos
                    WHERE Id = @Id
                ", new { Id = id });

            return emprestimo;
        }

        public static async Task Atualizar(Emprestimos emprestimo)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
                @"
                    UPDATE 
                        IdCliente = @IdCliente,
                        IdCarro = @IdCarro,
                        Status = @Status,
                        ValorTotal = @ValorTotal,
                        DataRetirada = @DataRetirada,
                        DataDevolucao = @DataDevolucao
                    FROM Emprestimos
                    WHERE
                        Id = @Id
                ", emprestimo);
        }
    }
}
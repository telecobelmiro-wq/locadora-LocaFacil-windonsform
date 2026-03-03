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
                    (IdCliente, IdCarro, Status, DataRetirada, DataDevolucao)
                    VALUES
                    (@IdCliente, @IdCarro, @Status, @DataRetirada, @DataDevolucao)
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
            UPDATE Emprestimos
            SET
                IdCliente = @IdCliente,
                IdCarro = @IdCarro,
                Status = @Status,
                DataRetirada = @DataRetirada,
                DataDevolucao = @DataDevolucao
            WHERE Id = @Id
        ", emprestimo);
        }
        public static async Task<Emprestimos> ObterPorUsuario(int idUsuario)
        {
            var emp = await conexaoBanco.CriarConexao()
                .QueryFirstOrDefaultAsync<Emprestimos>(
                @"SELECT * FROM Emprestimos WHERE IdCliente = @Id",
                new { Id = idUsuario });

            return emp;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeCarros.Banco;
using LocadoraDeCarros.Modelo;
using Dapper;
using System.Data.SqlClient;



    namespace LocadoraDeCarros.Repositories
    {
        public class CarroRepository
        {
            private static readonly ConexaoBanco conexaoBanco = new ConexaoBanco();

            public static async Task<IEnumerable<Carro>> ObterTodos()
            {
                var carros = await conexaoBanco.CriarConexao()
                    .QueryAsync<Carro>(
                    @"
                    SELECT
                        Id,
                        Modelo,
                        Marca,
                        Cor,
                        Preco,
                        Ano
                    FROM Carro
                ");

                return carros;
            }

            public static async Task Adicionar(Carro carro)
            {
                await conexaoBanco.CriarConexao().ExecuteAsync(
                    @"
                    INSERT INTO Carro
                    (Modelo, Marca, Cor, Preco, Ano)
                    VALUES
                    (@Modelo, @Marca, @Cor, @Preco, @Ano)
                ", carro);
            }

            public static async Task Deletar(int idCarro)
            {
                await conexaoBanco.CriarConexao().ExecuteAsync(
                    @"
                    DELETE FROM Carro
                    WHERE Id = @Id
                ", new { Id = idCarro });
            }

            public static async Task<Carro> ObterPorId(int idCarro)
            {
                var carro = await conexaoBanco.CriarConexao()
                    .QueryFirstOrDefaultAsync<Carro>(
                    @"
                    SELECT
                        Id,
                        Modelo,
                        Marca,
                        Cor,
                        Preco,
                        Ano
                    FROM Carro
                    WHERE Id = @Id
                ", new { Id = idCarro });

                return carro;
            }

        public static async Task Atualizar(Carro carroEdicao)
        {
            await conexaoBanco.CriarConexao().ExecuteAsync(
                @"
                    UPDATE Carro
                    SET
                        Modelo = @Modelo,
                        Marca = @Marca,
                        Cor = @Cor,
                        Preco = @Preco,
                        Ano = @Ano
                    WHERE
                        Id = @Id
                ", carroEdicao);
        }

           
        }
    }
        
    

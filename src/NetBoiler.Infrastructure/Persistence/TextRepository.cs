using System.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using NetBoiler.Application.Interfaces;
using Npgsql;


namespace NetBoiler.Infrastructure.Persistence;

public class TextRepository : ITextRepository
{
    private readonly string _connectionString;

    public TextRepository(IConfiguration config)
    {
        _connectionString = config.GetConnectionString("DefaultConnection")!;
    }

    public async Task SaveTextAsync(string text)
    {
        using IDbConnection db = new NpgsqlConnection(_connectionString);
        const string sql = "INSERT INTO fetched_texts (content, created_at) VALUES (@content, NOW())";
        await db.ExecuteAsync(sql, new { content = text });
    }
}

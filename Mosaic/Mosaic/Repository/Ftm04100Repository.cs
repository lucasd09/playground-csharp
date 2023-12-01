using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using Mosaic.Models.Ftm04100;

public class Ftm04100Repository
{
    private readonly string _connectionString;

    public Ftm04100Repository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IEnumerable<Ftm04100> GetAll()
    {
        using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
        {
            dbConnection.Open();
            return dbConnection.Query<Ftm04100>("SELECT * FROM Ftm04100");
        }
    }

    public void Insert(Ftm04100 acesso)
    {
        using (IDbConnection dbConnection = new MySqlConnection(_connectionString))
        {
            dbConnection.Open();
            dbConnection.Insert(acesso);
        }
    }
}

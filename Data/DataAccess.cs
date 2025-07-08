using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Data
{
  public class DataAccess
  {

    private String connectionString = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;
    public DataAccess() { }
    public DataTable GetDataTable(String nameTable, String querySql)
    {
      using (SqlConnection connection = GetConnection())
      {
        try
        {
          DataSet dataSet = new DataSet();
          SqlDataAdapter dataAdapter = GetDataAdapter(querySql, connection);
          dataAdapter.Fill(dataSet, nameTable);
          return dataSet.Tables[nameTable];
        }
        catch (SqlException err)
        {
          Console.WriteLine("Error: " + err.Message);
          return null;
        }
      }
    }
    public DataTable GetDataTable(String querySql)
    {
      using (SqlConnection connection = GetConnection())
      {
        try
        {
          DataSet dataSet = new DataSet();
          SqlDataAdapter dataAdapter = GetDataAdapter(querySql, connection);
          dataAdapter.Fill(dataSet);
          return dataSet.Tables[0];  // devolver la primera tabla
        }
        catch (SqlException err)
        {
          Console.WriteLine("Error: " + err.Message);
          return null;
        }
      }
    }
    private SqlConnection GetConnection()
    {
      try
      {
        // string connectionString = ConfigurationManager.ConnectionStrings["MiConexionSQL"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
      }
      catch (SqlException err)
      {
        Console.WriteLine("Something went wrong to the connection to the Database " + err.Message);
        return null;
      }
    }
    private SqlDataAdapter GetDataAdapter(String querySql, SqlConnection connection)
    {
      try
      {
        SqlDataAdapter dataAdapter;
        dataAdapter = new SqlDataAdapter(querySql, connection);
        return dataAdapter;
      }
      catch (SqlException err)
      {
        Console.WriteLine("Something went wrong when the DataAdapter got " + err.Message);
        return null;
      }
    }
  }
}

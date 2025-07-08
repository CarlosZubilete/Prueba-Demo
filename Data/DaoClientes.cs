using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Data
{
  public class DaoClientes
  {
    public DaoClientes() { }
    public DataTable GetAllCostumers()
    {
      DataAccess dataAccess = new DataAccess();
      return dataAccess.GetDataTable($"SELECT * FROM clientes");
    }
  }
}

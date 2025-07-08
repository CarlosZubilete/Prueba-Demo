using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data;

namespace Business
{
  public class ClientesService
  {
    public DataTable GetAllCostumers()
    {
      DaoClientes dao = new DaoClientes();
      return dao.GetAllCostumers();
    }
  }
}

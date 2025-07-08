using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;

namespace Views
{
  public partial class Index : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        this.Load_GridCostumers();
      }
    }
    private void Load_GridCostumers()
    {
      ClientesService clientesService = new ClientesService();
      gridCostumers.DataSource = clientesService.GetAllCostumers();
      gridCostumers.DataBind();
    }
  }
}
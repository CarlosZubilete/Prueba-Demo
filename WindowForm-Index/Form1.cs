using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Business;


namespace WindowForm_Index
{
  public partial class Index : Form
  {
    public Index()
    {
      InitializeComponent();
      this.Load += Form1_Load;
      this.gridCostumers.AutoGenerateColumns = true;
      //ClientesService clientesService = new ClientesService();
      //DataTable lista = clientesService.GetAllCostumers();
      //MessageBox.Show("Cantidad de registros: " + lista.Rows.Count.ToString()); // 'Output: Cantidad de registros 10 '
    }
    private void Form1_Load(object sender, EventArgs e)
    {
      Load_GridCostumers();
    }
    private void Load_GridCostumers()
    {
      ClientesService clientesService = new ClientesService();
      DataTable data = clientesService.GetAllCostumers();
      gridCostumers.DataSource = data;
    }
  }
}

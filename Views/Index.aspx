<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Views.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    
      <h1>HI, I'M A PROGRAMER IN C#</h1>

      <%--Grid con los resultados: --%>
      <div class="container_costumers">
        <asp:GridView runat="server" ID="gridCostumers" CssClass="container_costumers_grid"></asp:GridView>
      </div>
  
  </form>
</body>
</html>

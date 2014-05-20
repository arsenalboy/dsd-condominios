<%@ Page Language="C#" AutoEventWireup="true" CodeFile="consultaVisitantes.aspx.cs" Inherits="consultaVisitantes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
  
  <jsp:include page="/pages/header.jsp" />
  <form id="frmMorosos" action="/SISTEMACONDOMINIOWEB/ConsultaVisitasServlet" method=post>
  <input type="hidden" id="hidopcion"  name="opcion">  
    <div class="jumbotron">
      <div class="container">
        <h3>Consulta de Visitantes</h3>

      </div>
    </div>
    <div class="container">
      <hr>
      <div class="row">
        <div class="col-md-3" >
          <h4>Residente</h4>
        </div>
        <div class="col-md-3">
                 <asp:TextBox type="text" id="txtcodigo" name="codigo" class="form-control"  runat="server"></asp:TextBox>
        </div>
     
        <div class="col-md-3">
            <asp:Button ID="Button1" runat="server" Text="Buscar" class="btn btn-primary"/>
        </div>
      </div>
      <hr>
      <table class="table table-bordered table-hover" id="jqueryDataTable">
        <thead>
          <tr class="success">
            <th>DNI Visitante</th>
            <th>Nombre Visitante</th>
            <th>Residente</th>
            <th>Fecha Visita</th>
          </tr>
        </thead>
        <tbody id="div_resultado">
          <c:forEach var="bean" items="${requestScope.lista}" varStatus="i">
          <tr>
          	<td></td>
          	<td></td>
          	<td></td>
          	<td></td>
          </tr>
          </c:forEach>
          <div ></div>
        </tbody>
      </table>  
      <footer></footer>
    </div>
  
    </form>

    </div>
    </form>
</body>
</html>

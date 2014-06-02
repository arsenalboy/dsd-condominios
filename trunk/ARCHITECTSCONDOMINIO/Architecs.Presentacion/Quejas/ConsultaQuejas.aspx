<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaQuejas.aspx.cs" Inherits="Architecs.Presentacion.Quejas.ConsultaQuejas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
 <body>
  
  <jsp:include page="/pages/header.jsp" />
  <form id="frmMorosos" action="/SISTEMACONDOMINIOWEB/ConsultaQuejasServlet" method=post>
  <input type="hidden" id="hidopcion"  name="opcion">  
    <div class="jumbotron">
      <div class="container">
        <h3>Consulta de Quejas</h3>

      </div>
    </div>
    <div class="container">
      <hr>
      <div class="row">
        <div class="col-md-3" >
          <h4>Tipo de Queja</h4>
        </div>
        <div class="col-md-3">
          <input type="text" id="txtcodigo" name="codigo" class="form-control" 
          onKeyUp="filtrarQueja('filtroQuejas.jsp','&filtro='+this.value,'div_resultado')">
        </div>
        <div class="col-md-3">
          <div class="checkbox">
            <label>
              <input type="checkbox"  id="chktodos" name="todos">Todos</label>
          </div>
        </div>
        <div class="col-md-3">
             <input type="button" class="btn btn-primary" value="Buscar"
              onclick="filtrarQueja('filtroQuejas.jsp','&filtro=e','div_resultado')"/>
        </div>
      </div>
      <hr>
      <table class="table table-bordered table-hover" id="jqueryDataTable">
        <thead>
          <tr class="success">
            <th>ID Queja</th>
            <th>Residente</th>
            <th>Tipo Queja</th>
            <th>Motivo Queja</th>
            <th>Estado</th>
          </tr>
        </thead>
        <tbody id="div_resultado">
          
        </tbody>
      </table>  
      <footer></footer>
    </div>
  
    </form>
  </body>
</html>

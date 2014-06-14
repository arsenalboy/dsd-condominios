 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRegistrarVisita.aspx.cs" Inherits="Architecs.Presentacion.Visitas.frmRegistrarVisita" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
   	<jsp:include page="/pages/header.jsp" />
  	<div class="jumbotron">
      <div class="container">
        <h3>Registro de Visitas</h3>
        <p></p>
      </div>
    </div>
    <form id="form1" runat="server">
      
      <div class="container">
        <table class="table">
          <tbody>          
            <tr>
              <td>Número de Documento:</td>
              <td>
                  <asp:TextBox class="form-control" type="text" id="txtC_NumDocumento" name="txtC_NumDocumento" 
                      required runat="server"></asp:TextBox>
              </td>
            </tr>
            <tr>
              <td>Nombre de Visitante:</td>
              <td>
                <asp:TextBox class="form-control" id="txtC_Nombre" name="txtC_Nombre" required 
                      runat="server"></asp:TextBox>
              </td>
            </tr>
            <tr>
              <td>Residente:</td>
              <td>
                  <asp:DropDownList ID="DdlResidente" runat="server" class="form-control">
                  </asp:DropDownList>
              </td>
            </tr>
            <tr>
              <td>Fecha de Visita:</td>
              <td>
                  <asp:TextBox class="form-control" type= "date" id="txtFecha" name="txtFecha" required autofocus onchange="validarFechaMenorActual(this.value);" runat="server"></asp:TextBox>
              	<dvi id="div_resultado"></dvi>
              </td>
            </tr>
            <tr>
              <td></td>
              <td>
                <div class="btn-group">
                    <asp:Button ID="btnRegistar" runat="server" Text="Registrar" 
                        class="btn btn-default" onclick="btnRegistar_Click"/>
                </div>
                <div>
            		<p></p>
                    <div style="display:none;" id="divacepto">
                        <div class="alert alert-success"  >
			                <button type="button" class="close" data-dismiss="alert">&times;</button>
			                <b>En hora buena,</b> La Visita se registró con éxito.
			            </div>
                    </div>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </form>
</body>
</html>

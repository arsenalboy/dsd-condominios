<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreaQueja.aspx.cs" Inherits="Architecs.Presentacion.Quejas.CreaQueja" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/bootstrap_black.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../Scripts/jquery-menu.min.js"></script>
    <script type="text/javascript" src="../Scripts/bootstrap.min.js"></script>
</head>
<body>
  	<!-- #include file="../header.aspx" -->
  	<div class="jumbotron">
      <div class="container">
        <h3>REGISTO DE QUEJAS</h3>
        <p></p>
      </div>
    </div>
    <form id="form1" runat="server">
      
      <div class="container">
        <table class="table">
          <tbody>
            <tr>
              <td>Fecha de Queja:</td>
              <td>
                  <asp:TextBox class="form-control" type= "date" id="txtFecha" name="txtFecha" required autofocus onchange="validarFechaMenorActual(this.value);" runat="server"></asp:TextBox>
              	<dvi id="div_resultado"></dvi>
              </td>
            </tr>
            <tr>
              <td>Tipo de Queja:</td>
              <td>
                  <asp:DropDownList ID="CboTipoQueja" runat="server" class="form-control">
                      <asp:ListItem Selected="True">Leve</asp:ListItem>
                      <asp:ListItem>Grave</asp:ListItem>
                      <asp:ListItem>Muy Grave</asp:ListItem>
                  </asp:DropDownList>
              </td>
            </tr>
            <tr>
              <td>Motivo:</td>
              <td>
                  <asp:TextBox class="form-control" type="text" id="txtMotivo" name="txtMotivo" 
                      required runat="server" TextMode="MultiLine"></asp:TextBox>
              </td>
            </tr>
            <tr>
              <td>Detalle de la Queja:</td>
              <td>
                <asp:TextBox class="form-control" id="TxtDetalle" name="txtDetalle" required 
                      runat="server" TextMode="MultiLine"></asp:TextBox>
              </td>
            </tr>
            <tr>
              <td></td>
              <td>
                <div class="btn-group">
                    <asp:Button ID="botonEnviar" runat="server" Text="ENVIAR" 
                        class="btn btn-default" onclick="botonEnviar_Click"/>
                </div>
                <div>
                
           
            		      <p></p>
                           <div style="display:none;" id="divacepto">
                                <div class="alert alert-success"  >
			                    <button type="button" class="close" data-dismiss="alert">&times;</button>
			                    <b>En hora buena,</b> Su Queja se registró con éxito.
			                    </div>
         
                          </div>
            	


			         <%-- <p></p>
			          <div class="alert alert-danger">
			            <button type="button" class="close" data-dismiss="alert">&times;</button>
			            <b>ERROR!</b> No se pudo insertar el registro.
			          </div>--%>
            	
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </form>
  </body>
</html>

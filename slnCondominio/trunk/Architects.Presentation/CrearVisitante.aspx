<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CrearVisitante.aspx.cs" Inherits="CrearVisitante" %>

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
  	<div class="jumbotron">
      <div class="container">
        <h3>REGISTRO DE VISITANTES</h3>
        <p></p>
      </div>
    </div>
   
      
      <div class="container">      
        <table class="table">        
          <tbody>
            <tr>
              <td>DNI Visitante:</td>
              <td>
                      <asp:TextBox  id="txtDNIVisitante" runat="server" class="form-control" type="text"  name="txtDNIVisitante" required autofocus></asp:TextBox>
              </td>
            </tr>
            <tr>
              <td>Nombre Visitante:</td>
              <td>
                   <asp:TextBox  id="TextBox1" runat="server" class="form-control" type="text"  name="txtDNIVisitante" required></asp:TextBox>
              </td>
            </tr>
            <tr>
              <td>Residente:</td>
              <td>
                  <asp:DropDownList class="form-control" id="txtResidente" name="txtResidente" runat="server">
                  </asp:DropDownList>
               
              </td>
            </tr>
            <tr>
              <td>Fecha de Visita:</td>
              <td>
                    <asp:TextBox class="form-control" type= "date" id="txtFechaVisita" name="txtFechaVisita" required  runat="server"></asp:TextBox>
              </td>
            </tr>
            <tr>
              <td></td>
              <td>
                <div class="btn-group">
                    <asp:Button ID="Button1" runat="server" Text="Button" class="btn btn-default"/>
                </div>
                <div>
        
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>


    </div>
    </form>
</body>
</html>

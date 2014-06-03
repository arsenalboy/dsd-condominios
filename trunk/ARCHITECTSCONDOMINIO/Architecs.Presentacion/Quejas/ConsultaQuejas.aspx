<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaQuejas.aspx.cs" Inherits="Architecs.Presentacion.Quejas.ConsultaQuejas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
 <body>
  
  <jsp:include page="/pages/header.jsp" />
  <form id="frmMorosos"  runat="server">
  <input type="hidden" id="hidopcion"  name="opcion">  
    <div class="jumbotron">
      <div class="container">
        <h3>Consulta de Quejas</h3>

      </div>
    </div>
    <div class="container">
      <hr>
      <div class="row">
        <div class="col-md-6" >
          <h4>Tipo de Queja</h4>
        </div>
        <div class="col-md-6">
          <asp:DropDownList ID="CboTipoQueja" runat="server" class="form-control">
                      <asp:ListItem Selected="True">Todos</asp:ListItem>
                      <asp:ListItem>Leve</asp:ListItem>
                      <asp:ListItem>Grave</asp:ListItem>
                      <asp:ListItem>Muy Grave</asp:ListItem>
                  </asp:DropDownList>
        </div>
    <%--    <div class="col-md-3">
          <div class="checkbox">
            <label>
              <input type="checkbox"  id="chktodos" name="todos">Todos</label>
          </div>
        </div>--%>
        <div class="col-md-6" >
          <h4>Desde</h4>
        </div>
        <div class="col-md-6" >
          <asp:TextBox class="form-control" type= "date" id="TxtDesde" name="TxtDesde" required autofocus onchange="validarFechaMenorActual(this.value);" runat="server"></asp:TextBox>
        </div>
         <div class="col-md-6" >
          <h4>Hasta</h4>
        </div>
        <div class="col-md-6" >
          <asp:TextBox class="form-control" type= "date" id="TxtHasta" name="TxtHasta" required autofocus onchange="validarFechaMenorActual(this.value);" runat="server"></asp:TextBox>
        </div>
        <div class="col-md-6">
        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" class="btn btn-primary" 
                onclick="BtnBuscar_Click"/>
             
        </div>
      </div>
      <hr>
     <%-- <table class="table table-bordered table-hover" id="jqueryDataTable">
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
      </table>  --%>
        <asp:GridView ID="GvQuejas" runat="server" 
            class="table table-bordered table-hover" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="N_IdQueja" HeaderText="N_IdQueja" >
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="N_IdResidente" HeaderText="N_IdResidente" 
                    Visible="False" />
                <asp:BoundField DataField="C_Tipo" HeaderText="Tipo" >
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="C_Motivo" HeaderText="Motivo" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="D_FecRegistro" HeaderText="Fecha Registro" 
                    DataFormatString="{0:dd/MM/yyyy}">
                <ItemStyle HorizontalAlign="Center" Width="90px" />
                </asp:BoundField>
                <asp:BoundField DataField="B_Estado" HeaderText="B_Estado" Visible="False" />
                <asp:BoundField DataField="C_Nombre" HeaderText="RESIDENTE" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="C_NumDocume" HeaderText="Documento" >
                <ItemStyle HorizontalAlign="Center" Width="90px" />
                </asp:BoundField>
                <asp:BoundField DataField="C_Detalle" HeaderText="Detalle" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="D_FecQueja" HeaderText="Fecha Queja" >
                <ItemStyle HorizontalAlign="Center" Width="90px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
      <footer>
      <p></p>
			          <div class="alert alert-danger" id="divaviso" style="display:none;">
			            <button type="button" class="close" data-dismiss="alert">&times;</button>
			            <b>AVISO!</b> No se encuentra registros con el criterio de busqueda.
			          </div>
      </footer>
    </div>
  
    </form>
  </body>
</html>

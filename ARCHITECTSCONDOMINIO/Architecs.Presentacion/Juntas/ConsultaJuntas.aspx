<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaJuntas.aspx.cs" Inherits="Architecs.Presentacion.Juntas.ConsultaJuntas" %>

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
        <h3>Consulta de Juntas</h3>

      </div>
    </div>
    <div class="container">
      <hr>
      <div class="row">
      
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
        <asp:Button ID="BtnBuscar" runat="server" Text="Consultar" class="btn btn-primary" 
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
        <asp:GridView ID="DgvJuntas" runat="server" 
            class="table table-bordered table-hover" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="N_IdJunta" HeaderText="ID" >
                <ItemStyle Width="50px" />
                </asp:BoundField>
                <asp:BoundField DataField="D_Fecha" HeaderText="FECHA REGISTRO" 
                    DataFormatString="{0:dd/MM/yyyy}">
                <ItemStyle HorizontalAlign="Center" Width="90px" />
                </asp:BoundField>
                <asp:BoundField DataField="C_Hora" HeaderText="HORA" 
                    Visible="False" />
                <asp:BoundField DataField="C_Tema" HeaderText="TEMA A TRATAR" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="C_Acuerdo" HeaderText="ACUERDO" >
                <ItemStyle Width="200px" />
                </asp:BoundField>           
                <asp:BoundField DataField="C_NomPer" HeaderText="PRECIDEN" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="C_Cargo" HeaderText="CARGO" >
                <ItemStyle HorizontalAlign="Left" Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="C_PREJUN" HeaderText="ES PRESIDENTE" >
                <ItemStyle Width="80px" />
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

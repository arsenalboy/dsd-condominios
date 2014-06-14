<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVisita.aspx.cs" Inherits="Architecs.Presentacion.Visitas.frmVisita" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visitas</title>
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <jsp:include page="/pages/header.jsp" />
    <form id="form1" runat="server">
    
    <input type="hidden" id="hidopcion"  name="opcion">  
    <div class="jumbotron">
      <div class="container">
        <h3>Consulta de Visitas</h3>

      </div>
    </div>
    <div class="container">
      <hr>
      <div class="row">
        <div class="col-md-6" >
          <h4>Apellidos del Residente</h4>
        </div>
        <div class="col-md-6">
            <asp:DropDownList ID="DdlResidente" runat="server" class="form-control">                      
            </asp:DropDownList>
        </div>     
        <div class="col-md-6" >
          <h4>Fecha de Visita</h4>
        </div>
        <div class="col-md-6" >
          <asp:TextBox class="form-control" type= "date" id="txtFecVisita" name="TxtDesde" autofocus onchange="validarFechaMenorActual(this.value);" runat="server"></asp:TextBox>
        </div>       
        <div class="col-md-6">
        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" class="btn btn-primary" 
                onclick="BtnBuscar_Click" />             
        </div>
      </div>
      <hr />
        <asp:GridView ID="grVisitas" runat="server" 
            class="table table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="N_IdVisitante">
            <Columns>
                <asp:BoundField DataField="N_IdVisitante" HeaderText="N_IdVisitante" >
                <ItemStyle Width="50px" />
                </asp:BoundField>
                <asp:BoundField DataField="N_IdResidente" HeaderText="N_IdResidente" 
                    Visible="False" />
                <asp:BoundField DataField="O_ResidenteBE.C_NumDocume" HeaderText="NroDoc Visitante" >
                <ItemStyle Width="50px" />
                </asp:BoundField>
                <asp:BoundField DataField="C_Nombre" HeaderText="Nombre Visitante" >
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:BoundField DataField="D_FecVisita" HeaderText="Fecha Visita" 
                    DataFormatString="{0:dd/MM/yyyy}">
                <ItemStyle HorizontalAlign="Center" Width="90px" />
                </asp:BoundField>                
                <asp:BoundField DataField="O_ResidenteBE.C_Nombre" HeaderText="Nombre Residente" >
                <ItemStyle Width="170px" />
                </asp:BoundField>
                <asp:BoundField DataField="O_ResidenteBE.C_Apellidos" HeaderText="Apellido Residente" >
                <ItemStyle HorizontalAlign="Center" Width="170px" />
                </asp:BoundField>                
            </Columns>
        </asp:GridView>
      <footer>
    <p></p>
	<div class="alert alert-danger" id="divaviso" style="display:none;">
	    <button type="button" class="close" data-dismiss="alert">&times;</button>
	    <b>AVISO!</b> No se encuentran registros con el criterio de busqueda.
	</div>
    </footer>
    </div>
    </form>
</body>
</html>

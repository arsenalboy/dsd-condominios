<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmViviendas.aspx.cs" Inherits="Architecs.Presentacion.frmViviendas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listado de Viviendas</title>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.4.1-vsdoc.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <jsp:include page="/pages/header.jsp" />
    <div>
        <div class="jumbotron">
            <div class="container">
                <h3>
                    Administración de Viviendas</h3>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <h4>
                        Viviendas</h4>
                </div>
                <div class="col-md-3">
                    <asp:TextBox type="text" ID="txtcodigo" name="codigo" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscar_Click" />
                    <!-- Button trigger modal -->
                    <button class="btn btn-primary btn" data-toggle="modal" data-target="#myModal">
                        Launch demo modal
                    </button>
                </div>
            </div>
        </div>
        <%--OnPageIndexChanging="gvItems_PageIndexChanging"  
                OnRowCommand="gvItems_RowCommand" --%>
        <asp:GridView ID="gvViviendas" runat="server" Width="98%" AutoGenerateColumns="False"
            AllowPaging="True" EmptyDataText="No existen ítems a mostrar." class="table table-bordered table-hover">
            <Columns>
                <asp:BoundField DataField="N_IdVivienda" HeaderText="ID" ItemStyle-Width="50px" />
                <asp:BoundField DataField="C_NumEdificio" HeaderText="N° Edificio" />
                <asp:BoundField DataField="C_NumDpto" HeaderText="N° Dpto" />
                <asp:BoundField DataField="N_NumMetros" HeaderText="Metrs Cuad" />
                <asp:BoundField DataField="C_CodTipo" HeaderText="Tipo" />
                <asp:BoundField DataField="objResidente.C_Apellidos" HeaderText="Residente" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="btnEditar" runat="server" CommandArgument='<%#Eval("N_IdVivienda")%>'
                            CommandName="Ver" ImageUrl="~/Images/edit.gif" ToolTip="Ver" />
                    </ItemTemplate>
                    <HeaderStyle Width="30px" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="btnEliminar" runat="server" CommandArgument='<%#Eval("N_IdVivienda")%>'
                            CommandName="Ver" ImageUrl="~/Images/delete.gif" ToolTip="Ver" />
                    </ItemTemplate>
                    <HeaderStyle Width="30px" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
    <!-- Modal -->
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel"
        aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                        &times;</button>
                    <h4 class="modal-title" id="myModalLabel">
                        Modal title</h4>
                </div>
                <div class="modal-body">
                    ...
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal">
                        Close</button>
                    <button type="button" class="btn btn-primary">
                        Save
                    </button>
                </div>
            </div>
        </div>
    </div>
</body>
</html>

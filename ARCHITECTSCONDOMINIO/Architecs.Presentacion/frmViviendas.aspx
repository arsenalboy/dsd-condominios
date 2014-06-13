<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmViviendas.aspx.cs" Inherits="Architecs.Presentacion.frmViviendas" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listado de Viviendas</title>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.4.1-vsdoc.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/Paginas/frmViviendas.aspx.js" type="text/javascript"></script>
    <script src="Scripts/Popups.js" type="text/javascript"></script>
    <script src="Scripts/Validaciones.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
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
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscar_Click"/>
                      <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" class="btn btn-primary" data-toggle="modal"
                        data-target="#myModal" onclick="btnNuevo_Click" />
                </div>
            </div>
        </div>
        <asp:GridView ID="gvViviendas" runat="server" Width="98%" AutoGenerateColumns="False"
            AllowPaging="True" EmptyDataText="No existen ítems a mostrar." PageSize="7" 
            class="table table-bordered table-hover" onrowcommand="gvViviendas_RowCommand" 
            onrowdatabound="gvViviendas_RowDataBound" 
            onpageindexchanging="gvViviendas_PageIndexChanging">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HiddenField ID="hhdIDVivienda" runat="server" Value='<%#Eval("N_IdVivienda")%>' />
                    </ItemTemplate>
                    <HeaderStyle Width="30px" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:BoundField DataField="N_IdVivienda" HeaderText="ID" ItemStyle-Width="50px" />
                <asp:BoundField DataField="C_NumEdificio" HeaderText="N° Edificio" />
                <asp:BoundField DataField="C_NumDpto" HeaderText="N° Dpto" />
                <asp:BoundField DataField="N_NumMetros" HeaderText="Metrs Cuad" />
                <asp:BoundField DataField="C_CodTipo" HeaderText="Tipo" />
                <asp:BoundField DataField="objResidente.C_Apellidos" HeaderText="Residente" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="btnEditar" runat="server" CommandArgument='<%#Eval("N_IdVivienda")%>'
                            CommandName="Editar" ImageUrl="~/Images/edit.gif" ToolTip="Ver" />
                    </ItemTemplate>
                    <HeaderStyle Width="30px" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="btnEliminar" runat="server" CommandArgument='<%#Eval("N_IdVivienda")%>'
                            CommandName="Eliminar" ImageUrl="~/Images/delete.gif" ToolTip="Ver" />
                    </ItemTemplate>
                    <HeaderStyle Width="30px" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
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
    <asp:Label ID="lblMensajes" runat="server" Font-Bold="True" Font-Size="Larger" 
        ForeColor="#FF3300"></asp:Label>
    </form>
    </body>
</html>

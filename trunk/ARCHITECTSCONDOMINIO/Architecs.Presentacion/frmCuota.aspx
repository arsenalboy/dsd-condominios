<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCuota.aspx.cs" Inherits="Architecs.Presentacion.frmCuota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="jumbotron">
            <div class="container">
                <h3>
                    Administración de Cuotas</h3>
            </div>
        </div>
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <h4>
                        Cuotas</h4>
                </div>
                <div class="col-md-3">
                    <asp:TextBox type="text" ID="txtcodigo" name="codigo" class="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-3"> 
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary" OnClick="btnBuscar_Click"/>
                      <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" class="btn btn-primary" onclick="btnNuevo_Click" />
                </div>
            </div>
        </div>
        <asp:GridView ID="gvCuotas" runat="server" Width="98%" AutoGenerateColumns="False"
            AllowPaging="True" EmptyDataText="No existen ítems a mostrar." PageSize="7" 
            class="table table-bordered table-hover" onrowcommand="gvCuotas_RowCommand" 
            onpageindexchanging="gvCuotas_PageIndexChanging">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HiddenField ID="hhdIDCuota" runat="server" Value='<%#Eval("N_IdCuota")%>' />
                    </ItemTemplate>
                    <HeaderStyle Width="30px" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:BoundField DataField="N_IdCuota" HeaderText="ID" ItemStyle-Width="50px" />
                <asp:BoundField DataField="C_Periodo" HeaderText="Periodo" />
                <asp:BoundField DataField="objVivienda.C_NumEdificio" HeaderText="N° Edificio" />
                <asp:BoundField DataField="objVivienda.C_NumDpto" HeaderText="N° Dpto" />
                <asp:BoundField DataField="objVivienda.ObjResidente.C_Apellidos" HeaderText="Propietario/Residente" />

                <asp:BoundField DataField="N_Importe" HeaderText="Importe" />
                <asp:BoundField DataField="D_FecVncto" HeaderText="Fecha Vencto" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="objTipoPago.C_Descripcion" HeaderText="Tipo Pago" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="btnEditar" runat="server" CommandArgument='<%#Eval("N_IdCuota")%>'
                            CommandName="Editar" ImageUrl="~/Images/edit.gif" ToolTip="Ver" />
                    </ItemTemplate>
                    <HeaderStyle Width="30px" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField><%----%>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:ImageButton ID="btnEliminar" runat="server" CommandArgument='<%#Eval("N_IdCuota")%>'
                            CommandName="Eliminar" ImageUrl="~/Images/delete.gif" ToolTip="Ver" />
                    </ItemTemplate>
                    <HeaderStyle Width="30px" />
                    <ItemStyle HorizontalAlign="Center" />
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <asp:Label ID="lblMensajes" runat="server" Font-Bold="True" Font-Size="Larger" 
        ForeColor="#FF3300"></asp:Label>
</asp:Content>

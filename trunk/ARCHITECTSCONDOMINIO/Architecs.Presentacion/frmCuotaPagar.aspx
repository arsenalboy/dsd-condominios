<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="frmCuotaPagar.aspx.cs" Inherits="Architecs.Presentacion.frmCuotaPagar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="container">
            <h3>
               PAGO de Cuota - Cancelar</h3>
        </div>
    </div>
     <table style="left: 20px">
        <tr>
            <td>
                <div style="windows">
                   <%-- <form id="form1" runat="server" style="border: 2px; vertical-align: middle">--%>
                    <fieldset title="Datos de Vivienda:">
                         <table>
                            
                            
                            <tr>
                                <td style="right">
                                    Id Cuota :
                                </td>
                                <td style="width: 300px;">
                                    <asp:Label ID="lblN_IdCuota" runat="server" CssClass="form-control" Width="299px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="right">
                                    Periodo [YYYYMM]:
                                </td>
                                <td style="width: 300px;">
                                    <asp:TextBox ID="txtPeriodo" runat="server" CssClass="form-control" Enabled="false"  onkeypress="return filterInput(1, event)"
                                        Width="299px" MaxLength="6"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="right">
                                     Importe de Pago:
                                </td>
                                <td style="width: 300px;">
                                    <asp:TextBox ID="txtImportePago" runat="server" CssClass="form-control" onkeypress="return filterInput(1, event, true)"
                                        Width="299px" MaxLength="12" Enabled="false"></asp:TextBox>
                                </td>
                            </tr>
                           
                            <tr>
                                <td>
                                   Residente/Vivienda:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtResidenteVivienda" runat="server"  CssClass="form-control" Enabled="false"
                                        Height="70px" TextMode="MultiLine" ></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                   Fecha de Vencimiento: :
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFechaVcto" MaxLength="10" runat="server" Enabled="false"
                                        CssClass="form-control" ></asp:TextBox>
                                </td>
                            </tr>
                             <tr>
                                <td>
                                   Fecha de Pago: :
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFechaPago" MaxLength="10" runat="server"  type= "date" 
                                        CssClass="form-control" TextMode="Date"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                   N° de Operación:
                                </td>
                                <td>
                                    <asp:TextBox ID="txtNumeroOperacion" MaxLength="15" runat="server"  onkeypress="return filterInput(1, event)"
                                        CssClass="form-control"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Tipo de Pago :
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlTipoPagoos" runat="server"  CssClass="form-control">
                                    </asp:DropDownList>

                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar"
                                        class="btn btn-primary alert-success" onclick="btnGuardar_Click" />
                                </td>
                                <td>
                                    <asp:Button ID="btnCerrar" runat="server" Text="Regresar" 
                                        class="btn btn-primary alert-danger" onclick="btnCerrar_Click"
                                         />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Label ID="lblMensaje" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                   <%-- </form>--%>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>

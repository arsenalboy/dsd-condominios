<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="frmCuotaCrear.aspx.cs" Inherits="Architecs.Presentacion.frmCuotaCrear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="container">
            <h3>
                Registro de Cuota</h3>
        </div>
    </div>
    <table style="left: 20px">
        <tr>
            <td>
                <div style="windows">
                    <form id="form1" runat="server" style="border: 2px; vertical-align: middle">
                    <fieldset title="Datos de Vivienda:">
                        <table>
                            
                            
                            <tr>
                                <td style="right">
                                    Id Cuota :
                                </td>
                                <td style="width: 300px;">
                                    <asp:Label ID="lblN_IdVivienda" runat="server" CssClass="form-control" Width="299px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="right">
                                    Periodo [YYYYMM]:
                                </td>
                                <td style="width: 300px;">
                                    <asp:Label ID="lblPeriodo" runat="server" CssClass="form-control" Width="299px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="right">
                                     Importe de Pago:
                                </td>
                                <td style="width: 300px;">
                                    <asp:Label ID="Label1" runat="server" CssClass="form-control" Width="299px"></asp:Label>
                                </td>
                            </tr>
                           
                            <tr>
                                <td>
                                   Vivienda/Departamento :
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlVivienda" MaxLength="10" runat="server" CssClass="form-control"></asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                   Fecha de Vencimiento: :
                                </td>
                                <td>
                                    <asp:TextBox ID="txtFechaVcto" MaxLength="10" runat="server" CssClass="form-control"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Propietario :
                                </td>
                                <td>
                                    <asp:DropDownList ID="txtResidente" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Estado :
                                </td>
                                <td>
                                    <asp:CheckBox ID="chkB_Estado" runat="server" CssClass="form-control" Checked="True" />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar"
                                        class="btn btn-primary alert-success" />
                                </td>
                                <td>
                                    <asp:Button ID="btnCerrar" runat="server" Text="Regresar" class="btn btn-primary alert-danger"
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
                    </form>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>

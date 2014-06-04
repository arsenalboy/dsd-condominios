<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmViviendaCrear.aspx.cs"
    Inherits="Architecs.Presentacion.frmViviendaCrear" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nueva Vivienda</title>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.4.1-vsdoc.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/Paginas/frmViviendaCrear.aspx.js" type="text/javascript"></script>
    <script src="Scripts/Popups.js" type="text/javascript"></script>
    <script src="Scripts/Validaciones.js" type="text/javascript"></script>
</head>
<body>
    <table>
        <tr>
            <td>
                <div style="windows">
                    <form id="form1" runat="server" style="border: 2px; vertical-align: middle">
                    <div class="container">
                        <h3>
                            Administracion de Viviendas</h3>
                    </div>
                    <fieldset title="Datos de Vivienda:">
                        <table>
                            <tr>
                                <td>
                                    Id Vivienda :
                                </td>
                                <td style="width: 300px;">
                                    <asp:Label ID="lblN_IdVivienda" runat="server" CssClass="form-control" Width="299px"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    N° Edificio :
                                </td>
                                <td>
                                    <asp:TextBox ID="txtC_NumEdificio" MaxLength="10" runat="server" CssClass="form-control"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    N° Departamento :
                                </td>
                                <td>
                                    <asp:TextBox ID="txtC_NumDpto" MaxLength="10" runat="server" CssClass="form-control"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    N° Metros :
                                </td>
                                <td>
                                    <asp:TextBox ID="txtN_NumMetros" MaxLength="10    " runat="server" CssClass="form-control"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Propietario :
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlN_IdResidente" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Tipo :
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlC_CodTipo" runat="server" CssClass="form-control" AppendDataBoundItems="True">
                                        <asp:ListItem>CASA</asp:ListItem>
                                        <asp:ListItem>DPTO</asp:ListItem>
                                        <asp:ListItem>CHAL</asp:ListItem>
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
                                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-primary" />
                                </td>
                                <td>
                                    <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" class="btn btn-primary" OnClick="btnCerrar_Click" />
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
</body>
</html>

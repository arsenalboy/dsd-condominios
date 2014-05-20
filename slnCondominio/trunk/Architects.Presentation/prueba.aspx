<%@ Page Language="C#" AutoEventWireup="true" CodeFile="prueba.aspx.cs" Inherits="prueba" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<link href="css/bootstrap.css" rel="stylesheet" type="text/css" />--%>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    			           <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" class="btn btn-primary" 
                                onclick="BtnAgregar_Click" />

<ajaxToolkit:ToolkitScriptManager runat="Server" ID="ToolkitScriptManager1" />
                                
    <asp:Button ID="btnHidden" runat="server" Text="Button" style="display:none"/>
       


  <ajaxToolkit:ModalPopupExtender ID="MpDirectores" runat="server" 
                                                    TargetControlID="btnHidden"
                                                    PopupControlID="PnlDirectivos" 
                                                    BackgroundCssClass="modalBackground"                                                         
                                                    CancelControlID="BtnCerrar" 
                                                    DropShadow="true" />      

    <asp:Panel ID="PnlDirectivos" runat="server" Style="display:none;"  CssClass="modalPopup" >
     
  
      <table>
      <tr>
      <td>Buscar</td>
      <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
      <td><asp:ImageButton ID="BtnBusca" runat="server" ImageUrl="~/images/Buscar_24x24.png" /></td>
      </tr>
          <tr>
              <td colspan="3">
              <asp:UpdatePanel runat="server" ID="up1">
              <ContentTemplate>
              
              <asp:GridView ID="GvBusca" runat="server" AutoGenerateColumns="False" 
                                class="table table-striped table-bordered table-hover" 
                                ShowHeaderWhenEmpty="True">
                                <Columns>
                                    <asp:BoundField HeaderText="Codigo" DataField="N_IdDirectivo">
                                    <ItemStyle Width="80px" />
                                    </asp:BoundField>
                                    <asp:BoundField HeaderText="NOMBRE" DataField="C_NomPer">
                                    <ItemStyle Width="300px" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="SELECCIONE">
                                        <ItemTemplate>
                                            <asp:ImageButton ID="btnSelecciona" runat="server" ImageUrl="~/images/Select_16x16.png" />
                                        </ItemTemplate>
                                        <ItemStyle Width="90px" />
                                    </asp:TemplateField>
                                </Columns>
                                <emptydatatemplate>
                                    <asp:image id="NoDataImage"
                                    imageurl="~/images/NoData_32x32.png"
                                    alternatetext="No Image" 
                                    runat="server"/>
                                    No se encontraron registros.  
                                </emptydatatemplate> 
                            </asp:GridView>
               </ContentTemplate>
              </asp:UpdatePanel>
                  </td>
          </tr>
          <tr>
              <td >
                  &nbsp;</td><td >
                      <asp:Button ID="BtnAceptar" runat="server" Text="Aceptar" class="btn btn-primary"/>
                      <asp:Button ID="BtnCerrar" runat="server" Text="Cerrar" class="btn btn-primary"/>
                  </td>
                  <td >
                  &nbsp;</td>
          </tr>
      </table>

      
    </asp:Panel>
			            
    </div>
    </form>
</body>
</html>

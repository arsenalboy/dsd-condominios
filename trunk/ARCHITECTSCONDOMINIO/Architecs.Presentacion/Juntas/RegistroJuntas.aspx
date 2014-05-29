<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroJuntas.aspx.cs" Inherits="Architecs.Presentacion.Juntas.RegistroJuntas" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
        <form id="form1" runat="server">

<ajaxToolkit:ToolkitScriptManager runat="Server" ID="ToolkitScriptManager1" />

   
  
     <div>
     <asp:UpdatePanel ID="uptabla" runat ="server"><ContentTemplate>

          <div class="container">
      
        <div class="text-center">
        <h3><strong >Registro de Junta</strong></h3> 
      	        
        </div>
        <br>
        <div class="row">
          <div class="col-sm-3"></div>
           <div class="col-sm-6"> 
        	 <div class="well">
        		</div>
         		 <input type="hidden" name="hidDirectivos">	  
         		  <div id="hidepage" style="position: absolute;left:320px;top:290px;width: 150;height: 20">
                        <%-- <img  src="<%=request.getContextPath()%>/css/progress_bar.gif" >--%>
					</div>          		 				
		         	
           
          		 
          		 
          		 <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Fecha</label>
			              </div>
			              <div class="col-sm-4">
			             
			            <asp:TextBox ID="TextBox4" type="date" runat="server" class="form-control input-sm" required name="txtfecha"></asp:TextBox>
			              </div>
			              <div class="col-sm-1">
			                <label class="form-label">Hora</label>
			              </div>
			              <div class="col-sm-5">
			              	<div class="col-sm-4">
			              	   <asp:TextBox ID="TextBox5" type="number" runat="server" class="form-control input-sm" required min="6" max="23" name="txtHora" style="width: 55px; "></asp:TextBox>
			              	</div>
			              	<div class="col-sm-8">
			              		:00 Hrs
			              	</div>
			             
			              </div>
			     </div>
			             <br /><br />
			            <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Temas</label>
			              </div>
			              <div>
			                <div class="col-sm-10">
			                    <asp:TextBox ID="TextBox2" runat="server" class="form-control input-sm" 
                                    required placeholder="Tema" Height="88px" TextMode="MultiLine"></asp:TextBox>
			                </div>
			              </div>
			            </div>
			              <br/><br/><br/><br/>
			            <div class="form-group">
			              <div class="col-sm-2">
			                <label class="form-label">Acuerdos</label>
			              </div>
			              <div class="col-sm-10">
			                  <asp:TextBox ID="TextBox3" runat="server" class="form-control input-sm" required placeholder="Tema" TextMode="MultiLine"></asp:TextBox>
			              </div>
			            </div>
			            <br /><br />
			          <div class="form-group">
			            <div class="col-sm-2">
			              <label class="form-label">Directivos</label>
			            </div>
			            <div class="col-sm-5">
			           <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" class="btn btn-primary" 
                                onclick="BtnAgregar_Click" />
			            </div>
                        <br /><br />				           			
			          </div>
			           <br>
			          <div class="form-group">
			            <div class="col-md-12">
			             
                         <%--ACA VA LA GRILLA--%>
                            <asp:GridView ID="GvDirectivos" runat="server" AutoGenerateColumns="False" 
                                class="table table-striped table-bordered table-hover" 
                                ShowHeaderWhenEmpty="True">
                                <Columns>
                                    <asp:BoundField HeaderText="Codigo" DataField="N_IdDirectivo">
                                    <ItemStyle Width="80px" />
                                    </asp:BoundField>
                                    <asp:BoundField HeaderText="NOMBRE" DataField="C_NomPer">
                                    <ItemStyle Width="300px" />
                                    </asp:BoundField>
                                    <asp:TemplateField HeaderText="DIRIGE">
                                        <ItemTemplate>
                                            <asp:CheckBox ID="ChkSeleccionado" runat="server" />
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
			            </div>
			          </div>
                        <br /><br />
			          <div class="form-group">
				           <c:if test="${requestScope.mensaje!='1'}">
					          <div class="row">
					            <div class="col-md-12" align="center">
					                <asp:Button ID="BtnGrabar" runat="server" Text="Grabar" class="btn btn-primary"/>			              			             
					            </div>
					          </div>	
				          </c:if>	
			          </div>			         
			          	          		 			          		           		        
     
         	</div>
         </div>
          <div class="col-sm-3"></div>
       </div>     
       

         </ContentTemplate>

        </asp:UpdatePanel>
     </div>
    


     
   
  <ajaxToolkit:ModalPopupExtender ID="MpDirectores" runat="server" 
                                                    TargetControlID="TextBox1"
                                                    PopupControlID="PnlDirectivos" 
                                                    BackgroundCssClass="modalBackground"                                                         
                                                    CancelControlID="BtnCerrar" 
                                                    DropShadow="true" 
                                                    PopupDragHandleControlID="Panel3"/>    
                
    <asp:Panel ID="PnlDirectivos" runat="server" Style="display:none;"  CssClass="modalPopup">
     <asp:Panel ID="Panel3" runat="server"  Style="cursor: move; background-color:#F4F5EB; border:solid 1px Gray;color:Black"> 
  
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
    </asp:Panel>



    </form>
</body>
</html>

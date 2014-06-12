<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreaReserva.aspx.cs" Inherits="Architecs.Presentacion.Reservas.CreaReserva" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/css/bootstrap.css" rel="stylesheet" type="text/css" />

      <style >        .FechaHora
        {
              text-align: center;
              font-family: sans-serif;
              font-size: 600%;
              font-style: italic; 
              color: #06084B;
        }
    </style>
</head>

 <body>
  
    <!-- Main jumbotron for a primary marketing message or call to action -->
    <div class="jumbotron">
      <div class="container">
        <h3>RESERVA DE ESPACIOS COMUNES DEL CONDOMINIO</h3>
        <p></p>
      </div>
    </div>
    <div class="container">
      <!-- Example row of columns -->
      <div class="row">
        <div class="col-lg-0">
          <form id="form1" runat="server">
             <asp:ScriptManager ID="ScriptManager1" runat="server">
             </asp:ScriptManager>
            <div class="col-md-4" >Fecha:
                <asp:TextBox id="TxtFechReserva" type="date"  class="form-control" 
                    name="fc_fechaReserva" placeholder="dd/mm/yyyy" required="required" 
                    runat="server" AutoPostBack="True" 
                    ontextchanged="TxtFechReserva_TextChanged"></asp:TextBox> 
                </div>
            <div class="col-md-4">Espacio:
                <asp:DropDownList ID="CboEspacio" runat="server" required="required" 
                    class="form-control" AutoPostBack="True" 
                    onselectedindexchanged="CboEspacio_SelectedIndexChanged">
                </asp:DropDownList>
             </div>
            <table class="table">
              <thead>
                <tr>
                  <td>&nbsp;</td>
                </tr>
                <tr>
                  <th colspan="3">RANGO DE HORARIOS DISPONIBLES</th>
             
                </tr>
              </thead>
              <tbody id="div_resultado">
              <tr>
                <th width="50%">
                    <asp:DropDownList ID="CboHoraIni" runat="server" class="form-control" 
                        onselectedindexchanged="CboHoraIni_SelectedIndexChanged" 
                        AutoPostBack="True">
                    </asp:DropDownList>
                </th>
                <th width="50%" colspan="2"><asp:DropDownList ID="CboHoraFin" runat="server" 
                        class="form-control" 
                        onselectedindexchanged="CboHoraFin_SelectedIndexChanged" AutoPostBack="True">
                    </asp:DropDownList>
                    </th>
                </tr>

               
                
             
                <tr>

                              
                
                <th width="40%" align="center">
                <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                <ContentTemplate>
                    <asp:Label ID="LblFecha" runat="server" Text="01/01/2014" CssClass="FechaHora"></asp:Label> 
                      </ContentTemplate>
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID="CboHoraIni" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="CboHoraFin" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="TxtFechReserva" EventName="TextChanged" />
                </Triggers>
                </asp:UpdatePanel>
                </th>
                <th width="30%" align="center">
                <asp:UpdatePanel runat="server" ID="UpdatePanel2">
                <ContentTemplate>
                <asp:Label ID="LblHoraIni" runat="server" Text="00:00" CssClass="FechaHora"></asp:Label> 
                  </ContentTemplate>
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID="CboHoraIni" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="CboHoraFin" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="TxtFechReserva" EventName="TextChanged" />
                </Triggers>
                </asp:UpdatePanel>
                </th>
                <th width="30%" align="center">
                   <asp:UpdatePanel runat="server" ID="UpdatePanel3">
                <ContentTemplate>
                <asp:Label ID="LblHoraFin" runat="server" Text="00:00" CssClass="FechaHora"></asp:Label>
                  </ContentTemplate>
                <Triggers>
                <asp:AsyncPostBackTrigger ControlID="CboHoraIni" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="CboHoraFin" EventName="SelectedIndexChanged" />
                <asp:AsyncPostBackTrigger ControlID="TxtFechReserva" EventName="TextChanged" />
                </Triggers>
                </asp:UpdatePanel> 
                </th>
                
                

                </tr>

                 

              </tbody>
            </table>
            <div>
            
               <div style="display:none;" id="divacepto">
                <div class="alert alert-success"  >
			    <button type="button" class="close" data-dismiss="alert">&times;</button>
			    <b>En hora buena,</b> La junta se registró con éxito.
			    </div>
         
                 </div>

            		 <%-- <p></p>
			          <div class="alert alert-success">
			            <button type="button" class="close" data-dismiss="alert">&times;</button>
			            <b>En hora buena,</b> Su reserva se registró con éxito.
			          </div>
            	
          
			          <p></p>
			          <div class="alert alert-danger">
			            <button type="button" class="close" data-dismiss="alert">&times;</button>
			            <b>ERROR!</b> Usted ha superado las posibles reservas del espacio seleccionado por día.
			          </div>--%>
            		
            	
           </div>
           <p>
            <div class="col-md-4">
                <asp:Button ID="BtnGrabar" runat="server" Text="GRABAR" class="btn btn-default" 
                    onclick="BtnGrabar_Click"/>
              
            </div>
            
          </form>
        </div>
        <div class="col-lg-4">
        
          <p></p>
        </div>
      </div>
      <hr>
      <footer>
        <p>&copy; Architects 2014</p>
        <nav>
          <div class="container"></div>
        </nav>
      </footer>
    </div>
    <!-- /container -->
    
  </body>
</html>

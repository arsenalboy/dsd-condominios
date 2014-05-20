<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Condominio - Pagar Cuota Emitida</title>
    <link href="css/bootstrap-3.0.0.css" rel="stylesheet" media="screen">
    <script>
    function validar(){
         var periodo = document.form1.txtPeriodo.value;        
         if(periodo.length!=6){
        	 alert('El formato del periodo es incorrecto (AÑOMES-YYYYMM)');
             return false;
         }
        return true;	 
    }
       
    function ConfirmarPago() {
        	 if(confirm("¿Estas seguro de confirmar pago de la cuota?")) {
        	 	document.location.href= 'frmCuotaPagar.jsp?x=1';
	}
    </script>
   
  </head>
  <body>
  <jsp:include page="/pages/header.jsp" />    
  <div class="container"> 
   <p><strong>PAGO de Cuota - Cancelar</strong></p>
<form id="form1" name="form1" method="post" action="frmCuotaPagar.jsp?x=1" onsubmit="validar()">
  <fieldset>
    <legend>Pagos</legend>   
    <div class="col-md-4">
    	  Residente:
       	  <input id="txtResidente" type="text" name="txtResidente"  class="form-control"  value="<%=request.getAttribute("txtResidente") %>"/>
    </div>
    <div class="col-md-4">
    	  Vivienda:
          <input id="txtVivienda" type="text" name="txtVivienda"  class="form-control"  value="<%=request.getAttribute("txtVivienda") %>"/>
    </div>
    
    <div class="col-md-4" >
      Periodo a PAGAR [YYYYMM]:
        <input  type="number" name="txtPeriodo" id="txtPeriodo"    class="form-control" required autofocus   value="<%=request.getAttribute("txtPeriodo") %>"/>
        <input  type="hidden" name="txtIdVivienda" id="txtIdVivienda" value="<%=request.getAttribute("txtIdVivienda") %>">
        <input  type="hidden" name="txtIdCuota" id="txtIdCuota" value="<%=request.getAttribute("txtIdCuota") %>">
    </div>
    <div class="col-md-4">
			 	Tipo de Pago:
			 	<select name="slcTipoPago" class="form-control"
						id="slcTipoPago" required autofocus placeholder="Seleccionar" >
						<option></option>
						<%
						for(int intTipoPago=1;intTipoPago<=9; intTipoPago++){%>
						<option value="<%=intTipoPago%>">
						<%="ID: "+ "Tipo Pago " +" : " + intTipoPago%>
						</option>
						<%} %>
				</select>
	</div> 
      
	<div class="col-md-4">
      Importe de Pago:
        <input type="text" name="txtImportePago" id="txtImportePago" class="form-control" value="<%=request.getAttribute("txtImportePago") %>"/>
    </div>
      
    
     <div class="col-md-4">
     	 Fecha de Vencimiento:
        <input id="txtfechaVcto" type="date" name="txtfechaVcto"   class="form-control"  value="<%=request.getAttribute("txtfechaVcto") %>"/>
    </div>
    <div class="col-md-4">
         Fecha de Pago:
        <input id="txtfechaPago" type="text" name="txtfechaPago"    class="form-control"  value="<%=request.getAttribute("txtfechaPago") %>"/>      
    </div>
   
  </fieldset> 	
  	 <p>
    <div class="col-md-4">
        <input id="btnPagar" type="submit" value="Pagar"    class="btn btn-primary" onclick="ConfirmarPago();"/>
    </div> 
  	<p>;
  	</p>
  	<div>
                <%
            String vt=null;
            String vf=null;
            
            int x =0;
            x=(int)Integer.parseInt(request.getParameter("x"));
            if(x == 1){%>
            		  <p></p>
			          <div class="alert alert-success">
			            <button type="button" class="close" data-dismiss="alert">&times;</button>
			            <b>En hora buena,</b> Su Cuota se pago con éxito.
			          </div>
            	
            <%}else if(x >1 ){%>
			          <p></p>
			          <div class="alert alert-danger">
			            <button type="button" class="close" data-dismiss="alert">&times;</button>
			            <b>ERROR!</b> No se pudo pagar el registro de la Cuota.
			          </div>
            	<%}%>
                </div>

</form>


 <!-- Site footer -->
	   <div class="footer">
	   	 <p>&nbsp;</p>
	     <p>&copy; Orlando Carril 2014 </p>
	   </div>
	   
	 </div> <!-- /container -->
    

     <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/jquery-1.10.2.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap-3.0.0.js"></script>
  </body>
</html>
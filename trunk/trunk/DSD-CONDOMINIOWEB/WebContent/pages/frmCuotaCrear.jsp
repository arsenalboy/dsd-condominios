<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>

<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta name="description" content="">
	<meta name="author" content="">
	<title>Condominio - Registra Cuota</title>
	<meta name="viewport" content="width=device-width">
    <style type="text/css">
      body {
        padding-bottom: 20px;
      }
    </style>
    <script language="javascript" src="<%=request.getContextPath()%>/js/ajax.js"></script>

<script>
       function validar(){
         var periodo = document.form1.periodo.value;        
         if(periodo.length!=6){
        	 alert('El formato del periodo es incorrecto (AÑOMES-YYYYMM)');
             return false;
         }
         return true;
       }
    </script>

</head>
<body>
	<jsp:include page="/pages/header.jsp" />
	<div class="jumbotron">
      <div class="container">
        <h3>Generación de Cuotas</h3>
        <p></p>
      </div>
    </div>
	<div class="container">
	 <div class="row">
        <div class="col-lg-0">
		<form id="form1" name="form1" method="post" action="frmCuotaCrear.jsp?x=1" onsubmit="validar()">
		<fieldset>
        <legend>Cuota</legend>   
			<div class="col-md-4" >
				Periodo a generar [YYYYMM]:
				<input 	type="number" name="periodo" id="periodo"  
						class="form-control" required autofocus placeholder="YYYYMM" 
						value="<%=request.getAttribute("paramPeriodo") %>">
			</div>
			<div class="col-md-4">
			 	Importe de Pago:
			 	<input  type="number" name="importepago" class="form-control" 
						id="importepago" required autofocus placeholder="0.00" />
			</div>
			<div class="col-md-4">
			 	Id de Vivienda:
			 	<select name="slcvivienda" class="form-control"
						id="slcvivienda" required autofocus placeholder="Seleccionar" >
						<option></option>
						<%
						for(int intVivienda=1;intVivienda<=9; intVivienda++){%>
						<option value="<%=intVivienda%>">
						<%="ID: "+ "Vivienda N°" +" - : " + intVivienda + " - Ubic.:"+ intVivienda%>
						</option>
						<%} %>
				</select>
			</div> 
			<div class="col-md-4">
				Fecha de Vencimiento:
				<input id="fechaVcto" type="date" class="form-control" placeholder="dd/mm/yyyy" 
						name="fechaVcto" />
			</div> 
			
			
		</fieldset>
		<p>
			
			<div class="col-md-4">
				<input id="btnGuardar"
					type="submit" value="Guardar" class="btn btn-primary" />
			
			</div>
			
			<p>	
			<div>
				<%
            String vt=null;
            String vf=null;
            
            int x=0;
            x=(int)Integer.parseInt(request.getParameter("x"));
            if(x==1)
            {%>
				<p></p>
				<div class="alert alert-success">
					<button type="button" class="close" data-dismiss="alert">&times;</button>
					<b>En hora buena,</b> Su Cuota se registró con éxito.
				</div>

				<%}else if(x != 1 && x==0){%>
				<p></p>
				<div class="alert alert-danger">
					<button type="button" class="close"  onclick="ver();" data-dismiss="alert">&times;</button>
					<b>ERROR!</b> No se pudo insertar el registro de la Cuota.
				</div>
				<%}%>
			</div>
		</form>
		</div>
      </div>
       <hr>
		<!-- Site footer -->
		<div class="footer">
			<p>&nbsp;</p>
			<p>&copy; Orlando Carril 2014</p>
		</div>

	</div>
</body>
</html>
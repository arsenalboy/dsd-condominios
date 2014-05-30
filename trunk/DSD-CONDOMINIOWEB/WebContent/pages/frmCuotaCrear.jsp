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
	<div class="container">
        <h3>Generación de Cuotas</h3>
    </div>
	<div class="jumbotron">
		<form id="frmCuotaNueva" name="frmCuotaNueva" action="<%= request.getContextPath() %>/pages" method="post">
		<fieldset>
        <legend>Cuota Nueva</legend>   
        	<input type="hidden" id="id" name ="id" value="">
        	<table class="table table-bordered" style="width:600px;">
	        	<tr>
		        	<td><label>Periodo [YYYYMM]:</label> </td>
		        	<td>
						<input 	type="number" 
								name="periodo" 
								id="periodo"  
								class="form-control" 
								required autofocus placeholder="YYYYMM" 
								value="<%=request.getAttribute("paramPeriodo") %>">
					</td>
	        	</tr>
				<tr>
					<td><label>Importe de Pago:</label></td>
					<td>
			 			<input type="number" 
			 				   name="importepago" 
			 				   class="form-control" 
							   id="importepago" 
							   required autofocus placeholder="0.00" />
					</td>
				</tr>
				<tr>
					<td><label>Id de Vivienda:</label></td>
					<td>
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
					</td>
				</tr>
				<tr>
					<td><label>Fecha de Vencimiento: </label></td>
					<td>
						<input id="fechaVcto" 
								type="date" 
								class="form-control" 
								placeholder="dd/mm/yyyy" 
								name="fechaVcto" />
					</td>
				</tr>
				<tr>
					<td colspan="2">
						<input type="submit" value="Aceptar" class="btn btn-succes"/>
						<input type="button" value="Regresar" class="btn btn-danger"/>
						
						<!-- CuotaServlet?op=create" onsubmit="validar()" -->
					</td>	
				</tr>
			</table>	
		</fieldset>
		</form>
	</div>
	<div class="footer">
			<p>&nbsp;</p>
			<p>&copy; Orlando Carril 2014</p>
	</div>
	
</body>
</html>
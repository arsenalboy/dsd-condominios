<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html lang="en">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
	
	
 	<!-- Bootstrap core CSS -->
     <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">
 
 	<script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>
     
  
    
	<title>Condominio</title>
 
<body>

	<jsp:include page="/pages/header.jsp" />
	
	<div>
	
	<fieldset class="form-horizontal well">
	  <p>Mantenimiento de Viviendas </p>
	</fieldset>
		
	<fieldset class="form-horizontal well">
	 	<form id="form1" name="form1" method="post" action="">
		  <p>Buscar vivienda de un Residente: 
		    <label>
		    <input type="text" name="id"/>
		    </label>
		    <label>
		    <button id="button" type="submit" class="btn btn-primary">Buscar</button>		
		    </label>
		  </p>
		</form>
	</fieldset>
	
	<fieldset class="form-horizontal well">
		<form id="form2" name="form2" method="post" action="">
		    <button id="button" type="submit" class="btn btn-primary">Nuevo</button>		
		</form>
	</fieldset>
	<fieldset class="form-horizontal well">
		
		<table class="table table-striped table-bordered">
		  <tr>
		    <th width="49"  scope="col">Id Viv.</th>
		    <th width="49"  scope="col">Nro. Edi.</th>
		    <th width="192" scope="col">Nro. Dpto.</th>
		    <th width="55"  scope="col">Metraje</th>
		    <th width="55"  scope="col">Tipo Vivienda</th>
		    <th width="150" scope="col">Residente</th>
		    <th width="192" scope="col">Acciones</th>  
		    
		  </tr>

		  <tr>
		    <td>1</td>
		    <td>A1</td>
		    <td>120</td>
		    <td>150</td>
		    <td>DEPARTAMENTO</td>
		    <td>Luis Alberto</td>
		    
		    <td><a href="<%=request.getContextPath()%>/ViviendaServlet?Param=editar">Editar</a> - <a href="<%=request.getContextPath()%>/ViviendaServlet?Param=eliminar" onclick="return confirm('¿Está seguro que desea eliminar');">Eliminar</a></td>
		  </tr>

		  
		</table>
	</fieldset>
  </div>
</body>

<%@page import="cleaner.PagosWS"%>
<%@page import="org.datacontract.schemas._2004._07.Architecs_PagosService.*,cleaner.*"%>
<%@page import="org.tempuri.PagosService"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Listado de CUOTAS Generadas</title>
  <!-- Bootstrap core CSS -->
 	<!-- Bootstrap core CSS -->
     <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">
    <link href="<%=request.getContextPath()%>/css/bootswatch.min.css" rel="stylesheet" media="screen">
    <link href="<%=request.getContextPath()%>/css/jquery.dataTables.css" rel="stylesheet">
    <link href="<%=request.getContextPath()%>/css/DT_bootstrap.css" rel="stylesheet">
    
 	<script src="<%=request.getContextPath()%>/js/jquery-1.10.2.js"></script>
 	<script src="<%=request.getContextPath()%>/js/jquery.dataTables.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="<%=request.getContextPath()%>/js/bootstrap-3.0.0.js"></script>
	<script language="Javascript">
	function OnButton1()
	{
		if(document.forms[0].txtperiodo.value==""){
 			alert("Especifique un periodo");
			return false;
		}
		document.form1.action = "frmCuotaListar.jsp?x=1";
    	document.form1.submit();      
     	return true;
	}
	function OnButton2()
	{
		
		if(document.forms[0].txtperiodo.value==""){
			
			
			alert("Especifique un periodo");
			return false;
		}
    	document.form1.action ="frmCuotaCrear.jsp?x=0";
    	document.form1.submit();             	
    	return true;
	}
	</script>
</head>


<script type="text/javascript">

$(document).ready(function() {

} );

</script>
	
  <body>
  
  <jsp:include page="/pages/header.jsp" />
  <fieldset>
  	<div class="jumbotron">
      <div class="container">
        <h3>Cuotas Generadas</h3>
      </div>
    </div>
  </fieldset>  
  <fieldset class="form-horizontal well">
  	<form id="form1" name="form1" method="post" > 
        <p>Periodo a buscar [YYYYMM]:
        <label>
        	<input type="text" name="txtperiodo" id="txtperiodo" placeholder="201301"  class="form-control" />
		</label>
		    
        <label>
        <input type="submit" class="btn btn-primary" id="btnBuscar" value="Buscar" onclick="OnButton1();"/>
        </label>
          <input type="submit" class="btn btn-primary"  id="btnNuevo" value="Nuevo" onclick="OnButton2();"/>	            
        </p>
      </form>
     
  </fieldset>

  <fieldset  class="form-horizontal well">
      
	<table width="550" height="65" border="1" cellpadding="0" cellspacing="0"  class="table table-bordered table-hover">
  	<tr>
	  	<th width="40" scope="col">Item</th>
	    <th width="49" scope="col">Nro.Cuota</th>
	    <th width="70" scope="col">Periodo</th>
	    <th width="60" scope="col">N° Vivienda</th>
	    <th width="180" scope="col">Residente</th>
	    <th width="90" scope="col">Cuota</th>
	    <th width="90" scope="col">Fecha Vencto</th>
	    <th width="90" scope="col">Tipo Pago</th>
	    <th width="90" scope="col">Fecha Pago</th>
	  	<th width="192" scope="col">Acciones</th> 
  	</tr>

	 
	<%
	int i = 1;
	for(int Cuota=1;Cuota<=9; Cuota++) {
	%>  
	  <tr>
	    <td><%=i++ %></td>
	    <td><% out.print("Cuota "+ i); %></td>
	    <td><% out.print("Periodo"+ i); %></td>
	    <td><% out.print("N° Viv : " + i); %></td>
	    <td><% out.print("NombreResidente: " + i); %></td>
	     <td><% out.print("999.00" + i); %></td>
	     <td><% out.print("25/05/2014"); %></td>
	     <td><% out.print("Efectivo"); %></td>
	     <td><% out.print("30/05/2014" + i); %></td>
	     
	      <%if( (i >0)){ %>
	    		  <td>
	    		  <a href="Editar" onclick="return confirm('¿Está seguro que desea EDITAR Cuota');">Editar</a> - 
	    		  <a href="Eliminar" onclick="return confirm('¿Está seguro que desea ELIMINAR Cuota');">Eliminar</a></td>
	    		 
	    	<%}else{ %>	 
	   <td> Colocar Cuota</td>
	    <%} %>
	  </tr>
	<% }  
	  %>
  
	</table>

 	<!-- Site footer -->
	   <div class="footer">
	   	 <p>&nbsp;</p>
	     <p>&copy; OCarril 2014 </p>
	   </div>

    </fieldset>
  </body>
	
</html>
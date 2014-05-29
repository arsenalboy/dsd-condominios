<%@page import="util.FormatoFecha"%>
<%@page import="cleaner.PagosWS"%>
<%@page import="org.datacontract.schemas._2004._07.Architecs_PagosService.Cuota,cleaner.*"%>
<%@page import="org.datacontract.schemas._2004._07.Architecs_PagosService.TipoPago,cleaner.*"%>

<%@page import="org.tempuri.PagosService"%>
<%@page language="java" contentType="text/html; charset=ISO-8859-1"  pageEncoding="ISO-8859-1"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>LISTADO DE CUOTAS </title>
    
</head>

<script type="text/javascript">

</script>
	
<body>
  
  <jsp:include page="/pages/header.jsp" />
  <fieldset>
  	
      <div class="container">
        <h3>Cuotas Generadas</h3>
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
          
          <a href="<%= request.getContextPath()%>/CuotaServlet?op=create" class="btn btn-primar">Nuevo</a>           
        </p>
      </form>
     
  </fieldset>

  <fieldset  class="form-horizontal well">
      
	<table width="550" height="65" border="1" cellpadding="0" cellspacing="0"   
		   class="table table-striped">
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
	Cuota[] lstCuotas = (Cuota[])request.getAttribute("lstCuotas");
	int contador = 1;

	for(Cuota cuotas : lstCuotas){
	%>  
	  <tr>
	    <td><%=contador++ %></td>
	    <td><% out.print(cuotas.getN_IdCuota()); %></td>
	    <td><% out.print(cuotas.getC_Periodo()); %></td>
	    <td><% out.print(cuotas.getObjVivienda().getC_NumEdificio()); %></td>
	    <td><% out.print(cuotas.getObjVivienda().getObjResidente().getC_Apellidos()); %></td>
	    <td><% out.print(cuotas.getN_Importe()); %></td>
	    <td><% out.print(FormatoFecha.dateToStringDDMMYYYYY(cuotas.getD_FecVncto().getTime())); %></td>
	    <td><% out.print(cuotas.getObjTipoPago().getC_Descripcion()==null?"":cuotas.getObjTipoPago().getC_Descripcion()); %></td>
	    <td><% out.print(cuotas.getD_FecPago()==null?"":cuotas.getD_FecPago()); %></td>
	      <%if( (contador >0)){ %>
	    		  <td>
	    		  <a href="Editar"   onclick="return confirm('¿Está seguro que desea EDITAR Cuota');">Editar</a> - 
	    		  <a href="Eliminar" onclick="return confirm('¿Está seguro que desea ELIMINAR Cuota');">Eliminar</a></td>
	    		 
	    	<%}else{ %>	 
	   <td> Colocar Cuota</td>
	    <%} %>
	  </tr>
	<% } %>
  
	</table>

 	<!-- Site footer -->
	   <div class="footer">
	   	 <p>&nbsp;</p>
	     <p>&copy; OCarril 2014 </p>
	   </div>

    </fieldset>
  </body>
	
</html>
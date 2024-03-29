<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>


<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<!-- Bootstrap core CSS -->
    <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">
	<script type="text/javascript" src="<%=request.getContextPath()%>/js/jquery-1.11.1.min.js"></script>
    <script type="text/javascript" src="<%=request.getContextPath()%>/js/bootstrap.min.js"></script>
</head>
<body>
<!-- Static navbar -->
	  <div class="navbar navbar-default navbar-static-top">
	    <div class="container">
	      <div class="navbar-header">
	        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
	          <span class="icon-bar"></span>
	          <span class="icon-bar"></span>
	          <span class="icon-bar"></span>
	        </button>
	        
	      </div>

	      <div class="navbar-collapse collapse">
	        <ul class="nav navbar-nav">
	          <li class="active"><a href="<%=request.getContextPath()%>/pages/principal.jsp" target="_top">Inicio</a></li>
			  <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">Residentes <b class="caret"></b></a>
			  		<ul class="dropdown-menu">
						<li><a href="<%=request.getContextPath()%>/ResidenteServlet?opcion=1" target="_top" >Listar</a></li>	        							
					</ul>
			  </li>
			  <li><a href="<%=request.getContextPath()%>/pages/ViviendaBuscar.jsp" target="_top">Viviendas</a></li>
			  <li><a href="<%=request.getContextPath()%>/pages/ingresarReserva.jsp?x=0" target="_top">Reservas</a></li>
			  <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">Cuotas <b class="caret"></b></a>
			  		<ul class="dropdown-menu">
						<li><a href="<%=request.getContextPath()%>/CuotaServlet?op=list" target="_top" >Listar</a></li>
						<li><a href="<%=request.getContextPath()%>/pages/frmCuotaCrear.jsp?x=0" target="_top" >Registrar</a></li>
						<li><a href="<%=request.getContextPath()%>/pages/frmCuotaPagos.jsp" target="_top" >Listar Pagos</a></li>	     
						<li><a href="<%=request.getContextPath()%>/pages/frmCuotaPagar.jsp?x=0" target="_top" >Realizar Pago</a></li>   							
					</ul>
			  </li>
			  <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">Visitas <b class="caret"></b></a>
			  		<ul class="dropdown-menu">
						<li><a href="<%=request.getContextPath()%>/pages/principal.jsp" target="_top" >Registro</a></li>
						<li><a href="<%=request.getContextPath()%>/pages/principal.jsp" target="_top" >Quejas</a></li>	        							
					</ul>
			  </li>
			  <li><a href="<%=request.getContextPath()%>/pages/principal.jsp" target="_top">Juntas</a></li>
			  <li><a href="<%=request.getContextPath()%>/pages/reportes.jsp" target="_top">Reportes</a></li>
			  <li><a href="<%=request.getContextPath()%>/pages/principal.jsp" target="_top">Configuración</a></li>
	          <li><a href="<%=request.getContextPath()%>/pages/principal.jsp" target="_top">Salir</a></li>
	        </ul>
	      </div><!--/.nav-collapse -->
	    </div>
	  </div>
</body>
</html>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>


<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<!-- Bootstrap core CSS -->
    <link href="<%=request.getContextPath()%>/css/bootstrap.css" rel="stylesheet" media="screen">

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
			  <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">Consultas <b class="caret"></b></a>
			  		<ul class="dropdown-menu">
						<li><a href="<%=request.getContextPath()%>/pages/principal.jsp" target="_top" >Viviendas</a></li>
						<li><a href="<%=request.getContextPath()%>/pages/principal.jsp" target="_top" >Residentes</a></li>	        							
					</ul>
			  </li>
			  <li><a href="<%=request.getContextPath()%>/pages/ingresarReserva.jsp?x=0" target="_top">Reservas</a></li>
			  <li><a href="<%=request.getContextPath()%>/pages/frmListarCuota.jsp" target="_top">Cuotas</a></li>
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
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<!-- Bootstrap core CSS -->
    <link href="Styles/bootstrap_black.css" rel="stylesheet" media="screen">
	<script type="text/javascript" src="Scripts/jquery-menu.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>
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
	          <li class="active"><a href="principal.aspx" target="_top">Inicio</a></li>
			  <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">Residentes <b class="caret"></b></a>
			  		<ul class="dropdown-menu">
						<li><a href="#" target="_top" >Listar</a></li>	        							
					</ul>
			  </li>
			  <li><a href="#" target="_top">Viviendas</a></li>
			  <li><a href="<#" target="_top">Reservas</a></li>
			  <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">Cuotas <b class="caret"></b></a>
			  		<ul class="dropdown-menu">
						<li><a href="#" target="_top" >Listar</a></li>
						<li><a href="#" target="_top" >Registrar</a></li>
						<li><a href="#" target="_top" >Listar Pagos</a></li>	     
						<li><a href="#" target="_top" >Realizar Pago</a></li>   							
					</ul>
			  </li>
			  <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">Visitas <b class="caret"></b></a>
			  		<ul class="dropdown-menu">
						<li><a href="#" target="_top" >Registro</a></li>
						<li><a href="#" target="_top" >Quejas</a></li>	        							
					</ul>
			  </li>
			  <li><a href="#" target="_top">Juntas</a>
                       
              </li>
               <li class="dropdown"><a href="#" class="dropdown-toggle" data-toggle="dropdown">Quejas <b class="caret"></b></a>
			  		<ul class="dropdown-menu">
						<li><a href="<%=request.getContextPath()%>%>/Quejas/CreaQueja.aspx" target="_top" >Crear Queja</a></li>
						<li><a href="<%=Request.RequestContext()%>/Quejas/ConsultaQuejas.aspx" target="_top" >Consultar Quejas</a></li>	        							
					</ul>
			  </li>
			  <li><a href="principal.aspx" target="_top">Configuración</a></li>
	          <li><a href="principal.aspx" target="_top">Salir</a></li>
	        </ul>
	      </div><!--/.nav-collapse -->
	    </div>
	  </div>
      
</body>
</html>

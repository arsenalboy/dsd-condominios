
<html>
  
  <head>
  <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>Reserva Espacio comun</title>    
  	<meta name="viewport" content="width=device-width">
   	<link href="<%=request.getContextPath()%>/css/bootstrap.min.css" rel="stylesheet" media="screen">
	<script src="<%=request.getContextPath()%>/js/jquery-1.11.1.min.js"></script> 	 	 	 	
    <script src="<%=request.getContextPath()%>/js/bootstrap.min.js"></script>
    <style type="text/css">
      body {
        padding-bottom: 20px;
      }
    </style>
    <script language="javascript" src="<%=request.getContextPath()%>/js/ajax.js"></script>

  </head>
  
  <body>
  <jsp:include page="../pages/header.jsp" />
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
          <form method="post" Action="ingresarReserva.jsp?x=1">
            <div class="col-md-4" >Fecha:<input id="fc_fechaReserva" type="date"  class="form-control" name="fc_fechaReserva" placeholder="dd/mm/yyyy" required="required"
            onchange="validarFechaMenorActual(this.value);"
            onchange="listarHorarioDisponible('listarHorarios.jsp','&fecha='+this.value,'&ec='+document.getElementById('fc_espacioComun').value,'div_resultado')">
            </div>
            <div class="col-md-4">Espacio:
              <select class="form-control" id="fc_espacioComun" name="fc_espacioComun" required="required"
              onchange="listarHorarioDisponible('listarHorarios.jsp','&ec='+this.value,'&fecha='+document.getElementById('fc_fechaReserva').value,'div_resultado')">
				<option></option>

				<option value="1">Sala de Reuniones</option>
				<option value="2">Canchas de Futbol</option>
				<option value="3">Zona Recreativa</option>
				<option value="4">Sala de Reuniones</option>
				<option value="5">Sala de Secado y Lavado</option>
				<option value="6">Piscina</option>
				<option value="7">Gimansio</option>
								
              </select>
              <input type="hidden" id="idResidente" name="idResidente" value="${sessionScope.USUARIO_ACTUAL.idUsuario}">
            </div>
            <table class="table">
              <thead>
                <tr>
                  <td>&nbsp;</td>
                </tr>
                <tr>
                  <th>N&ordm;</th>
                  <th>HORARIOS DISPONIBLES</th>
                </tr>
              </thead>
              <tbody id="div_resultado">
                <tr >
                  <td></td>
                </tr>  
              </tbody>
            </table>
            <div>
            <p></p>
			 
            <%
           try {
        	   int x=0;
               x=(int)Integer.parseInt(request.getParameter("x"));
               if(x==1){%>
           	<div class="alert alert-success">
           		<button type="button" class="close" data-dismiss="alert">&times;</button>
           		<b>En hora buena,</b> Su reserva se registró con éxito.
         		</div>
 
        	  <%  }
           }catch(NullPointerException e){
        	   
                     }%>
            
           </div>
           <p>
            <div class="col-md-4">
              <input type="submit" class="btn btn-default" value="ENVIAR" onclick="ver();">
            </div>
            
          </form>
        </div>
        <div class="col-lg-4">
        
          <p></p>
        </div>
      </div>
      <hr>
      <footer>
        <p>&copy; Developers 2013</p>
        <nav>
          <div class="container"></div>
        </nav>
      </footer>
    </div>
    <!-- /container -->
    
  </body>

</html>
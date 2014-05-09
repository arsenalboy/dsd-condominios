<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Reportes</title>
<link href="<%=request.getContextPath()%>/css/bootstrap.min.css" rel="stylesheet" media="screen">
	<script src="<%=request.getContextPath()%>/js/jquery-1.11.1.min.js"></script> 	 	 	 	
    <script src="<%=request.getContextPath()%>/js/bootstrap.min.js"></script>
    <script language="javascript" src="<%=request.getContextPath()%>/js/ajax.js"></script>
</head>
<body>
<jsp:include page="/pages/header.jsp" />
<div class="container">
<h1>Residentes con deudas</h1>
<div class="col-md-4" >Desde:<input id="f_desde" type="date"  class="form-control" name="fc_fechaReserva" placeholder="dd/mm/yyyy" required="required"
    
    onchange="listarResM('listarMorosos.jsp','&fecha='+this.value,'&ec='+document.getElementById('f_hasta').value,'div_lrm')">
</div>
<div class="col-md-4" >Hasta:<input id="f_hasta" type="date"  class="form-control" name="fc_fechaReserva" placeholder="dd/mm/yyyy" required="required"
   
    onchange="listarResM('listarMorosos.jsp','&fecha='+this.value,'&ec='+document.getElementById('f_hasta').value,'div_lrm')">
</div>
<table class="table">
  <thead>
    <tr>
      <th>#</th>
      <th>Nombre</th>
      <th>Vivienda</th>
      <th>Periodo</th>
      <th>Importe</th>
      <th>Fecha Vencimiento</th>
      <th>Fecha Pago</th>
    </tr>
  </thead>
  <tbody id="div_lrm">
    
  </tbody>
</table>
      <footer>
        <p>&copy; Architects 2014</p>
      </footer>

    </div><!--/.container-->
</body>
</html>
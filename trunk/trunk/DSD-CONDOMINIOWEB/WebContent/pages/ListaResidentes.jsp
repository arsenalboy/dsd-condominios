<%@page import="cleaner.ResidenteWS"%>
<%@page import="org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE,cleaner.*"%>
<%@page import="org.tempuri.ResidenteService"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<script type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript" src="js/thickbox.js"></script>
<link rel="stylesheet" href="css/thickbox.css" type="text/css" media="screen" />

</head>
<body>
<jsp:include page="/pages/header.jsp" />
<div class="jumbotron">
      <div class="container">
        <h3>LISTA DE RESIDENTES</h3>
        <p></p>
      </div>
 </div>
 <p>
 <div class="container">
 <a href="<%=request.getContextPath()%>/pages/frmResidenteRegsitro.jsp?keepThis=true&TB_iframe=true&height=520&width=750" 
 class="thickbox"><span class="btn btn-primary btn-lg" role="button">Agregar</span></a> </div></p>
 <div class="panel-body">
<table class="table table-striped table-bordered">
  <thead>
    <tr>
      <th>#</th>
      <th>Nombre</th>
      <th>Apellidos</th>
      <th>Tipo de Documento</th>
      <th>Numero</th>
      <th>Fecha Nacimiento</th>
      <th>Correo</th>
      <th>Estado</th>
      <th>Acciones</th>
    </tr>
  </thead>
  <tbody>
<%

		ResidenteBE[] listado = (ResidenteBE[])request.getAttribute("ListaResidentes");
int x=1;

String estado=null;
String doc=null;
for (ResidenteBE r : listado) {

if(r.getB_Estado()==true){
 	estado = "Activo";
}else{
	estado = "Retirado";
}
if(r.getN_TipoDoc()==1){
 	doc = "DNI";
}else{
	doc = "Carnet de Extrnajería";
}
%>
<tr>	
<td><%=x++ %></td>
  <td><%=r.getC_Nombre() %></td>
  <td><%=r.getC_Apellidos() %></td>
  <td><%=doc %></td>
  <td><%=r.getC_NumDocume() %></td>
  <td><%=r.getD_FecNacimi()%></td>
  <td><%=r.getC_Correo() %></td>
  <td><%=estado %></td>
  <td>
<div class="btn-group">
  <a class="btn btn-primary"><i class="fa fa-user fa-fw"></i> Editar</a>
  <a class="btn btn-primary dropdown-toggle" data-toggle="dropdown" href="#">
    <span class="fa fa-caret-down">></span></a>
  <ul class="dropdown-menu">
    <li><a href="<%=request.getContextPath()%>/ResidenteServlet?opcion=4&cod=<%=r.getN_IdResidente()%>&keepThis=true&TB_iframe=true&height=300&width=750" 
			title="ACTUALIZAR RESIDENTE" class="thickbox">Actualizar</a></li>
    <li class="divider"></li>
    <li><a href="#"><i class="i"></i> Eliminar</a></li>
  </ul>
</div>
</td>
</tr>
<%}%>
  </tbody>
</table>
</div>
</body>
</html>
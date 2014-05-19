<%@page import="cleaner.ResidenteWS"%>
<%@page import="org.datacontract.schemas._2004._07.Architects_Dominio.Residente,cleaner.*"%>
<%@page import="org.tempuri.ResidenteService"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<jsp:include page="/pages/header.jsp" />
<div class="jumbotron">
      <div class="container">
        <h3>LISTA DE RESIDENTES</h3>
        <p></p>
      </div>
    </div>
    <table class="table">
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
    </tr>
  </thead>
  <tbody>
<%
Residente[] listado = (Residente[])request.getAttribute("ListaResidentes");
int x=1;

String estado=null;
String doc=null;
for (Residente r : listado) {

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
  <td><%=r.getD_FecNacimi().getTime() %></td>
  <td><%=r.getC_Correo() %></td>
  <td><%=estado %></td>
</tr>
<%}
%>
  </tbody>
</table>
      
    </div>
</body>
</html>
<%@page import="java.util.List"%>
<%@page import="javax.swing.JOptionPane"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@page import="cleaner.ResidenteWS"%>
<%@page import="org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE,cleaner.*"%>
<%@page import="org.tempuri.ResidenteService"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
<link rel="stylesheet" href="https://netdna.bootstrapcdn.com/bootstrap/3.1.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.0.3/jquery.min.js" type="text/javascript"></script>
    <script src="https://netdna.bootstrapcdn.com/bootstrap/3.1.1/js/bootstrap.min.js" type="text/javascript"></script>
</head>
<body>
<%	ResidenteBE r = new ResidenteBE();
	r = (ResidenteBE)request.getAttribute("residente");
	//JOptionPane.showMessageDialog(null, r.getC_Nombre());
	if(r != null) { 
%>
<form name"Residente" action="<%=request.getContextPath()%>/ResidenteServlet?opcion=3" method="post">

 <legend>ACTUALIZAR RESIDENTES</legend>
        <div class="form-group">
          <label for="txtNombre" class="col-md-2 control-label">Nombres</label>
          <div class="col-md-4">
            <input class="form-control" id="txtNombre" name="txtNombre" value="<%=r.getC_Nombre() %>" type="text" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtApellidos" class="col-md-2 control-label">Apellidos</label>
          <div class="col-md-4">
              <input class="form-control" id="txtApellidos" name="txtApellidos" value="<%=r.getC_Apellidos() %>" type="text" required>
          </div>
        </div>
        <div class="form-group">
          <label class="col-md-2 control-label" for="txtTipoDocumento">Tipo de Documento</label>
          <div class="col-md-6">
          <select id="txtTipoDocumento" name="txtTipoDocumento" class="form-control" required>
            <option value="1" >DNI</option>
				    <option value="2" >CARNET EXTRANJERIA</option>
          </select>
        </div>
        </div>
        <div class="form-group">
          <label for="txtNombre" class="col-md-2 control-label">Número de Documento</label>
          <div class="col-md-6">
            <input class="form-control" id="txtNuDocumento" name="txtNuDocumento" value="<%=r.getC_NumDocume() %>" type="text" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtFeNac" class="col-md-2 control-label">Fecha de nacimiento</label>
          <div class="col-md-6">
            <input class="form-control" id="txtFeNac" name="txtFeNac" value="<%=r.getD_FecNacimi() %>" type="date" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtCorreo" class="col-md-2 control-label">Correo</label>
          <div class="col-md-4">
            <input class="form-control" id="txtCorreo" name="txtCorreo" value="<%=r.getC_Correo() %>" type="email" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtClave" class="col-md-2 control-label">Contraseña</label>
          <div class="col-md-4">
            <input class="form-control" id="txtClave" name="txtClave" placeholder="Contraseña" type="password" required>
          </div>
        </div>
        <div class="form-group"></div>
        <div class="form-group">
          <div class="col-md-offset-2 col-md-2">
            <button type="submit" class="btn btn-default">Entrar</button>
          </div>
          <input type="hidden" name="n_IdResidente" value="<%=r.getN_IdResidente() %>" >	
        </div>
</form>
<%} %>
</body>
</html>
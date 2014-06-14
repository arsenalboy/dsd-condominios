<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
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
<div class="container">
<form class="form-horizontal" action="<%=request.getContextPath()%>/ResidenteServlet?opcion=2" method="post" role="form">
      <legend>RGISTRO DE RESIDENTES</legend>
        <div class="form-group">
          <label for="txtNombre" class="col-md-2 control-label">Nombres</label>
          <div class="col-md-4">
            <input class="form-control" id="txtNombre" name="txtNombre" value="REs1" placeholder="Nombres" type="text" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtApellidos" class="col-md-2 control-label">Apellidos</label>
          <div class="col-md-4">
              <input class="form-control" id="txtApellidos" name="txtApellidos" value="REs1" placeholder="Apellidos" type="text" required>
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
            <input class="form-control" id="txtNuDocumento" name="txtNuDocumento" value="88887777" placeholder="Número de Documento" type="text" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtFeNac" class="col-md-2 control-label">Fecha de nacimiento</label>
          <div class="col-md-6">
            <input class="form-control" id="txtFeNac" name="txtFeNac" placeholder="Fecha de nacimiento" value="20/10/1980"type="date" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtCorreo" class="col-md-2 control-label">Correo</label>
          <div class="col-md-4">
            <input class="form-control" id="txtCorreo" name="txtCorreo" value="a@a" placeholder="Correo" type="email" required>
          </div>
        </div>
        <div class="form-group">
          <label for="txtClave" class="col-md-2 control-label">Contraseña</label>
          <div class="col-md-4">
            <input class="form-control" id="txtClave" name="txtClave" value="123" placeholder="Contraseña" type="password" required>
          </div>
        </div>
        <div class="form-group"></div>
        <div class="form-group">
          <div class="col-md-offset-2 col-md-2">
            <button type="submit" class="btn btn-default">Entrar</button>
          </div>
        </div>
      </form>
</div>
</body>
</html>
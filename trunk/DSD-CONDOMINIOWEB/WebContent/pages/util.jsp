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
<%
int x = Integer.parseInt(request.getParameter("aux"));
String msg = request.getParameter("msg");
if(x>0){%>
	<div class="panel-body">
		<div class="alert alert-success">
		<button type="button" class="close" data-dismiss="alert">&times;</button>
		<b>En hora buena,</b> El registro se Realizo con éxito.<%=msg %>
		</div>
	</div>
<%}else{%>
	<div class="panel-body">
		<div class="alert alert-danger">
		<button type="button" class="close" data-dismiss="alert">&times;</button>
		<b>ERROR!</b> No se pudo realizar la operacion <%=msg %>
		</div>
	</div>
<%}%>
</body>
</html>
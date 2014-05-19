<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<form name"Residente" action="<%=request.getContextPath()%>/ResidenteServlet" method="post">
<TABLE WIDTH=300>	
		<TR>
			<TD WIDTH=100>	
				Nombre:
			</TD>			
			<TD WIDTH=100>
				<input id="txtNombre" name="txtNombre" type="text" value="${requestScope.txtNombre}" required autofocus/>
			</TD>
		</TR>	
		<TR>
			<TD WIDTH=100>	
				Tipo Doc.: 
			</TD>
			
			<TD WIDTH=100>			
				<select id="txtTipoDocumento" name="txtTipoDocumento" >
				  <option value="1" >DNI</option>
				  <option value="2" >CARNET EXTRANJERIA</option>			  
				</select>
			</TD>
		</TR>		
		<TR>
			<TD WIDTH=100>	
				Num. Doc.: 
			</TD>			
			<TD WIDTH=100>
				<input id="txtNuDocumento" name="txtNuDocumento" value="${requestScope.txtNuDocumento}" min="0" max="9999999999"  type="text" required autofocus style=" width : 179px;"/>
			</TD>
		</TR>		
		<TR>
			<TD WIDTH=100>	
				Fecha Nac.:
			</TD>			
			<TD WIDTH=100>
				 <input id="txtFeNac" name="txtFeNac" value="${requestScope.txtFeNac}" type="date" required autofocus/>
			</TD>
		</TR>
		
		<TR>
			<TD WIDTH=100>	
				Correo:
			</TD>
			<TD WIDTH=100>
				 <input id="txtCorreo" name="txtCorreo" type="email"  value="${requestScope.txtCorreo}"required autofocus/>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=100>					
			</TD>		
			<TD WIDTH=100>
				<button id="botonEnviar" type="submit" class="btn btn-primary" >Enviar</button>															
			</TD>
		</TR>			
		</TABLE>
</form>
</body>
</html>
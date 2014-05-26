<%@page import="javax.swing.JOptionPane"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@page import="cleaner.ResidenteWS"%>
<%@page import="org.datacontract.schemas._2004._07.Architects_Dominio.Residente,cleaner.*"%>
<%@page import="org.tempuri.ResidenteService"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<%
	Residente r= (Residente)request.getAttribute("residente");
	JOptionPane.showMessageDialog(null, r.getC_Correo());
	if(r != null) { 
%>
<form name"Residente" action="<%=request.getContextPath()%>/ResidenteServlet?opcion=2" method="post">

<TABLE WIDTH=300>	
		<TR>
			<TD WIDTH=100>	
				Nombre:
			</TD>			
			<TD WIDTH=100>
				<input id="txtNombre" name="txtNombre" type="text" value="<%=r.getC_Nombre() %>" required autofocus/>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=100>	
				Apellidos:
			</TD>			
			<TD WIDTH=100>
				<input id="txtApellidos" name="txtApellidos" type="text" value="<%=r.getC_Apellidos() %>" required autofocus/>
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
				<input id="txtNuDocumento" name="txtNuDocumento"   type="text"  value="<%=r.getC_NumDocume() %>"  style=" width : 179px;"/>
			</TD>
		</TR>		
		<TR>
			<TD WIDTH=100>	
				Fecha Nac.:
			</TD>			
			<TD WIDTH=100>
				 <input id="txtFeNac" name="txtFeNac"  type="date" value="<%=r.getD_FecNacimi() %>" autofocus/>
			</TD>
		</TR>
		
		<TR>
			<TD WIDTH=100>	
				Correo:
			</TD>
			<TD WIDTH=100>
				 <input id="txtCorreo" name="txtCorreo" type="email"  value="<%=r.getC_Correo() %>" required autofocus/>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=100>	
				Clave:
			</TD>
			<TD WIDTH=100>
				 <input id="txtClave" name="txtClave" type="text"  value="" required autofocus/>
			</TD>
		</TR>
		<TR>
			<TD WIDTH=100>					
			</TD>		
			<TD WIDTH=100>
				<button id="botonEnviar" type="submit" class="btn btn-primary" >Enviar</button>															
			</TD>
		</TR>	
		<input type="hidden" name="n_IdResidente" value="10" >		
		</TABLE>
</form>
<%} %>
</body>
</html>
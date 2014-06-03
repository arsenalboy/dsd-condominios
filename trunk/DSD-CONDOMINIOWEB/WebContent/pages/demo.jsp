<%@page import="util.FormatoFecha"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@page import="java.util.*,java.text.SimpleDateFormat"%>
        <%@page import="cleaner.ResidenteWS"%>
<%@page import="org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE,cleaner.*"%>
<%@page import="org.tempuri.ResidenteService"%>
<%@page import="javax.swing.JOptionPane"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<h1>Welcome</h1>
<%
String dateStr = "04/05/2010"; 

SimpleDateFormat curFormater = new SimpleDateFormat("dd/MM/yyyy"); 
Date dateObj = curFormater.parse(dateStr); 
Calendar calendar = Calendar.getInstance();

SimpleDateFormat sdf = new SimpleDateFormat("dd/MMMMM/yyyy hh:mm:ss");
out.print(sdf.format(calendar.getTime()));
/*try{
	
	Residente r= (Residente)request.getAttribute("residente");
	if(r != null) { 
		out.print(r.getC_Apellidos());
	}else{out.print("NULO");}
}catch(Exception e){
	
	
}*/
%>
</body>
</html>
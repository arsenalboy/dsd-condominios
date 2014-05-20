<%@page import="util.FormatoFecha"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
    <%@page import="java.util.*,java.text.SimpleDateFormat"%>
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
out.print(FormatoFecha.stringToCalendarDate("20/10/1986"));
%>
</body>
</html>
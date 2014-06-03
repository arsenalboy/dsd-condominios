package servlets;

import java.rmi.RemoteException;
import java.sql.Date;
import modelo.*;
import cleaner.VisitanteWS;
import util.*;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.xml.ws.WebServiceException;

/**
 * Servlet implementation class VisitanteServlet
 */
@WebServlet("/CrearVisitanteServlet")
public class CrearVisitanteServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CrearVisitanteServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String dniVisitante = request.getParameter("txtDNIVisitante");
		String nombreVisitante = request.getParameter("txtNombreVisitante");
		String nroDocResidente = request.getParameter ("txtResidente"); 
		Date fechaVisita = FormatoFecha.stringToSqlDateYYYYMMDD(request.getParameter("txtFechaVisita"));
		
		try {
			VisitanteWS wsRest = new VisitanteWS();
			
			wsRest.AgregarVisitante(dniVisitante, nombreVisitante, nroDocResidente, fechaVisita);
			
			RequestDispatcher rd = request.getRequestDispatcher("/pages/CreaVisitante.jsp?aux=y");
			rd.forward(request, response);
			
		} catch (Exception e) {
			System.out.println(e.getMessage());
			RequestDispatcher rd = request.getRequestDispatcher("/pages/CreaVisitante.jsp?aux=n");
			rd.forward(request, response);		
		}
	
	}

}

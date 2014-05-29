package servlets;

import java.io.IOException;
import java.io.PrintStream;
import java.util.Calendar;
import java.util.Date;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.swing.text.html.parser.Parser;

import org.apache.catalina.connector.Request;
import org.apache.jasper.tagplugins.jstl.core.Out;
import org.datacontract.schemas._2004._07.Architecs_PagosService.Cuota;
import org.datacontract.schemas._2004._07.Architecs_PagosService.TipoPago;
import org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE;

import util.FormatoFecha;

import cleaner.PagosWS;


@WebServlet("/CuotaServlet")
public class CuotaServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    public CuotaServlet() {
        super();
    }

	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		processRequest(request,response);
		//this.listar(request, response);
		//Video Tutorial: https://www.youtube.com/watch?v=Uo-OnVxnYiU
		//https://www.youtube.com/watch?v=E6cfGqqKegI
		
		
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		processRequest(request,response);
		//String op= request.getParameter("op");
		//String pagina ;
		//if(op.equals("create"))
	//	{
		//	pagina= "/pages/frmCuotaCrear.jsp";
		//	//RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(pagina);
	//		//dispatcher.forward(request, response);
	//		request.getRequestDispatcher(pagina).forward(request, response);
//		}
	//	else{
			this.listar(request, response);
	//	}
	}
	
	private void processRequest(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		
		String op= request.getParameter("op");
		String pagina="";
		if(op.equals("create"))
		{
			//RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(pagina);
			//dispatcher.forward(request, response);
			pagina= "/pages/frmCuotaCrear.jsp";
			request.getRequestDispatcher(pagina).forward(request, response);
			
		}
		else{
			this.listar(request, response);
		}
		//this.listar(request, response);
		
	}

	private void listar(HttpServletRequest request, HttpServletResponse response) 
			throws ServletException, IOException {
		
		String page=""; 
		try{

			PagosWS cuota = new PagosWS();
			
			Cuota[] lstCuota = cuota.ListarCuota("");
			request.setAttribute("lstCuotas", lstCuota);
			page="/pages/frmCuotaListar.jsp";
			
			
		}catch(Exception e){
			request.setAttribute("mensaje",e.getMessage());	
		}
		request.getRequestDispatcher(page).forward(request, response);
	}
}

package servlets;

import java.io.IOException;
import java.util.Calendar;
import java.util.Date;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.swing.text.html.parser.Parser;

import org.datacontract.schemas._2004._07.Architecs_PagosService.Cuota;
import org.datacontract.schemas._2004._07.Architecs_PagosService.TipoPago;

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
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		processRequest(request,response);
	}
	
	private void processRequest(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		String opcion = request.getParameter("opcion")==null?"2":request.getParameter("opcion");
		String periodo =request.getParameter("txtperiodo"); 
		
		String pPeriodo =request.getParameter("periodo"); 
		int pIdVivienda = Integer.parseInt(request.getParameter("slcvivienda")==null?"2":request.getParameter("slcvivienda"));
		
		//int pIdTipoPago =request.getParameter("txtperiodo"); 
		double pImporte =Double.parseDouble(request.getParameter("importepago")); 
		Calendar pFecVncto = FormatoFecha.stringToCalendarDate(request.getParameter("fechaVcto")==null?"2":request.getParameter("fechaVcto"));
		
		
		//System.out.println("<get> paramOpcion :"+periodo+ "</h3>");
		
		String page="";	
		try{
			if(opcion.equals("1")){	//trae todos las cuotas
				
				PagosWS cuota = new PagosWS();
				
				Cuota[] lstCuota = cuota.ListarCuota(periodo);
				request.setAttribute("lstCuotas", lstCuota);
				page="/pages/frmCuotaListar.jsp";
				
			}else if(opcion.equals("2")){	//trae todos las cuotas
				PagosWS cuota = new PagosWS();
				//cuota.RegistrarCuota(pPeriodo, pIdVivienda, pImporte, pFecVncto);
			}
		}catch(Exception e){
			request.setAttribute("mensaje",e.getMessage());	
		}
		
		request.getRequestDispatcher(page).forward(request, response);
	}

}

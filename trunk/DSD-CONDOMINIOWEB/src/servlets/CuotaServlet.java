package servlets;

import java.io.IOException;
import java.io.PrintStream;
import java.util.Calendar;
import java.sql.Date;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.swing.JOptionPane;
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
		
		/*String strperiodo = request.getParameter("periodo");
		String strVivienda = request.getParameter("slcvivienda");
		String strImporte = request.getParameter("importepago");
		String strfechaVcto = request.getParameter("fechaVcto");
		
		Date strfechaVenc = FormatoFecha.stringToSqlDateYYYYMMDD(strfechaVcto);
		PagosWS pagoWS = new PagosWS();
		Cuota cuota = new Cuota();
		cuota.setC_Periodo(strperiodo);
		
		pagoWS.RegistrarCuota(strperiodo
							 ,Integer.parseInt(strVivienda)
							 ,Float.parseFloat(strImporte)
							 ,strfechaVenc.toString());
		*/
	}
	
	private void processRequest(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		
		String op= request.getParameter("op")==null?"1":request.getParameter("op");
		String strperiodo = request.getParameter("periodo")==null?"1":request.getParameter("periodo");
		int strVivienda = Integer.parseInt(request.getParameter("slcvivienda")==null?"1":request.getParameter("slcvivienda"));
		double strImporte = Double.parseDouble(request.getParameter("importepago")==null?"1":request.getParameter("importepago"));
		//Date strfechaVcto = FormatoFecha.stringToSqlDateYYYYMMDD(request.getParameter("fechaVcto")==null?"1":request.getParameter("fechaVcto"));
		Date strfechaVcto = FormatoFecha.stringToSqlDateYYYYMMDD(request.getParameter("fechaVcto")==null?"2":request.getParameter("fechaVcto"));
		String page="";
		JOptionPane.showMessageDialog(null, strfechaVcto);
		if(op.equals("create"))
		{
			JOptionPane.showMessageDialog(null, "Create");
			try {
				PagosWS pagoWS = new PagosWS();
				Cuota cuota = new Cuota();
				cuota.setC_Periodo(strperiodo);
				pagoWS.RegistrarCuota(strperiodo,strVivienda,strImporte,strfechaVcto);
				
				page= "/pages/frmCuotaCrear.jsp";
			} catch (Exception e) {
				System.out.println("ERROR: "+e.getMessage());
			}
			
		}else if(op.equals("list")){
			//JOptionPane.showMessageDialog(null, "list");
			PagosWS cuota = new PagosWS();
			Cuota[] lstCuota = cuota.ListarCuota("");
			request.setAttribute("lstCuotas", lstCuota);
			
			page="/pages/frmCuotaListar.jsp";
		}
		request.getRequestDispatcher(page).forward(request, response);
	}

	/*private void listar(HttpServletRequest request, HttpServletResponse response) 
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
	}*/
}

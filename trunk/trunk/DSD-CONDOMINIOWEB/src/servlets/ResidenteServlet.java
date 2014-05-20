package servlets;

import java.io.IOException;
import java.sql.Date;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collection;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import javax.xml.bind.ParseConversionEvent;

import org.datacontract.schemas._2004._07.Architects_Dominio.Residente;

import util.FormatoFecha;
import cleaner.ResidenteWS;


@WebServlet("/ResidenteServlet")
public class ResidenteServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;


    public ResidenteServlet() { }


	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		processRequest(request,response);
		
		
	}

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		processRequest(request,response);
	}

	private void processRequest(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		
		
   		String opcion = request.getParameter("opcion")==null?"2":request.getParameter("opcion");
   		String c_Nombre = request.getParameter("txtNombre")==null?"2":request.getParameter("txtNombre");
		String c_Apellidos = request.getParameter("txtApellidos")==null?"2":request.getParameter("txtApellidos");
		int n_TipoDoc = Integer.parseInt(request.getParameter("txtTipoDocumento")==null?"2":request.getParameter("txtTipoDocumento"));
		String c_NumDocume = request.getParameter("txtNuDocumento")==null?"2":request.getParameter("txtNuDocumento");
		Calendar D_FecNacimi = FormatoFecha.stringToCalendarDate(request.getParameter("txtFeNac")==null?"2":request.getParameter("txtFeNac"));
		String c_Correo = request.getParameter("txtCorreo")==null?"2":request.getParameter("txtCorreo");
		String c_Clave = request.getParameter("txtClave")==null?"2":request.getParameter("txtClave");
		Boolean b_Estado=true;
		String page="";	
		

		try{
			//trae todas las cuotas vencidas
			if(opcion.equals("1")){		
				page="/pages/ListaResidentes.jsp?opcion=1";
				ResidenteWS residente = new ResidenteWS();
					HttpSession session=request.getSession();
					//Usuario usuario= (Usuario) session.getAttribute("USUARIO_ACTUAL");//listo ahora ya tienes al usuario para que onbtengas en codigo
					Residente[] listado = residente.listarResidente();
					request.setAttribute("ListaResidentes", listado);
	
			//registra juntas	
			}else if(opcion.equals("2")){
				page="/pages/ListaResidentes.jsp?opcion=1";
				ResidenteWS residente = new ResidenteWS();
				residente.CrearResidente(c_Nombre, c_Apellidos, n_TipoDoc, c_NumDocume, D_FecNacimi, c_Correo, c_Clave, b_Estado);
				opcion="1";
			}else if(opcion.equals("3")){
				
				/*page="/pages/BuscarDirigente.jsp";
				String codigo=request.getParameter("codigo").trim().equals("")?"-1":request.getParameter("codigo").trim();								
				c=(List<Directivos>) negocioJunta.BuscarDirectivos(Integer.parseInt(codigo));				
				request.setAttribute("lista",c);*/
				
			}else if(opcion.equals("4")){
				/*page="/pages/detalleResidente.jsp";
				String codigo=request.getParameter("codigo").trim().equals("")?"-1":request.getParameter("codigo").trim();								
				GestionResidente negocio=new GestionResidente();
				Residente resi=negocio.obtener(Integer.parseInt(codigo));
				request.setAttribute("resi",resi);
				*/
			}else if(opcion.equals("5")){
				/*page="/pages/detalleVivienda.jsp";
				String codigo=request.getParameter("codigo").trim().equals("")?"-1":request.getParameter("codigo").trim();								
			
				GestionVivienda viv=new GestionVivienda();
				Vivienda vivienda=viv.obtener(Integer.parseInt(codigo));
				request.setAttribute("vivienda",vivienda);*/
				
			}
						
		}catch(Exception e){
			request.setAttribute("mensaje",e.getMessage());	
			/*Junta junta=new Junta(0, fechaJunta, strHora, strTema, strAcuerdo, listado);
			request.setAttribute("beanJunta",junta);*/
		}
										
		request.getRequestDispatcher(page).forward(request, response);
				
	}
}

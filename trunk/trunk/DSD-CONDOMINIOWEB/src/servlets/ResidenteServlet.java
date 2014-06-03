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
import javax.swing.JOptionPane;
import javax.xml.bind.ParseConversionEvent;

import org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE;

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
		
		String opcion = request.getParameter("opcion")==null?"1":request.getParameter("opcion");
		int n_IdResidente = Integer.parseInt(request.getParameter("n_IdResidente")==null?"2":request.getParameter("n_IdResidente"));
		String c_Nombre = request.getParameter("txtNombre")==null?"2":request.getParameter("txtNombre");
		String c_Apellidos = request.getParameter("txtApellidos")==null?"2":request.getParameter("txtApellidos");
		int n_TipoDoc = Integer.parseInt(request.getParameter("txtTipoDocumento")==null?"2":request.getParameter("txtTipoDocumento"));
		String c_NumDocume = request.getParameter("txtNuDocumento")==null?"2":request.getParameter("txtNuDocumento");
		Date D_FecNacimi = FormatoFecha.stringToSqlDateYYYYMMDD(request.getParameter("txtFeNac")==null?"2":request.getParameter("txtFeNac"));
		
		String c_Correo = request.getParameter("txtCorreo")==null?"2":request.getParameter("txtCorreo");
		String c_Clave = request.getParameter("txtClave")==null?"2":request.getParameter("txtClave");
		Boolean b_Estado=true;
		String page="";	
		
		try{
 
			if(opcion.equals("1")){	//trae todos los residentes
				
				ResidenteWS residente = new ResidenteWS();
				
				ResidenteBE[] listado = residente.listarResidente();
				request.setAttribute("ListaResidentes", listado);
				page="/pages/ListaResidentes.jsp";
				
			}else if(opcion.equals("2")){ //registra Residentes
				
				ResidenteWS residente = new ResidenteWS();
				int x= residente.CrearResidente(c_Nombre, c_Apellidos, n_TipoDoc, c_NumDocume, D_FecNacimi, c_Correo, c_Clave, b_Estado);
				page="/pages/util.jsp?aux="+x;
				
			}else if(opcion.equals("3")){ //Actualiza Residentes
				
				ResidenteWS residente = new ResidenteWS();
				int x=residente.ModificarResidente(n_IdResidente, c_Nombre, c_Apellidos, n_TipoDoc, c_NumDocume, D_FecNacimi, c_Correo, c_Clave, b_Estado);
				page="/pages/util.jsp?aux="+x;
				
				
			}else if(opcion.equals("4")){ //Obtiene un residente por codigo
				
				ResidenteWS residente = new ResidenteWS();
				int codigo= Integer.parseInt(request.getParameter("cod").trim().equals("")?"0":request.getParameter("cod").trim());								
				
				
				System.out.println("codigo"+codigo);
				ResidenteBE r=residente.ObtenerResidentePorID(codigo);
				//residente.ObtenerResidente(codigo);mos
				request.setAttribute("residente",r);
				
				page="/pages/frmResidenteActualizar.jsp";
				
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

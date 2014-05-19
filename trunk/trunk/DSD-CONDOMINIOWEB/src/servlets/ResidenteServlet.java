package servlets;

import java.io.IOException;
import java.util.Collection;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import org.datacontract.schemas._2004._07.Architects_Dominio.Residente;

import cleaner.ResidenteWS;


/**
 * Servlet implementation class ResidenteServlet
 */
@WebServlet("/ResidenteServlet")
public class ResidenteServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

    /**
     * Default constructor. 
     */
    public ResidenteServlet() {
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//int cod = Integer.parseInt(request.getParameter("CodUsuario"));
		ResidenteWS residente = new ResidenteWS();
	
		try {
			HttpSession session=request.getSession();
			//Usuario usuario= (Usuario) session.getAttribute("USUARIO_ACTUAL");//listo ahora ya tienes al usuario para que onbtengas en codigo
			Residente[] listado = residente.listarResidente();
			request.setAttribute("ListaResidentes", listado);
			RequestDispatcher rd = request.getRequestDispatcher("/pages/EspacioComunCliente.jsp");
			rd.forward(request, response);

		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
	}

}

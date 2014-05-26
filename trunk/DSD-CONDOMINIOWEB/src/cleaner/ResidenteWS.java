package cleaner;

import java.rmi.RemoteException;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collection;
import java.sql.Date;
import java.util.List;

import org.datacontract.schemas._2004._07.Architects_Dominio.Residente;
import org.tempuri.IResidenteServiceProxy;
import org.tempuri.ResidenteService;

public class ResidenteWS {

	private IResidenteServiceProxy servicio;
	public ResidenteWS(){
		servicio = new IResidenteServiceProxy();
	}
	
	public int CrearResidente(String c_Nombre, String c_Apellidos, java.lang.Integer n_TipoDoc, 
			String c_NumDocume, Date d_FecNacimi, String c_Correo, String c_Clave, Boolean b_Estado){
		
		try {
			return servicio.crearResidente(c_Nombre, c_Apellidos, n_TipoDoc, c_NumDocume, d_FecNacimi, c_Correo, c_Clave, b_Estado);
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return 0;
	}
	
	public int ModificarResidente(int n_IdResidente,String c_Nombre, String c_Apellidos, int n_TipoDoc, 
			String c_NumDocume, Date d_FecNacimi, String c_Correo, String c_Clave, Boolean b_Estado){
		
		try {
			return servicio.actualizaResidente(n_IdResidente, c_Nombre, c_Apellidos, n_TipoDoc, c_NumDocume, d_FecNacimi, c_Correo, c_Clave, b_Estado);
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return 0;
	}
	
	public Residente ObtenerResidente(int n_IdResidente){
		
		try {
			return servicio.obtenerResidente(n_IdResidente);
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}
	
	public Residente[] listarResidente(){
	
		try {
			return servicio.listarResidente();
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;

	}
}

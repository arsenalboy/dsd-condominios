package cleaner;

import java.rmi.RemoteException;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collection;
import java.util.Date;
import java.util.List;

import org.datacontract.schemas._2004._07.Architects_Dominio.Residente;
import org.tempuri.IResidenteServiceProxy;
import org.tempuri.ResidenteService;

public class ResidenteWS {

	private IResidenteServiceProxy servicio;
	public ResidenteWS(){
		servicio = new IResidenteServiceProxy();
	}
	
	public int CrearResidente(int n_IdResidente, String c_Nombre, String c_Apellidos, int n_TipoDoc, 
			String c_NumDocume, Calendar D_FecNacimi, String c_Correo, String c_Clave, Boolean b_Estado){
		
		try {
			return servicio.crearResidente(n_IdResidente, c_Nombre, c_Apellidos, n_TipoDoc, c_NumDocume, D_FecNacimi, c_Correo, c_Clave, b_Estado);
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return 0;
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

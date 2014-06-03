package cleaner;

import java.rmi.RemoteException;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collection;
import java.sql.Date;
import java.util.List;

import org.datacontract.schemas._2004._07.Architects_Dominio.ResidenteBE;
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
			ResidenteBE prmResidenteBE = new ResidenteBE();
			prmResidenteBE.setC_Nombre(c_Nombre);
			prmResidenteBE.setC_Apellidos(c_Apellidos);
			prmResidenteBE.setN_TipoDoc(n_TipoDoc);
			prmResidenteBE.setC_NumDocume(c_NumDocume);
			prmResidenteBE.setD_FecNacimi(d_FecNacimi) ;
			prmResidenteBE.setC_Correo(c_Correo);
			prmResidenteBE.setC_Clave(c_Clave);
			return servicio.crearResidente(prmResidenteBE);
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return 0;
	}
	
	public int ModificarResidente(int n_IdResidente,String c_Nombre, String c_Apellidos, int n_TipoDoc, 
			String c_NumDocume, Date d_FecNacimi, String c_Correo, String c_Clave, Boolean b_Estado){
		
		try {
			ResidenteBE prmResidenteBE = new ResidenteBE();
			prmResidenteBE.setN_IdResidente(n_IdResidente);
			prmResidenteBE.setC_Nombre(c_Nombre);
			prmResidenteBE.setC_Apellidos(c_Apellidos);
			prmResidenteBE.setN_TipoDoc(n_TipoDoc);
			prmResidenteBE.setC_NumDocume(c_NumDocume);
			//prmResidenteBE.setD_FecNacimi(d_FecNacimi.getClass(Calendar.AM)) ;
			prmResidenteBE.setC_Correo(c_Correo);
			prmResidenteBE.setC_Clave(c_Clave);
			servicio.actualizarResidente(prmResidenteBE);
		} catch (RemoteException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return 0;
	}
	
	public ResidenteBE ObtenerResidente(int n_IdResidente){
		
		try {
			return servicio.obtenerResidentePorID(n_IdResidente);
		} catch (RemoteException e) {
			e.printStackTrace();
		}
		return null;
	}
	
	public ResidenteBE[] listarResidente(){
	
		try {
			return servicio.listarResidentes();
		} catch (RemoteException e) {
			e.printStackTrace();
		}
		return null;

	}
}

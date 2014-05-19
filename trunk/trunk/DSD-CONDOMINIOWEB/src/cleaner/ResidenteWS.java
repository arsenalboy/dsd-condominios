package cleaner;

import java.rmi.RemoteException;
import java.util.ArrayList;
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
	
	/*public int CrearResidente(int n_IdResidente, String c_Nombre, String c_Apellidos, int n_TipoDoc, 
			String c_NumDocume, Datetime D_FecNacimi, String c_Correo, String c_Clave, Boolean b_Estado){
		
		return servicio.crearResidente(n_IdResidente, c_Nombre, c_Apellidos, n_TipoDoc, c_NumDocume, d_FecNacimi, c_Correo, c_Clave, b_Estado);
	}*/
	
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

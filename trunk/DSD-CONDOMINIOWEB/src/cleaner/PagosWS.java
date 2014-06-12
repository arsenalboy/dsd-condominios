package cleaner;

import java.math.BigDecimal;
import java.rmi.RemoteException;
import java.sql.Date;

import org.datacontract.schemas._2004._07.Architects_Dominio.RetornaMensaje;
import org.datacontract.schemas._2004._07.Architecs_PagosService.Cuota;
import org.tempuri.IPagosServiceProxy;

import java.util.Calendar;


public class PagosWS {
	private IPagosServiceProxy servicio;
	
	public PagosWS(){
		servicio = new IPagosServiceProxy();
	}
	
	public RetornaMensaje RegistrarCuota(String pPeriodo, int pIdVivienda, double pImporte, Date pFecVncto){
		RetornaMensaje retornaMensaje = null;
		try{
			//Date dateFecVncto = pFecVncto.getTime(); 
			retornaMensaje = servicio.registrarCuota(pPeriodo, pIdVivienda,  pImporte, pFecVncto);
		}
		catch(RemoteException ex){
			ex.printStackTrace();
		}
		return retornaMensaje;
	}
	
	public RetornaMensaje ActualizarCuota(int pIdCuota, String pPeriodo, int pIdVivienda, double pImporte, String pFecVncto){
		RetornaMensaje retornaMensaje = null;
		try{
			//Date dateFecVncto = pFecVncto.getTime(); 
			retornaMensaje = servicio.actualizarCuota(pIdCuota, pPeriodo, pIdVivienda, pImporte, pFecVncto);
		}
		catch(RemoteException ex){
			ex.printStackTrace();
		}
		return retornaMensaje;
	}
	
	public RetornaMensaje EliminarCuota(int pIdCuota){
		RetornaMensaje retornaMensaje = null;
		try{
			retornaMensaje = servicio.eliminarCuota(pIdCuota);
		}
		catch(RemoteException ex){
			ex.printStackTrace();
		}
		return retornaMensaje;
	}
	
	public Cuota[] ListarCuota(String pPeriodo)
	{
		try{
			return  servicio.listarCuota(pPeriodo);
		}
		catch(RemoteException ex){
			ex.printStackTrace();
		}
		return null;
	}
	
	public Cuota BuscarCuota(int pIdCuota)
	{
		try{
			return  servicio.buscarCuota(pIdCuota);
		}
		catch(RemoteException ex){
			ex.printStackTrace();
		}
		return null;
	}

	
}

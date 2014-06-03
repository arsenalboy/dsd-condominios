package cleaner;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.ProtocolException;
import java.net.URL;
import javax.xml.bind.JAXBContext;
import javax.xml.bind.JAXBException;
import modelo.*;
import java.util.Date;

public class VisitanteWS {
	
	public Visitante ObtenerVisitante(String numDocumento)
	{
		try
		{
			String uri = 
			    "http://localhost:62061/VisitaService.svc/Visitantes/xml?NroDoc="+numDocumento;
			URL url = new URL(uri);
			HttpURLConnection connection = 
			    (HttpURLConnection) url.openConnection();
			connection.setRequestMethod("GET");
			connection.setRequestProperty("Accept", "application/xml");
			 
			JAXBContext jc = JAXBContext.newInstance(Visitante.class);
			InputStream xml = connection.getInputStream();
			Visitante visitante = 
			    (Visitante) jc.createUnmarshaller().unmarshal(xml);
			 
			connection.disconnect();
			return visitante;
		
		} catch (JAXBException e) {			
			e.printStackTrace();
			return null;
		} catch (MalformedURLException e) {			
			e.printStackTrace();
			return null;
		} catch (ProtocolException e) {
			e.printStackTrace();
			return null;
		} catch (IOException e) {			
			e.printStackTrace();
			return null;
		}
	}
	
	public void AgregarVisitante(String NumDocumentoVisitante, String Nombre, String numeroDocResidente, 
			Date FecNacim)
	{
		Visitante visitante = new Visitante();
		Residente residente = new Residente();		
		JAXBContext jaxbContext;
		
		try {
			
			residente.setNumeroDocumento(numeroDocResidente);
			visitante.setC_NumDocumento(NumDocumentoVisitante);
			visitante.setC_Nombre(Nombre);
			visitante.setD_FecVisita(FecNacim);
			visitante.setResidente(residente);			
			
			URL url = new URL("http://localhost:62061/VisitaService.svc/Visitantes");
			jaxbContext = JAXBContext.newInstance(Visitante.class);
			
			HttpURLConnection connection = (HttpURLConnection) url.openConnection(); 
	        connection.setDoOutput(true); 
	        connection.setInstanceFollowRedirects(false); 
	        connection.setRequestMethod("POST"); 
	        connection.setRequestProperty("Content-Type", "application/xml"); 

	        OutputStream os = connection.getOutputStream(); 
	        jaxbContext.createMarshaller().marshal(visitante, os); 
	        os.flush();

	        connection.getResponseCode(); 
	        connection.disconnect(); 
			
		} catch (JAXBException e) {			
			e.printStackTrace();
		} catch (MalformedURLException e) {			
			e.printStackTrace();
		} catch (ProtocolException e) {
			e.printStackTrace();
		} catch (IOException e) {			
			e.printStackTrace();
		}	
        
	}
}

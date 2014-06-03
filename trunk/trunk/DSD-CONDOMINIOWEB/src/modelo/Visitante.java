package modelo;

import java.util.Date;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlRootElement;

@XmlRootElement
public class Visitante {
		private int intCorrelativo;
		private String C_NumDocumento;
		private String C_Nombre;
		private Residente obResidente;		
		private Date D_FecVisita;
		

		public Visitante() {
			obResidente = new Residente();
		}
		
		public Visitante(String C_NumDocumento, String C_Nombre,
			 int intCodigoResidente, Date dHoraFechaVisitante) {
			obResidente = new Residente();
			this.C_NumDocumento = C_NumDocumento;
			this.C_Nombre = C_Nombre;
			this.obResidente.setIdResidente(intCodigoResidente);			
			this.D_FecVisita = dHoraFechaVisitante;
		}
		
		public int getintCorrelativo() {
			return intCorrelativo;
		}		
		public String getC_NumDocumento() {
			return C_NumDocumento;
		}
		@XmlElement
		public void setC_NumDocumento(String C_NumDocumento) {
			this.C_NumDocumento = C_NumDocumento;
		}		
		public String getC_Nombre() {
			return C_Nombre;
		}
		@XmlElement
		public void setC_Nombre(String C_Nombre) {
			this.C_Nombre = C_Nombre;
		}
		public Residente getResidente() {
			return obResidente;
		}
		@XmlElement
		public void setResidente(Residente residente) {
			this.obResidente = residente;
		}	

		public Date getD_FecVisita() {
			return D_FecVisita;
		}
		@XmlElement
		public void setD_FecVisita(Date dHoraFechaVisitante) {
			this.D_FecVisita = dHoraFechaVisitante;
		}	
}

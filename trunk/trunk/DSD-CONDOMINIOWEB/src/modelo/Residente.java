package modelo;

import java.util.Date;

import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlElement;


@XmlRootElement
public class Residente {

	private int idResidente;
	private String C_Nombre;
	private String C_Apellidos;
	private int N_TipoDoc;
	private Date D_FecNacimi;
	private String C_correo;
	private String C_numDocumen;
	private String C_clave;
	private String estadoRegistro;
	
	public Residente() {
		
	}

		
	public Residente(String nombreResidente, String apellidosResidente,
			int tipoDocumento, Date fechaNacimiento, String correo,
			String numeroDocumento, String clave, String estadoRegistro) {
		super();	
		this.C_Nombre = nombreResidente;
		this.C_Apellidos = apellidosResidente;
		this.N_TipoDoc = tipoDocumento;
		this.D_FecNacimi = fechaNacimiento;
		this.C_correo = correo;
		this.C_numDocumen = numeroDocumento;
		this.C_clave = clave;
		this.estadoRegistro = estadoRegistro;
	}

	public int getIdResidente() {
		return idResidente;
	}
	@XmlElement
	public void setIdResidente(int idResidente) {
		this.idResidente = idResidente;
	}

	public String getNombreResidente() {
		return C_Nombre;
	}
	@XmlElement
	public void setNombreResidente(String nombreResidente) {
		this.C_Nombre = nombreResidente;
	}
	@XmlElement
	public void setApellidos(String idResidente) {
		this.C_Apellidos = idResidente;
	}

	public String getApellidos() {
		return C_Apellidos;
	}	

	public int getTipoDocumento() {
		return N_TipoDoc;
	}
	@XmlElement
	public void setTipoDocumento(int tipoDocumento) {
		this.N_TipoDoc = tipoDocumento;
	}

	public Date getFechaNacimiento() {
		return D_FecNacimi;
	}
	@XmlElement
	public void setFechaNacimiento(Date fechaNacimiento) {
		this.D_FecNacimi = fechaNacimiento;
	}

	public String getCorreo() {
		return C_correo;
	}
	@XmlElement
	public void setCorreo(String correo) {
		this.C_correo = correo;
	}

	public String getNumeroDocumento() {
		return C_numDocumen;
	}
	@XmlElement
	public void setNumeroDocumento(String numeroDocumento) {
		this.C_numDocumen = numeroDocumento;
	}

	public String getClave() {
		return C_clave;
	}
	@XmlElement
	public void setClave(String clave) {
		this.C_clave = clave;
	}

	public String getEstadoRegistro() {
		return estadoRegistro;
	}
	@XmlElement
	public void setEstadoRegistro(String estadoRegistro) {
		this.estadoRegistro = estadoRegistro;
	}	
}

﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Architects.Persistencia
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CondominiosDB")]
	public partial class DBMLReservasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DBMLReservasDataContext() : 
				base(global::Architects.Persistencia.Properties.Settings.Default.CondominiosDBConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLReservasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLReservasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLReservasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLReservasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Maestros.dsd_mnt_I_EspacioComun")]
		public int dsd_mnt_I_EspacioComun([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string prm_C_Nombre, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> prm_B_Estado, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> prm_N_IdEspacioComun)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prm_C_Nombre, prm_B_Estado, prm_N_IdEspacioComun);
			prm_N_IdEspacioComun = ((System.Nullable<int>)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Maestros.dsd_mnt_S_EspacioComun")]
		public ISingleResult<dsd_mnt_S_EspacioComunResult> dsd_mnt_S_EspacioComun()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<dsd_mnt_S_EspacioComunResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Maestros.dsd_mnt_I_EspacioComunId")]
		public ISingleResult<dsd_mnt_I_EspacioComunIdResult> dsd_mnt_I_EspacioComunId([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdEspacioComun)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prm_N_IdEspacioComun);
			return ((ISingleResult<dsd_mnt_I_EspacioComunIdResult>)(result.ReturnValue));
		}
	}
	
	public partial class dsd_mnt_S_EspacioComunResult
	{
		
		private int _N_IdEspacioComun;
		
		private string _C_Nombre;
		
		private bool _B_Estado;
		
		public dsd_mnt_S_EspacioComunResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdEspacioComun", DbType="Int NOT NULL")]
		public int N_IdEspacioComun
		{
			get
			{
				return this._N_IdEspacioComun;
			}
			set
			{
				if ((this._N_IdEspacioComun != value))
				{
					this._N_IdEspacioComun = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Nombre", DbType="VarChar(100)")]
		public string C_Nombre
		{
			get
			{
				return this._C_Nombre;
			}
			set
			{
				if ((this._C_Nombre != value))
				{
					this._C_Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B_Estado", DbType="Bit NOT NULL")]
		public bool B_Estado
		{
			get
			{
				return this._B_Estado;
			}
			set
			{
				if ((this._B_Estado != value))
				{
					this._B_Estado = value;
				}
			}
		}
	}
	
	public partial class dsd_mnt_I_EspacioComunIdResult
	{
		
		private int _N_IdEspacioComun;
		
		private string _C_Nombre;
		
		private bool _B_Estado;
		
		public dsd_mnt_I_EspacioComunIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdEspacioComun", DbType="Int NOT NULL")]
		public int N_IdEspacioComun
		{
			get
			{
				return this._N_IdEspacioComun;
			}
			set
			{
				if ((this._N_IdEspacioComun != value))
				{
					this._N_IdEspacioComun = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Nombre", DbType="VarChar(100)")]
		public string C_Nombre
		{
			get
			{
				return this._C_Nombre;
			}
			set
			{
				if ((this._C_Nombre != value))
				{
					this._C_Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B_Estado", DbType="Bit NOT NULL")]
		public bool B_Estado
		{
			get
			{
				return this._B_Estado;
			}
			set
			{
				if ((this._B_Estado != value))
				{
					this._B_Estado = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

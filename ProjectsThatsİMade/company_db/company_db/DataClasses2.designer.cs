﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace company_db
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database_Company")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::company_db.Properties.Settings.Default.Database_CompanyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<employeesvwtable> employeesvwtables
		{
			get
			{
				return this.GetTable<employeesvwtable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employeesvwtable")]
	public partial class employeesvwtable
	{
		
		private string _employee_name;
		
		private System.Nullable<int> _employee_wages;
		
		public employeesvwtable()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_name", DbType="NVarChar(50)")]
		public string employee_name
		{
			get
			{
				return this._employee_name;
			}
			set
			{
				if ((this._employee_name != value))
				{
					this._employee_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_employee_wages", DbType="Int")]
		public System.Nullable<int> employee_wages
		{
			get
			{
				return this._employee_wages;
			}
			set
			{
				if ((this._employee_wages != value))
				{
					this._employee_wages = value;
				}
			}
		}
	}
}
#pragma warning restore 1591

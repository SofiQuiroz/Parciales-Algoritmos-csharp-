/*
 * Creado por SharpDevelop.
 * Usuario: Sofi
 * Fecha: 18/01/2022
 * Hora: 12:25 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace primer_parcial_2021
{
	/// <summary>
	/// Description of Proveedor.
	/// </summary>
	public class Proveedor
	{	
		private string nombre;
		private int codProve;
		private int telef;
		public Proveedor(string nom, int cod, int telefono)
		{	
			nombre=nom;
			codProve=cod;
			telef=telefono;
		}
		
		public string Nombre
		{
			set{ nombre=value;}
			get{ return nombre;}
		}
		
		public int CodProve
		{
			set{ codProve=value;}
			get{ return codProve;}
		}
		
		public int Telefono
		{
			set{ telef=value;}
			get{ return telef;}
		}
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: Sofi
 * Fecha: 18/01/2022
 * Hora: 12:25 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace primer_parcial_2021
{
	/// <summary>
	/// Description of Producto.
	/// </summary>
	public class Producto
	{	
		private string nombre;
		private int cod, stockActual;
		private double precio;
		private Proveedor proved;
		public Producto(string nom, int codigo, int stock, double pre, Proveedor prov)
		{	
			nombre=nom;
			cod=codigo;
			stockActual=stock;
			precio=pre;
			proved=prov;
		}
		
		public string Nombre
		{
			set{ nombre=value;}
			get{return nombre;}
		}
		
		public int Cod
		{
			set{cod=value;}
			get{return cod;}
		}
		
		public int StockActual
		{
			set{stockActual=value;}
			get{return stockActual;}
		}
		
		public double Precio
		{
			set{precio=value;}
			get{return precio;}
		}
		
		public Proveedor Proved
		{	
			set{proved=value;}
			get{return proved;}
		}
	}
}

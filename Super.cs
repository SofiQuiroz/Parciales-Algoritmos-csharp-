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
	/// Description of Super.
	/// </summary>
	public class Super
	{	
		private ArrayList productos;
		private ArrayList proveedores;
		private string nombre;
		public Super(string nom)
		{	
			nombre=nom;
			productos=new ArrayList();
			proveedores=new ArrayList();
		}
		
		public string NombreSuper
		{
			set{ nombre=value;}
			get{ return nombre;}
		}
		
		public ArrayList Productos
		{
			get{return productos;}
		}
		
		public ArrayList Proveedores
		{
			get{return proveedores;}
		}
		
		public void reponerStock(int nroProd, int unidades)
		{
			foreach(Producto elem in Productos)
			{
				if (elem.Cod==nroProd)
				{
					elem.StockActual+=unidades;
				}
			}
		}
		
		public void agregarProd(Producto prod)
		{
			productos.Add(prod);
			Console.WriteLine("Producto agregado con exito!");
		}
		
		public void agregarProv(Proveedor prov)
		{
			proveedores.Add(prov);
			Console.WriteLine("Proveedor agregado con exito!");
		}
	}
}

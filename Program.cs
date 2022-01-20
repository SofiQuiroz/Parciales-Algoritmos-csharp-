/*
 * Creado por SharpDevelop.
 * Usuario: Sofi
 * Fecha: 18/01/2022
 * Hora: 12:21 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace primer_parcial_2021
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*CREACION DE SUPER*/
			Super super=new Super("VeaMos");
			
			/*CARGA DE PRODUCTOS Y PROVEEDOR*/
			Console.Write("desea ingresar productos? s/n:");
			string resp=Console.ReadLine();
			while(resp!="n")
			{
				Console.WriteLine("Ingreso de datos de productos.");
				Console.Write("nombre del producto:");
				string nombre=Console.ReadLine();
				Console.Write("codigo del producto:");
				int cod=int.Parse(Console.ReadLine());
				Console.Write("stock del producto:");
				int stock=int.Parse(Console.ReadLine());
				Console.Write("precio del producto:");
				double precio=double.Parse(Console.ReadLine());
				
				
				Console.Write("codigo del proveedor:");
				int prov=int.Parse(Console.ReadLine());
				foreach(Proveedor codigo in super.Proveedores)
				{
					if(codigo.CodProve==prov)	//SI EL PROVEEDOR YA ESTÁ EN LA LISTA DEL SUPER, SOLO AGREGA EL PRODUCTO
					{
						Producto prod=new Producto(nombre,cod,stock,precio,codigo);
						super.agregarProd(prod);
					}
					else
					{
						//SI EL PROVEEDOR NO ESTÁ EN LA LISTA DEL SUPER, SE AGREGA PROVEEDOR Y PRODUCTO
						Console.Write("Proveedor no encontrado, dar de alta.");
						
						Console.WriteLine("Ingreso de datos de proveedores.");
						Console.Write("nombre del proveedor:");
						string nom_prov=Console.ReadLine();
						Console.Write("telefono del proveedor:");
						int tel=int.Parse(Console.ReadLine());
						
						Proveedor proved=new Proveedor(nom_prov,prov,tel);
						Producto prod=new Producto(nombre,cod,stock,precio,proved);
						
						super.agregarProd(prod);
						super.agregarProv(proved);
					}
				}
		
				Console.Write("desea ingresar más productos? s/n:");
				resp=Console.ReadLine();				
			}
			
			/*SIMULACION DE VENTAS*/
			
			ArrayList reponer=new ArrayList();
			
			double monto=0;
			
			Console.Write("desea realizar una compra?s/n");
			string r=Console.ReadLine();
			while(r!="n")
			{
				Console.Write("ingrese el codigo del producto:");
				int cod=int.Parse(Console.ReadLine());
				Console.Write("ingrese las unidades a comprar:");
				int uni=int.Parse(Console.ReadLine());
				foreach(Producto elem in super.Productos)	//RECORRE LA LISTA DE PRODUCTOS DEL SUPER
				{
					if(elem.Cod==cod)						//BUSCA EN LA LISTA DE PRODUCTOS DEL SUPER SI EL CODIGO INGRESADO CORRESPONDE AL CODIGO DE ALGUN PRODUCTO
					{	
						try{
							if(elem.StockActual<uni)		//SI EXISTE EL CODIGO. EVALUA EL STOCK Y SI ES MENOR AL QUE QUIERE LLEVAR, SALTA UNA EXCEPTION
							{
								reponer.Add(elem.Cod);		//AGREGA EL CODIGO A UNA LISTA PARA REPONER EL PRODUCTO
								throw new FaltaStockException();
							}
						}
						catch(FaltaStockException)
						{
							Console.WriteLine("Falta stock del producto.");	//AVISA QUE NO HAY STOCK
						}
						if(elem.StockActual>=uni)
						{
							elem.StockActual-=uni;			//SI HAY STOCK SUFICIENTE REALIZA LA COMPRA Y SE SUMA EL PRECIO AL MONTO RECAUDADO
							monto=monto+(elem.Precio*uni);
						}
					}
					
					if(elem.Cod!=cod)
					{
						Console.Write("No vendemos ese producto.");	//SI EL CODIGO NO SE ENCUENTRA EN LA LISTA DE PRODUCTOS DEL SUPER, DA AVISO DE QUE NO SE VENDE ESE PRODUCTO
					}
				}
				
				Console.Write("desea realizar otra compra?s/n");
				r=Console.ReadLine();
			}
			
			Console.Write("EL MONTO RECAUDADO ES DE ${0}",monto);
			
			//simular la reposición de los productos faltantes
			
			foreach(int codigo in reponer)
			{
				Console.Write("ingrese las unidades a reponer:");
				int u=int.Parse(Console.ReadLine());
				super.reponerStock(codigo,u);
			}
			
			
//			Implemente una función recursiva que reciba un conjunto de números y retorne como resultado 
//			la cantidad de valores impares mayores a 10.
//			Escriba la invocación a la función con sus respectivos parámetros.
			
			
		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
using System.Runtime.CompilerServices;

namespace YAGNI
{
    class program
    {
        public class ProductService
        {
            private static int ContadorID = 1;
            public void AddProduct(string productName, decimal price)
            {
                int productID = ContadorID++;
                Console.WriteLine("\n ID:" + productID +"\n"+ "Se agrego " + productName + " y cuesta " + price + " Pesos \n");
            }
            public void DeleteProduct(int productID)
            {            
                Console.WriteLine("\n Se a eliminado el producto ID: " + productID +"\n");        
            }
        }
        static void Main(string[] args)
        {
            bool menu = true;

            while (menu)
            {
                Console.WriteLine("Menu de Opciones: ");
                Console.WriteLine(" 1- Agregar Productos");
                Console.WriteLine(" 2- Eliminar Productos");
                Console.WriteLine(" 3- Salir del sistema ");
                Console.Write("   Elija lo que quiere hacer >>>");

                int opc = Convert.ToInt32(Console.ReadLine());

                ProductService service = new ProductService();

                switch (opc) 
                {
                    case 1:
                        Console.Write("Ingrese el nombre del producto: ");
                        string nombre = Convert.ToString(Console.ReadLine());
                        Console.Write("Ingrese el precio del producto: ");
                        decimal precio = Convert.ToDecimal(Console.ReadLine());
                        service.AddProduct(nombre , precio);
                        break;
                    case 2:
                        Console.Write("Ingrese el ID del producto que desea eliminar: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        service.DeleteProduct(num);
                        break;
                    case 3:
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Ingresa una opcion valida");
                        break;                 
                }
            }
        }
    }
}


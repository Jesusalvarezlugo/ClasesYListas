using ClasesYListas.Dtos;

namespace ClasesYListas.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {

            // Para que esto funcione, poner todos los campos en public
            /*//LISTA DE TIPO PRIMITIVO
            List<int> listaEnteros = new List<int>();
            //Añadir
            listaEnteros.Add(22);
            int entero = 6;
            listaEnteros.Add(entero);
            //[22][6]
            //Acceder ¡Las posiciones de una lista empiezan en el cero!
            //Directamente
            listaEnteros[0]=entero;//[6][6]
            listaEnteros[1] = 22;//[6][22]
            int posicionCero = listaEnteros[0];//posicionCero = 6
            int posicionUno = listaEnteros[1];//posicionUno = 22
            //Indirecto(Recoriendo la lista)
            for(int posicion = 0; posicion <listaEnteros.Count();posicion++)
            {
                Console.WriteLine(listaEnteros[posicion]);
            }

            //LISTA DE TIPO OBJETO

            List<ClienteDto> listaClientes = new List<ClienteDto>();
            //Crear un cliente
            ClienteDto cliente1=new ClienteDto();
            cliente1.nombreCliente = "Jesús";
            cliente1.apellidosCliente = "Álvarez";
            string nombreCompleto = cliente1.nombreCliente + cliente1.apellidosCliente;

            ClienteDto cliente2=new ClienteDto();
            cliente2.nombreCliente = "Pepe";
            cliente2.apellidosCliente = "Garcia";
            
            //Añadir los clientes a la lista
            listaClientes.Add(cliente1);
            listaClientes.Add (cliente2);
            //[cliente1][cliente2]

            //Acceder a un cliente específico por su posicion
            ClienteDto cliente2Prima=listaClientes[1];
            //Accedido al cliente 2 que estaba en la posicion de la 1 de la lista
            //y dentro de ese cliente hemos accedido a su campo nombre
            Console.WriteLine(listaClientes[1].nombreCliente);
            //Modificacion de un campo del objeto cliente2
            listaClientes[1].nombreCliente = "María";
            Console.WriteLine(listaClientes[1].nombreCliente);
            //Accedemos a la referencia de memoria de la lista
            Console.WriteLine(listaClientes);
            //Accedemos a la referencia de memoria del objeto cliente1
            Console.Write(listaClientes[0]);

            //Recorrer toda la lsita
            for (int posicion=0;posicion<listaClientes.Count();posicion++)
            {
                Console.WriteLine("\nNombre: " + listaClientes[posicion].nombreCliente);
            }

            //Eliminar, cuando se elimina la lista se recompone o se desplaza para cubrir
            //el espacio libre
            //listaClientes.RemoveAt(0);
            //Console.WriteLine(listaClientes.Count());

            //foreach
            //[cielnte1][cliente2]
            Console.WriteLine(cliente2.nombreCliente);
            Console.WriteLine(cliente2Prima.nombreCliente);
            Console.WriteLine(listaClientes[1].nombreCliente);
            cliente2Prima.nombreCliente = "Alfonso";
            Console.WriteLine(cliente2.nombreCliente);
            Console.WriteLine(cliente2Prima.nombreCliente);
            Console.WriteLine(listaClientes[1].nombreCliente);
            foreach (ClienteDto cliente in listaClientes)
            {
                cliente.nombreCliente = "Rocio";
            }

            Console.WriteLine(cliente2.nombreCliente);
            Console.WriteLine(cliente2Prima.nombreCliente);
            Console.WriteLine(listaClientes[1].nombreCliente);

            //Modificar un elemento especifico
            foreach(ClienteDto cliente in listaClientes)
            {
                if (cliente.nombreCliente == "Rocio")
                {
                    cliente.apellidosCliente = "Leal";
                }

            }
            Console.WriteLine(cliente2.apellidosCliente);
            */


            //Atributos en privado,
            //que es el modificador que tienen por defecto los miembros de una clase

            ClienteDto cliente = new ClienteDto();           
            /*cliente.NombreCliente = "Marcos";
            string nombre = cliente.NombreCliente;*/
            ClienteDto cliente1=new ClienteDto("Jesus","Alvarez Lugo");

            //INSTANCIAR UN NUEVO CLIENTE AL QUE SE LE INFORME EL NOMBRE Y EL DNI DIRECTAMENTE
            //SE IMPRIMA POR CONSOLA EL NOMBRE Y EL DNI UTILIZANDO EL METODO

            ClienteDto cliente2 = new ClienteDto("Jesús","23456456M");
            

            cliente2.ToString();
            Console.WriteLine(cliente2);//referencia
            Console.WriteLine(cliente2.toString());
            













           /* List<int> listaEnteros = new List<int>() { 1, 2, 3, 4, 5, };
            //borra por posicion
            listaEnteros.RemoveAt(1);
            //1 ,3 ,4 , 5
            //borra por valor
            listaEnteros.Remove(4);
            //1, 3, 5
            //borra por posicion indicando cuantas posiciones se ven afectadas
            listaEnteros.RemoveRange(1,2);
            // 1
            listaEnteros.Add(8);
            listaEnteros.Add(7);
            listaEnteros.Add(4);
            //1, 8, 7, 4
            //elimina los valores que cumplan la condicion dada 
            //listaEnteros.RemoveAll( x=> x<5 );//lista string--> listaEnteros.RemoveAll(x => x.equals("paula"));<-- eliminara todos los valores string que valgan "paula"
            //8, 7
            //listaEnteros.Clear();
            //Borra todos los elementos de la lista
            //

            listaEnteros.Reverse();
            //ordenada los valores de mayor a menor
            //8, 7, 4, 1
            listaEnteros.Sort();
            //ordena los valores de menor a mayor
            //1, 4, 5, 8

            */


        }
    }
}

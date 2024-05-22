
using System.Reflection.Metadata.Ecma335;

/// Integrantes: Sandy Hurtado - 1280624.
/// Se declaran variables
int valor = 5;
int tipodeleche = 0;
int opcion2 = 0;
int opcion3 = 0;
int opcion4 = 0;
int opcion5 = 0;
double agua = 0;
double deslactosada = 0;
double entera = 0;
double soya = 0;
double blanca = 0;
double morena = 0;
double suplemento = 0;
double precioazucar =0;
double unacucharada = 0;
double doscucharadas = 0;
double trescucharadas = 0;
double precioleche = 0;
bool agrandar;
double precioagrandado = 0;
double preciototal = 0;
bool confirmacion;
bool salir;
do
{    
    DateTime fechaEntrada = DateTime.Now;
    Console.WriteLine(fechaEntrada);
        ///Título
    Console.WriteLine("Máquina dispensadora de Licuados");

    /// Información del cliente
    Console.WriteLine("¿Cuál es su nombre?");
    String name = Console.ReadLine();
    Console.WriteLine("¿Desea ingresar NIT?");    
    double nit = double.Parse(Console.ReadLine());
    Console.WriteLine("Licuado de fresa:");


    /// Tipo de leche
     Console.WriteLine("Seleccione el tipo de leche:");
     Console.WriteLine("1. Sin leche -Q2.00");
     Console.WriteLine("2. Leche Deslactosada");
     Console.WriteLine("3. Leche Entera");
     Console.WriteLine("4. Leche de soya +Q3.00");     
      
    tipodeleche = int.Parse(Console.ReadLine());

    switch (tipodeleche)
    {
                case 1: Console.WriteLine("Usted a escogido unicamente con agua");
                Console.ReadLine();
               break;   
               case 2: Console.WriteLine("Usted a escogido leche deslactosada");
               Console.ReadLine();
               break;
               case 3: Console.WriteLine("Usted a escogido leche entera");
               Console.ReadLine();
               break;
               case 4: Console.WriteLine("Usted a escogido leche de soya");
               Console.ReadLine();
               break; 
               default:
                Console.WriteLine("Usted ha ingresado un caracter incorrecto");
                break;     
            return;                                 
    }



    ///Tipo de azúcar
    Console.WriteLine("Seleccione el tipo de azúcar que desea agregar");
    Console.WriteLine("1. Azúcar Blanca Q0.50");
    Console.WriteLine("2. Azúcar Morena Q0.40");
    Console.WriteLine("3. Suplemento Q0.60");
    
    opcion2 = int.Parse(Console.ReadLine());

    switch (opcion2)
    {
        case 1: Console.WriteLine("Usted ha escogido Azúcar Blanca");
                 Console.ReadLine();
        break;
        case 2: Console.WriteLine("Usted a escogido Azúcar Morena");
               Console.ReadLine();
        break;
        case 3: Console.WriteLine("Usted a escogido Suplemento");
               Console.ReadLine();
        break;
        default:
                Console.WriteLine("Usted ha ingresado un caracter incorrecto");
                break;     
        return;
    }



    /// Cantidad de azúcar
    Console.WriteLine("Seleccione la cantidad de azúcar");
    Console.WriteLine("1. Uno cucharada");
    Console.WriteLine("2. Dos cucharadas");
    Console.WriteLine("3. tres cucharadas");

    opcion3 = int.Parse(Console.ReadLine());

    switch (opcion3)
    {
        case 1: Console.WriteLine("Usted ha escogido una cucharada");
                 Console.ReadLine();
        break;
        case 2: Console.WriteLine("Usted a escogido dos cucharadas");
               Console.ReadLine();
        break;
        case 3: Console.WriteLine("Usted a escogido tres cucharadas");
               Console.ReadLine();
        break;
        default:
                Console.WriteLine("Usted ha ingresado un caracter incorrecto");
                break;     
        return;        
    }



    /// Agrandamiento del pedido
    Console.WriteLine("¿Desea agrandar el pedido?");
    Console.WriteLine("1: Si");
    Console.WriteLine("2: No");

    opcion4 = int.Parse(Console.ReadLine());

    switch (opcion4)
    {
        case 1: Console.WriteLine("El precio aumentará un %7");
                 Console.ReadLine();        
        break;        
           return;  
    }



    /// confirmar el pedido
    Console.WriteLine("¿Desea confirmar el pedido?");
     Console.WriteLine("Su nombre es:" + name);  
    Console.WriteLine("Su nombre es:" + nit);  
    DateTime fechaEntrada2 = DateTime.Now;
    Console.WriteLine(fechaEntrada2);
    Console.WriteLine("Cucharitas escogidas" + opcion3);
    Console.WriteLine("Tipo de leche" + tipodeleche);







} while (false);
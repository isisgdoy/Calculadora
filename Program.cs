using Calculadora;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;


// minhas classe é Program
// Metodo é o Menu
namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodosCal metodosCal = new MetodosCal();

            metodosCal.Menu();
        }

       

    }
}

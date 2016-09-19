using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronautDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Astronaut.changeThreshold(9);
            List<Astronaut> astrList = new List<Astronaut>();
            Astronaut ast1 =  Astronaut.CreateAstronaut("Shafiq", "Canadian");
            //Console.WriteLine(ast1);
            astrList.Add(ast1);
            Astronaut ast2 = Astronaut.CreateAstronaut("John", "USA");
            astrList.Add(ast2);
            Astronaut ast3 = Astronaut.CreateAstronaut("Chris", "UK");
            astrList.Add(ast3);
            Astronaut ast4 = Astronaut.CreateAstronaut("Shafiq", "Canadian");
            astrList.Add(ast4);
            Astronaut ast5 = Astronaut.CreateAstronaut("John", "USA");
            astrList.Add(ast5);
            Astronaut ast6 = Astronaut.CreateAstronaut("Chris", "UK");
            astrList.Add(ast6);
            
            foreach (Astronaut x in astrList)
            {
                Console.WriteLine(x);
            }
        }
    }
}

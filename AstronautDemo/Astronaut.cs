using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronautDemo
{
   public class Astronaut
    {
       //fields
       private static int ASTRONAUT_COUNT = 0;
       private static int THRESHOLD = 5;
       //properties
       public  string Name { get; private set; }
       public  string Nationality { get; private set; }

       private Astronaut(string name, string nationality)
       {
           Name = name;
           Nationality = nationality;
           ASTRONAUT_COUNT++;
       }

       public override string ToString()
       {
           return string.Format("Name: {0}  {1}  {2}", Name, Nationality, ASTRONAUT_COUNT);
       }

       public static Astronaut CreateAstronaut(string name, string nationality)
       {
           if(ASTRONAUT_COUNT < THRESHOLD)
           {
               return new Astronaut(name, nationality);
               //if put count++ AFT return, gives unreachable code err.
           }
           else
           {
               return null;
           }
       }
       //static method to access static+pvt COUNT field to change it
       public static void changeThreshold(int newThreshold)
       {
           THRESHOLD = newThreshold;
       }
    }
}

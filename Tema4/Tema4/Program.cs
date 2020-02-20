using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema4
{
    class Program
    {
        static void Main(string[] args)
        {
            // pentru Animal

            Animal animalA = new Animal();
            animalA.ceFelDeAnimal = "caine";
            animalA.culoare = "roz";
            animalA.varsta = 1;

            Console.WriteLine();
            Console.WriteLine("Tip animal: " + animalA.ceFelDeAnimal + "\nCuloare: " + animalA.culoare + "\nVarsta: " + animalA.varsta);

            Animal animalB = new Animal("pisica");
            animalB.culoare = "mov";
            animalB.varsta = 7;

            Console.WriteLine();
            Console.WriteLine("Tip animal: " + animalB.ceFelDeAnimal + "\nCuloare: " + animalB.culoare + "\nVarsta: " + animalB.varsta);

            Animal animalC = new Animal("iepure", "albatru", 3);

            Console.WriteLine();
            Console.WriteLine("Tip animal: " + animalC.ceFelDeAnimal + "\nCuloare: " + animalC.culoare + "\nVarsta: " + animalC.varsta);

            //Console.ReadKey();

            // pentru Imobil

            Imobil imobilA = new Imobil();
            imobilA.tipCasa = "studio";
            imobilA.nrEtaje = 1;
            imobilA.pret = 86750;

            Console.WriteLine();
            Console.WriteLine("Tip imobil: " + imobilA.tipCasa + "\nNumar etaje: " + imobilA.nrEtaje + "\nPret: " + imobilA.pret);

            Imobil imobilB = new Imobil("penthouse");
            imobilB.nrEtaje = 3;
            imobilB.pret = 805000;

            Console.WriteLine();
            Console.WriteLine("Tip imobil: " + imobilB.tipCasa + "\nNumar etaje: " + imobilB.nrEtaje + "\nPret: " + imobilB.pret);

            Imobil imobilC = new Imobil("vila", 2, 105000);

            Console.WriteLine();
            Console.WriteLine("Tip imobil: " + imobilC.tipCasa + "\nNumar etaje: " + imobilC.nrEtaje + "\nPret: " + imobilC.pret);

            Console.ReadKey();
        }
    }
}

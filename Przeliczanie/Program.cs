using System;

namespace Przeliczanie
{
    // Factory Pattern
    class Program
    {
        static int sumaKubatury;
        static int sumaPolaPowierzchni;
        static int sumaGestosci;
        
        static void Main(string[] args)
        {
            // Instancja klasy dokonywania wyboru
            MaterialProcessor proc = new MaterialProcessor();
            // Material
            Material material = new Material();
            
            Console.WriteLine("Podaj z ilu elemetnow ma sie składa budowla: ");
            int iloscElementow = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < iloscElementow; i++)
            {
                Console.Write("Wybierz typ materialu: 1. Drewno, 2. Stal, 3. Aluminium, 4. Srebro, 5. Miedz: ");
                
                int wybierz = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Podaj długosc (w metrach): ");
                int dlugosc = Convert.ToInt32(Console.ReadLine()); // Podawanie dlugosci
                
                Console.Write("Podaj szerkosc (w metrach): ");
                int szerokosc = Convert.ToInt32(Console.ReadLine()); // Podawanie szerokosci
                
                Console.Write("Podaj wysokosc (w metrach): ");
                int wysokosc = Convert.ToInt32(Console.ReadLine()); // Podawanie wysokosci

                material.Kubatura = dlugosc * wysokosc * szerokosc;
                material.PolePowierzchniBoczej = wysokosc * szerokosc;
                
                switch (wybierz)
                    {
                        case 1:
                            material.Gestosc = (int)EGestosci.drewno;
                            proc.GetMaterial(ERodzajeMaterialu.drewno, material);
                            break;
                        case 2:
                            material.Gestosc = (int)EGestosci.stal;
                            proc.GetMaterial(ERodzajeMaterialu.stal, material);
                            break;
                        case 3:
                            material.Gestosc = (int)EGestosci.aluminium;
                            proc.GetMaterial(ERodzajeMaterialu.aluminium, material);
                            break;
                        case 4:
                            material.Gestosc = (int)EGestosci.srebro;
                            proc.GetMaterial(ERodzajeMaterialu.srebro, material);
                            break;
                        case 5:
                            material.Gestosc = (int)EGestosci.miedz;
                            proc.GetMaterial(ERodzajeMaterialu.miedz, material);
                            break;
                    }
                sumaKubatury += material.Kubatura;
                sumaPolaPowierzchni += material.PolePowierzchniBoczej;
                sumaGestosci += material.Gestosc;
            }
            Console.WriteLine("Kubatura zlozonej figury: " + sumaKubatury);
            Console.WriteLine("Pole powierzchni bocznej figury: " + sumaPolaPowierzchni);
            Console.WriteLine("Suma Gestosci: " + sumaGestosci);
        }
    }
}
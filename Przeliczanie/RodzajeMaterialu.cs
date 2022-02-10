using System;

namespace Przeliczanie
{
    public class Drewno : IMaterial
    {
        public void GetMaterial(Material material)
        {
            Console.WriteLine("Drewno: " + material.nazwaMaterialu);
        }

        public void GetPolePowierzchniBoczej(Material material)
        {
            Console.WriteLine("Pole powierzchni bocznej: " + material.PolePowierzchniBoczej);
        }

        public void GetKubatura(Material material)
        {
            Console.WriteLine("Kubatura: " + material.Kubatura);
        }

        public void GetGestosc(Material material)
        {
            Console.WriteLine("Gestosc: " + material.Gestosc);
        }
    }

    public class Stal : IMaterial
    {
        public void GetMaterial(Material material)
        {
            Console.WriteLine("Stal: " + material.nazwaMaterialu);
        }
        
        public void GetPolePowierzchniBoczej(Material material)
        {
            Console.WriteLine("Pole powierzchni bocznej: " + material.PolePowierzchniBoczej);
        }
        
        public void GetKubatura(Material material)
        {
            Console.WriteLine("Kubatura: " + material.Kubatura);
        }
        
        public void GetGestosc(Material material)
        {
            Console.WriteLine("Gestosc: " + material.Gestosc);
        }
    }

    public class Aluminium : IMaterial
    {
        public void GetMaterial(Material material)
        {
            Console.WriteLine("Aluminium: " + material.nazwaMaterialu);
        }
        
        public void GetPolePowierzchniBoczej(Material material)
        {
            Console.WriteLine("Pole powierzchni bocznej: " + material.PolePowierzchniBoczej);
        }
        
        public void GetKubatura(Material material)
        {
            Console.WriteLine("Kubatura: " + material.Kubatura);
        }
        
        public void GetGestosc(Material material)
        {
            Console.WriteLine("Gestosc: " + material.Gestosc);
        }
    }

    public class Srebro : IMaterial
    {
        public void GetMaterial(Material material)
        {
            Console.WriteLine("Srebro: " + material.nazwaMaterialu);
        }
        
        public void GetPolePowierzchniBoczej(Material material)
        {
            Console.WriteLine("Pole powierzchni bocznej: " + material.PolePowierzchniBoczej);
        }
        
        public void GetKubatura(Material material)
        {
            Console.WriteLine("Kubatura: " + material.Kubatura);
        }
                
        public void GetGestosc(Material material)
        {
            Console.WriteLine("Gestosc: " + material.Gestosc);
        }
    }

    public class Miedz : IMaterial
    {
        public void GetMaterial(Material material)
        {
            Console.WriteLine("Miedz" + material.nazwaMaterialu);
        }
        
        public void GetPolePowierzchniBoczej(Material material)
        {
            Console.WriteLine("Pole powierzchni bocznej: " + material.PolePowierzchniBoczej);
        }
        
        public void GetKubatura(Material material)
        {
            Console.WriteLine("Kubatura: " + material.Kubatura);
        }
        
        public void GetGestosc(Material material)
        {
            Console.WriteLine("Gestosc: " + material.Gestosc);
        }
    }
}
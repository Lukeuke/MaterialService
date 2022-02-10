using System;

namespace Przeliczanie
{
    public class MaterialFactory
    {
        public virtual IMaterial CreateMaterial(ERodzajeMaterialu rodzaj, Material material)
        {
            IMaterial Imaterial = null;
            switch (rodzaj)
            {
                case ERodzajeMaterialu.drewno:
                    Imaterial = new Drewno();
                    break;
                case ERodzajeMaterialu.stal:
                    Imaterial = new Stal();
                    break;
                case ERodzajeMaterialu.aluminium:
                    Imaterial = new Aluminium();
                    break;
                case ERodzajeMaterialu.srebro:
                    Imaterial = new Srebro();
                    break;
                case ERodzajeMaterialu.miedz:
                    Imaterial = new Miedz();
                    break;
            }
            return Imaterial;
        }
    }
}
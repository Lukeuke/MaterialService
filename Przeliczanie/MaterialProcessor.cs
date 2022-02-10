namespace Przeliczanie
{
    public class MaterialProcessor
    {
        private IMaterial imaterial = null;

        public void GetMaterial(ERodzajeMaterialu rodzaj, Material material)
        {
            MaterialFactory factory = new MaterialFactory();

            this.imaterial = factory.CreateMaterial(rodzaj, material);
            this.imaterial.GetMaterial(material);
            this.imaterial.GetKubatura(material);
            this.imaterial.GetPolePowierzchniBoczej(material);
            this.imaterial.GetGestosc(material);
        }
    }
}
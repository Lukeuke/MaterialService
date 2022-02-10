namespace Przeliczanie
{
    public interface IMaterial
    {
        void GetMaterial(Material material);
        void GetPolePowierzchniBoczej(Material material);
        void GetKubatura(Material material);
        void GetGestosc(Material material);
    }
}
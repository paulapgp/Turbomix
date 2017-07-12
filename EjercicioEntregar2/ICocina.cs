namespace EjercicioEntregar2
{
    public interface ICocina
    {
        void Calentar(Alimento mAlimento1, Alimento mAlimento2);
        bool ComprobarAlimentos(Receta r, Alimento mAlimento1, Alimento mAlimento2);
        
    }
}
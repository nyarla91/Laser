namespace Level.Entity
{
    public interface IRecalculated
    {
        void Recalculate();
        float GetRecalculationPriority();
    }
}
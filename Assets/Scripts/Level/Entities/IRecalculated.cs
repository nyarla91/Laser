namespace Level.Entities
{
    public interface IRecalculated
    {
        void Recalculate();
        float GetRecalculationPriority();
    }
}
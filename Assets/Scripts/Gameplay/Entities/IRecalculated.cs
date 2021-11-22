namespace Gameplay.Entities
{
    public interface IRecalculated
    {
        void Recalculate();
        float GetRecalculationPriority();
    }
}
namespace EngineClasses.Interfaces
{
    public interface IValidatable
    {
        bool TotalValidated { get; }
        void ValidateData();
    }
}

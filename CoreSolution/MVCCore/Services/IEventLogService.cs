namespace MVCCore.Services
{
    public interface IEventLogService
    {
        void Log(string message, NiveauAlerte alerte);
    }
}
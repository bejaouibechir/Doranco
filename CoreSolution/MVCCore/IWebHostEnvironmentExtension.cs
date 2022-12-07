namespace MVCCore
{
    static public class IWebHostEnvironmentExtension
    {
        static public bool IsUbuntu(this IWebHostEnvironment env)
        {
            return true;
        }
        static public bool IsCentos(this IWebHostEnvironment env)
        {
            return true;
        }
        static public bool IsRedHat(this IWebHostEnvironment env)
        {
            return true;
        }
    }

    
}

namespace MVCCore.Extensions
{
    static public class IWebHostEnvironmentExtension
    {
#pragma warning disable CS8600     
        static public bool IsUbuntu(this IWebHostEnvironment env)
        {
            string value = Environment.GetEnvironmentVariable("LINUX");
            return value == "Ubuntu";
        }
        static public bool IsCentOS(this IWebHostEnvironment env)
        {
            string value = Environment.GetEnvironmentVariable("LINUX");
            return value == "CentOS";
        }
        static public bool IsOpenSuse(this IWebHostEnvironment env)
        {
            string value = Environment.GetEnvironmentVariable("LINUX");
            return value == "OpenSuse";
        }

    }


}

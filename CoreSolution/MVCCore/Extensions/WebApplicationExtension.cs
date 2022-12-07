using System.Diagnostics;

namespace MVCCore.Extensions
{
    static public class WebApplicationExtension
    {
        static public void UseXXX(this WebApplication app)
        {
            Debug.WriteLine(app.Environment.ApplicationName);
        }
    }
}

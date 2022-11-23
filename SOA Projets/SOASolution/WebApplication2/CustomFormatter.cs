using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http.Formatting;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Web;

public class CustomOutputFormatter : MediaTypeFormatter
{

    public CustomOutputFormatter()
    {
        
    }
    public override bool CanReadType(Type type)
    {
        return true;
    }

    public override bool CanWriteType(Type type)
    {
        return true;
    }

    public override async Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
    {
        await base.WriteToStreamAsync(type, value, writeStream, content, transportContext);
        var properties = type.GetType().GetProperties();
        string output = string.Empty;
        foreach (var item in properties)
        {
            output = output + item.GetValue(value);
        }
        HttpContext.Current.Response.Write(output);
    }

    public override Task<object> ReadFromStreamAsync(Type type, Stream readStream, HttpContent content, IFormatterLogger formatterLogger)
    {
        return base.ReadFromStreamAsync(type, readStream, content, formatterLogger);
    }

}
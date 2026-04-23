 using System.Net;
 using System.Text;
 
namespace Teonino.Assertr.Transport
{
    #if UNITY_EDITOR || DEVELOPMENT_BUILD

    public class RequestHandler
    {
        public static void Handle(HttpListenerContext context)
        {
            string json = "{ \"status\": \"ok\", \"message\": \"Assertr is running\" }";
            context.Response.ContentType = "application/json";

            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(json); 
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.OutputStream.Close();
        }
    }
    #endif
}
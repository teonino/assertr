 
 
namespace Teonino.Assertr.Transport
{
    #if UNITY_EDITOR || DEVELOPMENT_BUILD

    public class RequestHandler
    {
        public static void Handle(HttpListenerContext context)
        {
            string json = "{ \"status\": \"ok\", \"message\": \"Assertr is running\" }";
            context.Response.ContentType = "application/json";
        }
    }
    #endif
}
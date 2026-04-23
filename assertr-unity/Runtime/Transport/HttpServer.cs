using System.Net;
using UnityEngine;
using System.Threading;

namespace Teonino.Assertr.Transport
{
    #if UNITY_EDITOR || DEVELOPMENT_BUILD

    public class HttpServer
    {
        private HttpListener _listener;
        private int _port;
        private Thread _thread;

        public HttpServer(int port)
        {
            _port = port;
            _listener = new HttpListener();
            _listener.Prefixes.Add($"http://localhost:{port}/");
        }

        public void Start()
        {
            _listener.Start();
            _thread = new Thread(Listen);
            _thread.IsBackground = true;
            _thread.Start();


            Debug.Log($"Assertr HTTP server started on port {_port}");
        }

        public void Stop()
        {
            _listener.Stop();
            Debug.Log("Assertr HTTP Server stopped");
        }

        private void Listen()
        {
            while (_listener.IsListening)
                {
                    try
                    {
                        var context = _listener.GetContext();
                        RequestHandler.Handle(context)
                    }
                    catch (HttpListenerException)
                    {
                        break;
                    }
                }
        }
    }

    #endif
}
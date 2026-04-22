using System.Net;
using UnityEngine;

namespace Teonino.Assertr.Transport
{
    #if UNITY_EDITOR || DEVELOPMENT_BUILD

    public class HttpServer
    {
        private HttpListener _listener;
        private int _port;

        public HttpServer(int port)
        {
            _port = port;
            _listener = new HttpListener();
            _listener.Prefixes.Add($"http://localhost:{port}/");
        }

        public void Start()
        {
            _listener.Start();
            Debug.Log($"Assertr HTTP server started on port {_port}");
        }

        public void Stop()
        {
            _listener.Stop();
            Debug.Log("Assertr HTTP Server stopped");
        }
    }

    #endif
}
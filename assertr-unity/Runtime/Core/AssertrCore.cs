using UnityEngine;
using Teonino.Assertr.Transport;


namespace Teonino.Assertr
{
    #if UNITY_EDITOR || DEVELOPMENT_BUILD
    
    public class AssertrCore : MonoBehaviour
    {
        [SerializeField] private int port = 7777;

        private HttpServer _server;

        private void Awake()
        {
            _server = new HttpServer(port);
            _server.Start();
        }

        private void OnDestroy()
        {
            _server.Stop();
        }
    }
    
    #endif
}
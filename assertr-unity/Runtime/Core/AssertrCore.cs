using UnityEngine;

namespace Teonino.Assertr
{
    #if UNITY_EDITOR || DEVELOPMENT_BUILD
    
    public class AssertrCore : MonoBehaviour
    {
        [SerializeField] private int port = 7777;

        private void Awake()
        {
            Debug.Log($"Assertr started on port {port}");
        }
    }
    
    #endif
}
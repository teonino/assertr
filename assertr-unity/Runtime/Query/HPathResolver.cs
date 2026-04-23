using UnityEngine;

namespace Teonino.Assertr.Query
{
    public static class HPathResolver
    {
        public static GameObject Resolve(string path)
        {
            string[] segments = path.Split('/');

            GameObject current = GameObject.Find(segments[0]);

            if(current == null) return null;

            
            for (int i = 1; i < segments.Length; i++)
            {
                Transform child = current.transform.Find(segments[i]);
                if (child == null) return null;
                current = child.gameObject;
            }

            return current;
        }
    }
}
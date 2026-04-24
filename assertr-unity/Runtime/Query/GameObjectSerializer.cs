using UnityEngine;

namespace Teonino.Assertr.Query
{
    public static class GameObjectSerializer
    {
        public static string Serialise(GameObject go)
        {
            string serializedGameObject = $"{{ \"name\": \"{go.name}\", \"active\": {go.activeSelf.ToString().ToLower()}, \"tag\": \"{go.tag}\"}}";
            return serializedGameObject;
        }
    }
}
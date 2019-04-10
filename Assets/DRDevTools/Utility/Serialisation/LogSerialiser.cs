using UnityEngine;

namespace DRDevTools.Utility.Serialisation
{
    [CreateAssetMenu(menuName = "Utility/Serialisation/Log Serialiser")]
    public class LogSerialiser : Serialiser
    {
        private string last = string.Empty;

        public override T Deserialise<T>(object key, T target)
        {
            JsonUtility.FromJsonOverwrite(last, target);
            return target;
        }

        public override void Serialise(object key, object data)
        {
            var json = JsonUtility.ToJson(data);
            last = json;
        }
    }
}
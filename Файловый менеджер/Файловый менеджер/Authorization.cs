using System;
using System.Runtime.Serialization;

namespace Файловый_менеджер
{
    [Serializable]
    internal class Authorization
    {
        public Authorization() { }

        public string userName;
        public string password; 

        [OnSerializing]
        internal void OnSerializing(StreamingContext context)
        {
            password = Crypt.Encrypt(password);
        }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            password = Crypt.Decrypt(password);
        }
    }
}

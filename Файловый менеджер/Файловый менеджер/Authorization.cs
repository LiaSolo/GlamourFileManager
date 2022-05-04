using System;
using System.Runtime.Serialization;

namespace Файловый_менеджер
{
    [Serializable]
    internal class Authorization
    {
        public Authorization() { }

        //имя пользователя и пароль по умолчанию
        public string userName = "Admin";
        public string password = "Password";

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

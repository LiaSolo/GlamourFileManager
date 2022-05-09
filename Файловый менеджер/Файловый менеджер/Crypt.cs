using System;
using System.Text;
using System.Security.Cryptography;

namespace Файловый_менеджер
{
    internal class Crypt
    {
        static string closeKey = "<RSAKeyValue><Modulus>1/r62aEIsxbsRVukqFmfoOc+cD6QVbKC2QxpwMX/YvTsQagPmrzbwcqdCWHae4dh7qRfrFgzvfsXPELH8PnALdAgj1FiDm7oIl3ssIkW6S/a4sph5I/W4DP6mQdow2CjSo94hasKvQo7tqQZr8/SJLFz6d4I4JR9D/6gc5GxHaE=</Modulus><Exponent>AQAB</Exponent><P>3Ob+K3+jWErPrd7SFdr+/T++WWPs4r3Llo0nHAQCjUVOQHKiJ8mhiXXRnTVwzronLDOxcWtcYwWvDRKF/6FYdw==</P><Q>+kvKwy1asHicGrNqPOkhH7WDv0ONbFc6Svt/ulkgim2mMk2Ly1WmQ/wmjvzlCdPC9C9ORrxQFimR1DWruJTYpw==</Q><DP>Hfw9BCqPQazmA/P7EHxpoHbGn9uwjBa3S/hdFrB0qDiAJr9ow33bL42Opohah7U9HALoUzz/jXF4EY4yIkEEgQ==</DP><DQ>IDQAMnxzXqEl9ImA8bVM/bds6/7VA0t1xI/3LxKojSbuaypvAgpTCgw3Kc5/6XPFcYVknNU9uJxAlv0Qyv7boQ==</DQ><InverseQ>R9FTJdegFux59fJZl+vTvXdapNrmDR6OnrKbXenAwI5wSkxdYrMtz6b2NM8xV+upjanQqNws4kaOYrlKdPXLBg==</InverseQ><D>XuOEfELUqKIEkgBOWixuBmoyM2w5S31PIX7jo28Z4ecLOVlV6bzZq82RqsKUE7uKGiebZQOnT+tV7QLGBygi9u65wHQzao4FyTXa9L29J1wnCK+s3+utf3bDWw2TNwt0k9CwaNGEIBDh7c2OFiedkUGUtdqIk7T/PWR+FwguimU=</D></RSAKeyValue>";
        public static string Encrypt(string pasw)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(closeKey);
            byte[] encryptArray = rsa.Encrypt(Encoding.UTF8.GetBytes(pasw), true);
            return Convert.ToBase64String(encryptArray);
        }
        public static string Decrypt(string pasw)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //string closeKey = rsa.ToXmlString(true);
            rsa.FromXmlString(closeKey);
            byte[] decryptArray = rsa.Decrypt(Convert.FromBase64String(pasw), true);
            return Encoding.UTF8.GetString(decryptArray);
        }
    }
}

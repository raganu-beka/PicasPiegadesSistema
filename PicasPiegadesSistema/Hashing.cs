using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Reflection.Metadata.Ecma335;
using System.DirectoryServices;

namespace PicasPiegadesSistema
{
    class Hashing
    {
        public static string GeneratePasswordHash(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] hashedBytes = HashAlgorithm.Create("SHA1").ComputeHash(bytes);

            return Convert.ToBase64String(hashedBytes);
        }

        public static bool CheckPasswordHash(string password, string hash)
        {
            string passwordHash = GeneratePasswordHash(password);
            return passwordHash.Equals(hash);
        }
    }
}

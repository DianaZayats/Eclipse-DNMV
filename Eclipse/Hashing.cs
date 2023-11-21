using System.Security.Cryptography;
using System.Text;

namespace Eclipse
{
    internal class Hashing
    {
        static string HashData(string data)
        {
            byte[] bData = Convert.FromBase64String(data);
            using (var sha256 = SHA256.Create())
            {
                return Convert.ToBase64String(sha256.ComputeHash(bData));
            }
        }
    }
}

using System.Security.Cryptography;

namespace Eclipse
{
    internal class PasswordHashing
    {
        public string salt { get; set; }

        private readonly int iterarions = 10000;
        private readonly int hashLenght = 64;
        public void GenerateSalt()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[32];
                randomNumberGenerator.GetBytes(randomNumber);
                salt = Convert.ToBase64String(randomNumber);
            }

        }

        public string HashPassword(string toBeHashed)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(toBeHashed, Convert.FromBase64String(salt), iterarions, HashAlgorithmName.SHA512))
            {
                return Convert.ToBase64String(rfc2898.GetBytes(hashLenght));
            }
        }
    }
}
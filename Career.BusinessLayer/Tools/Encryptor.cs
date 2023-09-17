using System.Security.Cryptography;
using System.Text;

namespace Career.BusinessLayer.Tools
{
    public static class Encryptor
    {
        private const int KeySize = 64;
        private const int Iterations = 100;


        [Obsolete("Obsolete")]
        public static string Md5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(Encoding.ASCII.GetBytes(text));

            var result = md5.Hash;

            var strBuilder = new StringBuilder();
            foreach (var t in result!)
            {
                strBuilder.Append(t.ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public static string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);
            var offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                var @char = (char)random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        

        [Obsolete("Obsolete")]
        public static string HashPassword(string password)
        {
            var salt = new byte[24];
            new RNGCryptoServiceProvider().GetBytes(salt);
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations);
            var hash = pbkdf2.GetBytes(24);
            return Convert.ToBase64String(salt) + "|" + Iterations + "|" +
                   Convert.ToBase64String(hash);
        }

        [Obsolete("Obsolete")]
        public static bool IsValid(string testPassword, string origDelimHash)
        {
            var origHashedParts = origDelimHash.Split('|');
            var origSalt = Convert.FromBase64String(origHashedParts[0]);
            var origIterations = int.Parse(origHashedParts[1]);
            var origHash = origHashedParts[2];
            
            var pbkdf2 = new Rfc2898DeriveBytes(testPassword, origSalt, origIterations);
            var testHash = pbkdf2.GetBytes(24);
            
            return Convert.ToBase64String(testHash) == origHash;
        }
    }
}

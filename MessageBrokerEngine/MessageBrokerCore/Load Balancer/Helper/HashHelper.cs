using System.Security.Cryptography;
using System.Text;

namespace MessageBrokerEngine.MessageBrokerCore.LoadBalancer.Helper
{
    public static class HashHelper
    {
        public static int GenerateHashValue(string value)
        {
            try
            {
                using (SHA512 sha512 = SHA512.Create())
                {
                    byte[] hash = Encoding.ASCII.GetBytes(value);
                    byte[] result = sha512.ComputeHash(hash);

                    int hashValue = BitConverter.ToInt32(result, 0);
                    return hashValue;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while Hashing the IP ", ex);
            }

        }
    }
}

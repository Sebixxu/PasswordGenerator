using System;
using System.Linq;

namespace PasswordGenerator
{
    public static class RandomStringGenerator
    {
        private static readonly Random Random = new Random();
        
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private const string Numbers = "0123456789";

        public static string RandomString(int length)
        {
            return new string(Enumerable.Repeat(Chars, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }

        public static string RandomNumberString(int length)
        {
            return new string(Enumerable.Repeat(Numbers, length)
                .Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
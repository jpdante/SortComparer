using System;
using System.Security.Cryptography;

namespace SortComparer.Utils {
    public class RandomGenerator {
        private readonly RNGCryptoServiceProvider csp;

        public RandomGenerator() {
            csp = new RNGCryptoServiceProvider();
        }

        public int Next(int minValue, int maxExclusiveValue) {
            if (minValue >= maxExclusiveValue) throw new ArgumentOutOfRangeException("minValue must be lower than maxExclusiveValue");

            var diff = (long)maxExclusiveValue - minValue;
            var upperBound = uint.MaxValue / diff * diff;

            uint ui;
            do {
                ui = GetRandomUInt();
            } while (ui >= upperBound);
            return (int)(minValue + (ui % diff));
        }

        private uint GetRandomUInt() {
            var randomBytes = GenerateRandomBytes(sizeof(uint));
            return BitConverter.ToUInt32(randomBytes, 0);
        }

        private byte[] GenerateRandomBytes(int bytesNumber) {
            byte[] buffer = new byte[bytesNumber];
            csp.GetBytes(buffer);
            return buffer;
        }
    }
}
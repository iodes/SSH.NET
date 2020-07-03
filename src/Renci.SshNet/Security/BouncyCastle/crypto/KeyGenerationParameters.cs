using System;
using Renci.SshNet.Security.Org.BouncyCastle.Security;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto
{
    /**
     * The base class for parameters to key generators.
     */
    internal class KeyGenerationParameters
    {
        private SecureRandom random;
        private int strength;

        /**
         * initialise the generator with a source of randomness
         * and a strength (in bits).
         *
         * @param random the random byte source.
         * @param strength the size, in bits, of the keys we want to produce.
         */
        public KeyGenerationParameters(
            SecureRandom random,
            int strength)
        {
            if (random == null)
                throw new ArgumentNullException("random");

            if (strength < 1)
                throw new ArgumentException("strength must be a positive value", "strength");

            this.random = random;
            this.strength = strength;
        }

        /**
         * return the random source associated with this
         * generator.
         *
         * @return the generators random source.
         */
        public SecureRandom Random => random;

        /**
         * return the bit strength for keys produced by this generator,
         *
         * @return the strength of the keys this generator produces (in bits).
         */
        public int Strength => strength;
    }
}

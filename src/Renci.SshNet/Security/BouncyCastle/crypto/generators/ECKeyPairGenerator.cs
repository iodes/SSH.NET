using System;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto.Parameters;
using Renci.SshNet.Security.Org.BouncyCastle.Math;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC.Multiplier;
using Renci.SshNet.Security.Org.BouncyCastle.Security;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto.Generators
{
    internal class ECKeyPairGenerator
        : IAsymmetricCipherKeyPairGenerator
    {
        private readonly string algorithm;

        private ECDomainParameters parameters;
        private SecureRandom random;

        public ECKeyPairGenerator()
            : this("EC")
        {
        }

        public ECKeyPairGenerator(
            string algorithm)
        {
            if (algorithm == null)
                throw new ArgumentNullException("algorithm");

            this.algorithm = ECKeyParameters.VerifyAlgorithmName(algorithm);
        }

        public void Init(
            KeyGenerationParameters parameters)
        {
            if (parameters is ECKeyGenerationParameters)
            {
                var ecP = (ECKeyGenerationParameters)parameters;

                this.parameters = ecP.DomainParameters;
            }

            random = parameters.Random;

            if (random == null)
            {
                random = new SecureRandom();
            }
        }

        public AsymmetricCipherKeyPair GenerateKeyPair()
        {
            var n = parameters.N;
            BigInteger d;
            var minWeight = n.BitLength >> 2;

            for (;;)
            {
                d = new BigInteger(n.BitLength, random);

                if (d.CompareTo(BigInteger.Two) < 0 || d.CompareTo(n) >= 0)
                    continue;

                if (WNafUtilities.GetNafWeight(d) < minWeight)
                    continue;

                break;
            }

            var q = CreateBasePointMultiplier().Multiply(parameters.G, d);

            return new AsymmetricCipherKeyPair(
                new ECPublicKeyParameters(algorithm, q, parameters),
                new ECPrivateKeyParameters(algorithm, d, parameters));
        }

        protected virtual ECMultiplier CreateBasePointMultiplier()
        {
            return new FixedPointCombMultiplier();
        }

        internal static ECPublicKeyParameters GetCorrespondingPublicKey(
            ECPrivateKeyParameters privKey)
        {
            var ec = privKey.Parameters;
            var q = new FixedPointCombMultiplier().Multiply(ec.G, privKey.D);

            return new ECPublicKeyParameters(privKey.AlgorithmName, q, ec);
        }
    }
}

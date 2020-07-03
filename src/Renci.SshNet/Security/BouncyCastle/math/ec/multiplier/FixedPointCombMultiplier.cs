using System;
using Renci.SshNet.Security.Org.BouncyCastle.Math.Raw;

namespace Renci.SshNet.Security.Org.BouncyCastle.Math.EC.Multiplier
{
    internal class FixedPointCombMultiplier
        : AbstractECMultiplier
    {
        protected override ECPoint MultiplyPositive(ECPoint p, BigInteger k)
        {
            var c = p.Curve;
            var size = FixedPointUtilities.GetCombSize(c);

            if (k.BitLength > size)
            {
                /*
                 * TODO The comb works best when the scalars are less than the (possibly unknown) order.
                 * Still, if we want to handle larger scalars, we could allow customization of the comb
                 * size, or alternatively we could deal with the 'extra' bits either by running the comb
                 * multiple times as necessary, or by using an alternative multiplier as prelude.
                 */
                throw new InvalidOperationException("fixed-point comb doesn't support scalars larger than the curve order");
            }

            var info = FixedPointUtilities.Precompute(p);
            var lookupTable = info.LookupTable;
            var width = info.Width;

            var d = (size + width - 1) / width;

            var R = c.Infinity;

            var fullComb = d * width;
            uint[] K = Nat.FromBigInteger(fullComb, k);

            var top = fullComb - 1;

            for (var i = 0; i < d; ++i)
            {
                uint secretIndex = 0;

                for (var j = top - i; j >= 0; j -= d)
                {
                    var secretBit = K[j >> 5] >> (j & 0x1F);
                    secretIndex ^= secretBit >> 1;
                    secretIndex <<= 1;
                    secretIndex ^= secretBit;
                }

                var add = lookupTable.Lookup((int)secretIndex);

                R = R.TwicePlus(add);
            }

            return R.Add(info.Offset);
        }
    }
}

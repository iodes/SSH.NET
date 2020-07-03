using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renci.SshNet.Common;
using Renci.SshNet.Security;
using Renci.SshNet.Tests.Common;

namespace Renci.SshNet.Tests.Classes.Security.Cryptography
{
    /// <summary>
    ///This is a test class for DsaKeyTest and is intended
    ///to contain all DsaKeyTest Unit Tests
    ///</summary>
    [TestClass]
    public class DsaKeyTest : TestBase
    {
        /// <summary>
        ///A test for DsaKey Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void DsaKeyConstructorTest()
        {
            var target = new DsaKey();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DsaKey Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void DsaKeyConstructorTest1()
        {
            byte[] data = null; // TODO: Initialize to an appropriate value
            var target = new DsaKey(data);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DsaKey Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void DsaKeyConstructorTest2()
        {
            var p = new BigInteger(); // TODO: Initialize to an appropriate value
            var q = new BigInteger(); // TODO: Initialize to an appropriate value
            var g = new BigInteger(); // TODO: Initialize to an appropriate value
            var y = new BigInteger(); // TODO: Initialize to an appropriate value
            var x = new BigInteger(); // TODO: Initialize to an appropriate value
            var target = new DsaKey(p, q, g, y, x);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void DisposeTest()
        {
            var target = new DsaKey(); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for G
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void GTest()
        {
            var target = new DsaKey(); // TODO: Initialize to an appropriate value
            BigInteger actual;
            actual = target.G;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for KeyLength
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void KeyLengthTest()
        {
            var target = new DsaKey(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.KeyLength;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for P
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PTest()
        {
            var target = new DsaKey(); // TODO: Initialize to an appropriate value
            BigInteger actual;
            actual = target.P;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Public
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PublicTest()
        {
            var target = new DsaKey(); // TODO: Initialize to an appropriate value
            BigInteger[] expected = null; // TODO: Initialize to an appropriate value
            BigInteger[] actual;
            target.Public = expected;
            actual = target.Public;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Q
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void QTest()
        {
            var target = new DsaKey(); // TODO: Initialize to an appropriate value
            BigInteger actual;
            actual = target.Q;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for X
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void XTest()
        {
            var target = new DsaKey(); // TODO: Initialize to an appropriate value
            BigInteger actual;
            actual = target.X;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Y
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void YTest()
        {
            var target = new DsaKey(); // TODO: Initialize to an appropriate value
            BigInteger actual;
            actual = target.Y;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renci.SshNet.Security.Cryptography.Ciphers.Modes;
using Renci.SshNet.Tests.Common;

namespace Renci.SshNet.Tests.Classes.Security.Cryptography.Ciphers.Modes
{
    /// <summary>
    ///This is a test class for OfbCipherModeTest and is intended
    ///to contain all OfbCipherModeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OfbCipherModeTest : TestBase
    {
        /// <summary>
        ///A test for EncryptBlock
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void EncryptBlockTest()
        {
            byte[] iv = null; // TODO: Initialize to an appropriate value
            var target = new OfbCipherMode(iv); // TODO: Initialize to an appropriate value
            byte[] inputBuffer = null; // TODO: Initialize to an appropriate value
            var inputOffset = 0; // TODO: Initialize to an appropriate value
            var inputCount = 0; // TODO: Initialize to an appropriate value
            byte[] outputBuffer = null; // TODO: Initialize to an appropriate value
            var outputOffset = 0; // TODO: Initialize to an appropriate value
            var expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.EncryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DecryptBlock
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void DecryptBlockTest()
        {
            byte[] iv = null; // TODO: Initialize to an appropriate value
            var target = new OfbCipherMode(iv); // TODO: Initialize to an appropriate value
            byte[] inputBuffer = null; // TODO: Initialize to an appropriate value
            var inputOffset = 0; // TODO: Initialize to an appropriate value
            var inputCount = 0; // TODO: Initialize to an appropriate value
            byte[] outputBuffer = null; // TODO: Initialize to an appropriate value
            var outputOffset = 0; // TODO: Initialize to an appropriate value
            var expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.DecryptBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for OfbCipherMode Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void OfbCipherModeConstructorTest()
        {
            byte[] iv = null; // TODO: Initialize to an appropriate value
            var target = new OfbCipherMode(iv);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}

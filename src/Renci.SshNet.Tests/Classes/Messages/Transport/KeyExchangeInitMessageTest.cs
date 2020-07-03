﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renci.SshNet.Messages.Transport;
using Renci.SshNet.Tests.Common;
using System.Linq;

namespace Renci.SshNet.Tests.Classes.Messages.Transport
{
    /// <summary>
    /// Represents SSH_MSG_KEXINIT message.
    /// </summary>
    [TestClass]
    public class KeyExchangeInitMessageTest : TestBase
    {
        [TestMethod]
        [TestCategory("KeyExchangeInitMessage")]
        [Owner("olegkap")]
        [Description("Validates KeyExchangeInitMessage message deserialization.")]
        public void Test_KeyExchangeInitMessage_Load()
        {
            var m = new KeyExchangeInitMessage();

            var input = new byte[]
            {
                0xc9, 0x58, 0x3f, 0x44, 0x54, 0xb4, 0x58, 0x48, 0x5f, 0xf8, 0x7d, 0xb8, 0x2d, 0x54, 0x11, 0xbf, 0x00, 0x00, 0x00, 0xb7, 0x65, 0x63, 0x64, 0x68, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x6e, 0x69, 0x73, 0x74, 0x70, 0x32, 0x35, 0x36, 0x2c, 0x65, 0x63, 0x64, 0x68, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x6e, 0x69, 0x73, 0x74, 0x70, 0x33, 0x38, 0x34, 0x2c, 0x65, 0x63, 0x64, 0x68, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x6e, 0x69, 0x73, 0x74, 0x70, 0x35, 0x32, 0x31, 0x2c, 0x64, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2d, 0x68, 0x65, 0x6c, 0x6c, 0x6d, 0x61, 0x6e, 0x2d, 0x67, 0x72, 0x6f, 0x75, 0x70, 0x2d, 0x65, 0x78, 0x63, 0x68, 0x61, 0x6e, 0x67, 0x65, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x35, 0x36, 0x2c, 0x64, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2d, 0x68, 0x65, 0x6c, 0x6c, 0x6d, 0x61, 0x6e, 0x2d, 0x67, 0x72, 0x6f, 0x75, 0x70, 0x2d, 0x65, 0x78, 0x63, 0x68, 0x61, 0x6e, 0x67, 0x65, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x2c, 0x64, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2d, 0x68, 0x65, 0x6c, 0x6c, 0x6d, 0x61, 0x6e, 0x2d, 0x67, 0x72, 0x6f, 0x75, 0x70, 0x31, 0x34, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x2c, 0x64, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2d, 0x68, 0x65, 0x6c, 0x6c, 0x6d, 0x61, 0x6e, 0x2d, 0x67, 0x72, 0x6f, 0x75, 0x70, 0x31, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x00, 0x00, 0x00, 0x23, 0x73, 0x73, 0x68, 0x2d, 0x72, 0x73, 0x61, 0x2c, 0x73, 0x73, 0x68, 0x2d, 0x64, 0x73, 0x73, 0x2c, 0x65, 0x63, 0x64, 0x73, 0x61, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x6e, 0x69, 0x73, 0x74, 0x70, 0x32, 0x35, 0x36, 0x00, 0x00, 0x00, 0x9d, 0x61, 0x65, 0x73, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x39, 0x32, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x61, 0x65, 0x73, 0x32, 0x35, 0x36, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x61, 0x72, 0x63, 0x66, 0x6f, 0x75, 0x72, 0x32, 0x35, 0x36, 0x2c, 0x61, 0x72, 0x63, 0x66, 0x6f, 0x75, 0x72, 0x31, 0x32, 0x38, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x33, 0x64, 0x65, 0x73, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x62, 0x6c, 0x6f, 0x77, 0x66, 0x69, 0x73, 0x68, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x63, 0x61, 0x73, 0x74, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x39, 0x32, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x32, 0x35, 0x36, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x72, 0x63, 0x66, 0x6f, 0x75, 0x72, 0x2c, 0x72, 0x69, 0x6a, 0x6e, 0x64, 0x61, 0x65, 0x6c, 0x2d, 0x63, 0x62, 0x63, 0x40, 0x6c, 0x79, 0x73, 0x61, 0x74, 0x6f, 0x72, 0x2e, 0x6c, 0x69, 0x75, 0x2e, 0x73, 0x65, 0x00, 0x00, 0x00, 0x9d, 0x61, 0x65, 0x73, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x39, 0x32, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x61, 0x65, 0x73, 0x32, 0x35, 0x36, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x61, 0x72, 0x63, 0x66, 0x6f, 0x75, 0x72, 0x32, 0x35, 0x36, 0x2c, 0x61, 0x72, 0x63, 0x66, 0x6f, 0x75, 0x72, 0x31, 0x32, 0x38, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x33, 0x64, 0x65, 0x73, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x62, 0x6c, 0x6f, 0x77, 0x66, 0x69, 0x73, 0x68, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x63, 0x61, 0x73, 0x74, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x39, 0x32, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x32, 0x35, 0x36, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x72, 0x63, 0x66, 0x6f, 0x75, 0x72, 0x2c, 0x72, 0x69, 0x6a, 0x6e, 0x64, 0x61, 0x65, 0x6c, 0x2d, 0x63, 0x62, 0x63, 0x40, 0x6c, 0x79, 0x73, 0x61, 0x74, 0x6f, 0x72, 0x2e, 0x6c, 0x69, 0x75, 0x2e, 0x73, 0x65, 0x00, 0x00, 0x00, 0xa7, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x6d, 0x64, 0x35, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x2c, 0x75, 0x6d, 0x61, 0x63, 0x2d, 0x36, 0x34, 0x40, 0x6f, 0x70, 0x65, 0x6e, 0x73, 0x73, 0x68, 0x2e, 0x63, 0x6f, 0x6d, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x32, 0x35, 0x36, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x32, 0x35, 0x36, 0x2d, 0x39, 0x36, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x35, 0x31, 0x32, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x35, 0x31, 0x32, 0x2d, 0x39, 0x36, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x72, 0x69, 0x70, 0x65, 0x6d, 0x64, 0x31, 0x36, 0x30, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x72, 0x69, 0x70, 0x65, 0x6d, 0x64, 0x31, 0x36, 0x30, 0x40, 0x6f, 0x70, 0x65, 0x6e, 0x73, 0x73, 0x68, 0x2e, 0x63, 0x6f, 0x6d, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x2d, 0x39, 0x36, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x6d, 0x64, 0x35, 0x2d, 0x39, 0x36, 0x00, 0x00, 0x00, 0xa7, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x6d, 0x64, 0x35, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x2c, 0x75, 0x6d, 0x61, 0x63, 0x2d, 0x36, 0x34, 0x40, 0x6f, 0x70, 0x65, 0x6e, 0x73, 0x73, 0x68, 0x2e, 0x63, 0x6f, 0x6d, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x32, 0x35, 0x36, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x32, 0x35, 0x36, 0x2d, 0x39, 0x36, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x35, 0x31, 0x32, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x2d, 0x35, 0x31, 0x32, 0x2d, 0x39, 0x36, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x72, 0x69, 0x70, 0x65, 0x6d, 0x64, 0x31, 0x36, 0x30, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x72, 0x69, 0x70, 0x65, 0x6d, 0x64, 0x31, 0x36, 0x30, 0x40, 0x6f, 0x70, 0x65, 0x6e, 0x73, 0x73, 0x68, 0x2e, 0x63, 0x6f, 0x6d, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x2d, 0x39, 0x36, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x6d, 0x64, 0x35, 0x2d, 0x39, 0x36, 0x00, 0x00, 0x00, 0x15, 0x6e, 0x6f, 0x6e, 0x65, 0x2c, 0x7a, 0x6c, 0x69, 0x62, 0x40, 0x6f, 0x70, 0x65, 0x6e, 0x73, 0x73, 0x68, 0x2e, 0x63, 0x6f, 0x6d, 0x00, 0x00, 0x00, 0x15, 0x6e, 0x6f, 0x6e, 0x65, 0x2c, 0x7a, 0x6c, 0x69, 0x62, 0x40, 0x6f, 0x70, 0x65, 0x6e, 0x73, 0x73, 0x68, 0x2e, 0x63, 0x6f, 0x6d, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            };

            m.Load(input);

            Assert.IsFalse(m.FirstKexPacketFollows);
            Assert.IsTrue(m.Reserved == 0);

            Assert.IsTrue(m.CompressionAlgorithmsClientToServer.SequenceEqual(new[]
            {
                "none", "zlib@openssh.com"
            }));

            Assert.IsTrue(m.CompressionAlgorithmsServerToClient.SequenceEqual(new[]
            {
                "none", "zlib@openssh.com"
            }));

            Assert.IsTrue(m.EncryptionAlgorithmsClientToServer.SequenceEqual(new[]
            {
                "aes128-ctr", "aes192-ctr", "aes256-ctr", "arcfour256", "arcfour128", "aes128-cbc", "3des-cbc", "blowfish-cbc", "cast128-cbc", "aes192-cbc", "aes256-cbc", "arcfour", "rijndael-cbc@lysator.liu.se"
            }));

            Assert.IsTrue(m.EncryptionAlgorithmsServerToClient.SequenceEqual(new[]
            {
                "aes128-ctr", "aes192-ctr", "aes256-ctr", "arcfour256", "arcfour128", "aes128-cbc", "3des-cbc", "blowfish-cbc", "cast128-cbc", "aes192-cbc", "aes256-cbc", "arcfour", "rijndael-cbc@lysator.liu.se"
            }));

            Assert.IsTrue(m.KeyExchangeAlgorithms.SequenceEqual(new[]
            {
                "ecdh-sha2-nistp256", "ecdh-sha2-nistp384", "ecdh-sha2-nistp521", "diffie-hellman-group-exchange-sha256", "diffie-hellman-group-exchange-sha1", "diffie-hellman-group14-sha1", "diffie-hellman-group1-sha1"
            }));

            Assert.IsTrue(m.LanguagesClientToServer.SequenceEqual(new[]
            {
                ""
            }));

            Assert.IsTrue(m.LanguagesServerToClient.SequenceEqual(new[]
            {
                ""
            }));

            Assert.IsTrue(m.MacAlgorithmsClientToServer.SequenceEqual(new[]
            {
                "hmac-md5", "hmac-sha1", "umac-64@openssh.com", "hmac-sha2-256", "hmac-sha2-256-96", "hmac-sha2-512", "hmac-sha2-512-96", "hmac-ripemd160", "hmac-ripemd160@openssh.com", "hmac-sha1-96", "hmac-md5-96"
            }));

            Assert.IsTrue(m.MacAlgorithmsServerToClient.SequenceEqual(new[]
            {
                "hmac-md5", "hmac-sha1", "umac-64@openssh.com", "hmac-sha2-256", "hmac-sha2-256-96", "hmac-sha2-512", "hmac-sha2-512-96", "hmac-ripemd160", "hmac-ripemd160@openssh.com", "hmac-sha1-96", "hmac-md5-96"
            }));

            Assert.IsTrue(m.ServerHostKeyAlgorithms.SequenceEqual(new[]
            {
                "ssh-rsa", "ssh-dss", "ecdsa-sha2-nistp256"
            }));
        }

        [TestMethod]
        [TestCategory("KeyExchangeInitMessage")]
        [Owner("olegkap")]
        [Description("Validates KeyExchangeInitMessage message serialization.")]
        public void Test_KeyExchangeInitMessage_GetBytes()
        {
            var m = new KeyExchangeInitMessage()
            {
                KeyExchangeAlgorithms = new[]
                {
                    "diffie-hellman-group-exchange-sha256", "diffie-hellman-group-exchange-sha1", "diffie-hellman-group14-sha1", "diffie-hellman-group1-sha1"
                },
                ServerHostKeyAlgorithms = new[]
                {
                    "ssh-rsa", "ssh-dss"
                },
                EncryptionAlgorithmsClientToServer = new[]
                {
                    "aes256-ctr", "3des-cbc", "aes128-cbc", "aes192-cbc", "aes256-cbc", "blowfish-cbc", "cast128-cbc", "aes128-ctr", "aes192-ctr"
                },
                EncryptionAlgorithmsServerToClient = new[]
                {
                    "aes256-ctr", "3des-cbc", "aes128-cbc", "aes192-cbc", "aes256-cbc", "blowfish-cbc", "cast128-cbc", "aes128-ctr", "aes192-ctr"
                },
                MacAlgorithmsClientToServer = new[]
                {
                    "hmac-md5", "hmac-sha1"
                },
                MacAlgorithmsServerToClient = new[]
                {
                    "hmac-md5", "hmac-sha1"
                },
                CompressionAlgorithmsClientToServer = new[]
                {
                    "none"
                },
                CompressionAlgorithmsServerToClient = new[]
                {
                    "none"
                },
                LanguagesClientToServer = new[]
                {
                    string.Empty
                },
                LanguagesServerToClient = new[]
                {
                    string.Empty
                },
                FirstKexPacketFollows = false,
                Reserved = 0
            };

            var input = new byte[]
            {
                0x14, 0xf3, 0x3b, 0xf9, 0x5e, 0x70, 0x18, 0x6a, 0x43, 0x3d, 0x93, 0x9e, 0x1c, 0x50, 0x4a, 0x8a, 0x33, 0x00, 0x00, 0x00, 0x7e, 0x64, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2d, 0x68, 0x65, 0x6c, 0x6c, 0x6d, 0x61, 0x6e, 0x2d, 0x67, 0x72, 0x6f, 0x75, 0x70, 0x2d, 0x65, 0x78, 0x63, 0x68, 0x61, 0x6e, 0x67, 0x65, 0x2d, 0x73, 0x68, 0x61, 0x32, 0x35, 0x36, 0x2c, 0x64, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2d, 0x68, 0x65, 0x6c, 0x6c, 0x6d, 0x61, 0x6e, 0x2d, 0x67, 0x72, 0x6f, 0x75, 0x70, 0x2d, 0x65, 0x78, 0x63, 0x68, 0x61, 0x6e, 0x67, 0x65, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x2c, 0x64, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2d, 0x68, 0x65, 0x6c, 0x6c, 0x6d, 0x61, 0x6e, 0x2d, 0x67, 0x72, 0x6f, 0x75, 0x70, 0x31, 0x34, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x2c, 0x64, 0x69, 0x66, 0x66, 0x69, 0x65, 0x2d, 0x68, 0x65, 0x6c, 0x6c, 0x6d, 0x61, 0x6e, 0x2d, 0x67, 0x72, 0x6f, 0x75, 0x70, 0x31, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x00, 0x00, 0x00, 0x0f, 0x73, 0x73, 0x68, 0x2d, 0x72, 0x73, 0x61, 0x2c, 0x73, 0x73, 0x68, 0x2d, 0x64, 0x73, 0x73, 0x00, 0x00, 0x00, 0x63, 0x61, 0x65, 0x73, 0x32, 0x35, 0x36, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x33, 0x64, 0x65, 0x73, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x39, 0x32, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x32, 0x35, 0x36, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x62, 0x6c, 0x6f, 0x77, 0x66, 0x69, 0x73, 0x68, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x63, 0x61, 0x73, 0x74, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x39, 0x32, 0x2d, 0x63, 0x74, 0x72, 0x00, 0x00, 0x00, 0x63, 0x61, 0x65, 0x73, 0x32, 0x35, 0x36, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x33, 0x64, 0x65, 0x73, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x39, 0x32, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x32, 0x35, 0x36, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x62, 0x6c, 0x6f, 0x77, 0x66, 0x69, 0x73, 0x68, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x63, 0x61, 0x73, 0x74, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x62, 0x63, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x32, 0x38, 0x2d, 0x63, 0x74, 0x72, 0x2c, 0x61, 0x65, 0x73, 0x31, 0x39, 0x32, 0x2d, 0x63, 0x74, 0x72, 0x00, 0x00, 0x00, 0x12, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x6d, 0x64, 0x35, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x00, 0x00, 0x00, 0x12, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x6d, 0x64, 0x35, 0x2c, 0x68, 0x6d, 0x61, 0x63, 0x2d, 0x73, 0x68, 0x61, 0x31, 0x00, 0x00, 0x00, 0x04, 0x6e, 0x6f, 0x6e, 0x65, 0x00, 0x00, 0x00, 0x04, 0x6e, 0x6f, 0x6e, 0x65, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            };

            byte[] output = m.GetBytes();

            //  Skip first 17 bytes since 16 bytes are randomly generated
            Assert.IsTrue(input.Skip(17).SequenceEqual(output.Skip(17)));
        }

        /// <summary>
        ///A test for KeyExchangeInitMessage Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void KeyExchangeInitMessageConstructorTest()
        {
            var target = new KeyExchangeInitMessage();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CompressionAlgorithmsClientToServer
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void CompressionAlgorithmsClientToServerTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.CompressionAlgorithmsClientToServer = expected;
            string[] actual = target.CompressionAlgorithmsClientToServer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CompressionAlgorithmsServerToClient
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void CompressionAlgorithmsServerToClientTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.CompressionAlgorithmsServerToClient = expected;
            string[] actual = target.CompressionAlgorithmsServerToClient;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EncryptionAlgorithmsClientToServer
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void EncryptionAlgorithmsClientToServerTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.EncryptionAlgorithmsClientToServer = expected;
            string[] actual = target.EncryptionAlgorithmsClientToServer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EncryptionAlgorithmsServerToClient
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void EncryptionAlgorithmsServerToClientTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.EncryptionAlgorithmsServerToClient = expected;
            string[] actual = target.EncryptionAlgorithmsServerToClient;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FirstKexPacketFollows
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void FirstKexPacketFollowsTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            var expected = false; // TODO: Initialize to an appropriate value
            target.FirstKexPacketFollows = expected;
            var actual = target.FirstKexPacketFollows;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for KeyExchangeAlgorithms
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void KeyExchangeAlgorithmsTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.KeyExchangeAlgorithms = expected;
            string[] actual = target.KeyExchangeAlgorithms;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LanguagesClientToServer
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void LanguagesClientToServerTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.LanguagesClientToServer = expected;
            string[] actual = target.LanguagesClientToServer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LanguagesServerToClient
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void LanguagesServerToClientTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.LanguagesServerToClient = expected;
            string[] actual = target.LanguagesServerToClient;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MacAlgorithmsClientToServer
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void MacAlgorithmsClientToServerTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.MacAlgorithmsClientToServer = expected;
            string[] actual = target.MacAlgorithmsClientToServer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MacAlgorithmsServerToClient
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void MacAlgorithmsServerToClientTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.MacAlgorithmsServerToClient = expected;
            string[] actual = target.MacAlgorithmsServerToClient;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Reserved
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void ReservedTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            uint expected = 0; // TODO: Initialize to an appropriate value
            target.Reserved = expected;
            var actual = target.Reserved;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ServerHostKeyAlgorithms
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder
        public void ServerHostKeyAlgorithmsTest()
        {
            var target = new KeyExchangeInitMessage(); // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            target.ServerHostKeyAlgorithms = expected;
            string[] actual = target.ServerHostKeyAlgorithms;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

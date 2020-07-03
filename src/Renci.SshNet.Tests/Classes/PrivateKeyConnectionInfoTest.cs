using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renci.SshNet.Tests.Common;
using Renci.SshNet.Tests.Properties;
using System.IO;
using System.Text;

namespace Renci.SshNet.Tests.Classes
{
    /// <summary>
    /// Provides connection information when private key authentication method is used
    /// </summary>
    [TestClass]
    public class PrivateKeyConnectionInfoTest : TestBase
    {
        [TestMethod]
        [TestCategory("PrivateKeyConnectionInfo")]
        [TestCategory("integration")]
        public void Test_PrivateKeyConnectionInfo()
        {
            var host = Resources.HOST;
            var username = Resources.USERNAME;
            var keyFileStream = new MemoryStream(Encoding.ASCII.GetBytes(Resources.RSA_KEY_WITHOUT_PASS));

            #region Example PrivateKeyConnectionInfo PrivateKeyFile
            var connectionInfo = new PrivateKeyConnectionInfo(host, username, new PrivateKeyFile(keyFileStream));

            using (var client = new SshClient(connectionInfo))
            {
                client.Connect();
                client.Disconnect();
            }
            #endregion

            Assert.AreEqual(connectionInfo.Host, Resources.HOST);
            Assert.AreEqual(connectionInfo.Username, Resources.USERNAME);
        }

        [TestMethod]
        [TestCategory("PrivateKeyConnectionInfo")]
        [TestCategory("integration")]
        public void Test_PrivateKeyConnectionInfo_MultiplePrivateKey()
        {
            var host = Resources.HOST;
            var username = Resources.USERNAME;
            var keyFileStream1 = new MemoryStream(Encoding.ASCII.GetBytes(Resources.RSA_KEY_WITHOUT_PASS));
            var keyFileStream2 = new MemoryStream(Encoding.ASCII.GetBytes(Resources.RSA_KEY_WITHOUT_PASS));

            #region Example PrivateKeyConnectionInfo PrivateKeyFile Multiple
            var connectionInfo = new PrivateKeyConnectionInfo(host, username,
                new PrivateKeyFile(keyFileStream1),
                new PrivateKeyFile(keyFileStream2));

            using (var client = new SshClient(connectionInfo))
            {
                client.Connect();
                client.Disconnect();
            }
            #endregion

            Assert.AreEqual(connectionInfo.Host, Resources.HOST);
            Assert.AreEqual(connectionInfo.Username, Resources.USERNAME);
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void DisposeTest()
        {
            var host = string.Empty; // TODO: Initialize to an appropriate value
            var username = string.Empty; // TODO: Initialize to an appropriate value
            PrivateKeyFile[] keyFiles = null; // TODO: Initialize to an appropriate value
            var target = new PrivateKeyConnectionInfo(host, username, keyFiles); // TODO: Initialize to an appropriate value
            target.Dispose();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PrivateKeyConnectionInfo Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PrivateKeyConnectionInfoConstructorTest()
        {
            var host = string.Empty; // TODO: Initialize to an appropriate value
            var port = 0; // TODO: Initialize to an appropriate value
            var username = string.Empty; // TODO: Initialize to an appropriate value
            var proxyType = new ProxyTypes(); // TODO: Initialize to an appropriate value
            var proxyHost = string.Empty; // TODO: Initialize to an appropriate value
            var proxyPort = 0; // TODO: Initialize to an appropriate value
            var proxyUsername = string.Empty; // TODO: Initialize to an appropriate value
            var proxyPassword = string.Empty; // TODO: Initialize to an appropriate value
            PrivateKeyFile[] keyFiles = null; // TODO: Initialize to an appropriate value
            var target = new PrivateKeyConnectionInfo(host, port, username, proxyType, proxyHost, proxyPort, proxyUsername, proxyPassword, keyFiles);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for PrivateKeyConnectionInfo Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PrivateKeyConnectionInfoConstructorTest1()
        {
            var host = string.Empty; // TODO: Initialize to an appropriate value
            var username = string.Empty; // TODO: Initialize to an appropriate value
            var proxyType = new ProxyTypes(); // TODO: Initialize to an appropriate value
            var proxyHost = string.Empty; // TODO: Initialize to an appropriate value
            var proxyPort = 0; // TODO: Initialize to an appropriate value
            var proxyUsername = string.Empty; // TODO: Initialize to an appropriate value
            var proxyPassword = string.Empty; // TODO: Initialize to an appropriate value
            PrivateKeyFile[] keyFiles = null; // TODO: Initialize to an appropriate value
            var target = new PrivateKeyConnectionInfo(host, username, proxyType, proxyHost, proxyPort, proxyUsername, proxyPassword, keyFiles);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for PrivateKeyConnectionInfo Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PrivateKeyConnectionInfoConstructorTest2()
        {
            var host = string.Empty; // TODO: Initialize to an appropriate value
            var username = string.Empty; // TODO: Initialize to an appropriate value
            var proxyType = new ProxyTypes(); // TODO: Initialize to an appropriate value
            var proxyHost = string.Empty; // TODO: Initialize to an appropriate value
            var proxyPort = 0; // TODO: Initialize to an appropriate value
            var proxyUsername = string.Empty; // TODO: Initialize to an appropriate value
            PrivateKeyFile[] keyFiles = null; // TODO: Initialize to an appropriate value
            var target = new PrivateKeyConnectionInfo(host, username, proxyType, proxyHost, proxyPort, proxyUsername, keyFiles);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for PrivateKeyConnectionInfo Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PrivateKeyConnectionInfoConstructorTest3()
        {
            var host = string.Empty; // TODO: Initialize to an appropriate value
            var username = string.Empty; // TODO: Initialize to an appropriate value
            var proxyType = new ProxyTypes(); // TODO: Initialize to an appropriate value
            var proxyHost = string.Empty; // TODO: Initialize to an appropriate value
            var proxyPort = 0; // TODO: Initialize to an appropriate value
            PrivateKeyFile[] keyFiles = null; // TODO: Initialize to an appropriate value
            var target = new PrivateKeyConnectionInfo(host, username, proxyType, proxyHost, proxyPort, keyFiles);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for PrivateKeyConnectionInfo Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PrivateKeyConnectionInfoConstructorTest4()
        {
            var host = string.Empty; // TODO: Initialize to an appropriate value
            var port = 0; // TODO: Initialize to an appropriate value
            var username = string.Empty; // TODO: Initialize to an appropriate value
            var proxyType = new ProxyTypes(); // TODO: Initialize to an appropriate value
            var proxyHost = string.Empty; // TODO: Initialize to an appropriate value
            var proxyPort = 0; // TODO: Initialize to an appropriate value
            var proxyUsername = string.Empty; // TODO: Initialize to an appropriate value
            PrivateKeyFile[] keyFiles = null; // TODO: Initialize to an appropriate value
            var target = new PrivateKeyConnectionInfo(host, port, username, proxyType, proxyHost, proxyPort, proxyUsername, keyFiles);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for PrivateKeyConnectionInfo Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PrivateKeyConnectionInfoConstructorTest5()
        {
            var host = string.Empty; // TODO: Initialize to an appropriate value
            var port = 0; // TODO: Initialize to an appropriate value
            var username = string.Empty; // TODO: Initialize to an appropriate value
            var proxyType = new ProxyTypes(); // TODO: Initialize to an appropriate value
            var proxyHost = string.Empty; // TODO: Initialize to an appropriate value
            var proxyPort = 0; // TODO: Initialize to an appropriate value
            PrivateKeyFile[] keyFiles = null; // TODO: Initialize to an appropriate value
            var target = new PrivateKeyConnectionInfo(host, port, username, proxyType, proxyHost, proxyPort, keyFiles);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for PrivateKeyConnectionInfo Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PrivateKeyConnectionInfoConstructorTest6()
        {
            var host = string.Empty; // TODO: Initialize to an appropriate value
            var port = 0; // TODO: Initialize to an appropriate value
            var username = string.Empty; // TODO: Initialize to an appropriate value
            PrivateKeyFile[] keyFiles = null; // TODO: Initialize to an appropriate value
            var target = new PrivateKeyConnectionInfo(host, port, username, keyFiles);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for PrivateKeyConnectionInfo Constructor
        ///</summary>
        [TestMethod]
        [Ignore] // placeholder for actual test
        public void PrivateKeyConnectionInfoConstructorTest7()
        {
            var host = string.Empty; // TODO: Initialize to an appropriate value
            var username = string.Empty; // TODO: Initialize to an appropriate value
            PrivateKeyFile[] keyFiles = null; // TODO: Initialize to an appropriate value
            var target = new PrivateKeyConnectionInfo(host, username, keyFiles);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}

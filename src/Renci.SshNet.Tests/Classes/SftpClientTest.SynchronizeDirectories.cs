﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renci.SshNet.Tests.Properties;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Renci.SshNet.Tests.Classes
{
    /// <summary>
    /// Implementation of the SSH File Transfer Protocol (SFTP) over SSH.
    /// </summary>
    public partial class SftpClientTest
    {
        [TestMethod]
        [TestCategory("Sftp")]
        [TestCategory("integration")]
        public void Test_Sftp_SynchronizeDirectories()
        {
            RemoveAllFiles();

            using (var sftp = new SftpClient(Resources.HOST, Resources.USERNAME, Resources.PASSWORD))
            {
                sftp.Connect();

                var uploadedFileName = Path.GetTempFileName();

                var sourceDir = Path.GetDirectoryName(uploadedFileName);
                var destDir = "/";
                var searchPattern = Path.GetFileName(uploadedFileName);
                IEnumerable<FileInfo> upLoadedFiles = sftp.SynchronizeDirectories(sourceDir, destDir, searchPattern);

                Assert.IsTrue(upLoadedFiles.Count() > 0);

                foreach (var file in upLoadedFiles)
                {
                    Debug.WriteLine(file.FullName);
                }

                sftp.Disconnect();
            }
        }

        [TestMethod]
        [TestCategory("Sftp")]
        [TestCategory("integration")]
        public void Test_Sftp_BeginSynchronizeDirectories()
        {
            RemoveAllFiles();

            using (var sftp = new SftpClient(Resources.HOST, Resources.USERNAME, Resources.PASSWORD))
            {
                sftp.Connect();

                var uploadedFileName = Path.GetTempFileName();

                var sourceDir = Path.GetDirectoryName(uploadedFileName);
                var destDir = "/";
                var searchPattern = Path.GetFileName(uploadedFileName);

                var asyncResult = sftp.BeginSynchronizeDirectories(sourceDir,
                    destDir,
                    searchPattern,
                    null,
                    null
                );

                // Wait for the WaitHandle to become signaled.
                asyncResult.AsyncWaitHandle.WaitOne(1000);

                IEnumerable<FileInfo> upLoadedFiles = sftp.EndSynchronizeDirectories(asyncResult);

                Assert.IsTrue(upLoadedFiles.Count() > 0);

                foreach (var file in upLoadedFiles)
                {
                    Debug.WriteLine(file.FullName);
                }

                // Close the wait handle.
                asyncResult.AsyncWaitHandle.Close();

                sftp.Disconnect();
            }
        }
    }
}

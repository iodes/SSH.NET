using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renci.SshNet.Common;

namespace Renci.SshNet.Tests.Classes.Common
{
    [TestClass]
    [SuppressMessage("ReSharper", "InvokeAsExtensionMethod")]
    public class ExtensionsTest_Concat
    {
        private Random _random;

        [TestInitialize]
        public void Init()
        {
            _random = new Random();
        }

        [TestMethod]
        public void ShouldReturnSecondWhenFirstIsEmpty()
        {
            byte[] first = Array<byte>.Empty;
            byte[] second = CreateBuffer(16);

            byte[] actual = Extensions.Concat(first, second);

            Assert.IsNotNull(actual);
            Assert.AreEqual(second, actual);
        }

        [TestMethod]
        public void ShouldReturnSecondWhenFirstIsNull()
        {
            const byte[] first = null;
            byte[] second = CreateBuffer(16);

            byte[] actual = Extensions.Concat(first, second);

            Assert.IsNotNull(actual);
            Assert.AreEqual(second, actual);
        }

        [TestMethod]
        public void ShouldReturnFirstWhenSecondIsEmpty()
        {
            byte[] first = CreateBuffer(16);
            byte[] second = Array<byte>.Empty;

            byte[] actual = Extensions.Concat(first, second);

            Assert.IsNotNull(actual);
            Assert.AreEqual(first, actual);
        }

        [TestMethod]
        public void ShouldReturnFirstWhenSecondIsNull()
        {
            byte[] first = CreateBuffer(16);
            const byte[] second = null;

            byte[] actual = Extensions.Concat(first, second);

            Assert.IsNotNull(actual);
            Assert.AreEqual(first, actual);
        }

        [TestMethod]
        public void ShouldReturnNullWhenFirstAndSecondAreNull()
        {
            const byte[] first = null;
            const byte[] second = null;

            byte[] actual = Extensions.Concat(first, second);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void ShouldConcatSecondToFirstWhenBothAreNotEmpty()
        {
            byte[] first = CreateBuffer(4);
            byte[] second = CreateBuffer(2);

            byte[] actual = Extensions.Concat(first, second);

            Assert.IsNotNull(actual);
            Assert.AreEqual(first.Length + second.Length, actual.Length);
            Assert.AreEqual(first[0], actual[0]);
            Assert.AreEqual(first[1], actual[1]);
            Assert.AreEqual(first[2], actual[2]);
            Assert.AreEqual(first[3], actual[3]);
            Assert.AreEqual(second[0], actual[4]);
            Assert.AreEqual(second[1], actual[5]);
        }

        [TestMethod]
        [TestCategory("LongRunning")]
        [TestCategory("Performance")]
        public void Performance_LargeArray_FirstEmpty()
        {
            byte[] first = Array<byte>.Empty;
            byte[] second = CreateBuffer(50000);
            const int runs = 10000;

            Performance(first, second, runs);
        }

        [TestMethod]
        [TestCategory("LongRunning")]
        [TestCategory("Performance")]
        public void Performance_LargeArray_SecondEmpty()
        {
            byte[] first = CreateBuffer(50000);
            byte[] second = Array<byte>.Empty;
            const int runs = 10000;

            Performance(first, second, runs);
        }

        [TestMethod]
        [TestCategory("LongRunning")]
        [TestCategory("Performance")]
        public void Performance_LargeArray_BothNotEmpty()
        {
            byte[] first = CreateBuffer(50000);
            byte[] second = CreateBuffer(20000);
            const int runs = 10000;

            Performance(first, second, runs);
        }

        private static void Performance(byte[] first, byte[] second, int runs)
        {
            var stopWatch = new Stopwatch();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            stopWatch.Start();

            for (var i = 0; i < runs; i++)
            {
                byte[] result = Extensions.Concat(first, second);
                var resultLength = result.Length;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            stopWatch.Stop();

            Console.WriteLine(stopWatch.ElapsedMilliseconds);

            stopWatch.Reset();
            stopWatch.Start();

            for (var i = 0; i < runs; i++)
            {
                IEnumerable<byte> result = Enumerable.Concat(first, second);
                var resultLength = result.ToArray().Length;
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            stopWatch.Stop();

            Console.WriteLine(stopWatch.ElapsedMilliseconds);
        }

        private byte[] CreateBuffer(int length)
        {
            var buffer = new byte[length];
            _random.NextBytes(buffer);
            return buffer;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberUtils;
using System;
using System.Collections;

namespace SparkfishWebApi.Test
{
    [TestClass]
    public class ListifyWorks
    {
        private IList _numberSequence;

        public ListifyWorks()
        {
            _numberSequence = new Listify(100, 200);
        }
        [TestMethod]
        public void Listify_ValidIndex_Equal()
        {
            var val = _numberSequence[50];
            Assert.AreEqual(val, 150);
        }
        [TestMethod]
        public void Listify_ValidIndex_NotEqual()
        {
            var val = _numberSequence[50];
            Assert.AreNotEqual(val, 149);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Listify_InvalidIndex_IndexGreaterThanCount()
        {
            var val = _numberSequence[101];
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Listify_InvalidIndex_IndexLessThanZero()
        {
            var val = _numberSequence[-1];
        }

    }
}
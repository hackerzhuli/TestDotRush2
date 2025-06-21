using NUnit.Framework;
using UnityEngine;

namespace How.Are.You.Doing
{
    public class MyPackageTest
    {
        [Test]
        public void Test()
        {
            var n = 1;
            n += 2;
            Assert.AreEqual(3, n);
        }

    }
}


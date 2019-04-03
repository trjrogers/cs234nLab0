using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using MTDClasses;

namespace MTDTests
{
    [TestFixture]
    class BoneyardTests
    {
        BoneYard bone = new BoneYard(2);
        [SetUp]
        public void SetUpAllTests()
        {
        }

        [Test]
        public void TestOverloadedConstructor()
        {
            Assert.AreEqual(0, bone[0].Side1);
        }
    }
}

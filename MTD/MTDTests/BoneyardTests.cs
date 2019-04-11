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
        BoneYard bone1;
        BoneYard bone2;
        Domino def;
        Domino d12;
        Domino d21;
        Domino d33;

        [SetUp]
        public void SetUpAllTests()
        {
            def = new Domino();
            d12 = new Domino(1, 2);
            d21 = new Domino(2, 1);
            d33 = new Domino(3, 3);

            bone1 = new BoneYard();
            bone2 = new BoneYard(6);
        }

        [Test]
        public void TestOverloadedConstructor()
        {
            bone2 = new BoneYard(6);
            Assert.AreEqual(bone2.DominosRemaining, 49);

            bone2 = new BoneYard();
            Assert.AreEqual(bone2.DominosRemaining, 0);
        }

        [Test]
        public void TestShuffle()
        {
            bone1 = new BoneYard(6);
            bone2 = new BoneYard(6);

            Domino d = bone1[0];

            bone2.Shuffle();

            Assert.False(bone2[0].Equals(d));
        }
    }
}

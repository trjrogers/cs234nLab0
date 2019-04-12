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
        // Initialize fields for two boneyards, a default domino, 1-2 domino, 2-1 domino. and double-3 domino
        BoneYard bone1;
        BoneYard bone2;
        Domino def;
        Domino d12;
        Domino d21;
        Domino d33;

        [SetUp]
        public void SetUpAllTests()
        {
            // Constructs appropriate dominos for each domino respective to its variable name
            def = new Domino();
            d12 = new Domino(1, 2);
            d21 = new Domino(2, 1);
            d33 = new Domino(3, 3);

            // Constructs empty BoneYard and BoneYard with maxDot number of 6
            bone1 = new BoneYard();
            bone2 = new BoneYard(6);
        }

        [Test]
        public void TestDefaultConstructor()
        {
            // Checks to see if default constructed boneyard is empty, as expected
            Assert.AreEqual(bone1.DominosRemaining, 0);
        }

        [Test]
        public void TestOverloadedConstructor()
        {
            // Checks to see if overloaded constructed boneyard has 49 dominos, as expected
            Assert.AreEqual(bone2.DominosRemaining, 49);
        }

        [Test]
        public void TestShuffle()
        {
            // Constructs overloaded boneyard with  maxdot of , and checks if bone1 and bone2 have the same first index
            bone1 = new BoneYard(6);
            bone2.Shuffle();

            Assert.AreNotEqual(bone1[0], bone2[0]);
        }

        [Test]
        public void TestIsEmpty()
        {
            Assert.AreEqual(bone1.IsEmpty(), true);
        }

        [Test]
        public void TestDominosRemaining()
        {
            // Checks to see if boneyards have the expected number of dominos in their lists
            Assert.AreEqual(bone1.DominosRemaining, 0);
            Assert.AreEqual(bone2.DominosRemaining, 49);
        }

        [Test]
        public void TestDraw()
        {
            // Calls draw function on bone2
            bone2.Draw();

            // Checks to see if the drawn domino was removed from bone2
            Assert.AreEqual(bone2.DominosRemaining, 48);
        }

        [Test]
        public void TestToString()
        {
            // Constructs boneyard with maxdot of 0, meaning there should only be one domino on list with both sides value of 0
            bone1 = new BoneYard(0);
            // Casts bone1 to string
            string str = bone1.ToString();

            // Checks to see if the expected string is what is returned after converting bone1 to string
            Assert.AreEqual(str, "Side 1: 0  Side 2: 0" + "\n");
        }
    }
}

using System;
using Adaptation_Builder_Immutable.Domain;
using NUnit.Framework;

namespace NUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GuardTest_CounterpartyId()
        {
            Assert.Throws<ArgumentException>(() => new EconomicEntity(0, null, null, 0, 0, 0, null, false, null));
        }

        [Test]
        public void GuardTest_CounterpartyName()
        {
            Assert.Throws<ArgumentNullException>(() => new EconomicEntity(1, null, null, 0, 0, 0, null, false, null));
        }

        [Test]
        public void GuardTest_NettingGroupName()
        {
            Assert.Throws<ArgumentNullException>(() => new EconomicEntity(1, "CptyName", null, 0, 0, 0, null, false, null));
        }

        [Test]
        public void GuardTest_EffectiveMaturity()
        {
            Assert.Throws<ArgumentException>(() => new EconomicEntity(1, "CptyName", "netting", 0, 0, 0, null, false, null));
        }
    }
}
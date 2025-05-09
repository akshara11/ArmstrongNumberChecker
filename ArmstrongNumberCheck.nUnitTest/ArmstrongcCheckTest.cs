using ArmstrongNumberChecker;
namespace ArmstrongNumberCheck.nUnitTest
{
    public class ArmstrongcCheckTests
    {
        private ArmstrongNumber armstrongnumber { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            armstrongnumber = new ArmstrongNumber();
        }
        
        [TestCase(153)]
        [TestCase(370)]
        [TestCase(34)]
        [TestCase(1634)]
        [TestCase(786)]
        public void GetArmstrongNumber_EqualTests(int number)
        {
            var result = armstrongnumber.IsArmstrong(number);
            Assert.AreEqual(true, result);
        }
    }
}
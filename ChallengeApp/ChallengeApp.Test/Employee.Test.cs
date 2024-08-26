using System.Reflection.Metadata;

namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //arrange
            var user =new Employee("Marcin", "Lubiepierogi",33);
            user.AddScore(5);
            user.AddScore(6);

            //act
            var result = user.Result;

            //assert

            Assert.AreEqual(11, result);
        }
    }
}
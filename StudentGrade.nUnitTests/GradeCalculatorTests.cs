using StudentGrades;

namespace StudentGrade.nUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; } = null!;
        
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(99)]
        [TestCase(91)]
        [TestCase(95)]
        [TestCase(93)]
       



        public void GetGradeByPercentage_EqualTest(int percentage)
        {
            //Assign

            //var percentage = 99;
            //Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            //Assert
                       
            Assert.AreEqual("A",grade);
        }

        [TestCase(1)]
        [TestCase(45)]
        [TestCase(75)]
        [TestCase(89)]




        public void GetGradeByPercentage_NotEqualTest(int percentage)
        {
            //Assign

            //var percentage = 99;
            //Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            //Assert

            Assert.AreNotEqual("A", grade);
        }
    }
}
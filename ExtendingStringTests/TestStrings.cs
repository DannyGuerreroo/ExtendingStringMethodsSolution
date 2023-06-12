using ExtendingStringMethods;
using Moq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace ExtendingStringTests
{
    [TestClass]
    public class TestStrings
    {
        string testString = "Tacocat";

        [TestMethod]
        public void ReverseInput_KeepCasingPosition() // Tests for reversing a string while keeping the casing positioning the same
        {
            var output = testString.ReverseInput(true);
            Assert.AreEqual("Tacocat", output);
        }
        [TestMethod]
        public void RemoveDuplicate_Success() // Tests for proper duplicate character removal
        {
            var output = testString.RemoveDuplicates();
            Assert.AreEqual("Tacot", output);
        }
        [TestMethod]
        public void MaxOccurrencesVowels_Success() // Tests for accurate gathering of max vowels from a string
        {
            var output = testString.MaxOccurrence(Occurrences.OccurrenceType.MaxVowels);
            Assert.AreEqual(2, output);
        }
        [TestMethod]
        public void MaxOccurrencesVowels_WrongType() // Tests for MaxOccurrence defaulting to non-vowels
        {
            var output = testString.MaxOccurrence(Occurrences.OccurrenceType.MinVowels);
            Assert.AreEqual(2, output);
        }
        [TestMethod]
        public void MinOccurrencesVowels_Success() // Tests for accurate gathering of min vowels from a string
        {
            var output = testString.MinOccurrence(Occurrences.OccurrenceType.MinVowels);
            Assert.AreEqual(1, output);
        }
        [TestMethod]
        public void MinOccurrencesVowels_WrongType() // Tests for MinOccurrence defaulting to non-vowels
        {
            var output = testString.MinOccurrence(Occurrences.OccurrenceType.MaxVowels);
            Assert.AreEqual(1, output);
        }
    }
}
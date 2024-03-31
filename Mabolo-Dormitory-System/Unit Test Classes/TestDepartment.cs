using Mabolo_Dormitory_System.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Mabolo_Dormitory_System.Unit_Test_Classes
{
    public class TestDepartment
    {
        [Fact]
        public void Department_Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            int expectedDepartmentId = 101;
            string expectedDepartmentName = "Computer Science";
            string expectedCollegeName = "School of Engineering";

            // Act
            Department department = new Department(expectedDepartmentId, expectedDepartmentName, expectedCollegeName);

            // Assert
            Assert.Equal(expectedDepartmentId, department.DepartmentId);
            Assert.Equal(expectedDepartmentName, department.DepartmentName);
            Assert.Equal(expectedCollegeName, department.CollegeName);
        }

        // Exception Tests (for ValidateArg)
        [Fact]
        public void Department_Constructor_ThrowsArgumentOutOfRangeException_ForInvalidDepartmentId()
        {
            // Arrange
            int invalidDepartmentId = -5;
            string validDepartmentName = "Mathematics";
            string validCollegeName = "College of Arts and Sciences";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentOutOfRangeException>(() => new Department(invalidDepartmentId, validDepartmentName, validCollegeName));
        }

        [Fact]
        public void Department_Constructor_ThrowsArgumentNullException_ForNullDepartmentName()
        {
            // Arrange
            int validDepartmentId = 102;
            string nullDepartmentName = null;
            string validCollegeName = "College of Business";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentNullException>(() => new Department(validDepartmentId, nullDepartmentName, validCollegeName));
        }

        [Fact]
        public void Department_Constructor_ThrowsArgumentNullException_ForNullCollegeName()
        {
            // Arrange
            int validDepartmentId = 103;
            string validDepartmentName = "Physics";
            string nullCollegeName = null;

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentNullException>(() => new Department(validDepartmentId, validDepartmentName, nullCollegeName));
        }

        [Fact]
        public void Department_Constructor_ThrowsArgumentException_ForEmptyDepartmentName()
        {
            // Arrange
            int validDepartmentId = 104;
            string emptyDepartmentName = "";
            string validCollegeName = "College of Medicine";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new Department(validDepartmentId, emptyDepartmentName, validCollegeName));
        }

        [Fact]
        public void Department_Constructor_ThrowsArgumentException_ForWhitespaceDepartmentName()
        {
            // Arrange
            int validDepartmentId = 105;
            string whitespaceDepartmentName = "  ";
            string validCollegeName = "College of Law";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new Department(validDepartmentId, whitespaceDepartmentName, validCollegeName));
        }

        [Fact]
        public void Department_Constructor_ThrowsArgumentException_ForLongDepartmentName()
        {
            // Arrange
            int validDepartmentId = 106;
            string longDepartmentName = new string('a', 101); // Exceeds max length (100)
            string validCollegeName = "College of Education";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new Department(validDepartmentId, longDepartmentName, validCollegeName));
        }

        [Fact]
        public void Department_Constructor_ThrowsArgumentException_ForEmptyCollegeName()
        {
            // Arrange
            int validDepartmentId = 107;
            string validDepartmentName = "Chemistry";
            string emptyCollegeName = "";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new Department(validDepartmentId, validDepartmentName, emptyCollegeName));
        }

        [Fact]
        public void Department_Constructor_ThrowsArgumentException_ForWhitespaceCollegeName()
        {
            // Arrange
            int validDepartmentId = 108;
            string validDepartmentName = "Biology";
            string whitespaceCollegeName = "  ";

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new Department(validDepartmentId, validDepartmentName, whitespaceCollegeName));
        }

        [Fact]
        public void Department_Constructor_ThrowsArgumentException_ForLongCollegeName()
        {
            // Arrange
            int validDepartmentId = 109;
            string validDepartmentName = "Statistics";
            string longCollegeName = new string('a', 101); // Exceeds max length (45)

            // Assert (using Assert.Throws for expected exceptions)
            Assert.Throws<ArgumentException>(() => new Department(validDepartmentId, validDepartmentName, longCollegeName));
        }

        // ToString Tests
        [Fact]
        public void Department_ToString_ReturnsCorrectFormattedString()
        {
            // Arrange
            int expectedDepartmentId = 201;
            string expectedDepartmentName = "English Literature";
            string expectedCollegeName = "College of Arts and Sciences";

            // Act
            Department department = new Department(expectedDepartmentId, expectedDepartmentName, expectedCollegeName);
            string actualToStringOutput = department.ToString();

            // Assert
            string expectedToString = expectedDepartmentId + ": " + expectedDepartmentName;
            Assert.Equal(expectedToString, actualToStringOutput);
        }

    }
}

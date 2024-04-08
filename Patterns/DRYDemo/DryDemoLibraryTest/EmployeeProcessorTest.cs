﻿using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DryDemoLibraryTest
{
    public class EmployeeProcessorTest
    {
        [Theory]
        [InlineData("Timothy", "Corey", "TimoCore")]
        [InlineData("Tim", "Corey", "TimXCore")]
        [InlineData("Tim", "Co", "TimXCoXX")]
        public void GenerateEmployeeId_ShouldCalculate(string firstName, string lastName, string expectedStart)
        {
            // Arrange
            EmployeeProcessor processor = new EmployeeProcessor();

            // Act
            string actualStart = processor.GenerateEmployeeID(firstName, lastName).Substring(0, expectedStart.Length);

            // Assert
            Assert.Equal(expectedStart, actualStart);
        }
    }
}

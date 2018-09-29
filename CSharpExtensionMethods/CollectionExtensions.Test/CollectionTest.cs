using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionExtensions.Test
{
    [TestClass]
    public class CollectionTest
    {
        [TestMethod]
        public void List_NotNullOrEmpty_Null_List()
        {
            // Arrange
            List<string> list = null;

            // Act
            bool result = Collection.NotNullOrEmpty<string>(list);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void List_NotNullOrEmpty_Empty_List()
        {
            // Arrange
            List<string> list = new List<string>();

            // Act
            bool result = Collection.NotNullOrEmpty<string>(list);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void List_NotNullOrEmpty_List_With_Items()
        {
            // Arrange
            List<string> list = new List<string>();
            list.Add("John");

            // Act
            bool result = Collection.NotNullOrEmpty<string>(list);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IEnumerable_NotNullOrEmpty_Null_List()
        {
            // Arrange
            IEnumerable<string> list = null;

            // Act
            
            bool result = list.NotNullOrEmpty();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IEnumerable_NotNullOrEmpty_Empty_List()
        {
            // Arrange
            List<string> list = new List<string>();

            // Act
            bool result = list.NotNullOrEmpty();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IEnumerable_NotNullOrEmpty_List_With_Items()
        {
            // Arrange
            List<string> list = new List<string>();
            list.Add("John");

            // Act
            bool result = list.NotNullOrEmpty();

            // Assert
            Assert.IsTrue(result);
        }
    }
}

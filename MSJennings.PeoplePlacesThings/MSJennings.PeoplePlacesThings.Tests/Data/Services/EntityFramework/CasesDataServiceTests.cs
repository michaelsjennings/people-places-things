using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSJennings.PeoplePlacesThings.Tests.Data.Services.EntityFramework
{
    [TestClass]
    public class CasesDataServiceTests
    {
        #region Public Methods

        [TestMethod]
        public void CreateCase_WithNullCase_ShouldThrowException()
        {
        }

        [TestMethod]
        public void CreateCase_WithValidCase_ShouldSaveAndReturnId()
        {
        }

        [TestMethod]
        public void CreateCaseAsync_WithNullCase_ShouldThrowException()
        {
        }

        [TestMethod]
        public void CreateCaseAsync_WithValidCase_ShouldSaveAndReturnId()
        {
        }

        [TestMethod]
        public void DeleteCase_WithInvalidCaseId_ShouldReturnFalse()
        {
        }

        [TestMethod]
        public void DeleteCase_WithValidCaseId_ShouldRemoveAndReturnTrue()
        {
        }

        [TestMethod]
        public void DeleteCaseAsync_WithInvalidCaseId_ShouldReturnFalse()
        {
        }

        [TestMethod]
        public void DeleteCaseAsync_WithValidCaseId_ShouldRemoveAndReturnTrue()
        {
        }

        [TestMethod]
        public void RetrieveCase_WithInvalidCaseId_ShouldReturnNull()
        {
        }

        [TestMethod]
        public void RetrieveCase_WithValidCaseId_ShouldReturnCase()
        {
        }

        #endregion Public Methods
    }
}
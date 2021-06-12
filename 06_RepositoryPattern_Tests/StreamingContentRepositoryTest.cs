using _06_RepositoryPatttern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTest
    {

        

        //repo
        private StreamingContentRepository _repo;
        //poco
        private StreamingContent _content;
        //this should run before any test

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.",
                "R", 5.8, false, GenreType.Drama);

            _repo.AddContentToList(_content);
        }




        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            //Arrange --> Setting up the playing field

            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";
            StreamingContentRepository repository = new StreamingContentRepository();
            //Act - Get/Run Tthe code we want to test
            repository.AddContentToList(content);
            StreamingContent contentFromDirectory = repository.GetContentByTitle("Toy Story");

            //Assert -->use the Assert Class to verify the expected outcome.
            Assert.IsNotNull(contentFromDirectory);
        }

        //Update

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange
            //TestInitialize
            StreamingContent newContent = new StreamingContent("Rubber 2", "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.",
                "R", 10, false, GenreType.RomCom);

            //Act 
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert

            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow("Rubber",true)]
        [DataRow("Toy Story",false)]
        public void UpdateExistingContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate)
        {
            //Arrange
            //TestInitialize
            StreamingContent newContent = new StreamingContent("Rubber 2", "A car tyre comes to life with the power to make people explode and goes on a murderous rampage through the California desert.",
                "R", 10, false, GenreType.RomCom);

            //Act 
            bool updateResult = _repo.UpdateExistingContent(originalTitle, newContent);

            //Assert

            Assert.AreEqual(shouldUpdate,updateResult);
            
        }

        [DataTestMethod]
        [DataRow(true)]
        //[DataRow(false)]
        public void DeleteContent_ShouldReturnTrue()
        {
            //Arrange

            //Act

            bool deleteResult = _repo.RemoveContentList(_content.Title);

            //Assert

            Assert.IsTrue(deleteResult);
        }
        
        

        
    }

    
}

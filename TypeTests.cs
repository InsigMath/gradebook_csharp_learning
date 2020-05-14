using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
                [Fact] // An attribute in C#, think of it as a piece of data attached to the symbol it follows, in this case Test1
        public void Test1()
        {
            // Break up tests to three sections

            // arrage
            var book1 = GetBook("Book 1");
            // var book2 = book1;
            GetBookSetName(book1, "New Name");

            // act

            // assert
            Assert.Equal("Book 1", book1.Name);
            // Assert.Equal("New Name", book2.Name);
            //Assert.NotSame(book1, book2);
        }

        [Fact] // An attribute in C#, think of it as a piece of data attached to the symbol it follows, in this case Test1
        public void CanSetNameFromReference()
        {
            // Break up tests to three sections

            // arrage
            var book1 = GetBook("Book 1");
            // var book2 = book1;
            SetName(book1, "New Name");

            // act

            // assert
            Assert.Equal("New Name", book1.Name);
            // Assert.Equal("New Name", book2.Name);
            //Assert.NotSame(book1, book2);
        }


        [Fact] 
        public void TwoVarsCanReferenceSameObject()
        {
            // Break up tests to three sections

            // arrage
            var book1 = GetBook("Book 1");
            var book2 = book1; // book2 points tot he same object as book1 (i.e., doesnt create a copy)

            // act

            // assert
            // Assert.Equal("Book 1", book1.Name);
            // Assert.Equal("Book 1", book2.Name);
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}

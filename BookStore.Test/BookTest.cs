using Moq;

namespace BookStore.Test
{
    public class BookTest
    {
        public static List<Author> authorsData
            = new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Name = "Name 1",
                    BirthDay = DateTime.Now,
                },
                new Author()
                {
                    Id = 2,
                    Name = "Name 2",
                    BirthDay = DateTime.Now,
                },
                new Author()
                {
                    Id = 3,
                    Name = "Name 3",
                    BirthDay = DateTime.Now,
                }
            };

        public static List<Book> BookData
            = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                  Title = "Book 1",
                  AuthorId = 1,
                  ReleaseDate = new DateTime(2005,05,07)
                },
                new Book()
                {
                    Id = 4,
                    Title = "Book 4",
                    AuthorId = 1,
                    ReleaseDate = new DateTime(2007,05,07)
                },
                new Book()
                {
                    Id = 2,
                    Title = "Book 2",
                    AuthorId = 2,
                    ReleaseDate = new DateTime(2015,05,07)
                },
                new Book()
                {
                    Id = 3,
                  Title = "Book 3",
                  AuthorId = 3,
                  ReleaseDate = new DateTime(2010,05,07)
                },
            };

        [Fact]
        public void GetAllBooksByAuthorId_Count_Check()
        {
            var expectedCount = 2;
            var auhorId = 1;
            var mockedBookRepository = new Mock<IBookRepository>();

            mockedBookRepository.Setup(x => x.GetAllBooksByAuthorId(authorId)).Returns(Books.Where(b => b.authorId).ToList());

            var service = new BookService(mockedBookRepository.Object);

            var result = service.GetAllBooksByAuthorId();

            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count());
        }
    }
}
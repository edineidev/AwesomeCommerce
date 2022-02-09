using FluentAssertions;

using NSubstitute;

using Way2Commerce.Domain.Entities;
using Way2Commerce.Domain.Repositories;

using Xunit;

namespace Way2Commerce.Domain.UnitTests.Repositories;

public class UnitTest1
{
    [Fact(Skip = "Need update")]
    public void Test1()
    {
        var repository = Substitute.For<IProductRepository>();

        //repository.Create(Arg.Any<Product>()).Returns(1);

        //var id = repository.Create(new Product(1, "Code123", "Wayne Batman", "Sou foda!!!", 99.99m, Category.Eletronics));

        //id.Should().Be(1);
    }
}
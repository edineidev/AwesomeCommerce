using Xunit;
using NSubstitute;
using FluentAssertions;
using Way2Commerce.Domain.Repositories;
using Way2Commerce.Domain.Entities;

namespace Way2Commerce.Domain.UnitTests.Repositories;

public class UnitTest1
{
    [Fact(Skip="Need update")]
    public void Test1()
    {
        var repository  = Substitute.For<IProductRepository>();

        //repository.Create(Arg.Any<Product>()).Returns(1);

        var id = repository.Create(new Product(1, "Code123", "Wayne Batman", "Sou foda!!!", 99.99m, 1));

        id.Should().Be(1);
    }
}
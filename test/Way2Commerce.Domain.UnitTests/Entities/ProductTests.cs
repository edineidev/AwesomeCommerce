using Xunit;
using NSubstitute;
using FluentAssertions;
using Way2Commerce.Domain.Repositories;
using Way2Commerce.Domain.Entities;

namespace Way2Commerce.Domain.UnitTests.Entities;
public class ProductTests
{
        [Fact]
    public void Test1()
    {
        var product  = new Product(1, "123456", "Wayne Batman", "Sou foda!!!", 99.99m, 1);

        var isValid = product.IsValid();

        isValid.Should().Be(true);
    }

            [Fact]
    public void Test2()
    {
        var product  = new Product(1, "1234567", "Wayne Batman", "Sou foda!!!", 99.99m, 1);

        var isValid = product.IsValid();

        isValid.Should().Be(false);
    }
}
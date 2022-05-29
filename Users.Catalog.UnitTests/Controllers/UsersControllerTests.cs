using System.Net;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Users.Catalog.Controllers;
using Users.Catalog.Models.Dtos;

namespace Users.Catalog.UnitTests.Controllers
{
    [Trait("Category", "Unit")]
    public class UsersControllerTests
    {
        private readonly UsersController _userController;

        private const string API_UP = "UP";

        public UsersControllerTests()
        {
            _userController = new UsersController();
        }

        [Fact]
        public void Get_WhenCalled_ShouldNotBeNull()
        {
            // Arrange

            // Act
            var result = _userController.Get();

            // Assert
            result.Should().BeOfType<ActionResult<IEnumerable<UserDto>>>();
            result.Should().NotBeNull();
        }

        [Fact]
        public void HealthCheck_WhenCalled_ShoulReturnUp()
        {
            // Arrange

            // Act
            var result = _userController.HealthCheck();

            // Assert
            result.Should().Be(API_UP);
        }
    }
}
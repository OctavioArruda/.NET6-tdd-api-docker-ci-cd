using System.ComponentModel.DataAnnotations;

namespace Users.Catalog.Models.Dtos
{
    public record UserDto(Guid Id, string Name, string Surname, int Age);
    public record CreateUserDto([Required] string Name, string Suername, [Range(0, 150)]int Age);
    public record UpdateUserDto([Required] string Name, string Suername, [Range(0, 150)]int Age);
}
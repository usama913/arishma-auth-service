namespace Arishma.Auth.Application;
public record UserDto(Guid Id, string Name);
public record ServiceInfoDto(string Service, string Subdomain, string Status, string DatabaseProvider);

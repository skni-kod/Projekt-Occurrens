namespace Application.WorkAccount.Commands.SingUpUser;

public record SingUpUserRequest(
    string Login,
    string Password);
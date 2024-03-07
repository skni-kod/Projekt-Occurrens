namespace Application.WorkAccount.Commands.SignInUser;

public record SignInUserRequest(
    string Login,
    string Password);
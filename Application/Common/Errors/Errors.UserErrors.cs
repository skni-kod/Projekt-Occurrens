using ErrorOr;

namespace Application.Common.Errors;

public static partial class Errors
{
    public static class UserErrors
    {
        public static Error duplicateEmail => Error.Conflict
        (
        code: "Duplicate e-mail",
        description: "Niepoprawne dane rejestracji!"
        );
    }
}
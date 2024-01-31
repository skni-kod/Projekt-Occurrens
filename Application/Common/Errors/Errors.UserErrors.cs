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

        public static Error nullEmailOrPasswork => Error.Conflict
        (
            code: "E-mail or password is null",
            description: "Podałeś niepoprawne dane logowania!"
        );

        public static Error accountNotVerified => Error.Conflict
        (code: "Account not verified!", description: "Zweryfikuj adres e-mail!");

        public static Error somethinkWentWrong => Error.Conflict
            (code:"Somethink went wrong!", description:"Coś poszło nie tak!");
        
        public static Error badEmail => Error.Conflict
            (code:"Bad e-mail!", description:"Podałeś niepoprawny e-mail");
    }
}
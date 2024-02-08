using ErrorOr;

namespace Application.Common.Errors;

public static partial class Errors
{
    public static class DoctorInfoErrors
    {
        public static Error WrongAddressId => Error.Conflict(
            code: "Bad Id",
            description: "Gabinet z takim adresem nie istnieje!"
            );
        
        public static Error NotAccess => Error.Conflict(
            code: "Wrong user",
            description: "Nie posiadasz takiego gabinetu!"
        );

        public static Error DataExists => Error.Conflict(
            code: "Data Exist",
            description: "Nie możesz utworzyć informacji dla gabinetu który posiada już informacje!"
            );
    }
}
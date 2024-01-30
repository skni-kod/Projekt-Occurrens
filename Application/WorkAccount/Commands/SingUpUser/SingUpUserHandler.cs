    using Application.Common.Errors;
    using Application.Contracts.AccountAnswer;
    using Core.Account.Repositories;
    using MediatR;
    using ErrorOr;

    namespace Application.WorkAccount.Commands.SingUpUser;

    public class SingUpUserHandler : IRequestHandler<SingUpUserCommand, ErrorOr<AccountResponse>>
    {
        private readonly IAccountRepository _accountRepository;

        public SingUpUserHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        
        public async Task<ErrorOr<AccountResponse>> Handle(SingUpUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _accountRepository.UserData(request.Login,request.Password ,request.Who, cancellationToken);

            if (user is null) return Errors.UserErrors.nullEmailOrPasswork;

            if (user.VerifiedAt == null) return Errors.UserErrors.accountNotVerified;

            var token = await _accountRepository.GenerateJwt(user);

            return new AccountResponse(token);
        }
    }
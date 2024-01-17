using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Users.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Users.Handler
{
    public class CreateUserHandler : AsyncRequestHandler<CreateUserCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateUserHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                FullName = request.FullName,
                Email = request.Email,
                PasswordHash = request.PasswordHash,
                PhoneNumber = request.PhoneNumber,
                RefreshToken = request.RefreshToken,
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

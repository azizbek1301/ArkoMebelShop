using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Users.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Users.Handler
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateUserHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            user.FullName=request.FullName;
            user.Email=request.Email;
            user.PasswordHash=request.PasswordHash;
            user.PhoneNumber=request.PhoneNumber;
            user.RefreshToken=request.RefreshToken;

            _context.Users.Update(user);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }
}

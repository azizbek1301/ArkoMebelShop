using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Users.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Users.Handler
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdCommand, User>
    {
        private readonly IApplicationDbContext _context;

        public GetUserByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> Handle(GetUserByIdCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            return user;
        }
    }
}

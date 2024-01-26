using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.Security;
using ArkoMebel.Service.UseCases.Admins.Commands;
using ArkoMebel.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace ArkoMebel.Service.UseCases.Admins.Handlers
{
    public class CreateAdminHandler : IRequestHandler<CreateAdminCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateAdminHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateAdminCommand request, CancellationToken cancellationToken)
        {
            Admin checkAdmin = await _context.Admins.FirstOrDefaultAsync(x => x.Email == request.Email,cancellationToken);

            Admin admin = new Admin()
            {
                Email = request.Email,
                FullName = request.FullName,
                PasswordHash = PasswordHash.ComputeShA512HashFromString(request.Password),
                Role = request.Role

            };
            await _context.Admins.AddAsync(admin);
            int response = await _context.SaveChangesAsync(cancellationToken);


            return response;

        }
    }
}

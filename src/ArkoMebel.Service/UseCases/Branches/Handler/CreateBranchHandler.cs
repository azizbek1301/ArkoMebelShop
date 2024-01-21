using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Branches.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Branches.Handler
{
    public class CreateBranchHandler:AsyncRequestHandler<CreateBranchCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateBranchHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = new Branch()
            {
                Name = request.Name,
                OpenAt = request.OpenAt,
                CloseAt = request.CloseAt,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                AddressId = request.AddressId,
                Link = request.Link,
            };

            await _context.Branches.AddAsync(branch);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

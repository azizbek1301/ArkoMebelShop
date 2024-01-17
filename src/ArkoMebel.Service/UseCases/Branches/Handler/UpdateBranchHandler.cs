using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Branches.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Branches.Handler
{
    public class UpdateBranchHandler : IRequestHandler<UpdateBranchCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateBranchHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateBranchCommand request, CancellationToken cancellationToken)
        {
            var branch = await _context.Branches.FirstOrDefaultAsync(x => x.Id == request.Id);
            branch.Name = request.Name;
            branch.AddressId = request.AddressId;
            branch.PhoneNumber = request.PhoneNumber;
            branch.Email = request.Email;
            branch.OpenAt = request.OpenAt;
            branch.CloseAt = request.CloseAt;
            branch.Link = request.Link;

            _context.Branches.Update(branch);
            var res = await _context.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}

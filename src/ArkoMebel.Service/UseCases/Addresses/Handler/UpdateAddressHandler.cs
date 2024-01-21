using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Addresses.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Addresses.Handler
{
    public class UpdateAddressHandler : IRequestHandler<UpdateAddressCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateAddressHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var address=await _context.Addresses.FirstOrDefaultAsync(x=>x.Id==request.Id);
            address.City=request.City;
            address.Home=request.Home;
            _context.Addresses.Update(address);

            var result = await _context.SaveChangesAsync(cancellationToken);
            return result > 0;
        }
    }

}

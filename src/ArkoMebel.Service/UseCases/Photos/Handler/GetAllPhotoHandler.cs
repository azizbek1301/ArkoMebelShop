using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Photos.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Photos.Handler
{
    public class GetAllPhotoHandler : IRequestHandler<GetAllPhotoQuery, List<Photo>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllPhotoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Photo>> Handle(GetAllPhotoQuery request, CancellationToken cancellationToken)
        {
            return await _context.Photos.ToListAsync();
        }
    }
}

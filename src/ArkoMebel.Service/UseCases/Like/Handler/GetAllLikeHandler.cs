using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Like.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Like.Handler
{
    public class GetAllLikeHandler : IRequestHandler<GetAllLikeQuery, List<Likes>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllLikeHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Likes>> Handle(GetAllLikeQuery request, CancellationToken cancellationToken)
        {
            return await _context.Likes.ToListAsync();
        }
    }
}

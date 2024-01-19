using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Comments.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Comments.Handler
{
    public class GetAllCommentHandler : IRequestHandler<GetAllCommentQuery, List<Comment>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllCommentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> Handle(GetAllCommentQuery request, CancellationToken cancellationToken)
        {
            return await _context.Comments.ToListAsync();
        }
    }
}

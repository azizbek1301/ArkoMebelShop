using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Categories.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Categories.Handler
{
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryByIdQuery, Category>
    {
        private readonly IApplicationDbContext _context;

        public GetCategoryByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var command=await _context.Categories.FirstOrDefaultAsync(x=>x.Id==request.Id); 
            if(command!=null)
            {
                return command;
            }
            else
            {
                throw new ArgumentNullException("topilmadi");
            }
        }
    }
}

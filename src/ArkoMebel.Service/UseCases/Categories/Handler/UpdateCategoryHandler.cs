using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Categories.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Categories.Handler
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCategoryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async  Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x =>x.Id == request.Id);
            category.Name = request.Name;
            category.PhotoPath = request.PhotoPath;

            _context.Categories.Update(category);
            var res = await _context.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}

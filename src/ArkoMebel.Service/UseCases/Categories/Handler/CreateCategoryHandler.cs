using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Categories.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Categories.Handler
{
    public class CreateCategoryHandler:AsyncRequestHandler<CreateCategoryCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateCategoryHandler(IApplicationDbContext context)
        {
            _context=context;
        }



        protected override async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category()
            {
                Name = request.Name,
                PhotoPath = request.PhotoPath,
            };
        }
    }
}

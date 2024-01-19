using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Portfolios.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Portfolios.Handler
{
    public class CreatePortfolioHandler : AsyncRequestHandler<CreatePortfolioCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreatePortfolioHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreatePortfolioCommand request, CancellationToken cancellationToken)
        {
            var command = new Portfolio()
            {
                PhotoPath = request.PhotoPath,
                CategoryId = request.CategoryId,
           
            };
        }
    }
}

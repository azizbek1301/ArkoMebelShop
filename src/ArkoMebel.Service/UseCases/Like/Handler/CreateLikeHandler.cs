using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Like.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Like.Handler
{
    public class CreateLikeHandler : AsyncRequestHandler<CreateLikeCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateLikeHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateLikeCommand request, CancellationToken cancellationToken)
        {
            var comment = new Likes()
            {
                ProductId = request.ProductId,
                UserId = request.UserId,
            };
        }
    }
}

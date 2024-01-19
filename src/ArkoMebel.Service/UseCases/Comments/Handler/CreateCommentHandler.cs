using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Comments.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Comments.Handler
{
    public class CreateCommentHandler : AsyncRequestHandler<CreateCommentCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateCommentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = new Comment()
            {
                ProductId=request.ProductId,
                UserName =request.UserName,
                Text =request.Text,
                PhotoPath =request.PhotoPath,
            };
        }
    }
}

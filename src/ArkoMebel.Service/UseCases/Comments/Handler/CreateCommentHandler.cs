using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.Abstraction.File;
using ArkoMebel.Service.UseCases.Comments.Command;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace ArkoMebel.Service.UseCases.Comments.Handler
{
    public class CreateCommentHandler : AsyncRequestHandler<CreateCommentCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;
        public CreateCommentHandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        protected override async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            var comment = new Comment()
            {
                ProductId=request.ProductId,
                UserName =request.UserName,
                Text =request.Text,
                PhotoPath =await _fileService.UploadImageAsync(request.PhotoPath),

            };

            _context.Comments.Add(comment);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

using MediatR;

namespace ArkoMebel.Service.UseCases.Categories.Command
{
    public class DeleteCategoryCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
    
}

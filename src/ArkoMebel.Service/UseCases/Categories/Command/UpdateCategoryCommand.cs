using MediatR;

namespace ArkoMebel.Service.UseCases.Categories.Command
{
    public class UpdateCategoryCommand:IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoPath { get; set; } = default!;
    }
}

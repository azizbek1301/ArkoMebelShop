using MediatR;

namespace ArkoMebel.Service.UseCases.Categories.Command
{
    public class CreateCategoryCommand:IRequest
    {
        public string Name { get; set; }
        public string PhotoPath { get; set; } = default!;
    }
}

using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Categories.Queries
{
    public class GetCategoryByIdQuery:IRequest<Category>
    {
        public int Id { get; set; } 
    }
}

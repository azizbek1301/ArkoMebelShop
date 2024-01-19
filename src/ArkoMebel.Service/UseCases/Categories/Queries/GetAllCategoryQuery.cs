using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Categories.Queries
{
    public class GetAllCategoryQuery:IRequest<List<Category>>
    {

    }
}

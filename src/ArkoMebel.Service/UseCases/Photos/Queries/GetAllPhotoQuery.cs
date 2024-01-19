using ArkoMebel.Domain.Entites;
using MediatR;

namespace ArkoMebel.Service.UseCases.Photos.Queries
{
    public class GetAllPhotoQuery : IRequest<List<Photo>>
    {
    }
}

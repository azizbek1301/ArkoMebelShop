using MediatR;
using Microsoft.AspNetCore.Http;

namespace ArkoMebel.Service.UseCases.Categories.Command
{
    public class CreateCategoryCommand:IRequest
    {
        public string Name { get; set; }
        public IFormFile PhotoPath { get; set; } 
    }
}

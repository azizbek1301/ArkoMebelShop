using MediatR;
using Microsoft.AspNetCore.Http;

namespace ArkoMebel.Service.UseCases.Portfolios.Command
{
    public class CreatePortfolioCommand:IRequest
    {
        public IFormFile PhotoPath { get; set; }
        public int CategoryId { get; set;}  
    }
}

using MediatR;

namespace ArkoMebel.Service.UseCases.Portfolios.Command
{
    public class CreatePortfolioCommand:IRequest
    {
        public string PhotoPath { get; set; }
        public int CategoryId { get; set;}  
    }
}

using MediatR;

namespace ArkoMebel.Service.UseCases.Branches.Command
{
    public class DeleteBranchCommand:IRequest<bool>
    {
        public int Id {  get; set; }
    }
}

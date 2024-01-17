using ArkoMebel.Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkoMebel.Service.UseCases.Users.Queries
{
    public class GetUserByIdCommand:IRequest<User>
    {
        public int Id { get; set; }
    }
}

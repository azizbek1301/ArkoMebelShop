﻿using MediatR;

namespace ArkoMebel.Service.UseCases.Branches.Command
{
    public class UpdateBranchCommand:IRequest<bool>
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public TimeOnly OpenAt { get; set; }
        public TimeOnly CloseAt { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int AddressId { get; set; }
        public string Link { get; set; } = default!;
    }
}

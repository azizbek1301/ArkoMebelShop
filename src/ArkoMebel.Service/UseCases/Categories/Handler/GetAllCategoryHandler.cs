﻿using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Categories.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Categories.Handler
{
    public class GetAllCategoryHandler:IRequestHandler<GetAllCategoryQuery,List<Category>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllCategoryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var command= await _context.Categories.ToListAsync(cancellationToken);
           
            //if(command)
            //{
            //    throw new Exception("Topilmadi");
            //}
            return command;
        }
    }
}

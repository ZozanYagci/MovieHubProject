﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieHub.Application.Features.CQRS.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest<Unit>
    {
        public string CategoryName { get; set; }
    }
}

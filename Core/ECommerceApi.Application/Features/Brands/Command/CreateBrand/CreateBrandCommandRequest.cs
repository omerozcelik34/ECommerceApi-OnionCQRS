﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Brands.Command.CreateBrand
{
    public class CreateBrandCommandRequest : IRequest<Unit>
    {
        public string Name { get; set; }
    }
}

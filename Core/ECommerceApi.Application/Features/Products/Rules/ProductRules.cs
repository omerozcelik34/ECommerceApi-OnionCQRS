﻿using ECommerceApi.Application.Bases;
using ECommerceApi.Application.Features.Products.Exceptions;
using ECommerceApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.Features.Products.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products, string requestTitle)
        { 
            if(products.Any(x => x.Title == requestTitle)) throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}

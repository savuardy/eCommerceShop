﻿using System.Collections;
using System.Collections.Generic;

namespace eCommerce_shop.Errors
{
    public class ApiValidationErrorResponse : ApiResponse
    {
        public ApiValidationErrorResponse() : base(400)
        {
        }
        
        public IEnumerable<string> Errors { get; set; }
    }
}
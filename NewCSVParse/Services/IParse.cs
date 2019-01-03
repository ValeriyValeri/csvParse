﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCSVParse.Services
{
    public interface IParse
    {
        List<string[]> Parse(IFormFile file);
    }
}

﻿using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation
{
    public class VIPClient : Client
    {
        public override void AddCash(decimal cash)
        {
            throw new NotImplementedException();
        }
    }
}
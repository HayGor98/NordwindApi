﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NordwindApi.Core.Infrastructure.EntityAbstraction
{
    public class EntityBaseWithId:EntityBase
    {
        public int Id { get; set; }
    }
}

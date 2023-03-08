﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodePrisistance
{
    public class DbInitializer
    {
        public static void Initialize(NotesDBContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}

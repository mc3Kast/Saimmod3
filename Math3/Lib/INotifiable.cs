﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3.Lib
{
    public interface INotifiable
    {
        void NotifyEmpty();
        void NotifyNotEmpty();
    }
}

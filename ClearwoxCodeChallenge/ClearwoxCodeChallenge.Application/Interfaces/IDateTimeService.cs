﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClearwoxCodeChallenge.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}

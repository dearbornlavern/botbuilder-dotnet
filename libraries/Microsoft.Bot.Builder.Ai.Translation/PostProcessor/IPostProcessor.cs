﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Bot.Builder.Ai.Translation.PostProcessor
{
    public interface IPostProcessor
    {
        void Process(out string processedResult);
    }
}

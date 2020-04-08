﻿using System.Collections.Generic;

namespace SM64Lib.Configuration
{
    public class CustomModelConfig
    {
        public string Name { get; set; } = string.Empty;
        public List<int> CollisionPointerDestinations { get; private set; } = new List<int>();
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace StatsCore
{
    internal class Guard
    {
        public static bool IsGamePaused()
        {
            if (Time.timeScale == 0f)
                return true;

            return false;
        }
    }
}

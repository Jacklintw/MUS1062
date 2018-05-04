﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Shared
{
    public static class Utils
    {
        public static string GetDataPath()
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relative = @"..\..\App_Data\";
            string absolute = Path.GetFullPath(Path.Combine(baseDirectory, relative));
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
            return absolute;
        }
    }
}

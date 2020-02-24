﻿using System.IO;
using System.Reflection;

namespace Livraria.Henrique.SeleniumTest.Helpers
{
    public static class TestHelper
    {
        public static string PastaDoExecutavel => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}

﻿using AminaTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AminaTest
{
    public class OpenUrl
    {
        public static void GoTo(string url)
        {
            Driver.Instance.Navigate().GoToUrl(url);
            Thread.Sleep(1000);

        }

    }
}
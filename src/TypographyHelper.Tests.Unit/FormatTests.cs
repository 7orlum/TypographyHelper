﻿using Xunit;
using System.Globalization;
using Orlum.TypographyHelper;
using static Orlum.TypographyHelper.Format;


namespace TypographyHelper.Tests.Unit
{
    public class FormatTests
    {
        [Fact]
        public void AcronimsWork()
        {
            var number = 1;
            var result = Format.NP($"I have got {number} {number:NP;en;cat;cats}");
            Assert.Equal("I have got 1 cat", result);

            result = NP($"I have got {number} {number:NP;en;cat;cats}");
            Assert.Equal("I have got 1 cat", result);

            result = CV($"{number:C}", "USD", CultureInfo.GetCultureInfo("ru-ru"));
            Assert.Equal("1,00 $", result);
        }
    }
}

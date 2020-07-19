// <copyright file="WynikTest.cs">Copyright ©  2020</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Tests
{
    [TestClass]
    [PexClass(typeof(Wynik))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class WynikTest
    {

        [PexMethod]
        public Wynik Constructor()
        {
            Wynik target = new Wynik();
            return target;
            // TODO: dodaj asercje do metoda WynikTest.Constructor()
        }
    }
}

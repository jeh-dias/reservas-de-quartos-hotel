using Application;
using Domain;
using Services;
using System;
using System.Collections.Generic;

namespace Aplications
{
    /// <summary>
    /// Faz a chamada para a classe intermediária entre a view e o Program
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            new ViewIntermediate().StartChoices();
        }
    }
}

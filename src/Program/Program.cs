//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

/// <summary>
/// Clase que contiene el punto de entrada al programa.
/// </summary>
namespace WordsPhrases
{
    public class Program
    {
        /// <summary>
        /// El punto de entrada al programa.
        /// </summary>
        public static void Main()
        {
            const string text1 = " text1 ";
            const string text2 = " text2 ";
            const string expected = "text1 text2";
            Phrase phrase = new Phrase();
            Word word1 = new Word(text1.Trim());
            Word word2 = new Word(text2.Trim());
            phrase.AddWord(word1);
            phrase.AddWord(word2);
            string actual = phrase.GetPhrase();
            //Assert.AreEqual(expected, actual);

            if (actual.Trim() == expected.Trim())
            {
                Console.WriteLine($"Okay, '{actual.Trim()}' es igual a '{expected.Trim()}'");
            }
            else
            {
                Console.WriteLine($"Algo salió mal, '{actual.Trim()}' es difernte de '{expected.Trim()}'");
            }
        }
    }
}

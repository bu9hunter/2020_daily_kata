using System;
using System.Text;
using Diamond_Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Diamond_Kata_Test
{
    [TestClass]
    public class UnitTest1
    {
        DianmondFactory diamondFactory;

        [TestInitialize]
        public void Setup()
        {
            diamondFactory = new DianmondFactory();
        }

        [TestMethod]
        public void if_make_diamond_with_numeric_character_then_return_null()
        {
            char letter = '0';

            Assert.IsNull(diamondFactory.print(letter));
        }

        private static void CollectionAssertJaggedArray(char[][] diamondPrint, char[][] returnedDiamonPrint)
        {
            for (int i = 0; i < diamondPrint.Length; i++)
            {
                CollectionAssert.AreEqual(diamondPrint[i], returnedDiamonPrint[i]);
            }
        }

        [TestMethod]
        public void make_diamond_with_A_character()
        {
            char letter = 'A';
            char[][] diamondPrint = {
                new char [] { 'A' }
            };

            char[][] returnedDiamonPrint = diamondFactory.print(letter);

            CollectionAssertJaggedArray(diamondPrint, returnedDiamonPrint);
        }

        [TestMethod]
        public void character_ascii_code_print()
        {
            Assert.AreEqual(65, (int)'A');
        }

        [TestMethod]
        public void make_diamond_with_upper_diamond_B()
        {
            char letter = 'B';
            char[][] diamondPrint = {
                new char [] { '.', 'A', '.' },
                new char [] { 'B', '.', 'B' },
            };

            char[][] returnedDiamonPrint = diamondFactory.print(letter);

            CollectionAssertJaggedArray(diamondPrint, returnedDiamonPrint);

        }

        [TestMethod]
        public void make_diamond_with_upper_diamond_C()
        {
            char letter = 'C';
            char[][] diamondPrint = {
                new char [] { '.', '.', 'A', '.', '.' },
                new char [] { '.', 'B', '.', 'B', '.' },
                new char [] { 'C', '.', '.', '.', 'C' },
            };

            char[][] returnedDiamonPrint = diamondFactory.print(letter);

            CollectionAssertJaggedArray(diamondPrint, returnedDiamonPrint);

        }

        [TestMethod]
        public void make_diamond_with_upper_diamond_D()
        {
            char letter = 'D';
            char[][] diamondPrint = {
                new char [] { '.', '.', '.', 'A', '.', '.', '.' },
                new char [] { '.', '.', 'B', '.', 'B', '.', '.' },
                new char [] { '.', 'C', '.', '.', '.', 'C', '.' },
                new char [] { 'D', '.', '.', '.', '.', '.', 'D' },
            };

            char[][] returnedDiamonPrint = diamondFactory.print(letter);

            CollectionAssertJaggedArray(diamondPrint, returnedDiamonPrint);

        }

        [TestMethod]
        public void make_diamond_with_full_dialmond_B()
        {
            char letter = 'B';
            char[][] diamondPrint = {
                new char [] { '.', 'A', '.' },
                new char [] { 'B', '.', 'B' },
                new char [] { '.', 'A', '.' },
            };

            char[][] returnedDiamonPrint = diamondFactory.print(letter);

            CollectionAssertJaggedArray(diamondPrint, returnedDiamonPrint);

        }
    }
}

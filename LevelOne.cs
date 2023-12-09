using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTests.Solution
{
    public class LevelOne
    {
        private const int kNumber = 6;
        private const int cNumber = 9;
        private const string valueIfAnyChar = "0";

        private List<char> _listOfCharToFindInFile;

        public LevelOne(List<char> listOfCharToFindInFile)
        {

            _listOfCharToFindInFile = new List<char>();
            _listOfCharToFindInFile = listOfCharToFindInFile;
        }


        public int GetMagicNumber(string path)
        {
            string valueConcatenation = valueIfAnyChar;
            foreach (char ch in _listOfCharToFindInFile)
            {
                valueConcatenation += GetMagicNumber(path, ch).ToString();
            }
            return Int32.Parse(valueConcatenation);
        }

        public int GetSuperMagicNumber(string path)
        {
            string valueConcatenation = valueIfAnyChar;
            foreach (char ch in _listOfCharToFindInFile)
            {
                valueConcatenation += GetSuperMagicNumber(path, ch).ToString();
            }
            return Int32.Parse(valueConcatenation);
        }
        private int GetSuperMagicNumber(string path, char charToCount)
        {
            int sumOfSpecificChar = CountCharByPositon(path, charToCount);
            int totalChar = CountChar(path, charToCount);

            if (totalChar == 0)
                return 0;

            if (charToCount == 'k')
                return totalChar * (sumOfSpecificChar / totalChar) * kNumber;

            return totalChar * (sumOfSpecificChar / totalChar) * cNumber;
        }

        private int GetMagicNumber(string path, char charToCount)
        {

            if (charToCount == 'k')
                return CountChar(path, charToCount) * kNumber;
            else
                return CountChar(path, charToCount) * cNumber;
        }

        /// <summary>
        /// Method who count number off specific charactere
        /// </summary>
        /// <param name="path"></param>
        /// <param name="charToCount"></param>
        /// <returns>number of occurence in a file</returns>
        private int CountChar(string path, char charToCount)
        {
            string file = File.ReadAllText(path);
            int nbOfChar = file.Count(c => char.ToUpperInvariant(c) == char.ToUpperInvariant(charToCount));
            return nbOfChar;
        }

        /// <summary>
        /// Method who get index of specific charactere and sum it 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="charToCount"></param>
        /// <returns></returns>
        private int CountCharByPositon(string path, char charToCount)
        {
            int res = 0;
            string file = File.ReadAllText(path);
            List<string> fileLine = file.Split('\n').ToList();
            List<int> foundIndexesOfSpecificChar = new List<int>();

            foreach (string line in fileLine)
            {
                for (int it = 0; it < line.Count(); it ++)
                {
                    if (char.ToUpperInvariant(line[it]) == char.ToUpperInvariant(charToCount))
                        foundIndexesOfSpecificChar.Add(it + 1);
                }
            }

            foreach(int item in foundIndexesOfSpecificChar)
                res += item;

            return res;
        }

    }
}

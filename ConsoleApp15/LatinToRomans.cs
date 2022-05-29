using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class LatinToRomans
    {
        public static string LatinToRomansMeth(int enteredNumber)
        {
            string total="";
            int onesDigit = enteredNumber % 10;
            int tensDigit = ((enteredNumber % 100)-onesDigit)/10;
            int hundredsDigit=((enteredNumber % 1000)-tensDigit-onesDigit)/100;
            int thousandDigit = (enteredNumber - hundredsDigit - tensDigit - onesDigit) / 1000;
            switch (enteredNumber.ToString().Length)
            {
                case 4:
                    total =ThousandDigit(thousandDigit) +HundredsDigitCalc(hundredsDigit)+TensDigitCalc(tensDigit)+OnesDigitCalc(onesDigit) ;
                    break;
                case 3:
                    total =HundredsDigitCalc(hundredsDigit) + TensDigitCalc(tensDigit) + OnesDigitCalc(onesDigit);
                    break;
                case 2:
                    total =TensDigitCalc(tensDigit) + OnesDigitCalc(onesDigit);
                    break;
                case 1:
                    total =OnesDigitCalc(onesDigit);
                    break;
            }
            return total;
        }
        private static string OnesDigitCalc(int onesDigit)
        {
            string total = "";
            if (onesDigit >= 9)
            {
                total += "IX";
            }
            else if (onesDigit >= 5)
            {
                total += "V";
                for (int i = 0; i < onesDigit - 5; i++)
                {
                    total += "I";
                }
            }
            else
            {
                if (onesDigit == 4)
                {
                    total += "IV";
                }
                else
                {
                    for (int i = 0; i < onesDigit; i++)
                    {

                        total += "I";
                    }
                }
            }
            return total;
        }
        private static string TensDigitCalc(int tensDigit)
        {
            string total = "";
            if (tensDigit >= 9)
            {
                total += "XC";
            }
            else if (tensDigit >= 5)
            {
                total += "L";
                for (int i = 0; i < tensDigit - 5; i++)
                {
                    total += "X";
                }
            }
            else
            {
                if (tensDigit == 4)
                {
                    total += "XL";
                }
                else
                {
                    for (int i = 0; i < tensDigit; i++)
                    {
                        total += "X";
                    }
                }
            }
            return total;
        }
        private static string HundredsDigitCalc(int hundredsDigit)
        {
            string total = "";
            if (hundredsDigit >= 9)
            {
                total += "CM";
            }
            else if (hundredsDigit >= 5)
            {
                total += "D";
                for (int i = 0; i < hundredsDigit - 5; i++)
                {
                    total += "C";
                }
            }
            else
            {
                if (hundredsDigit == 4)
                {
                    total += "CD";
                }
                else
                {
                    for (int i = 0; i < hundredsDigit; i++)
                    {
                        total += "C";
                    }
                }
            }
            return total;
        }
        private static string ThousandDigit(int thousandDigit)
        {
            string total = "";
            for (int i = 0; i < thousandDigit; i++)
            {
                total += 'M';
            }
            return total;
        }
    }
}

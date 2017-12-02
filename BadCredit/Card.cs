using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadCredit
{
    class Card
    {
        static private string _cardNumber;

        public Card(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public string ReturnsCardName()
        {
            string _invalid = "INVALID";
            if (!InputValidation(_cardNumber))
            {
                return _invalid;
            }
            else
            {
                if (PerformsMathCheck())
                {
                    if ((_cardNumber.Substring(0, 2) == "34" || _cardNumber.Substring(0, 2) == "37") && (_cardNumber.Length == 15))
                    {
                        return "American Express";
                    }
                    else if ((_cardNumber.Substring(0, 2) == "51" || _cardNumber.Substring(0, 2) == "52" || _cardNumber.Substring(0, 2) == "53" ||
                        _cardNumber.Substring(0, 2) == "54" || _cardNumber.Substring(0, 2) == "55") && (_cardNumber.Length == 16))
                    {
                        return "MasterCard";
                    }
                    else if ((_cardNumber.Substring(0, 1) == "4") && (_cardNumber.Length == 13 || _cardNumber.Length == 16))
                    {
                        return "Visa";
                    }
                    else
                    {
                        return _invalid;
                    }
                }
                else
                {
                    return _invalid;
                }
            }

        }

        static private bool InputValidation(string cardNumber)
        {
            string _cardNumber = cardNumber;
            if (_cardNumber.Length!=15 && _cardNumber.Length != 13 && _cardNumber.Length != 16)
            {
                return false;
            }
            else
            {
                foreach(var el in _cardNumber)
                {
                    short a;
                    if (!Int16.TryParse(Convert.ToString(el), out a))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        static private bool PerformsMathCheck()
        {
            int sumOfEven = 0;
            int sumOfOdd = 0;
            for(var i = 0; i < _cardNumber.Length; i++)
            {
                int temp = (int)Char.GetNumericValue(_cardNumber[i]);
                if (i % 2 == 1)
                {
                    sumOfEven += (temp * 2) / 10;
                    sumOfEven += (temp * 2) % 10;
                }
                else
                {
                    sumOfOdd += temp;
                }
            }
            if (((sumOfEven + sumOfOdd) % 10) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

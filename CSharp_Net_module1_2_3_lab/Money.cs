using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
        enum CurrencyTypes
    {
        UAH, 
        USD, 
        EU
    }

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public int Amount { get; set; }
        public CurrencyTypes CurrencyType { get; set; }


        // 3) declare parameter constructor for properties initialization
        public Money(int amount, CurrencyTypes currencyType)
        {
            Amount = amount;
            CurrencyType = currencyType;
        }
        public Money()
        {

        }

        // 4) declare overloading of operator + to add 2 objects of Money

        public static Money operator +(Money obj1, Money obj2)
        {
            Money sum = new Money();

            if (obj1.CurrencyType == obj2.CurrencyType)
            {
                sum.Amount = obj1.Amount + obj2.Amount;
                sum.CurrencyType = obj1.CurrencyType;
            }

            switch (obj1.CurrencyType)
            {
                case CurrencyTypes.USD:
                    if (obj2.CurrencyType == CurrencyTypes.EU)
                    {
                        sum.Amount = obj1.Amount + obj2.Amount * 2;
                        sum.CurrencyType = obj1.CurrencyType;
                    }
                    if (obj2.CurrencyType == CurrencyTypes.UAH)
                    {
                        sum.Amount = obj1.Amount + obj2.Amount * 20;
                        sum.CurrencyType = obj1.CurrencyType;
                    }
                    break;
                case CurrencyTypes.EU:
                    if (obj2.CurrencyType == CurrencyTypes.USD)
                    {
                        sum.Amount = obj1.Amount + (int)obj2.Amount / 2;
                        sum.CurrencyType = obj1.CurrencyType;
                    }
                    if (obj2.CurrencyType == CurrencyTypes.UAH)
                    {
                        sum.Amount = obj1.Amount + obj2.Amount * 30;
                        sum.CurrencyType = obj1.CurrencyType;
                    }
                    break;
                case CurrencyTypes.UAH:
                    if (obj2.CurrencyType == CurrencyTypes.USD)
                    {
                        sum.Amount = obj1.Amount + (int)obj2.Amount / 2;
                        sum.CurrencyType = obj1.CurrencyType;
                    }
                    if (obj2.CurrencyType == CurrencyTypes.EU)
                    {
                        sum.Amount = obj1.Amount + (int)obj2.Amount / 3;
                        sum.CurrencyType = obj1.CurrencyType;
                    }
                    break;
            }
            return sum;
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator --(Money obj1)
        {
            Money sum = new Money();

            sum.Amount = obj1.Amount - 1;
            sum.CurrencyType = obj1.CurrencyType;

            return sum;

        }

        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money obj1, Money obj2)
        {
            Money sum = new Money();

            sum.Amount = obj1.Amount * 3;
            sum.CurrencyType = obj1.CurrencyType;

            return sum;

        }

        // 7) declare overloading of operator > and < to compare 2 objects of Money

        public static bool operator >(Money obj1, Money obj2)
        {

            if (obj1.ConvertToCurrencyUAN() > obj2.ConvertToCurrencyUAN())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Money obj1, Money obj2)
        {
            if (obj1.ConvertToCurrencyUAN() < obj2.ConvertToCurrencyUAN())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // 8) declare overloading of operator true and false to check CurrencyType of object

        public static bool operator true(Money obj) 
        { 
         return obj.CurrencyType == CurrencyTypes.UAH;
        }
            
        public static bool operator false(Money obj) 
        {
         return obj.CurrencyType == CurrencyTypes.USD || obj.CurrencyType == CurrencyTypes.EU;
        }

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa

        public static explicit operator double (Money obj)
        {
            return (double)obj.Amount;
        }

        public static implicit operator string(Money obj)
        {
            return obj.CurrencyType.ToString();
        }

        public static explicit operator Money(double obj)
        {
            Money result = new Money();
            result.Amount = (int)obj;
            return result;
        }
        //public static explicit operator Money(string obj)
        //{
        //    Money result = new Money();
        //    //switch (obj)
        //    //{
        //    //    case (string)CurrencyTypes.USD :
        //    //        result.CurrencyType = CurrencyTypes.USD;
        //    //        break;

        //    //}

        //    ////result.CurrencyType = ;
        //    //return result;
        //}

        public int ConvertToCurrencyUAN()
        {
            int ret = new int();

            switch (this.CurrencyType)
            {
                case CurrencyTypes.USD:
                    ret = (int)this.Amount * 20;
                    break;
                case CurrencyTypes.EU:
                    ret = (int)this.Amount * 30;
                    break;
                case CurrencyTypes.UAH:
                    ret = (int)this.Amount;
                    break;
            }
            return ret;
        }
    }
    }

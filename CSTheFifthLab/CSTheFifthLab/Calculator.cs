using System;
using System.Collections.Generic;
using System.Text;

namespace CSTheFifthLab
{
    public static class Calculator
    {
        private static double result;

        public static void Count(View view, String data)
        {
            String[] splited;
            if ((splited = data.Split('/')).Length > 1) Devide(splited);else
            if ((splited = data.Split('*')).Length > 1) Multiply(splited);else
            if ((splited = data.Split('+')).Length > 1) Sum(splited);else
            if ((splited = data.Split('-')).Length > 1) Substract(splited);else
               throw new IncorrectOperationException("Incorrect operation");
            view.Write(result);
        }

        private static void Substract(string[] splited)
        {
            try
            {
                double minuend = Double.Parse(splited[0]);
                double substrahend = Double.Parse(splited[1]);
                result = minuend - substrahend;
            }
            catch (Exception e)
            {
                throw new IncorrectDataException("Incorrect data");
            }
        }

        private static void Sum(string[] splited)
        {
            try
            {
                double firstSummand = Double.Parse(splited[0]);
                double secondSummand = Double.Parse(splited[1]);
                result = firstSummand + secondSummand;
            }
            catch (Exception e)
            {
                throw new IncorrectDataException("Incorrect data");
            }
        }

        private static void Multiply(string[] splited)
        {
            try
            {
                double fistMultiplicand = Double.Parse(splited[0]);
                double secondMultiplicand = Double.Parse(splited[1]);
                result = fistMultiplicand * secondMultiplicand;
            }
            catch (Exception e)
            {
                throw new IncorrectDataException("Incorrect data");
            }
        }
         
        private static void Devide(string[] splited)
        {
            try
            {
                double dividend = Double.Parse(splited[0]);
                double divisor = Double.Parse(splited[1]);
                if(Math.Abs(divisor) < 0.0000000000000000000000000000000000000000001)
                {
                    throw new DivideByZeroException("Division by zero");
                }
                result = dividend / divisor;
            }
            catch (Exception e)
            {
                throw new IncorrectDataException("Incorrect data");
            }
        }
    }
}
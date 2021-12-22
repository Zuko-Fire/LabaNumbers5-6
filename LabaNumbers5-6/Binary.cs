using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaNumbers5_6
{
    internal class Binary : Integer
    {
        public override string Dec(string a)
        {
            try
            {
                int num1 = Convert.ToInt32(this.num, 2);
                int num2 = Convert.ToInt32(a, 2);
                string result = Convert.ToString((num1 - num2), 2);
                return result;
            }
            catch(Exception ex) 
            {
                return "Error";
            }
        }

        public override string Div(string a)
        {
            try
            {
                if (Convert.ToInt32(a) == 0) throw new Exception();
                int num1 = Convert.ToInt32(this.num, 2);
                int num2 = Convert.ToInt32(a, 2);
                string result = Convert.ToString((num1 / num2), 2);
                return result;
            }
            catch (Exception e)
            {
                return "Error";
            }
        }

        public override string getNum()
        {
            return this.num;
        }

        public override string Mul(string a)
        {
            try
            {
                int num1 = Convert.ToInt32(this.num, 2);
                int num2 = Convert.ToInt32(a, 2);
                string result = Convert.ToString((num1 * num2), 2);
                return result;
            }
            catch(Exception e) 
            {
                return "Error";
            }
        }

        public override string Plus(string a)
        {
            try
            {
                int num1 = Convert.ToInt32(this.num, 2);
                int num2 = Convert.ToInt32(a, 2);
                string result = Convert.ToString((num1 + num2), 2);
                return result;
            }
            catch(Exception e) 
            {
                return "Error";
            }
        }

        public override void setNum(string a)
        {
            this.num = a;
        }
        public string ToDecimal (string a)

        {
            try
            {
                return Convert.ToString(Convert.ToInt32(a, 2), 10);
            }
            catch(Exception e) 
            {
                return "Error";
            }
        }
        public string ToDecimal()

        {
            return Convert.ToString(Convert.ToInt32(this.num, 2), 10);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursTest
{
    public class Class1
    {
        public int DiscountPrice(int price)
        {
            int sum = ((price / 100) * 15) * price;
            return sum;
        }
        public string SalaryNotNull(int salary)
        {
            if (salary <= 0 || salary > 100000)
            {
                return "цена не может быть меньше или равана нулю  или больше 100000";
            }
            else
                return "Все правильно";
         }
        public Boolean LoginTrue(string login)
        {
            if (login == "Admin")
            {
                return true;
            }
            else
                return false;
        }
        public Boolean PasswordTrue(string paswword)
        {
            if (paswword == "1111")
            {
                return true;
            }
            else
                return false;
        }

    }
}

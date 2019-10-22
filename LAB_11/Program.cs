using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_11
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First Task

            //string[] Months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            //var n = 8;
            ////IEnumerable<string> month1 = from month in Months where month.Length == n select month;
            //IEnumerable<string> month1 = Months.Where(month => month.Length == n).Select(month => month);
            //foreach (var item in month1)
            //    Console.WriteLine(item);

            //Console.WriteLine("-----------------------");

            ////IEnumerable<string> month2 = from month in Months where month.StartsWith("J") || month.StartsWith("F") || month.StartsWith("Au") || month.StartsWith("D") select month;
            //IEnumerable<string> month2 = Months.Where(month => month.StartsWith("J") || month.StartsWith("F") || month.StartsWith("Au") || month.StartsWith("D")).Select(month => month);
            //foreach (var item in month2)
            //    Console.WriteLine(item);

            //Console.WriteLine("-----------------------");

            ////IEnumerable<string> month3 = from month in Months orderby month select month;
            //IEnumerable<string> month3 = Months.OrderBy(month => month).Select(month => month);
            //foreach (var item in month3)
            //    Console.WriteLine(item);

            //Console.WriteLine("-----------------------");

            ////IEnumerable<string> month4 = from month in Months where month.Contains("u") && month.Length > 3 select month;
            //IEnumerable<string> month4 = Months.Where(month => month.Contains("u") && month.Length > 3).Select(month => month);
            //foreach (var item in month4)
            //    Console.WriteLine(item);

            #endregion Task First

            #region Task Second and Third

            int[] marks1 = { 9, 9, 9, 9, 9 };
            Enrolle man1 = new Enrolle("Max", 18, 344, marks1);
            int[] marks2 = { 2, 5, 4, 3, 6};
            Enrolle man2 = new Enrolle("Dan", 19, 305, marks2);
            int[] marks3 = { 10, 6, 8, 9, 6 };
            Enrolle man3 = new Enrolle("Katya", 18, 318, marks3);
            int[] marks4 = { 10, 10, 9, 9, 9 };
            Enrolle man4 = new Enrolle("Dasha", 18, 287, marks4);
            int[] marks5 = { 10, 3, 8, 9, 6 };
            Enrolle man5 = new Enrolle("Pasha", 19, 300, marks5);
            List <Enrolle> list = new List<Enrolle>();
            list.Add(man1);
            list.Add(man2);
            list.Add(man3);
            list.Add(man4);
            list.Add(man5);
            foreach (var item in list)
                Console.WriteLine(item.ToString());
            Console.WriteLine("-----------------");

            //IEnumerable<Enrolle> querry1 = from item in list where item.marks.Min() < 4 select item;
            ////IEnumerable<Enrolle> querry1 = list.Select(marks => marks.marks).Select();
            //foreach (var item in querry1)
            //    Console.WriteLine(item.ToString());
            //Console.WriteLine("-----------------");

            //var sum = 40;
            ////IEnumerable<Enrolle> querry2 = from item in list where item.marks.Sum() > sum select item;
            //IEnumerable<Enrolle> querry2 = list.Where(man => man.marks.Sum() > sum).Select(man => man);
            //foreach (var item in querry2)
            //    Console.WriteLine(item.ToString());
            //Console.WriteLine("-----------------");

            ////IEnumerable<Enrolle> querry3 = from item in list where item.marks.Contains(10) select item;
            //IEnumerable<Enrolle> querry3 = list.Where(man => man.marks.Contains(10)).Select(man => man);
            //foreach (var item in querry3)
            //    Console.WriteLine(item.ToString());
            //Console.WriteLine("-----------------");

            ////IEnumerable<Enrolle> querry4 = from item in list orderby item.name select item;
            //IEnumerable<Enrolle> querry4 = list.OrderBy(man => man.name).Select(man => man);
            //foreach (var item in querry4)
            //    Console.WriteLine(item.ToString());
            //Console.WriteLine("-----------------");

            ////IEnumerable<Enrolle> querry5 = (from item in list orderby item.marks.Average() select item).Take(2);
            //IEnumerable<Enrolle> querry5 = list.OrderBy(man => man.marks.Average()).Select(man => man).Take(2);
            //foreach (var item in querry5)
            //    Console.WriteLine(item.ToString());
            //Console.WriteLine("-----------------");

            #endregion Task Second and Third

            #region Task Fourth

            var querry6 = from item in list where item.marks.Min() < 4 && item.marks.Contains(6) orderby item.Age group item by item.marks[0];
            //IEnumerable<Enrolle> querry1 = list.Select(marks => marks.marks).Select();
            foreach (var item in querry6)
            {
                Console.WriteLine(item.Key);
                foreach (var man in item)
                    Console.WriteLine(man.ToString());           
            }
            Console.WriteLine("-----------------");

            #endregion Task Fourth

            #region Task Fifth

            int[] mass = { 18, 2, 3, 4, 5 };
            var querry7 = from item in list join num in mass on item.Age equals num select new { Name = item.name, Num = num };
            foreach (var item in querry7)
                Console.WriteLine($"Name: {item.Name}\tNum: {item.Num}");

            #endregion Task Fift
        }
    }
}

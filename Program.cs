using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    class people
    {
        private int ID;
        private string name;
        private string email;

        public void People()
        {
            Console.Write("Nhập id: ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập email: ");
            email = Console.ReadLine();

        }
        public void showPeople()
        {
            Console.WriteLine("Id la: " + ID);
            Console.WriteLine("Ten la: " + name);
            Console.WriteLine("Email: " + email);
        }
    }


    class staff : people
    {
        private double salary;
        public void Staff()
        {
            Console.Write("Nhap luong: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        public void showSalary()
        {
            Console.WriteLine("mức lương: " + salary);
        }

    }
    class manage : staff
    {
        private int level;
        public void Level()
        {
            Console.Write("Nhap level: ");
            level = Convert.ToInt32(Console.ReadLine());
        }
        public void showLevel()
        {
            Console.WriteLine("level" + level);
        }
        static void Main(string[] args)
        {
            manage objManage = new manage();
            objManage.People();
            objManage.Staff();
            objManage.Level();
            objManage.showPeople();
            objManage.showSalary();
            objManage.showLevel();

            Console.ReadLine();

        }

    }

}



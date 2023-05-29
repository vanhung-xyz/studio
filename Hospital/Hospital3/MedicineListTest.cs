using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hospital2
{
    class MedicineListTest
    {
        static void Main(string[] args)
        {
            try
            {
                M objMedicines = new MedicineList
                objMedicines.AcceptDetails();
                objMedicines.DisplayDetails();
                char input = 'Y';
                do
                {
                    int choice;
                    Console.WriteLine("\nSelect one of the following options:");
                    Console.WriteLine("1. Sort\n 2. Remove\n 3. Reverse\n 4. Search\n 5. Exit");
                    Console.WriteLine("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            objMedicines.objPatientNames.Sort();
                            Console.WriteLine("\n-----After Sorting-----");
                            objMedicines.DisplayDetails();
                            break;
                        case 2:
                            if (objMedicines.Remove())
                            {
                                Console.WriteLine("\n----After Removing-----");
                                objMedicines.DisplayDetails();
                            }
                            else
                                Console.WriteLine("Patient with this name does not exist");
                            break;
                        case 3:
                            objMedicines.objPatientNames.Reverse();
                            Console.WriteLine("----After Reversing-----");
                            objMedicines.DisplayDetails();
                            break;
                        case 4:
                            objMedicines.Search();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid Data Entry!");
                            break;
                    }
                } while (input == 'Y' || input == 'y');

            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0}", objEx.Message);
            }
        }
    }
}s
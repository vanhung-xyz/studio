﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class DoctorTable
    {
        public Hashtable objDoctorDetails = new Hashtable();

        public void AcceptDetails()
        {
            string name;

            string address;

            char choice = 'Y';

            try
            {
                do
                {
                    Console.WriteLine("Enter the doctor's name : ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the address : ");
                    address = Console.ReadLine();

                    objDoctorDetails.Add(name, address);
                    Console.Write("Do you want to add more records [Y/N] : ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'Y' || choice == 'y');
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error : {0} ", objEx.Message);
            }
        }
        public void DisplayDetails()
        {
            ICollection objCollection = objDoctorDetails.Keys;

            Console.WriteLine("\nDetails of doctor : ");
            Console.WriteLine("Doctor's Name \t Address");
            Console.WriteLine("--------------\t -------");

            foreach (string details in objCollection)
            {
                Console.WriteLine(details + "\t\t" + objDoctorDetails[details]);
            }
            Console.WriteLine("Total number of doctors : " + objDoctorDetails.Count);
        }
        public bool Remove()
        {
            string choice;
            Console.WriteLine("Enter the name of the doctor : ");
            choice = Console.ReadLine();
            if (objDoctorDetails.ContainsKey(choice))
            {
                objDoctorDetails.Remove(choice);
                return true;
            }
            else
                return false;
        }
        public void Search()
        {
            string choice;
            Console.WriteLine("Enter the name of the doctor : ");
            choice = Console.ReadLine();
            if (choice != "")
            {
                if (objDoctorDetails.ContainsKey(choice))
                {
                    Console.WriteLine("Record Found! ");
                    Console.WriteLine("Doctor's Name : {0}", choice);

                    Console.WriteLine("Addresss : {0} ", objDoctorDetails[choice]);
                }
                else
                    Console.WriteLine("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}

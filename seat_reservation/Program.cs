 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seat_reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seats = new int[20];//seat array
            int seat_counter = 20;//to count leftover seats
            int seat_number;//to get the seat number from user
            int number_of_seats;//quantity of seat
            char choice = 'y';//to store user choice

            while (choice.Equals('y') || choice.Equals('Y'))
            {
                Console.Write("Enter the number of seats to book: ");
                number_of_seats = int.Parse(Console.ReadLine());
                if (number_of_seats <= seat_counter)
                {   
                    //This loop continue run number_of_seats time
                    for (int i = 0; i < number_of_seats; i++)
                    {
                        Console.Write("Enter the seat number: ");
                        seat_number = int.Parse(Console.ReadLine());

                        //logic for if seat is reserved or not
                        if (seats[seat_number - 1] != 1)
                        {
                            //setting seat status to reserved
                            seats[seat_number - 1] = 1;
                            //to count number of seat left
                            seat_counter--;
                        }
                        //logic for if seat number is already reserved
                        else
                        {
                            Console.WriteLine("Error Occured");
                            Console.WriteLine("That seat is already reserved");
                            Console.WriteLine("Try Again");
                            number_of_seats++;
                        }

                    }
                    
                    Console.Write("Do you want to book more?(Y/N) ");
                    choice = char.Parse(Console.ReadLine());
                }
                //Logic if all the seats are already reserved
                else
                {
                    Console.WriteLine("Movie is HouseFull");
                    Console.WriteLine("Exiting......");
                    break;
                }
            }
        }
    }
}

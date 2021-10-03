using System;
using System.Collections.Generic;

namespace Day14_Stack_QueueAssignment
{
    class Program
    {
        static void Main(string[] args)
        {


            //UC1_LinkedList List = new UC1_LinkedList();
            //List.Add(56);
            //List.Add(30);
            //List.Add(70);
            //List.Display();

            //#region LinkedList

            //UC2_LinkedList list = new UC2_LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();
            //#endregion


            //UC4_Insert_LinkedList List = new UC4_Insert_LinkedList();
            //List.Add(56);
            //List.Add(70);
            //List.InsertAtParticularPosition(2, 30);
            //List.Display();

            //UC3_Append_Linkedlist List = new UC3_Append_Linkedlist();
            //List.Add(56);
            //List.append(30);
            //List.append(70);

            //UC5_Delete_linkedlist List = new UC5_Delete_linkedlist();

            //List.Add(56);
            //List.Add(30);
            //List.Add(70);
            //List.pop();
            //List.Display();


            //UC6_Delete_Last_Linkedlist List = new UC6_Delete_Last_Linkedlist();

            //List.Add(56);
            //List.Add(30);
            //List.Add(70);
            //List.PopLast();
            //List.Display();


            //UC7_find_Linkedlist List = new UC7_find_Linkedlist();

            //List.Add(56);
            //List.Add(30);
            //List.Add(70);
            //List.Search(30);
            //List.Display();



            //#region UC8_InsertAtParticularPosition

            //UC8_Insert_Linkedlist list8 = new UC8_Insert_Linkedlist();
            //list8.Add(56);
            //list8.Add(30);
            //list8.Add(70);
            //list8.Display();
            //if (list8.Search(list8.head, 30))
            //{
            //    Console.WriteLine("\nYes,Serached Value(30) Found");
            //    list8.InsertAfter(list8.head.next, 40);
            //    Console.WriteLine("\n40 Inserted After Searched Value(30)");
            //    list8.Display();
            //}
            //else
            //    Console.WriteLine("Searched Value Not Found");



            //#endregion




            #region UC9_Delete_Showsize

            UC9_Linkedlist list9 = new UC9_Linkedlist();
            list9.Add(56);
            list9.Add(30);
            list9.Add(70);
            list9.Display();
            if (list9.Search(list9.head, 30))
            {
                Console.WriteLine("\nYes,Searched Value(30) Found");
                list9.InsertAfter(list9.head.next, 40);
                Console.WriteLine("\n40 Inserted After Searched Value(30)");
                list9.Display();
            }
            else
            {
                Console.WriteLine("Searched Value Not Found");
            }
            list9.DeleteNode(40);
            Console.WriteLine("\n40 Again Removed from List");
            list9.Display();
            Console.WriteLine("\nAfter Deleting the node the List Size is: " + list9.ShowListSize());

            #endregion








        }
    }

}

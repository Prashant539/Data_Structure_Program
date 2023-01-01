
using UnOrderedList;

namespace UnorderedList
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Programs!");
            Linkedlist<string> list= new Linkedlist<string>();
            //Linkedlist<string> list = new Linkedlist<string>();
            string txt = "My name is Prashant from gorakhpur";
            string[] textList = txt.Split(" ");
            foreach(var Data in textList)
               
            {
                
                list.Add(Data);
                ///Console.WriteLine(Data)
                list.Search("My");
               
            }
            list.Display();


        }
    }
}

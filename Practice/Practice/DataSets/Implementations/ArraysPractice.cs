using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Resources:
// https://msdn.microsoft.com/en-us/library/ms379570(v=vs.80).aspx 

namespace Practice.DataSets
{
    class ArraysPractice
    {
        public static void HowToCreateAndResizeLists()
        {
            List<string> listExampleEmpty = new List<string>();
            listExampleEmpty.Add("Hello");
            listExampleEmpty.Add("World");

            List<int> listExample = new List<int> { 1, 2 };

            List<string> listExampleWithInitialSize = new List<string>(100);
            listExampleWithInitialSize[99] = "Hey";
        }

        public static void HowToCreateAndResizeArrayLists()
        {
            ArrayList arrayListExample = new ArrayList();

            arrayListExample.Add(1);
            arrayListExample.Add("");
            arrayListExample.Add(new Guid()); // Being able to add every time into the ArrayList would require the developer to check
                                              // the type of all objects before performing operations on them
        }

        public static void HowToCreateAnArray()
        {
            int[] arrayExampleEmpty = new int[3]; // Create an empty array of size 3
            arrayExampleEmpty[0] = 1; // Overwrite default values of 0 with the appropriate values 
            arrayExampleEmpty[1] = 2;
            arrayExampleEmpty[2] = 3;

            int[] arrayExample = { 1, 2, 3, 4, 5 }; // Create a populated array of size 5
        }

        public static void HowToResizeAnArray()
        {
            int[] arrayExample = { 1, 2, 3, 4, 5 };

            int[] temp = new int[20]; // Create an empty temp array of the required size 
            arrayExample.CopyTo(temp, 0); // Copy all elements from existing array to the new one
            arrayExample = temp; // Assing temp array to the initial array
        }
    }
}

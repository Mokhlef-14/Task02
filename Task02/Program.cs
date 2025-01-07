namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            char selection = '\0';
            int sum = 0;
            double Mean = 0;

            do
            {

                Console.WriteLine("****************************************\n");
                Console.WriteLine("<<< Press any button from below >>>\n");
                Console.WriteLine("(Dublicated numbers not allowed)\n"); //additional functionality
                Console.WriteLine("P - print numbers");
                Console.WriteLine("A - Add numbers");
                Console.WriteLine("M - Display mean of the numbers ");
                Console.WriteLine("S - Display smallest number");
                Console.WriteLine("L - Display largest number");
                Console.WriteLine("K - Sort the list (Bubble sort)"); //additional functionality
                Console.WriteLine("C - Clear an element "); //task2
                Console.WriteLine("F - Find an element "); // task2
                Console.WriteLine("Q - Quit\n");
                Console.WriteLine("****************************************");

                selection = Convert.ToChar(Console.ReadLine());

                switch (selection)
                {

                    /******************************************* print the list ***********************************************/
                    case 'P':
                    case 'p':


                        if (myList.Count == 0)

                        {
                            Console.WriteLine("the list is empty : [   ]\n");
                            break;
                        }

                        Console.WriteLine("[ ");

                        for (int i = 0; i < myList.Count; i++)
                        {


                            if (i == 0)
                            {
                                Console.Write(" [ ");

                            }
                            Console.Write(myList[i]);
                            Console.Write(" ");

                            //if (i < myList.Count - 1)
                            //{
                            //    Console.Write(" ");
                            //}
                        }

                        Console.WriteLine("]");



                        break;

                    /******************************************* Add number to the list *****************************************/
                    case 'A':
                    case 'a':

                        int counter = 0;
                        int len = myList.Count;
                        
                        Console.WriteLine("enter your number to add\n");

                        int number = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i <= len - 1; i++)
                        {

                            if (number == myList[i])
                            {

                                counter++;                                
                                break;
                            }

                        }
                        if (counter >= 1)
                        {
                            Console.WriteLine("number is entered before");
                        }
                        else
                        {
                            myList.Add(number);

                        }
                        break;


                    /******************************************* Calculate the mean of the numbers ******************************/

                    case 'M':
                    case 'm':

                        if (myList.Count == 0)
                        {
                            Console.WriteLine("The list is empty!");
                            break;
                        }
                        else
                        {

                            for (int i = 0; i < myList.Count; i++)
                            {
                                sum += myList[i];
                                Mean = sum / myList.Count;

                            }
                        }
                        Console.WriteLine($" Mean = {Mean} \n");
                        break;

                    /******************************************* Get the smallest number ***********************************/
                    case 'S':
                    case 's':


                        if (myList.Count == 0)
                        {
                            Console.WriteLine("The list is empty!");
                            break;
                        }

                        int min = myList[0];

                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (myList[i] < min)
                            {
                                min = myList[i];
                            }
                        }

                        Console.WriteLine($" the smallest number is = {min}\n");
                        break;
                    /******************************************* Get the largest number *************************************/
                    case 'L':
                    case 'l':


                        if (myList.Count == 0)
                        {
                            Console.WriteLine("The list is empty!");
                            break;
                        }

                        int max = myList[0];

                        for (int i = 0; i < myList.Count; i++)
                        {
                            if (myList[i] > max)
                            {
                                max = myList[i];
                            }
                        }

                        Console.WriteLine($" the biggest number is = {max}\n");

                        break;
                    /******************************************* sort the list  ****************************************/
                    case 'K':
                    case 'k':

                        int size = myList.Count;
                        int temp;

                        for (int i = 0; i < size - 1; i++)
                        {
                            for (int j = 0; j < size - 1 - i; j++)
                            {
                                if (myList[j] > myList[j + 1])
                                {
                                    temp = myList[j];
                                    myList[j] = myList[j + 1];
                                    myList[j + 1] = temp;
                                }
                            }
                        }

                        for (int i = 0; i < myList.Count; i++)
                        {


                            if (i == 0)
                            {
                                Console.Write(" [");

                            }
                            Console.Write(myList[i]);
                            if (i < myList.Count - 1)
                            {
                                Console.Write(" ");
                            }
                        }

                        Console.WriteLine(" ]");


                        break;
                    /******************************************* Clear the list *****************************************/
                    case 'C':
                    case 'c':
                        myList.Clear();
                        Console.WriteLine("the list is empty now!");
                        break;
                    /******************************************* find a number in the list ******************************/
                    case 'F':
                    case 'f':

                        int flag = 0;
                        int length = myList.Count;
                        int index = 0;

                        Console.WriteLine("please enter a value to search");
                        int value = Convert.ToInt32(Console.ReadLine());



                        for (int i = 0; i <= length - 1; i++)
                        {


                            if (value == myList[i])
                            {

                                flag++;
                                index = i;
                                break;


                            }

                        }
                        if (flag == 1)
                        {
                            Console.WriteLine($"The element {value} is found at index {index}.");
                        }
                        else
                        {
                            Console.Write($"{value} Not found !\n");

                        }
                        break;

                    case 'Q':
                    case 'q':
                        Console.WriteLine("Exiting ...");
                        break;

                    default:
                        Console.WriteLine("invalid choice!!,Please try again");
                        break;
                }


            }

            while ((selection != 'Q') && (selection != 'q'));
            

        
            
        Console.WriteLine("GoodBye");
            








            }
        }
}

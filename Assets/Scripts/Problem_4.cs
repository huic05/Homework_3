using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_4 : MonoBehaviour
{
    /* Create a List of numbers that are odd and are divisible by the number 7 between 1 and 144.
     * You should have a list that looks like this 7, 21, 35, 49, 63, 77, 91, 105, 119, 133
     * Declare an array that's half the size of the list and save every other number from the list into the array 
     * You should have a array that looks like this 7, 35, 63, 91, 119
    */

    void Start()
    {
        List<int> numbers = new List<int>();
        for (int n = 1; n <= 144) ;
        {
            if (n % 2 == 1 && n % 7 == 0) ;
            {
                numbers.add(n);
            }
        }
        print(numbers);
        int[] half = new int[5];
        
    }
}

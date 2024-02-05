/**********************************************************************************************************************
// File Name : Arrays.cs
// Author : David Galmines
// Creation Date : January 25, 2024
//
// Brief Description : This script adds the sum of integers in an array, arranges floats in an array in reverse order,
                       and reorganizes the character positions in strings in an array to read backwards.
**********************************************************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //declares float array of 5 numbers with decimals
    private float[] fArray = { 1.23f, 4.56f, 7.89f, 10.11f, 12.13f };

    //declares integer array for 5 integers
    private int[] iArray = { 4, 54, 275, 9, 7 };

    //declares string array of 5 strings
    private string[] sArray = { "Trix", "are", "for", "kids", "insert 5th word" };

    /// <summary>
    /// Reverses order of floats, adds integers, and calls function to reverse the letter order of strings
    /// </summary>
    void Start()
    {
        //takes the floats in fArray, and arranges them in reverse order
        for (int i = fArray.Length - 1; i >= 0; i--)
        {
            print(fArray[i]);
        }

        //takes the integers in iArray, and adds the values together until all the integers in the array are added
        int sum = 0;
        for (int j = 0; j < iArray.Length; j++)
        {
            sum = sum + iArray[j];
            print(sum);
        }

        //calls function that reverses the character order of a string in sArray 5 times (once for each string)
        for (int k = 0; k < 5; k++)
        {
            ReverseXorMethod(sArray[k]);
        }
    }

    /// <summary>
    /// Divides a single string into its characters, and arranges them in reverse order
    /// </summary>
    /// <param name="stringToReverse">the array containing strings (sArray)</param>
    void ReverseXorMethod(string stringToReverse)
    {
        //declares and defines a new array made up of sArray's characters
        var charArray = stringToReverse.ToCharArray();

        //declares and defines how many characters make up the string that is being reversed
        var len = stringToReverse.Length - 1;

        //rearranges the characters through XOR comparisons
        //len variable subtracts after each loop to end the loop in the middle of the string
        for (int m = 0; m < len; m++, len--)
        {
            //identifies the latter half of characters, and replaces the first half (in order still) (BOING => ING)
            charArray[m] ^= charArray[len];

            //replaces the latter half of characters with the first half (now in reverse order) (ING => IOB)
            charArray[len] ^= charArray[m];

            //adds the latter half of characters to the beginning of the new string (in reverse order) (IOB => GNIOB)
            charArray[m] ^= charArray[len];
        }
        //displays the reversed string in the console window
        print(new string(charArray));
    } 
}

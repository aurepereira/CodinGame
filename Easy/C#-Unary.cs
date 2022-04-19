// https://www.codingame.com/training/easy/unary

// STATEMENT
// Your program must encode a string into a series of zeros.
// A string is an encoded form of digital values and you have to transform those values into a new format.


// SOLUTION
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(string[] args)
    {
        string MESSAGE = Console.ReadLine();
        string binaryT = "";
        Regex regex = new Regex(@"(1*)(0*)");

        // Convert MESSAGE to binary
        // Get binary representation of character, and pad result with 0 
        // to match 7-bit expected value.
        for (int i = 0; i < MESSAGE.Length; i++) {
            binaryT += Convert.ToString(MESSAGE[i], 2).PadLeft(7, '0');
        }

        // Display unary representation of string
        Console.WriteLine(UnaryConvert(binaryT).Trim());
    }

    // Convert binary to unary
    public static string UnaryConvert(string binary) {
        char[] tokenArray = binary.ToArray();
        string result = string.Empty;
        char prevToken = '\0';

        for (int i = 0; i < tokenArray.Length; i++) {
            char currentToken = tokenArray[i];

            if (prevToken != '1' && currentToken == '1') 
            {
                result += " 0 0";
                prevToken = '1';
            }
            else if (prevToken != '0' && currentToken == '0') 
            {
                result += " 00 0";
                prevToken = '0';
            }
            else 
            {
                result += "0";
            }
        }
        return result;
    }
}

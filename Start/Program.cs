using EnumerableTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskTest tt = new TaskTest();
            tt.GetUppercaseStrings_Should_Return_Uppercased_Strings();
            tt.GetStringsLength_Should_Return_Strings_Length();
            tt.GetSquareSequence_Should_Return_Square_Items();
            tt.GetMovingSumSequence_Should_Return_Moving_Sum_Items();
            tt.GetEvenItems_Should_Return_EvenItems();
            tt.GetEvenItems_Should_Return_Empty_If_Sequence_Length_Is_Less_Than_2();
            tt.GetPrefixItems_Should_Return_Items_Started_With_Required_Prefix();
            tt.GetPrefixItems_Should_Return_Empty_Sequence_If_No_Items_With_Required_Prefix();
            tt.GetPrefixItems_Should_Raise_Exception_If_Prefix_Is_Null();
            tt.PropagateItemsByPostionIndex_Should_Return_Right_Results();
            tt.GetUsedChars_Should_Return_List_of_Chars();
            tt.GetStringOfSequence_Should_Return_Right_Results();
            tt.Get3TopItems_Should_Return_Square_Items();
            tt.GetCountOfGreaterThen10_Should_Return_Right_Result();
            tt.GetFirstContainsFirst_Should_Return_Right_Result();
            tt.GetCountOfStringsWithLengthEqualsTo3_Should_Return_Right_Result();
            tt.GetCountOfStrings_Should_Return_Right_Result();
            tt.GetCountOfStringsWithMaxLenght_Should_Return_Right_Result();
             //tt.GetSpecificEventEntriesCount_Should_Return_Right_Result();
            tt.GetDigitCharsCount_Should_Return_Number_Of_Digit_Chars();
            tt.GetDigitCharsCount_Should_Throw_ArgumentException_If_data_Is_Null();
             //tt.GetIEnumerableTypesNames_Should_Return_Right_Results();
            tt.GetQuarterSales_Should_Return_Right_Results();
            tt.SortStringsByLengthAndAlphabet_Should_Return_Right_Results();
            tt.GetMissingDigits_Should_Return_Right_Results();
            tt.SortDigitNamesByNumericOrder_Should_Return_Right_Results();
            tt.CombineNumbersAndFruits_Should_Return_Right_Results();
            tt.GetCommonChars_Should_Return_Right_Results();
            tt.GetStringsOnly_Should_Return_Right_Results();
            tt.GetSumOfAllInts_Should_Return_Right_Results();
            tt.GetTotalStringsLength_Should_Return_Right_Results();
            tt.IsSequenceHasNulls_Should_Return_Right_Results();
            tt.IsAllStringsAreUppercase_Should_Return_Right_Results();
            tt.GetFirstNegativeSubsequence_Should_Return_Right_Results();
            tt.AreNumericListsEqual_Should_Return_Right_Results();
            tt.GetNextVersionFromList_Should_Return_Right_Results();
            tt.GetSumOfVectors_Should_Return_Right_Results();
            tt.GetProductOfVectors_Should_Return_Right_Results();
            tt.GetAverageOfDoubleValues_Should_Return_Right_Results();

            Console.ReadKey();
        }
    }
}

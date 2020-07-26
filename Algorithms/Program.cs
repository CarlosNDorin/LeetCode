using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int programToChose = -1;

            while (programToChose != 0)
            {
                Console.WriteLine("Choose a program:");
                Console.WriteLine("1:Two Sum");
                Console.WriteLine("2:Add Two Numbers");
                Console.WriteLine("3:Longest SubString Without Repeating Chars");
                Console.WriteLine("4:Median Of Two Sorted Arrays");
                Console.WriteLine("5:Longest Palindromic Substring");
                Console.WriteLine("6:ZigZag Conversion");
                Console.WriteLine("7:Reverse Integer");
                Console.WriteLine("8:String to Integer (atoi)");
                Console.WriteLine("9:Palindrome Number");
                Console.WriteLine("10:Regular Expression Matching");
                Console.WriteLine("11:Container With Most Water");
                Console.WriteLine("12:Integer To Roman");
                Console.WriteLine("13:Roman To Integer");
                Console.WriteLine("14:Longest Common Prefix");
                Console.WriteLine("15:3 Sum");
                Console.WriteLine("16:3 Sum Closest");
                Console.WriteLine("17:letter Combinations of a Phone Number");
                Console.WriteLine("18:4 Sum");
                Console.WriteLine("19:Remove Nth Node From End of List");
                Console.WriteLine("20:Valid Parentheses");
                Console.WriteLine("21:MergeTwoSortedLists");
                Console.WriteLine("22:Generate Parentheses");
                Console.WriteLine("23:Merge k Sorted Lists");
                Console.WriteLine("24.Swap Nodes in Pairs");
                Console.WriteLine("25.Reverse Nodes in k - Group");
                Console.WriteLine("26.Remove Duplicates from Sorted Array");
                Console.WriteLine("27.Remove Element");
                Console.WriteLine("28.Implement strStr()");
                Console.WriteLine("29.Divide Two Integers");
                Console.WriteLine("30.Substring with Concatenation of All Words");
                Console.WriteLine("31.Next Permutation");
                Console.WriteLine("32.Longest Valid Parentheses");
                Console.WriteLine("33.Search in Rotated Sorted Array");
                Console.WriteLine("34.Find First and Last Position of Element in Sorted Array");
                Console.WriteLine("35.Search Insert Position");
                Console.WriteLine("36.Valid Sudoku");
                Console.WriteLine("37.Sudoku Solver");
                Console.WriteLine("38.Count and Say");
                Console.WriteLine("39.Combination Sum");
                Console.WriteLine("40.Combination Sum II");
                Console.WriteLine("41.First_Missing_Positive");
                Console.WriteLine("42.Trapping_Rain_Water");
                Console.WriteLine("43.Multiply Strings");
                Console.WriteLine("44.Wildcard Matching");
                Console.WriteLine("45.Jump Game II");
                Console.WriteLine("46.Permutations");
                Console.WriteLine("53.Maximum Subarray");
                Console.WriteLine("58.LengthOfLastWord");
                Console.WriteLine("66.PlusOne");
                Console.WriteLine("67.Add Binary");
                Console.WriteLine("69.Sqrt(x)");
                Console.WriteLine("70.ClimbStairs");
                Console.WriteLine("83.Remove Duplicates from Sorted List");
                Console.WriteLine("88.Merge Sorted Array");
                Console.WriteLine("100.Same Tree");
                Console.WriteLine("101. Symmetric Tree");
                Console.WriteLine("104. Maximum Depth of Binary Tree");
                Console.WriteLine("107. Binary Tree Level Order Traversal II");
                Console.WriteLine("108. Convert Sorted Array to Binary Search ");
                Console.WriteLine("110. Balanced Binary Tree");
                Console.WriteLine("111. Minimum Depth of Binary Tree");
                Console.WriteLine("112. Path Sum");
                Console.WriteLine("118. PascalsTriangle");
                Console.WriteLine("119. PascalsTriangleII");
                Console.WriteLine("121. Best Time to Buy and Sell Stock");
                Console.WriteLine("122. Best Time to Buy and Sell StockII");
                Console.WriteLine("125. Valid Palindrome");
                Console.WriteLine("136. Single Number");
                Console.WriteLine("155. Min Stack");
                Console.WriteLine("160. IntersectionofTwoLinkedLists");

                Console.WriteLine("0:Exit");
                programToChose = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (programToChose)
                {
                    case -1:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.Bubble(new int[] { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 });
                        break;
                    case 1:
                        Console.WriteLine("Two Sum");
                        TwoSum twosum = new TwoSum();
                        int[] nums = { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };
                        int[] sum = twosum.Twosum(nums, 542);
                        Console.WriteLine(sum[0] + "," + sum[1]);
                        break;

                    case 2:
                        Console.WriteLine("Add Two Numbers");
                        AddTwoNumber addTwo = new AddTwoNumber();
                        AddTwoNumber.ListNode l1 = new AddTwoNumber.ListNode(0);
                        AddTwoNumber.ListNode l2 = new AddTwoNumber.ListNode(0);
                        AddTwoNumber.ListNode tempNode = l1;
                        for (int i = 1; i < 10; i++)
                        {
                            tempNode.next = new AddTwoNumber.ListNode(i);
                            tempNode = tempNode.next;
                        }
                        tempNode = l2;
                        for (int i = 1; i < 10; i++)
                        {
                            tempNode.next = new AddTwoNumber.ListNode(i);
                            tempNode = tempNode.next;
                        }
                        AddTwoNumber.ListNode answer = addTwo.AddTwoNumbers(l1, l2);
                        while (answer != null)
                        {
                            Console.Write(answer.val);
                            answer = answer.next;
                        }
                        Console.WriteLine("");
                        break;

                    case 3:
                        Console.WriteLine("Longest SubString Without Repeating Chars");
                        LongesSubStringWithoutRepeatingCharacters longest = new LongesSubStringWithoutRepeatingCharacters();
                        Console.WriteLine(longest.LongestSubString("asdfgd"));
                        break;

                    case 4:
                        Console.WriteLine("Median Of Two Sorted Arrays");
                        int[] a = { 1, 2 };
                        int[] b = { 3, 4 };
                        medianOfTwoSortedArrays median = new medianOfTwoSortedArrays();
                        median.sortedMerge(a, b);
                        break;

                    case 5:
                        Console.WriteLine("Longest Palindromic Substring");
                        LongestPalindromicSubstring pali = new LongestPalindromicSubstring();
                        string check = pali.longestPalindromeSubstring("kyyrjtdplseovzwjkykrjwhxquwxsfsorjiumvxjhjmgeueafubtonhlerrgsgohfosqssmizcuqryqomsipovhhodpfyudtusjhonlqabhxfahfcjqxyckycstcqwxvicwkjeuboerkmjshfgiglceycmycadpnvoeaurqatesivajoqdilynbcihnidbizwkuaoegmytopzdmvvoewvhebqzskseeubnretjgnmyjwwgcooytfojeuzcuyhsznbcaiqpwcyusyyywqmmvqzvvceylnuwcbxybhqpvjumzomnabrjgcfaabqmiotlfojnyuolostmtacbwmwlqdfkbfikusuqtupdwdrjwqmuudbcvtpieiwteqbeyfyqejglmxofdjksqmzeugwvuniaxdrunyunnqpbnfbgqemvamaxuhjbyzqmhalrprhnindrkbopwbwsjeqrmyqipnqvjqzpjalqyfvaavyhytetllzupxjwozdfpmjhjlrnitnjgapzrakcqahaqetwllaaiadalmxgvpawqpgecojxfvcgxsbrldktufdrogkogbltcezflyctklpqrjymqzyzmtlssnavzcquytcskcnjzzrytsvawkavzboncxlhqfiofuohehaygxidxsofhmhzygklliovnwqbwwiiyarxtoihvjkdrzqsnmhdtdlpckuayhtfyirnhkrhbrwkdymjrjklonyggqnxhfvtkqxoicakzsxmgczpwhpkzcntkcwhkdkxvfnjbvjjoumczjyvdgkfukfuldolqnauvoyhoheoqvpwoisniv");
                        Console.WriteLine(check);
                        break;
                    case 6:
                        Console.WriteLine("ZigZag Conversion");
                        ZigZagConversion zigZag = new ZigZagConversion();
                        zigZag.Convert1("PAYPALISHIRING", 4);
                        Console.WriteLine(zigZag.Convert("ABC", 2));
                        break;
                    case 7:
                        Console.WriteLine("ReverseInteger");
                        ReverseInteger reverseInteger = new ReverseInteger();
                        Console.WriteLine(reverseInteger.Reverse(-2147483648));
                        break;
                    case 8:
                        Console.WriteLine("String to Integer (atoi)");
                        StringtoIntegerAtoi stringtoIntegerAtoi = new StringtoIntegerAtoi();
                        Console.WriteLine(stringtoIntegerAtoi.MyAtoi("+11e530408314"));
                        break;
                    case 9:
                        Console.WriteLine("Palindrome Number");
                        PalindromeNumber palindromeNumber = new PalindromeNumber();
                        Console.WriteLine(palindromeNumber.IsPalindrome(121));
                        break;
                    case 10:
                        Console.WriteLine("Regular Expression Matching");
                        RegularExpressionMatching regularExpressionMatching = new RegularExpressionMatching();
                        Console.WriteLine(regularExpressionMatching.IsMatch("", ""));
                        break;
                    case 11:
                        Console.WriteLine("Container With Most Water");
                        ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();
                        int[] height = { 1, 7, 3, 4, 5 };
                        Console.WriteLine(containerWithMostWater.MaxArea(height));
                        break;
                    case 12:
                        Console.WriteLine("Integer To Roman");
                        IntegertoRoman integertoRoman = new IntegertoRoman();
                        Console.WriteLine(integertoRoman.IntToRoman(2000));
                        break;
                    case 13:
                        Console.WriteLine("Roman To Integer");
                        RomanToInteger romanToInteger = new RomanToInteger();
                        Console.WriteLine(romanToInteger.RomanToInt("MCMXCIV"));
                        break;
                    case 14:
                        Console.WriteLine("Longest Common Prefix");
                        LongestcommonPrefix longestcommonPrefix = new LongestcommonPrefix();
                        string[] stringToSend = { "flight", "flow", "fligaro" };
                        Console.WriteLine(longestcommonPrefix.LongestCommonPrefix(stringToSend));
                        break;
                    case 15:
                        Console.WriteLine("3Sum");
                        ThreeSumClass threeSum = new ThreeSumClass();
                        int[] threeNumsArray = { -13, 5, 13, 12, -2, -11, -1, 12, -3, 0, -3, -7, -7, -5, -3, -15, -2, 14, 14, 13, 6, -11, -11, 5, -15, -14, 5, -5, -2, 0, 3, -8, -10, -7, 11, -5, -10, -5, -7, -6, 2, 5, 3, 2, 7, 7, 3, -10, -2, 2, -12, -11, -1, 14, 10, -9, -15, -8, -7, -9, 7, 3, -2, 5, 11, -13, -15, 8, -3, -7, -12, 7, 5, -2, -6, -3, -10, 4, 2, -5, 14, -3, -1, -10, -3, -14, -4, -3, -7, -4, 3, 8, 14, 9, -2, 10, 11, -10, -4, -15, -9, -1, -1, 3, 4, 1, 8, 1 };
                        Console.WriteLine(threeSum.ThreeSum(threeNumsArray));
                        break;
                    case 16:
                        Console.WriteLine("3SumClosest");
                        threeSumClose ThreeSumClosest = new threeSumClose();
                        int[] threeNumsArrayCloset = { 1, 1, -1, -1, 3 };
                        Console.WriteLine(ThreeSumClosest.ThreeSumClosest(threeNumsArrayCloset, 1));
                        break;
                    case 17:
                        Console.WriteLine("Letter Combinations of a Phone Number");
                        LetterCombinationsofaPhoneNumber letterCombinations = new LetterCombinationsofaPhoneNumber();
                        Console.WriteLine(letterCombinations.LetterCombinations("23"));
                        break;
                    case 18:
                        Console.WriteLine("4Sum");
                        _4Sum _4Sum = new _4Sum();
                        int[] fourSum = { -3, -2, -1, 0, 0, 1, 2, 3 };
                        Console.WriteLine(_4Sum.FourSum(fourSum, 0));
                        break;
                    case 19:
                        Console.WriteLine("Remove_Nth_Node_From_End_of_List");
                        Remove_Nth_Node_From_End_of_List remove_Nth_Node_From_End = new Remove_Nth_Node_From_End_of_List();
                        Remove_Nth_Node_From_End_of_List.ListNode newList = new Remove_Nth_Node_From_End_of_List.ListNode(0);
                        Remove_Nth_Node_From_End_of_List.ListNode ln1 = newList;
                        for (int i = 1; i < 10; i++)
                        {
                            ln1.next = new Remove_Nth_Node_From_End_of_List.ListNode(i);
                            ln1 = ln1.next;
                        }
                        Console.WriteLine(remove_Nth_Node_From_End.RemoveNthFromEnd(newList, 1));
                        break;
                    case 20:
                        Console.WriteLine("Valid Parentheses");
                        Valid_Parentheses valid_Parentheses = new Valid_Parentheses();
                        Console.WriteLine(valid_Parentheses.IsValid("[([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([([(["));
                        break;
                    case 21:
                        Console.WriteLine("MergeTwoSortedLists");
                        break;
                    case 22:
                        Console.WriteLine("22. Generate Parentheses");
                        List<string> result = new List<string>();
                        Generate_Parentheses generate_Parentheses = new Generate_Parentheses();
                        generate_Parentheses.Dfs(result, "", 5, 5);
                        Console.WriteLine(result);
                        break;
                    case 23:
                        Console.WriteLine("23. Merge k Sorted Lists");
                        Merge_k_Sorted_Lists merge_K_Sorted_Lists = new Merge_k_Sorted_Lists();
                        merge_K_Sorted_Lists.MergeKLists(merge_K_Sorted_Lists.CreateListNodes());
                        break;
                    case 24:
                        Console.WriteLine("24. Swap Nodes in Pairs");
                        SwapNodesinPairs swapNodesinPairs = new SwapNodesinPairs();
                        swapNodesinPairs.SwapPairs(swapNodesinPairs.createList(5));
                        break;
                    case 25:
                        Console.WriteLine("25. Reverse Nodes in k-Group");
                        ReverseNodesink_Group reverseNodesink_Group = new ReverseNodesink_Group();
                        reverseNodesink_Group.ReverseKGroup(reverseNodesink_Group.createList(8), 3);
                        break;
                    case 26:
                        Console.WriteLine("26.Remove Duplicates from Sorted");
                        Remove_Duplicates_from_Sorted_Array remove_Duplicates_From_Sorted_Array = new Remove_Duplicates_from_Sorted_Array();
                        int[] n = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
                        Console.WriteLine(remove_Duplicates_From_Sorted_Array.removeDuplicatesfromSortedArray(n));
                        break;
                    case 27:
                        Console.WriteLine("27. Remove Element");
                        Remove_Element remove_Element = new Remove_Element();
                        int[] x = { 0, 1, 2, 2, 3, 0, 4, 2 };
                        Console.WriteLine(remove_Element.RemoveElement(x, 2));
                        break;
                    case 28:
                        Console.WriteLine("28. Implement strStr()");
                        ImplementstrStr implementstrStr = new ImplementstrStr();
                        Console.WriteLine(implementstrStr.StrStr("mississippi", "pi"));
                        implementstrStr.prefix("ATCACATCATCA");
                        implementstrStr.prefix2("ATCACATCATCA");
                        implementstrStr.KMP("hello", "ll");
                        break;

                    case 29:
                        Console.WriteLine("29. Divide Two Integers");
                        DivideTwoIntegers divideTwoIntegers = new DivideTwoIntegers();
                        Console.WriteLine(divideTwoIntegers.Divide(2147483647, 1));
                        break;

                    case 30:
                        Console.WriteLine("30. Substring with Concatenation of All Words");
                        SubstringwithConcatenationofAllWords substringwithConcatenationofAllWords = new SubstringwithConcatenationofAllWords();
                        string[] stringToSend30 = new string[] { "foo", "bar" };
                        substringwithConcatenationofAllWords.FindSubstring("barfoothefoobarman", stringToSend30);
                        break;

                    case 31:
                        Console.WriteLine("31.Next Permutation");
                        NextPermutation nextPermutation = new NextPermutation();
                        int[] intList = { 3, 2, 1 };
                        nextPermutation.nextPermutation(intList);
                        break;

                    case 32:
                        Console.WriteLine("32. Longest Valid Parentheses");
                        LongestValidParentheses longestValidParentheses = new LongestValidParentheses();
                        Console.WriteLine(longestValidParentheses.longestvalidparentheses("((()))"));
                        break;

                    case 33:
                        Console.WriteLine("33. Search in Rotated Sorted Array");
                        Search_in_Rotated_Sorted_Array search_In_Rotated_Sorted_Array = new Search_in_Rotated_Sorted_Array();
                        int[] searchIn = { 4, 5, 6, 0, 1, 2, 3 };
                        Console.WriteLine(search_In_Rotated_Sorted_Array.Search(searchIn, 0));
                        break;

                    case 34:
                        Console.WriteLine("34. Find First and Last Position of Element in Sorted Array");
                        FindFirstandLastPositionofElementinSortedArray findFirstandLastPositionofElementinSortedArray = new FindFirstandLastPositionofElementinSortedArray();
                        int[] numsFirstLast = { 8, 8 };
                        findFirstandLastPositionofElementinSortedArray.SearchRange(numsFirstLast, 8);
                        break;
                    case 35:
                        Console.WriteLine(" 35.Search Insert Position");
                        SearchInsertPosition searchInsertPosition = new SearchInsertPosition();
                        int[] numsInsertPosition = { 1, 3, 5, 6 };
                        searchInsertPosition.SearchInsert(numsInsertPosition, 5);
                        break;

                    case 36:
                        Console.WriteLine(" 36.Valid Sudoku");
                        ValidSudoku validSudoku = new ValidSudoku();
                        var arr = new char[][] {
                        new char[] {'5','3','.','.','7','.','.','.','.'},
                        new char[] {'6','.','.','1','9','5','.','.','.'},
                        new char[] {'.','9','8','.','.','.','.','6','.'},
                        new char[] {'8','.','.','.','6','.','.','.','3'},
                        new char[] {'4','.','.','8','.','3','.','.','1'},
                        new char[] {'7','.','.','.','2','.','.','.','6'},
                        new char[] {'.','6','.','.','.','.','2','8','.'},
                        new char[] {'.','.','.','4','1','9','.','.','5'},
                        new char[] {'.','.','.','.','8','.','.','7','9'}
                        };

                        validSudoku.IsValidSudoku(arr);
                        break;

                    case 37:
                        Console.WriteLine("37. Sudoku Solver");
                        SudokuSolver sudokuSolver = new SudokuSolver();
                        var arr1 = new char[][] {
                        new char[] {'5','3','.','.','7','.','.','.','.'},
                        new char[] {'6','.','.','1','9','5','.','.','.'},
                        new char[] {'.','9','8','.','.','.','.','6','.'},
                        new char[] {'8','.','.','.','6','.','.','.','3'},
                        new char[] {'4','.','.','8','.','3','.','.','1'},
                        new char[] {'7','.','.','.','2','.','.','.','6'},
                        new char[] {'.','6','.','.','.','.','2','8','.'},
                        new char[] {'.','.','.','4','1','9','.','.','5'},
                        new char[] {'.','.','.','.','8','.','.','7','9'}
                        };
                        sudokuSolver.SolveSudoku(arr1);
                        break;

                    case 38:
                        Console.WriteLine("38. Count and Say");
                        CountandSay countandSay = new CountandSay();
                        Console.WriteLine(countandSay.CountAndSay(3));
                        break;

                    case 39:
                        Console.WriteLine("39. Combination Sum");
                        CombinationSum combinationSum = new CombinationSum();
                        combinationSum.combinationSum(new int[] { 2, 3, 6, 7 }, 7);
                        break;

                    case 40:
                        Console.WriteLine("40. Combination Sum II");
                        CombinationSum2 combinationSum2 = new CombinationSum2();
                        combinationSum2.combinationSum2(new int[] { 10, 1, 2, 7, 6, 1, 5 }, 8);
                        break;
                    case 41:
                        Console.WriteLine("First_Missing_Positive");
                        First_Missing_Positive first_Missing_Positive = new First_Missing_Positive();
                        Console.WriteLine(first_Missing_Positive.FirstMissingPositive(new int[] { 3, 4, -1, 1 }).ToString());
                        break;
                    case 42:
                        Console.WriteLine("42.Trapping_Rain_Water");
                        Console.WriteLine(new Trapping_Rain_Water().Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
                        break;
                    case 43:
                        Console.WriteLine("43. Multiply Strings");
                        Console.WriteLine(new MultiplyStrings().Multiply("123", "321"));
                        break;
                    case 44:
                        Console.WriteLine("44. Wildcard Matching");
                        Console.WriteLine(new WildcardMatching().IsMatch("adceb", "*a*b"));
                        break;
                    case 45:
                        Console.WriteLine("45. Jump Game II");
                        Console.WriteLine(new JumpGameII().Jump(new int[] { 2, 3, 1, 1, 4 }));
                        break;
                    case 46:
                        Console.WriteLine("46. Permutations");
                        Console.WriteLine(new Permutations().Permute(new int[] { 1, 2, 3 }));
                        break;
                    case 47:
                        Console.WriteLine("47. PermutationsII");
                        Console.WriteLine(new PermutationsII().PermuteUnique(new int[] { 2, 2, 1, 1 }));
                        break;
                    /*  case 48:
                          Console.WriteLine("48. Rotate Image");
                          int[,] matrix = new int[3,3] {  { 1, 2, 3 }, { 4, 5, 6, }, { 7, 8, 9 }  };
                          Console.WriteLine(new RotateImage().Rotate(matrix));
                          break;
                          */
                    case 49:
                        Console.WriteLine("49. GroupAnagrams");
                        Console.WriteLine(new GroupAnagrams().groupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" }));
                        break;

                    case 50:
                        Console.WriteLine("50. Pow(x,n)");
                        Console.WriteLine(new Pow().MyPow(2.0, -2));
                        break;

                    case 51:
                        Console.WriteLine("51. NQueens");
                        Console.WriteLine(new NQueens().SolveNQueens(4));
                        break;

                    case 52:
                        Console.WriteLine("52. NQueensII");
                        Console.WriteLine(new NQueensII().TotalNQueens(4));
                        break;

                    case 53:
                        Console.WriteLine("53. Maximum Subarray");
                        Console.WriteLine(new Maximum_Subarray().MaxSubArray(new int[] { -2, 1 }));
                        break;

                    case 54:
                        Console.WriteLine("54. Spiral Matrix");
                        Console.WriteLine(new SpiralMatrix().SpiralOrder(new int[][] {
                        new int[] {1,2,3},
                        new int[] {4,5,6},
                        new int[] {7,8,9}
                        }));
                        break;

                    case 55:
                        Console.WriteLine("55. JumpGame");
                        Console.WriteLine(new JumpGame().CanJump(new int[] { 2, 3, 1, 1, 4 }));
                        break;

                    case 56:
                        Console.WriteLine("56. Merge Intervals");
                        Console.WriteLine(new MergeIntervals().Merge(new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } }));
                        break;

                    case 58:
                        Console.WriteLine("58. LengthOfLastWord");
                        Console.WriteLine(new LengthofLastWord().LengthOfLastWord("a "));
                        break;

                    case 66:
                        Console.WriteLine("66. Plus One");
                        Console.WriteLine(new PlusOne().plusOne(new int[] { 9 }));
                        break;

                    case 67:
                        Console.WriteLine("67. Add Binary");
                        Console.WriteLine(new AddBinary().addBinary("1010", "1011"));
                        break;

                    case 69:
                        Console.WriteLine("69. Sqrt(x)");
                        Console.WriteLine(new SqrtX().MySqrt(26));
                        break;
                    case 70:
                        Console.WriteLine("70. ClimbStairs");
                        Console.WriteLine(new ClimbingStairs().climbStairs(6));
                        break;
                    case 83:
                        Console.WriteLine("83. Remove Duplicates from Sorted List");
                        Console.WriteLine(new RemoveDuplicatesfromSortedList().DeleteDuplicates(new RemoveDuplicatesfromSortedList().createList(5)));
                        break;
                    case 88:
                        Console.WriteLine("88. Merge Sorted Array");
                        new MergeSortedArray().Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);
                        break;

                    case 100:
                        Console.WriteLine("100. Same Tree");
                        SameTree sameTree = new SameTree();
                        Console.WriteLine(sameTree.IsSameTree(sameTree.createTree(), sameTree.createTree()));
                        break;
                    case 101:
                        Console.WriteLine("101. Symmetric Tree");
                        SymmetricTree symmetricTree = new SymmetricTree();
                        Console.WriteLine(symmetricTree.IsSymmetric(symmetricTree.createTree()));
                        break;
                    case 104:
                        Console.WriteLine("104. Maximum Depth of Binary Tree");
                        MaximumDepthofBinaryTree maximumDepthofBinaryTree = new MaximumDepthofBinaryTree();
                        Console.WriteLine(maximumDepthofBinaryTree.MaxDepth(maximumDepthofBinaryTree.createTree()));
                        break;
                    case 107:
                        Console.WriteLine("107. Binary Tree Level Order Traversal II");
                        BinaryTreeLevelOrderTraversalII binaryTreeLevelOrderTraversalII = new BinaryTreeLevelOrderTraversalII();
                        Console.WriteLine(binaryTreeLevelOrderTraversalII.LevelOrderBottom(binaryTreeLevelOrderTraversalII.createTree()));
                        break;
                    case 108:
                        Console.WriteLine("108. Convert Sorted Array to Binary Search ");
                        ConvertSortedArraytoBinarySearchTree convertSortedArraytoBinarySearchTree = new ConvertSortedArraytoBinarySearchTree();
                        Console.WriteLine(convertSortedArraytoBinarySearchTree.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 }));
                        break;
                    case 110:
                        Console.WriteLine("110. Balanced Binary Tree");
                        BalancedBinaryTree balancedBinaryTree = new BalancedBinaryTree();
                        Console.WriteLine(balancedBinaryTree.IsBalanced(balancedBinaryTree.createTree()));
                        break;
                    case 111:
                        Console.WriteLine("111. Minimum Depth of Binary Tree");
                        MinimumDepthofBinaryTree minimumDepthofBinaryTree = new MinimumDepthofBinaryTree();
                        Console.WriteLine(minimumDepthofBinaryTree.MinDepth(minimumDepthofBinaryTree.createTree()));
                        break;
                    case 112:
                        Console.WriteLine("112. Path Sum");
                        PathSum pathSum = new PathSum();
                        Console.WriteLine(pathSum.HasPathSum(pathSum.createTree(), 6));
                        break;
                    case 118:
                        Console.WriteLine("118. PascalsTriangle");
                        Console.WriteLine(new PascalsTriangle().Generate(2));
                        break;
                    case 119:
                        Console.WriteLine("119. PascalsTriangleII");
                        Console.WriteLine(new PascalsTriangleII().GetRow(2));
                        break;
                    case 121:
                        Console.WriteLine("121. Best Time to Buy and Sell Stock");
                        Console.WriteLine(new BestTimetoBuyandSellStock().MaxProfit(new int[] { 2, 4, 1 }));
                        break;
                    case 122:
                        Console.WriteLine("122. Best Time to Buy and Sell StockII");
                        Console.WriteLine(new BestTimetoBuyandSellStockII().MaxProfit(new int[] { 2, 4, 1 }));
                        break;
                    case 125:
                        Console.WriteLine("125. Valid Palindrome");
                        Console.WriteLine(new ValidPalindrome().IsPalindrome("A man, a plan, a canal: Panama"));
                        break;
                    case 136:
                        Console.WriteLine("136. Single Number");
                        Console.WriteLine(new SingleNumber().singleNumber(new int[] { 2, 2, 1 }));
                        break;
                    case 155:
                        Console.WriteLine("155. Min Stack");
                        // Console.WriteLine(new SingleNumber().singleNumber(new int[] { 2, 2, 1 }));
                        break;
                    case 160:
                        Console.WriteLine("160. IntersectionofTwoLinkedLists");
                        // Console.WriteLine(new SingleNumber().singleNumber(new int[] { 2, 2, 1 }));
                        break;
                    case 167:
                        Console.WriteLine("167. Two Sum II - Input array is sorted");
                        Console.WriteLine(new TwoSumIIInputarrayissorted().TwoSum(new int[] { 2, 3, 4 }, 6));
                        break;
                    case 168:
                        Console.WriteLine("168. Excel Sheet Column Title");
                        Console.WriteLine(new ExcelSheetColumnTitle().ConvertToTitle(701));
                        break;
                    case 169:
                        Console.WriteLine("169. Majority Element");
                        Console.WriteLine(new MajorityElement().Majorityelement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
                        break;
                    case 171:
                        Console.WriteLine("171. Excel Sheet Column Number");
                        Console.WriteLine(new ExcelSheetColumnNumber().TitleToNumber("AB"));
                        break;
                    case 189:
                        Console.WriteLine("189. Rotate Array");
                        new RotateArray().Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3);
                        break;
                    case 190:
                        Console.WriteLine("190. Reverse Bits");
                        Console.WriteLine(new ReverseBits().reverseBits(43261596));
                        break;
                    case 198:
                        Console.WriteLine("198. House Robber");
                        Console.WriteLine(new HouseRobber().Rob(new int[] { 2, 1, 1, 2 }));
                        break;
                    case 202:
                        Console.WriteLine("202.  HappyNumber");
                        Console.WriteLine(new HappyNumber().IsHappy(2));
                        break;
                    case 204:
                        Console.WriteLine("204.  CountPrimes");
                        Console.WriteLine(new CountPrimes().Countprimes(3));
                        break;
                    case 205:
                        Console.WriteLine("205.  IsomorphicStrings");
                        Console.WriteLine(new IsomorphicStrings().IsIsomorphic("foo", "bar"));
                        break;
                    case 206:
                        Console.WriteLine("206.  ReverseLinkedList");
                        ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
                        Console.WriteLine(reverseLinkedList.ReverseList(reverseLinkedList.createList(5)));
                        break;
                    case 217:
                        Console.WriteLine("217.  Containsduplicate");
                        Console.WriteLine(new ContainsDuplicate().Containsduplicate(new int[] { 1, 2, 3, 4, 4 }));
                        break;
                    case 219:
                        Console.WriteLine("217.  ContainsDuplicateII");
                        Console.WriteLine(new ContainsDuplicateII().ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1));
                        break;

                    case 225:
                        Console.WriteLine("225. Implement Stack using Queues");
                        ImplementStackusingQueues.MyStack implementStackusingQueues = new ImplementStackusingQueues.MyStack();
                        implementStackusingQueues.Push(1);
                        implementStackusingQueues.Push(2);
                        implementStackusingQueues.Push(3);
                        Console.WriteLine(implementStackusingQueues.Top());
                        break;

                    case 232:
                        Console.WriteLine("232. Implement Queue Using Stacks");
                        break;

                    case 234:
                        Console.WriteLine("234. Palindrome Linked List");
                        PalindromeLinkedList palindromeLinkedList = new PalindromeLinkedList();
                        Console.WriteLine(palindromeLinkedList.IsPalindrome(palindromeLinkedList.createList(4)));
                        break;

                    case 242:
                        Console.WriteLine("242. Valid Anagram");
                        Console.WriteLine(new ValidAnagram().IsAnagram("aacc", "ccac"));
                        break;

                    case 258:
                        Console.WriteLine("258. AddDigits");
                        Console.WriteLine(new AddDigit().AddDigits(38));
                        break;

                    case 263:
                        Console.WriteLine("263. UglyNumbers");
                        Console.WriteLine(new UglyNumber().IsUgly(-2147483648));
                        break;

                    case 268:
                        Console.WriteLine("268. MissingNumber");
                        Console.WriteLine(new MissingNumber().Missingnumber(new int[] { 3, 0, 1 }));
                        break;

                    case 283:
                        Console.WriteLine("283. MoveZeroes");
                        new MoveZeroes().Movezeroes(new int[] { 3, 0, 1 });
                        break;
                    case 290:
                        Console.WriteLine("290. Wordpattern");
                        Console.WriteLine(new WordPattern().Wordpattern("abba", "dog cat cat dog"));
                        break;
                    case 292:
                        Console.WriteLine("292. Nim Game");
                        Console.WriteLine(new NimGame().CanWinNim(8));
                        break;
                    case 299:
                        Console.WriteLine("299. BullsandCows");
                        Console.WriteLine(new BullsandCows().GetHint("1123", "0111"));
                        break;
                    case 303:
                        Console.WriteLine("303. Range Sum Query - Immutable");
                        NumArray numArray = new NumArray(new int[] { -2, 0, 3, -5, 2, -1 });
                        Console.WriteLine(numArray.SumRange(2, 5));
                        break;
                    case 326:
                        Console.WriteLine("326. Power of Three");
                        Console.WriteLine(new PowerofThree().IsPowerOfThree(243));
                        break;
                    case 344:
                        Console.WriteLine("344. Reverse String");
                        new ReverseString().reverseString(new char[] { 'H', 'a', 'n', 'n', 'a', 'h' });
                        break;
                    case 349:
                        Console.WriteLine("349. Intersection Of Two Arrays");
                        new IntersectionofTwoArrays().Intersection(new int[] { 1, 2, 3 }, new int[] { 2, 3, 4 });
                        break;
                    case 350:
                        Console.WriteLine("350. Intersection Of Two Arrays II");
                        new IntersectionOfTwoArraysII().Intersect(new int[] { 1, 2, 2, 3 }, new int[] { 2, 2, 3, 4 });
                        break;
                    case 345:
                        Console.WriteLine("345. Reverse Vowels of a String");
                        Console.WriteLine(new ReverseVowelsofaString().ReverseVowels("LeetCode"));
                        break;
                    case 367:
                        Console.WriteLine("367. Valud Perfect Square");
                        Console.WriteLine(new ValidPerfectSquare().IsPerfectSquare(14));
                        break;
                    case 371:
                        Console.WriteLine("371. SumOfTwoIntegers");
                        Console.WriteLine(new SumofTwoIntegers().GetSum(-1, 5));
                        break;
                    case 374:
                        Console.WriteLine("374. Guess Number High Or Lower");
                        Console.WriteLine(new GuessNumberHighOrLower(2).GuessNumber(2));
                        break;
                    case 387:
                        Console.WriteLine("387. First Unique Character in a String");
                        Console.WriteLine(new FirstUniqueCharacterinaString().FirstUniqChar("cc"));
                        break;
                    case 389:
                        Console.WriteLine("389. First Unique Character in a String");
                        Console.WriteLine(new FindtheDifference().FindTheDifference("abc", "abcd"));
                        break;
                    case 392:
                        Console.WriteLine("392. IsSubsequence");
                        Console.WriteLine(new IsSubsequence().IsASubsequence("Ahbgdc", "abc"));
                        break;
                    case 401:
                        Console.WriteLine("401. BinaryWatch");
                        Console.WriteLine(new BinaryWatch().ReadBinaryWatch(1));
                        break;
                    case 404:
                        Console.WriteLine("404. SumOfLeftLeaves");
                        break;
                    case 405:
                        Console.WriteLine("405. Convert a Number to Hexadecimal");
                        Console.WriteLine(new ConvertaNumbertoHexadecimal().ToHex(111111));
                        break;
                    case 409:
                        Console.WriteLine("409. Longestpalindrome");
                        Console.WriteLine(new LongestPalindrome().Longestpalindrome("civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth"));
                        break;
                    case 412:
                        Console.WriteLine("412. FizzBuzz");
                        Console.WriteLine(new FizzBuzz().Fizzbuzz(15));
                        break;
                    case 414:
                        Console.WriteLine("414. Third Maximum Number");
                        Console.WriteLine(new ThirdMaximumNumber().ThirdMax(new int[] { 1, 2 }));
                        break;
                    case 415:
                        Console.WriteLine("415. Add String");
                        Console.WriteLine(new AddStrings().Addstrings("9", "99"));
                        break;
                    case 416:
                        Console.WriteLine("416. Partition Equal Subset Sum");
                        Console.WriteLine(new PartitionEqualSubsetSum().CanPartition(new int[] { 1, 5, 11, 5 }));
                        break;

                    case 417:
                        Console.WriteLine("417. Pacific Atlantic Water Flow");
                         Console.WriteLine(new PacificAtlanticWaterFlow().PacificAtlantic(new int[,] { { 1, 2, 2, 3, 5 },{ 3, 2, 3, 4, 4 },{ 2, 4, 5, 3, 1 },{ 6, 7, 1, 4, 5 },{ 5, 1, 1, 2, 4 } }));
                        break;

                    case 419:
                        Console.WriteLine("419. Battleships in a Board");
                        var matrix = new char[3][];
                        matrix[0] = new char[] { 'X', '.', '.', 'X' };
                        matrix[1] = new char[] { '.', '.', '.', 'X' };
                        matrix[2] = new char[] { '.', '.', '.', 'X' };
                        //matrix[3] = new char[] { '.', '.', '.', 'X' };
                        Console.WriteLine(new BattleshipsinaBoard().CountBattleships(matrix));
                        break;


                    case 5555:
                        testing testing = new testing();
                        testing.test();
                        break;

                    default: break;   
                }
            }
            Console.WriteLine("Bye");
        }
    }
}

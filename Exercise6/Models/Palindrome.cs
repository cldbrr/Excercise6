using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercise6.Models
{
    public class Palindrome
    {
        [Display(Name = "Number")]
        [Range(1, long.MaxValue, ErrorMessage = "The value must be greater than 0")]
        public long PalindromeValue { get; set; }

        public bool IsPalindrome
        {
            get
            {
                string palindromeString = this.PalindromeValue.ToString();
                int palindromeLength = palindromeString.Length;

                for (int i = 0; i < palindromeLength; i++)
                {
                    if (palindromeString[i] != palindromeString[palindromeLength - 1 - i])
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
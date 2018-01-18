using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lucky_number_model.Models
{
    public class LuckyNumber
    {
        private decimal balance;
        private int [] nums  = new int [3];

        Random rnd = new Random();

        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Please choose a number between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number
        public string Message
        { get
            {
                if (Balance <= 0)
                    return "Game Over: Spin To Try Again";

                return " ";
            }
            set
            {

            }
        }
        [Required]
        public decimal Balance {
            get
            {
                if (isWinner)
                    return balance + 2; 
                else
                    return balance;
            }
            set
            {
                this.balance = value;
            }
        } // the balance for this game
        public int [] Spinner
        {
            get
            {
                
                for(int i = 0; i< nums.Length; i++)
                {
                    
                    nums[i] = rnd.Next(0, 10);
                    if (nums[i] == Number)
                        isWinner = true; 
                }
                
                return nums;
            }
            set
            {

            }
        }
        public Boolean isWinner { get; set; } // a flag for when the lucky number matches the spin
    }
}
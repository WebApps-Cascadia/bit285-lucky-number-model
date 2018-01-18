using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lucky_number_model.Models
{
    public class LuckyNumber
    {
        private decimal _balance;
        //private Boolean _iswinner;
        //private int[] _spinner = new int[3];

        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number

        [Required]
        public decimal Balance {
            get
            {
                return _balance;
            }
            set {
                if (isWinner == true)
                {
                    _balance += 2;
                }
                else {
                    _balance = value;
                }
            } } // the balance for this game
        public Boolean isWinner { get; set; } // a flag for when the lucky number matches the spin
        public string message {
            get
            {
                if (_balance <= 0)
                {
                    return "GAME OVER: Spin to try again";
                }
                return "";
            }
            set
            {

            }
        }
        //make smart property that will set is winner to true if any of three randomly generated integers equals lucky number
        /*public int[] Spinner
        {
            get{

            }
            set{
            }
        }*/
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lucky_number_model.Models
{
    public class LuckyNumber
    {
        private int _balance;
        private Boolean _isWinner;
        private int[] _spinner;

        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number

        [Required]
        public decimal Balance
        {
            get
            {
                //if the _isWinner is true then add 2 to balance.
                return _balance;
            }
            set
            {
                _balance = value;
            }
         } // the balance for this game

        // TODO - Make this a smart property that will set _isWinner to true
        public Boolean isWinner { get; set; } // a flag for when the lucky number matches the spin

        public string Message
        {
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
 
        public int[] Spinner
        {
            get
            {

            }

            set
            {

            }
        }
    }

}
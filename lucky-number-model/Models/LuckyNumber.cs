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
        private Boolean _iswinner;
        private int[] _spinner= new int[3];
        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number

        [Required]
        public decimal Balance
        {
            get
            {
                if(isWinner==true)
                {
                    _balance += 1;
                }
                else if(isWinner==false)
                {
                    _balance -= 1;
                }
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }// the balance for this game

        public Boolean isWinner {
            get
            {
                if (_spinner[0] == Number || _spinner[1] == Number || _spinner[2] == Number)
                {
                    _iswinner = true;
                }
                else
                {
                    _iswinner = false;
                }
                return _iswinner;
            }
            set
            {

            }
        } // a flag for when the lucky number matches the spin

        public string Message
        {
            get
            {
                if (_balance <= 0)
                {
                    _balance = 4;
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
                var rand1 = new System.Random();
                _spinner[0] = rand1.Next(0, 10);
                _spinner[1] = rand1.Next(0, 10);
                _spinner[2] = rand1.Next(0, 10);
                return _spinner;
            }
            set
            {

            }
        }
    }
}
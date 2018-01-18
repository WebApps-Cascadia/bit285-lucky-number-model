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
        private int[] _spinner = new int[3];

        private Random _rnd = new Random();

        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number

        // the balance for this game
        [Required]
        public decimal Balance
        {
            get
            {
                if (isWinner) { _balance = _balance + 2; }
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public Boolean isWinner { get; set; } // a flag for when the lucky number matches the spin

        public string GameMessage
        {
            get
            {
                if (Balance <= 0) { return "GAME OVER: Spin to try again!"; }
                return "";
            }
            set
            {

            }
        }

        //public int[] spinner
        //{
        //    get
        //    {
        //        for (int i = 0; i <= 2; i++)
        //        {
        //            spinner[i] = _rnd.Next(1, 10);
        //        }
        //        return spinner;
        //    }
        //    set
        //    {

        //    }
        //}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lucky_number_model.Models
{
    public class LuckyNumber
    {
        private Random rand = new Random();
        private int startingBalance = 4;

        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number

        public int[] Spinner
        {
            get
            {
                if (this.Balance <= 0)
                {
                    GameMessage = "GAME OVER: Spin to try again";
                    Balance = startingBalance;
                    return _Spinner;
                }

                this.Balance = this.Balance - 1;

                this._Spinner[0] = rand.Next(0, 10);
                this._Spinner[1] = rand.Next(0, 10);
                this._Spinner[2] = rand.Next(0, 10);

                if (_Spinner[0] == this.Number || _Spinner[1] == this.Number || _Spinner[2] == this.Number)
                    isWinner = true;
                else
                    isWinner = false;

                return _Spinner;
            }
            set
            {
                this._Spinner = value;
            }
        }

        public int[] _Spinner = new int[3];

        [Required]
        public decimal Balance
        {
            get
            {
                if (isWinner)
                {
                    this.balance = this.balance + 2;
                }
                return this.balance;
            }

            set
            {
                this.balance = value;
            }

        }

        private decimal balance;


        public Boolean isWinner {
            get
            {
                return _isWinner;
            }
            set
            {
                _isWinner = value;
            }
        } // a flag for when the lucky number matches the spin
        private Boolean _isWinner;

        public String GameMessage { get; set; }
    }
}
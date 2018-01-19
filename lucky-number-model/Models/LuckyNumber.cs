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
        private bool _isWinner;
        private int[] _spinner = new int[3];
        

        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number

        [Required]
        public int Balance {
            get
            {
                //if (_spinner[0] == Number || _spinner[1] == Number || _spinner[2] == Number)
                //{
                //    _isWinner = true;
                //    _balance += 1;
                //}
                //else
                //{
                //    _isWinner = false;
                //    _balance -= 1;
                //} 
                //cannot figure out why it's not working correctly.
                return _balance;
            }
                set
            {
                
                _balance = value;
            }
                } // the balance for this game

        //TO MAKE THIS A SMART PROPERTY AND SET WINNER TO TRUE AND SPIN MATCHES LUCKY NUMBER
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

        public string Message {
            get
            {
                if (Balance <= 0)
                {
                    return "GAME OVER: Spin to try again";//message for the game
                }
                return "";
            }

            set
            {

            }
        }

        public int[] Spinner {

            get
            {
                var rnd = new System.Random();
                _spinner[0] = rnd.Next(1, 10);
                _spinner[1] = rnd.Next(1, 10);
                _spinner[2] = rnd.Next(1, 10);
                return _spinner;
            }
                set
            {
                _spinner = value;
            }
        }
        
    }
    
}
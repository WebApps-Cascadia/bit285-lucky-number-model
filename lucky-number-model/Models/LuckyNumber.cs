using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lucky_number_model.Models
{
    public class LuckyNumber
    {
        private decimal _Balance;
        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number
        //adding a new GameMessage property to the model that takes the place of the ViewBag.Error
        public string GameMessage {
            get
            {
                if(_Balance <= 0)
                {
                    return "GAME OVER: Spin to try again!!!";
                }
                return "";
            }
        }
        //adding a new getter & setter to the Balance property to check the isWinner,
        //if true, Balance = Balance + 2
        [Required]
        public decimal Balance
        {
            get
            {
                if(isWinner== true)
                {
                    return _Balance = _Balance + 2;
                }
                return _Balance;
            }
            set
            {
                _Balance = value;
            }
            // the balance for this game
        }
        public Boolean isWinner { get; set; } // a flag for when the lucky number matches the spin
        private int[] _spinner;
        
        

    }
}
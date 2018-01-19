using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lucky_number_model.Models
{
    public class LuckyNumber
    {
        [Required]
        [Display(Name = "Lucky Number")]
        [Range(1, 9, ErrorMessage = "Number must be between 1 and 9")]
        public int Number { get; set; } // the user's choice of a lucky number

        [Required]
        public decimal Balance { get; set; }


        // the balance for this game

        public string GameMessage;

        
        public int[] Spinner
        {
            get
            {
                isWinner = false;
                int[] Spinner = new int[3];
               
                Random rng = new Random();
                for (int i = 0; i < 2; i++)
                {
                    Spinner[i] = rng.Next(1, 10);
                }
                if (Spinner[0] == Number || Spinner[1] == Number || Spinner[2] == Number)
                {
                    isWinner = true;
                }
                
                

                return Spinner;
            }
        }
        public Boolean isWinner;
    }
}
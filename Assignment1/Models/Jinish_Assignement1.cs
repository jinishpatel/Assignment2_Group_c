using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace Assignment1.Models;



public class Jinish_Assignement1
{



    [Required(ErrorMessage = "Please first enter Weight of the body.")]
    public decimal? Weight_236 { get; set; }

    [Required(ErrorMessage = "Please first enter height of the body.")]
    public decimal? Height_236 { get; set; }
    public decimal? CalculateBMI()
    {
        decimal? BMI_236 = 0;

        BMI_236 = (Weight_236 / (Height_236 * Height_236)) * 703;
        return Math.Round((decimal)BMI_236, 2); 
    }
}

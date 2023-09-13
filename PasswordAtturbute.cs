using DataAccessLayer;
using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVC.Custom_Validations
{
    public class PasswordAtturbute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value ,ValidationContext validationContext)
        {
            string name = value.ToString();
            string pass = ((UserViewModel)validationContext.ObjectInstance).Password;
            if(name == pass)
            {
                ValidationResult res = new ValidationResult("name and password must be diffrend");
                return res;
            }
            return ValidationResult.Success;
        }
    }
}
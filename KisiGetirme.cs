using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVC.Custom_Validations
{
    public class KisiGetirme:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value.ToString().ToLower() == "Gurkan".ToLower())
            {
                ErrorMessage = "sen glemezsin.";
                return false;
            }
            return true;
        }
    }
}
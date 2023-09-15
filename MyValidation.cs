using DAL.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Haberler.Validation
{
    public class MyValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                EditorRepository edt = new EditorRepository();
                foreach (var item in edt.List())
                {
                    if (value.ToString() == item.UserName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
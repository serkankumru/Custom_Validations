﻿using FirstMVC.Custom_Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="bu alan acayip gereklidir")]
        [PasswordAtturbute]
        public string UserName { get; set; }
        [KisiGetirme]
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        //[Range(5,15,ErrorMessage ="bişeyler bişeyler.")]
        public int UserType { get; set; }

[Required]
[Range(1,int.MaxValue,ErrorMessage ="Product must be selected")]
public int ProductId { get; set; }

public int BannerType { get; set; }//0:head,1bottom,2middle

[ForeignKey("ProductId")]
public virtual Product Product { get; set; }

[NotMapped]
public string ImageUrl
{
    get
    {
        return "/MyImages/" + Product.Id + "_" + Product.ProductImages.First(c => c.IsMain).Id+".jpg";
    }
}
        
    }
}



namespace Shop.Web.Entities
{
    using Shop.Web.Data.Entities;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product  : IEntity
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The filed {0} onlz can only contain {1} characters length.")]
        [Required]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public double Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        public string ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.ImageUrl))
                {
                    return null;
                }

                return $"https://shopzulu.azurewebsites.net{this.ImageUrl.Substring(1)}";
            }
        }


        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { get; set; }
    }

}


using System.ComponentModel.DataAnnotations;

namespace CurdOperationWithDapperNetCoreMVC_Demo.Models
{
    public class ProductModel
    {
        public Guid ProductId { get; set; }

        [Display(Name = "Product")]
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        [Display(Name = "Description")]
        public string ProdcutDescription { get; set; }

        [Display(Name = "Created")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Updated")]
        public DateTime? UpdateOn { get; set; }
    }
}

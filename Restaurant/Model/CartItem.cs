using System.ComponentModel.DataAnnotations;

namespace RestaurantApi.Model
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FoodName {  get; set; }
        [Required]
        public string RestaurantName {  get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Quality {  get; set; }
        [Required]
        public int UserId {  get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
    }
}

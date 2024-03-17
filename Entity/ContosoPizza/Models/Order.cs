using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPizza.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced {  get; set; }
        public DateTime? OrderFulfiled {  get; set; }
        public int CustomerId { get; set; }


        public Customer Cuctomer { get; set; } = null!;
        public ICollection<OrderDetail> OrdersDetails { get; set; } = null!;
    }
}
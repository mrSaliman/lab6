using System.ComponentModel.DataAnnotations;

namespace lab6.Models;

public class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    [Range(0, double.MaxValue)]
    public decimal SpecialDiscount { get; set; }

    public bool IsCompleted { get; set; }

    public int ResponsibleEmployeeId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? ResponsibleEmployee { get; set; }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HybridBusinessPOS.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual Inventory Inventory { get; set; }
    }

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }

    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
    }

    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public int QuantityInStock { get; set; }
    }

    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required]
        public string Name { get; set; }
        public string ContactInfo { get; set; }
    }

    public class PurchaseOrder
    {
        [Key]
        public int PurchaseOrderId { get; set; }
        [Required]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }

    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [Required]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        [Required]
        public decimal AmountDue { get; set; }
        public DateTime DateIssued { get; set; }
    }

    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public int InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
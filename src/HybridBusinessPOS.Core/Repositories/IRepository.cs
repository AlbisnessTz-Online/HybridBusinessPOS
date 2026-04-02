// IRepository.cs

using System.Collections.Generic;

namespace HybridBusinessPOS.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }

    public interface IProductRepository : IRepository<Product>
    {
        // Additional methods specific to Product can be declared here
    }

    public interface ICustomerRepository : IRepository<Customer>
    {
        // Additional methods specific to Customer can be declared here
    }

    public interface IOrderRepository : IRepository<Order>
    {
        // Additional methods specific to Order can be declared here
    }

    public interface IInventoryRepository : IRepository<Inventory>
    {
        // Additional methods specific to Inventory can be declared here
    }

    public interface ISupplierRepository : IRepository<Supplier>
    {
        // Additional methods specific to Supplier can be declared here
    }

    public interface IPurchaseOrderRepository : IRepository<PurchaseOrder>
    {
        // Additional methods specific to PurchaseOrder can be declared here
    }

    public interface IInvoiceRepository : IRepository<Invoice>
    {
        // Additional methods specific to Invoice can be declared here
    }

    public interface IPaymentRepository : IRepository<Payment>
    {
        // Additional methods specific to Payment can be declared here
    }

    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        IInventoryRepository Inventories { get; }
        ISupplierRepository Suppliers { get; }
        IPurchaseOrderRepository PurchaseOrders { get; }
        IInvoiceRepository Invoices { get; }
        IPaymentRepository Payments { get; }
        void Save();
    }
}
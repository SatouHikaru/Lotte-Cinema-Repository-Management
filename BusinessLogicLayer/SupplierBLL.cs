using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class SupplierBLL
    {
        SupplierDAL supplierDAL = new SupplierDAL();

        public DataTable GetAll()
        {
            return supplierDAL.GetAll();
        }

        public DataTable GetByName(Supplier supplier)
        {
            return supplierDAL.GetByName(supplier.Name);
        }

        public int Add(Supplier supplier)
        {
            return supplierDAL.Add(supplier.Name, supplier.PhoneNumber, supplier.Address);
        }

        public int Update(Supplier supplier)
        {
            return supplierDAL.Update(supplier.ID, supplier.Name, supplier.PhoneNumber, supplier.Address);
        }

        public int Delete(Supplier supplier)
        {
            return supplierDAL.Delete(supplier.ID);
        }

        public DataTable Display()
        {
            return supplierDAL.Display();
        }

        public int Recover(Supplier supplier)
        {
            return supplierDAL.Recover(supplier.ID, supplier.Name, supplier.PhoneNumber, supplier.Address);
        }
    }
}
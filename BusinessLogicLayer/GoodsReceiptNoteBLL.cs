using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class GoodsReceiptNoteBLL
    {
        GoodsReceiptNoteDAL grnDAL = new GoodsReceiptNoteDAL();

        public void GetDate(DataTable dt)
        {
            grnDAL.GetDate(dt);
        }

        public void GetSupplierName(DataTable dt)
        {
            grnDAL.GetSupplierName(dt);
        }

        public void GetEmployeeName(DataTable dt)
        {
            grnDAL.GetEmployeeName(dt);
        }

        public void GetCommodityName(DataTable dt)
        {
            grnDAL.GetCommodityName(dt);
        }

        public DataTable GetByNumber(GoodsReceiptNote goodsReceiptNote)
        {
            return grnDAL.GetByNumber(goodsReceiptNote.GRN_No);
        }

        public int Add(GoodsReceiptNote goodsReceiptNote)
        {
            return grnDAL.Add(goodsReceiptNote.Date, goodsReceiptNote.Supplier.ID, goodsReceiptNote.Employee.ID);
        }

        public int AddDetails(GoodsReceiptNote goodsReceiptNote)
        {
            return grnDAL.AddDetails(goodsReceiptNote.GRN_No, goodsReceiptNote.Commodity.ID,
                                     goodsReceiptNote.Cost, goodsReceiptNote.Quantity);
        }

        public int Update(GoodsReceiptNote goodsReceiptNote)
        {
            return grnDAL.Update(goodsReceiptNote.GRN_No, goodsReceiptNote.Supplier.ID, goodsReceiptNote.Employee.ID);
        }

        public int UpdateDetails(GoodsReceiptNote goodsReceiptNote)
        {
            return grnDAL.UpdateDetails(goodsReceiptNote.GRN_No, goodsReceiptNote.Commodity.ID,
                                        goodsReceiptNote.Cost, goodsReceiptNote.Quantity);
        }

        public int Delete(GoodsReceiptNote goodsReceiptNote)
        {
            return grnDAL.Delete(goodsReceiptNote.GRN_No);
        }

        public int Remove(GoodsReceiptNote goodsReceiptNote)
        {
            return grnDAL.Remove(goodsReceiptNote.GRN_No, goodsReceiptNote.Commodity.ID);
        }

        public DataTable Display()
        {
            return grnDAL.Display();
        }

        public DataTable DisplayDetails()
        {
            return grnDAL.DisplayDetails();
        }

        public int Recover(GoodsReceiptNote goodsReceiptNote)
        {
            return grnDAL.Recover(goodsReceiptNote.GRN_No, goodsReceiptNote.Date,
                                  goodsReceiptNote.Supplier.ID, goodsReceiptNote.Employee.ID);
        }
    }
}
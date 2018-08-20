using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class GoodsIssueNoteBLL
    {
        GoodsIssueNoteDAL ginDAL = new GoodsIssueNoteDAL();

        public void GetDate(DataTable dt)
        {
            ginDAL.GetDate(dt);
        }

        public void GetCommodityName(DataTable dt)
        {
            ginDAL.GetCommodityName(dt);
        }

        public void GetEmployeeName(DataTable dt)
        {
            ginDAL.GetEmployeeName(dt);
        }

        public DataTable GetByNumber(GoodsIssueNote goodsIssueNoteDetails)
        {
            return ginDAL.GetByNumber(goodsIssueNoteDetails.GIN_No);
        }

        public int Add(GoodsIssueNote goodsIssueNoteDetails)
        {
            return ginDAL.Add(goodsIssueNoteDetails.Date, goodsIssueNoteDetails.Employee.ID);
        }

        public int AddDetails(GoodsIssueNote goodsIssueNoteDetails)
        {
            return ginDAL.AddDetails(goodsIssueNoteDetails.GIN_No, goodsIssueNoteDetails.Commodity.ID,
                                     goodsIssueNoteDetails.Cost, goodsIssueNoteDetails.Quantity);
        }

        public int Update(GoodsIssueNote goodsIssueNote)
        {
            return ginDAL.Update(goodsIssueNote.GIN_No, goodsIssueNote.Employee.ID);
        }

        public int UpdateDetails(GoodsIssueNote goodsIssueNoteDetails)
        {
            return ginDAL.UpdateDetails(goodsIssueNoteDetails.GIN_No, goodsIssueNoteDetails.Commodity.ID,
                                        goodsIssueNoteDetails.Cost, goodsIssueNoteDetails.Quantity);
        }

        public int Delete(GoodsIssueNote goodsIssueNoteDetails)
        {
            return ginDAL.Delete(goodsIssueNoteDetails.GIN_No);
        }

        public int Remove(GoodsIssueNote goodsIssueNoteDetails)
        {
            return ginDAL.Remove(goodsIssueNoteDetails.GIN_No, goodsIssueNoteDetails.Commodity.ID);
        }

        public DataTable Display()
        {
            return ginDAL.Display();
        }

        public DataTable DisplayDetails()
        {
            return ginDAL.DisplayDetails();
        }

        public int Recover(GoodsIssueNote goodsIssueNoteDetails)
        {
            return ginDAL.Recover(goodsIssueNoteDetails.GIN_No, goodsIssueNoteDetails.Date, goodsIssueNoteDetails.Employee.ID);
        }
    }
}
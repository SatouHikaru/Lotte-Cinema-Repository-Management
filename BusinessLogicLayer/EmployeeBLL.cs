using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class EmployeeBLL
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();

        public DataTable GetAll()
        {
            return employeeDAL.GetAll();
        }

        public DataTable GetByName(Employee employee)
        {
            return employeeDAL.GetByName(employee.FullName);
        }

        public int Add(Employee employee)
        {
            return employeeDAL.Add(employee.FullName, employee.Gender, employee.Birthday, employee.MobilePhone);
        }

        public int Update(Employee employee)
        {
            return employeeDAL.Update(employee.ID, employee.FullName, employee.Gender, employee.Birthday, employee.MobilePhone);
        }

        public int Delete(Employee employee)
        {
            return employeeDAL.Delete(employee.ID);
        }

        public DataTable Display()
        {
            return employeeDAL.Display();
        }

        public int Recover(Employee employee)
        {
            return employeeDAL.Recover(employee.ID, employee.FullName, employee.Gender, employee.Birthday, employee.MobilePhone);
        }
    }
}
using MVCApplication.Models;

namespace MVCApplication.EF
{
    public interface _repositary
    {
        IList<ApplicationUser> Getdaitails();
    }
    public class DataAccess : _repositary
    {
        private readonly DatabaseContext _dbContext;
        public DataAccess(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
                
        }
        public IList<ApplicationUser> Getdaitails()
        {
            var dbd = _dbContext.EmpTable.ToList();
            return dbd;
        }
            
    }
}


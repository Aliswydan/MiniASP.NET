using HomeWork5.Commands;
using HomeWork5.DataBase;
using Microsoft.EntityFrameworkCore;

namespace HomeWork5.Services
{
    public class CVServices : ICVServices
    {
        public Appdbcontext _db { get; set; }
       
        public CVServices(Appdbcontext appdbcontext)
        {
            _db = appdbcontext;
        }

        

        public async Task<int> AddCV(CVCommands cmd)
        {
        var cv = new CVClass();
        cv.FirstName = cmd.FirstName;
        cv.LastName = cmd.LastName;
        cv.Email = cmd.Email;
        cv.Skills = cmd.Skills;
        cv.Sex = cmd.Sex;
        cv.Nationality = cmd.Nationality;
        cv.Password = cmd.Password;
        cv.Birthday = cmd.Birthday;
        cv.Photo = cmd.Photo;
        
        _db.CVdb.Add(cv);
        await _db.SaveChangesAsync();
    
        int idcv = cv.CVId;
            
        return idcv;

                
        }

        public async Task<List<CVClass>> GetCV()
        {
            var cv = await _db.CVdb.ToListAsync();
            if(cv == null)
            {
                return null;
            }
            return cv;

        }

        public async Task<CVClass> GetCVById(int id)
        { 
          return await _db.CVdb.FindAsync(id);
        }

        
    }
}

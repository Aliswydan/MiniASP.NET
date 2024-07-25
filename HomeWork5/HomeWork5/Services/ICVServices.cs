using Azure;
using HomeWork5.Commands;
using HomeWork5.DataBase;

namespace HomeWork5.Services
{
    public interface ICVServices
    {

        Task<int> AddCV(CVCommands cmd);
        Task<List<CVClass>> GetCV();
        Task<CVClass> GetCVById(int id);

    }
}

using System.Threading.Tasks;

namespace DiviSharp.Services
{
    interface IDiviSharpService
    {
        Task<string> GetBlockHash(int block);
        Task<int> GetBlockCount();
    }
}

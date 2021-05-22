using System;
using System.Threading.Tasks;


namespace R5T.D0066
{
    public interface ICurrentDirectoryPathProvider
    {
        Task<string> GetCurrentDirectoryPath();
    }
}

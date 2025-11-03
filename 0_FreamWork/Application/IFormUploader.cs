using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace _0_FreamWork.Application
{
    public interface IFormUploader
    {
        string Upload(IFormFile file,string path);
    }
}

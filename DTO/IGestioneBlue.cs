using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public interface IGestioneBlue
    {
        List<Bluechip> GetAllBluechips();
        Bluechip GetBluechipBySimbol(string Simbolo);
    }
}

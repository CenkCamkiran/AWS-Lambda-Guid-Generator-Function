using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ResponseModel: BaseModel
    {
        public List<string> GuidList { get; set; } = new List<string>();
    }
}

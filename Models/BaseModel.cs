using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseModel
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
        public int ResponseCode {  get; set; }
        public string ResponseMessage { get; set; } = string.Empty;
    }
}

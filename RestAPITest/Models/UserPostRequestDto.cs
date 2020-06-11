using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPITest.Models
{
    class UserPostRequestDto
    {
        public string Email { get; internal set; }
        public string Name { get; set; }
        public string UserName { get; internal set; }
    }
}

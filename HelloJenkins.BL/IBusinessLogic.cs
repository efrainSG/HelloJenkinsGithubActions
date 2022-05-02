using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloJenkins.BL
{
    public interface IBusinessLogic
    {
        public string Name { get; set; }
        public string Description { get; set; }

        string SayHello();

        string SayHelloAsync();
    }
}

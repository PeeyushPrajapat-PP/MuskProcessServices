using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    class SubHeader
    {
        public int _subHeaderID { get; set; }
        public string _subTitle { get; set; }
        
        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }
    }


}

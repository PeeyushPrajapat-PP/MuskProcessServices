using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace MuskProcessServices
{
    public class Header
    {
        public int _HeaderID { get; set; }
        public string _Title { get; set; }

        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }

    }

}
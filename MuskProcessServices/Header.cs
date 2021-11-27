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
        // Attributes
        private int _headerId { get; set; }
        private string _title { get; set; }
        private DateTime? _updatedAt { get; set; }
        private DateTime? _createdAt { get; set; }

        // Constructor
        public Header(int headerId, string title)
        {
            _headerId = headerId;
            _title = title;
        }
        public int HeaderId
        {
            get { return _headerId; }
        }

        public string Title
        {
            get { return _title; }
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuskProcessServices
{
    public class SiteInspection
    {
        // Attributes
        private int? _siteInspectionId;
        private int _siteId;
        private int _completedBy;
        private int _supervisor;
        private int _inspector;
        private string _workArea;
        private string _jobDescription;
        private string _type;
        private int _status;

        private DateTime? _submittedAt;
        private string _createdAt;

        // Constructors
        public SiteInspection(int siteId, int completedBy, int supervisor, int inspector, string workArea, string jobDescription, string type, string createdAt)
        {
            _siteId = siteId;
            _completedBy = completedBy;
            _supervisor = supervisor;
            _inspector = inspector;
            _workArea = workArea;
            _jobDescription = jobDescription;
            _type = type;
            _status = 0;
            _createdAt =createdAt;
        }

        // Methods
        public int? SiteInspectionId
        {
            get { return _siteInspectionId; }
        }
        public int SiteId
        {
            get { return _siteId; }
        }
        public int CompletedBy
        {
            get { return _completedBy; }
        }
        public int Supervisor
        {
            get { return _supervisor; }
        }
        public int Inspector
        {
            get { return _inspector; }
        }
        public string WorkArea
        {
            get { return _workArea; }
        }
        public string JobDescription
        {
            get { return _jobDescription; }
        }
        public string Type
        {
            get { return _type; }
        }
        public int Status
        {
            get { return _status; }
        }
        public string CreatedAt
        {
            get { return _createdAt; }
        }
    }
}

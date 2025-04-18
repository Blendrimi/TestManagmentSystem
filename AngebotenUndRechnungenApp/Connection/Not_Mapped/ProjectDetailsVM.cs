using System;
using System.Collections.Generic;
using System.Text;

namespace Connection.Not_Mapped
{
    public class ProjectDetailsVM
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string CustomerName { get; set; }
        public string ProjectName { get; set; }
        public string Builder { get; set; }
        public string NoOfReferenceOrInvoice { get; set; }
        public string CleaningLocation { get; set; }
        public DateTime InsertedDate { get; set; }
        public int ClientsID { get; set; }
        public int TypeOfReportId { get; set; }
    }
}

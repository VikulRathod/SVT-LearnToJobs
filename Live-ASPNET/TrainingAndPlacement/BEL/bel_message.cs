using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class bel_message
    {
        // table enquiry
        public string bel_enqid { get; set; }
        public string bel_enqfnm { get; set; }
        public string bel_enqlnm { get; set; }
        public string bel_enqcontact { get; set; }
        public string bel_enqmail { get; set; }


        // table Teachers
        public string bel_empid { get; set; }
        public string bel_empfnm { get; set; }
        public string bel_emplnm { get; set; }
        public string bel_empcontact { get; set; }
        public string bel_empmail { get; set; }

        // table Student
        public string bel_memid { get; set; }
        public string bel_memfnm { get; set; }
        public string bel_memlnm { get; set; }
        public string bel_memcontact { get; set; }
        public string bel_memmail { get; set; }
        public string bel_memclass { get; set; }
        public string bel_memhouse { get; set; }

        // table event
        public Int32 bel_eid { get; set; }
        public string bel_esub { get; set; }
        public string bel_ebody { get; set; }

        //send_Notification 
        public string bel_Id { get; set; }
        public string bel_Login_id { get; set; }
        public string bel_Subject_Type { get; set; }
        public string bel_Message { get; set; }
        public string bel_Contact_No { get; set; }
        public string bel_Email_Id { get; set; }
        public string bel_SMS_Send_Date { get; set; }
        public string bel_Send_Type { get; set; }
    }
}

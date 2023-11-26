using Autoservice_Back.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoService_BackEnd.DTO
{
    public class AnswerGetOrder
    {        
        public string Description { get; set; }
        public bool IsActive { get; set; }  
        public DateTime Start { get; set; }  
        public DateTime End { get; set; }
        public string Result { get; set; }
        public string Vin { get; set; }
        public string StateNumber { get; set; }
        public int MileAge { get; set; }
         
    }
}

namespace AutoService_BackEnd.DTO
{
    public class AnswerAutentic
    {
        public int Client_id { get; set; }
        public string  Name { get; set;}
        public string  SurName { get; set;}
        public string  SecondName { get; set;}
        public bool ToNotify { get; set; }
    }
}

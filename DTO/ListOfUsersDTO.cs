namespace TestAutomationAPI
{
    public class ListOfUsersDTO
    {
        public long page { get; set; }
        public long perPage { get; set; }
        public long total { get; set; }
        public long totalPages { get; set; }
        public List<Datum> data { get; set; }
        public Support support { get; set; }
    }

    public class Datum
    {
        public long id { get; set; }
        public string email { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Uri avatar { get; set; }
    }

    public class Support
    {
        public Uri url { get; set; }
        public string text { get; set; }
    }
}

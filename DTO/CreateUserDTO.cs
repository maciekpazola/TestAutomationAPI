namespace TestAutomationAPI.DTO
{
    public class CreateUserDTO
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public string Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}

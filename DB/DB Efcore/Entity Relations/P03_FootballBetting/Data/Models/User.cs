namespace P03_FootballBetting.Data.Models
{
      class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}
//UserId, Username, Password, Email, Name, Balance
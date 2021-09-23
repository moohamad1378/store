namespace Store_1.Application.Services.Users.Queries.GetUsers
{
    public class GetUsersDto
    {//در این لایه یوزر هارو بین لایه هاو کلاس ها جا ب جا میکنیم
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}

using BookstoreCafe.Data;

namespace BookstoreCafe.Services.Users
{
    public class UserService : IUserService
    {
        private readonly BookCafeDbContext data;

        public UserService(BookCafeDbContext data)
        {
            this.data = data;
        }

        public string UserFullName(string userId)
        {
            var user = data.Users.First(u => u.Id == userId);

            if (user is null || string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
            {
                return null;
            }

            return user.FirstName + " " + user.LastName;
        }
    }
}
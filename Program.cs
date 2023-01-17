using Hotel_Proj.Domain.Enums;
using Hotel_Proj.Domain.Entities;
using Hotel_Proj.Services;
using Hotel_Proj.Data.DbContexts;
using Hotel_Proj.Data.Repositories;

//UserServices users = new UserServices();
var ap = new AppDbContext();

Repositories<User> users = new Repositories<User>(ap);

User user1 = new User()
{
    FullName = "Test",
    Password = "Testp",
    PhoneNumber = "998966555856",
    UserRole = ((int)UserRole.user)
};

User user2 = new User()
{
    FullName = "Test2",
    Password = "Test2p",
    PhoneNumber = "998966557456",
    UserRole = ((int)UserRole.user)
};

await users.CreateAsync(user1);
Console.WriteLine("User 1 created");
await users.CreateAsync(user2);
Console.WriteLine("User2");

Console.ReadKey();
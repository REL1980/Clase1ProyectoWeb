//Programa inicial de todo sistema
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/users", () => {
    
    var user1 = new User("Enrique","Diaz",1980);
    var user2 = new User("Rodolfo","Perez",1975);
    var user3 = new User("Pablito","Peñaloza",1995);
    var user4 = new User("Angel","Sancon",2004);
    
    var users = new List<User>();

    users.Add(user1);
    users.Add(user2);
    users.Add(user3);
    users.Add(user4);

    return users;

});

app.Run();

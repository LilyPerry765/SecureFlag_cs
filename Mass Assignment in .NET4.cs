//cwe915
public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}

// /Create?Login=username&Password=pwd
public IActionResult Create(User user)
{
    _context.Update(user);
    return View(user);
}
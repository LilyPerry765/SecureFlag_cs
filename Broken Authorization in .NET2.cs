//cwe285
[AllowAnonymous]
public class AccountController : Controller {
    [Authorize]
    public ActionResult AdminFunctionality() {
    }

    public actionResult PublicFunctionality() { 
    }

}
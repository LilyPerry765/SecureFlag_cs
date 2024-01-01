cwe94, cwe95
[HttpGet]
[Route("page")]
public ActionResult Index(string name)
{
    var razorTpl = $"Hello {name}!";
    ViewBag.RenderedTemplate = Razor.Parse(razorTpl);
    ViewBag.Template = razorTpl;
    return View();
}
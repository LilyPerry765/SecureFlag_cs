//no-cwe
XmlDocument document = new XmlDocument();
document.XmlResolver = new XmlUrlResolver();
document.Load(model.MyFileInput.OpenReadStream());
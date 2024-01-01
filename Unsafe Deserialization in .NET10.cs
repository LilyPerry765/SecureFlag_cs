//no-cwe
[Serializable]
public class SomeClass
{
	public string SomeProperty { get; set; }
	public double SomeOtherProperty { get; set; }
}

class Program
{
	static void Main(string[] args)
	{
	   BinaryFormatter binaryFormatter = new BinaryFormatter();
	   MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes("untrusted.file"));
	   SomeClass obj = (SomeClass)binaryFormatter.Deserialize(memoryStream);
	   Console.WriteLine(obj.SomeProperty);
	   Console.WriteLine(obj.SomeOtherProperty);
	}
}

[Serializable]
public class DangerousClass
{
    private string path;

	public DangerousClass(String path) {
		this.path = path;
	}

	public ~DangerousClass() {
		File.Delete(path)
	}
}
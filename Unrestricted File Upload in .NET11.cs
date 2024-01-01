//no-cwe
namespace Application.Utils
{
    public class FileUpload 
    {
        private string uploadedFile;
        private string fileContent;
        private string safeUploadFolder = @"C:\temp\secure";

        public String execute() {
            try {
                string completePathNewFile= safeUploadFolder + System.IO.Path.PathSeparator + uploadedFile;
                if (!File.Exists(completePathNewFile))
                {
                    using (StreamWriter sw = File.CreateText(completePathNewFile))
                    {
                        sw.WriteLine(fileContent);
                    }
                }
                return "SUCCESS";
            } catch (System.Exception e) {
                return "ERROR";
            }
        }
    }
}
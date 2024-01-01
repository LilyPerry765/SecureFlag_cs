//no-cwe
private static string GetRemoteObject(string location) 
{
    using (var client = new WebClient()) {
        return client.DownloadString(location);
    }
}
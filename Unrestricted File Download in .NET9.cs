//no-cwe
using System;

public class Assets
{
  public static string assetsDir = "/opt/wwwdata/assets/";

  public static string getAssetPath(string assetName)
  {
    return System.IO.Path.Combine(
      assetsDir, 
      assetName
    );
  }
}
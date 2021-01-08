#region HeadComments
// ********************************************************************
//  Author：Gz
//  Date：2021-01-07 20:07:09
//  Describe：
// *********************************************************************
#endregion
using System.IO;

public class CreatScriptTmpControll : UnityEditor.AssetModificationProcessor
{
    /// <summary>
    /// 在资源创建时调用
    /// </summary>
    /// <param name="path">自动传入资源路径</param>
    public static void OnWillCreateAsset(string path)
    {
        path = path.Replace(".meta", "");
        if (path.EndsWith(".cs"))
        {
            string allText = File.ReadAllText(path);
            allText = allText.Replace("#CREATIONDATE#", System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            File.WriteAllText(path, allText);
        }
    }
}



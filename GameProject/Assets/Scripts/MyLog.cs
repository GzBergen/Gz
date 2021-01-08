#region HeadComments
// ********************************************************************
//  Author：Gz
//  Date：2021-01-08 10:04:39
//  Describe：
// *********************************************************************
#endregion

using UnityEngine;

public class MyLog : MonoBehaviour
{   
    /// <summary>
    /// 打印
    /// </summary>
    /// <param name="msg"></param>
    public static void Log(object msg)
    {
        if (GameSetting.openLog)
        {
            Debug.Log(msg);
        }
    }
    public static void LogWarning(object msg)
    {
        if (GameSetting.openLog)
        {
            Debug.LogWarning(msg);
        }
    }
    public static void LogError(object msg)
    {
        if (GameSetting.openLog)
        {
            Debug.LogError(msg);
        }
    }
}


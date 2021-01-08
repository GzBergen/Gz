#region HeadComments
// ********************************************************************
//  Author：Gz
//  Date：2021-01-07 20:07:09
//  Describe：主启动
// *********************************************************************
#endregion

using UnityEngine;

public class Launch : MonoBehaviour
{
    private void Awake()
    {
        Debug.unityLogger.logEnabled = GameSetting.openLog;

    }
}


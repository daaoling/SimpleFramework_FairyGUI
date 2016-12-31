using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;

/// <summary>
/// 场景加载前的资源加载
/// </summary>
public class LoadMgr : Manager
{
    //public 

    public void ReplaceScene(string uiPacList, LuaFunction func = null)
    {
        ///释放之前场景的 UI Fairy包
        
        ///加载当前的UI Fairy包

        //if (newScene != curScene)
        //{
        //    ///呼叫之前场景释放成功
            
        //    ///呼叫当前场景加载成功
        //}        

        //Debug.Log(" ReplaceScene ");

        if (func != null)
        {
            func.BeginPCall();
            func.PCall();
            func.EndPCall();
            func.Dispose();
            func = null;
        }
        
    }

    ///进度条显示当前的情况
}

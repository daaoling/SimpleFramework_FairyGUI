using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using FairyGUI;
using System.Linq;
/// <summary>
/// 场景加载前的资源加载
/// </summary>
public class LoadMgr : UnitySingleton<LoadMgr>
{
    bool startReplace = false;
    public string[] fairyGUIPackList = null;

    void Awake() { 
		this.enabled = false; 
	}

    public void ReplaceScene(string uiPacList, Action func = null)
    {
        this.requestQueue = new Queue<Callback>();
        this.allIndex = 0;
        this.curIndex = 0;
        this.finish_func = func;
        this.timer = 1f;

        if (fairyGUIPackList != null) {
            Debug.Log(" 释放之前场景的 UI Fairy包 "); 
            for (int i = 0; i < fairyGUIPackList.Length; i++)
            {
                string curPackName = fairyGUIPackList[i];
                requestQueue.Enqueue(delegate() { UIPackage.RemovePackage("UI/" + curPackName); });
                this.allIndex++;
            }
        }

        this.fairyGUIPackList = uiPacList.Split(":"[0]).Where(t => { return !string.IsNullOrEmpty(t); }).ToArray();
        Debug.Log(" 加载当前的UI Fairy包" );
       
        for (int i = 0; i < fairyGUIPackList.Length; i++)
        {
            string curPackName = fairyGUIPackList[i];
            Debug.Log(" fairyGUIPackList[" + i + "] " + curPackName);
            requestQueue.Enqueue(delegate() { UIPackage.AddPackage("UI/" + curPackName); });
            this.allIndex++;
        }

        this.enabled = true;
    }

    public Queue<Callback> requestQueue;
    int allIndex;
    int curIndex;
    public Callback curRequest;


    float timer = 1f;

    void Update() 
    {
        ///强制性加点延迟
        if ((timer -= Time.deltaTime) < 0f)
        {
            timer = 1f;

            if (curIndex < allIndex)
            {
                this.curRequest = requestQueue.Dequeue();
                this.curRequest();
                this.curIndex++;
                //UpdateProgree();
            }
            else
            {
                OnProgressFinish();
            }
        }
    }

    ///进度条显示当前的情况
    void OnGUI()
    {
        GUI.color = Color.red;
        GUI.Label(new Rect(10, 10, 1500, 100), "当前比例 " + (float)curIndex / (float)allIndex + "");
    }
    
    Action finish_func;
    void OnProgressFinish() 
    {
        Debug.Log(" OnProgressFinish ");

//        if (this.finish_func != null)
//        {
//            this.finish_func.BeginPCall();
//            this.finish_func.PCall();
//            this.finish_func.EndPCall();
//            this.finish_func.Dispose();
//            this.finish_func = null;
//        }
//
		finish_func();
        this.enabled = false;
    }
   
}

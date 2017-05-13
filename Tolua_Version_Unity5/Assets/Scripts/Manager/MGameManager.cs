using UnityEngine;
using System;
using System.Collections;
using FairyGUI;


public class MGameManager : Singleton<MGameManager>
{

    //public void Start()
    //{

    //    //LuaManager.InitStart();
    //    //LuaManager.DoFile("Logic/Game");            //加载游戏
    //    //LuaManager.DoFile("Logic/Network");         //加载网络
    //    //NetManager.OnInit();

    //    //Util.CallMethod("Game", "OnInitOK");          //初始化完成

    //    //LuaManager.Instance.StartMainLuaLogic();

    //    InitUISetting();

    //    StartLuaLogic();
    //}





    public void Init()
    {
#if UNITY_WEBPLAYER || UNITY_WEBGL || UNITY_STANDALONE_WIN || UNITY_STANDALONE_OSX || UNITY_EDITOR
        CopyPastePatch.Apply();
#endif
        UIConfig.defaultFont = "afont";
        GRoot.inst.SetContentScaleFactor(1152, 648, UIContentScaler.ScreenMatchMode.MatchHeight);
    }

    public void Start()
    {
        UnityEngine.Debug.Log(" Start Lua : Logic");

        //LuaManager.Instance.luaenv.DoString("require 'Main'");

        //Action main = LuaManager.Instance.luaenv.Global.Get<Action>("Main");
        //映射到一个delgate，要求delegate加到生成列表，否则返回null，建议用法
        //main();

        MLuaManager.Instance.Start();
    }

    public void Update() { }

    public void Release() { }
}



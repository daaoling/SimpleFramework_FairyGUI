using UnityEngine;
using System;
using System.Collections;
using FairyGUI;

public class Main : MonoBehaviour {

    //LuaEnv luaenv = null;

    public static Main Instance;
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        //UIConfig.defaultFont = "afont";
        //GRoot.inst.SetContentScaleFactor(1152, 648);

        //UIPackage.AddPackage("UI/Common");
        //UIPackage.AddPackage("UI/DengLu");

        ////GComponent mainCom = FairyGUI.UIPackage.CreateObject("DengLu", "Main").asCom;
        ////mainCom.SetSize(FairyGUI.GRoot.inst.width, FairyGUI.GRoot.inst.height);
        ////mainCom.AddRelation(FairyGUI.GRoot.inst, FairyGUI.RelationType.Size);
        ////FairyGUI.GRoot.inst.AddChild(mainCom);

        //luaenv = new LuaEnv();
        //luaenv.DoString("require 'main'");


        //Action e = luaenv.Global.Get<Action>("startMain");//映射到一个delgate，要求delegate加到生成列表，否则返回null，建议用法
        //e();


        //UnityEngine.UI.Button.


        //LuaManager.Instance.Start();

        ///here start gamelogic, so need start at last
        //GameManager.Instance.Start();

        MLuaManager.Instance.Init();

        MGameManager.Instance.Init();
        MGameManager.Instance.Start();
        //MGameManager.Instance.INI();
    }


    void Update() 
    {
        //GameManager.Instance.Update();
        //LuaManager.Instance.Update();
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (luaenv != null)
    //    {
    //        luaenv.Tick();
    //    }
    //}

    void OnDestroy()
    {
        //GameManager.Instance.Release();
        //LuaManager.Instance.Release();
    }
}

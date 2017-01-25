﻿using UnityEngine;
using System;
using System.Collections;
using XLua;
using FairyGUI;

public class Main : MonoBehaviour {

    LuaEnv luaenv = null;

    // Use this for initialization
    void Start()
    {
        UIConfig.defaultFont = "afont";
        GRoot.inst.SetContentScaleFactor(1152, 648);

        UIPackage.AddPackage("UI/Common");
        UIPackage.AddPackage("UI/DengLu");

        //GComponent mainCom = FairyGUI.UIPackage.CreateObject("DengLu", "Main").asCom;
        //mainCom.SetSize(FairyGUI.GRoot.inst.width, FairyGUI.GRoot.inst.height);
        //mainCom.AddRelation(FairyGUI.GRoot.inst, FairyGUI.RelationType.Size);
        //FairyGUI.GRoot.inst.AddChild(mainCom);

        luaenv = new LuaEnv();
        luaenv.DoString("require 'main'");


        Action e = luaenv.Global.Get<Action>("startMain");//映射到一个delgate，要求delegate加到生成列表，否则返回null，建议用法
        e();


        //UnityEngine.UI.Button.
    }

    // Update is called once per frame
    void Update()
    {
        if (luaenv != null)
        {
            luaenv.Tick();
        }
    }

    void OnDestroy()
    {
        luaenv.Dispose();
    }
}
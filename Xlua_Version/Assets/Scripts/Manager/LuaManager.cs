using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;
using XLua;

public class LuaManager : Singleton<LuaManager>
{
    public LuaEnv luaenv;
    
    public void Start() 
    {
        luaenv = new LuaEnv();
    
        InitLuaPath();
        AddLuaLoader();
    }


    public void Release() 
    {
        luaenv.Dispose();
    }

    #region Init
    void AddLuaLoader()
    {
        luaenv.AddLoader(LuaFileUtils.Instance.ReadFile);
    }
     void InitLuaPath()
     {
         if (AppConst.DebugMode)
         {
             //string rootPath = AppConst.FrameworkRoot;
             AddSearchPath(AppConst.luaDir);
         }
         //else
         //{
         //    AddSearchPath(Util.DataPath + "lua");
         //}
     }
	#endregion

    public void Update() { }

    //Application.dataPth + "/Lua"
    public void AddSearchPath(string fullPath)
    {
        if (!Path.IsPathRooted(fullPath))
        {
            throw new LuaException(fullPath + " is not a full path");
        }


        fullPath = ToPackagePath(fullPath);
        LuaFileUtils.Instance.AddSearchPath(fullPath);
    }

    //Application.dataPth + "/Lua" + "/?.lua"
    string ToPackagePath(string path)
    {
        //StringBuilder sb = StringBuilderCache.Acquire();
        StringBuilder sb = new StringBuilder();
        sb.Append(path);
        sb.Replace('\\', '/');

        if (sb.Length > 0 && sb[sb.Length - 1] != '/')
        {
            sb.Append('/');
        }

        sb.Append("?.lua");
        //return StringBuilderCache.GetStringAndRelease(sb);
        return sb.ToString();
    }


}


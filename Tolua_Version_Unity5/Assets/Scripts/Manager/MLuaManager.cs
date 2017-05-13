using UnityEngine;
using System.Collections;
using LuaInterface;

public class MLuaManager : Singleton<MLuaManager>
{

    private LuaState lua;
    //private LuaLoader loader;
    private LuaLooper loop = null;

    public void Init()
    {
        //loader = new LuaLoader();
        lua = new LuaState();
        this.OpenLibs();
        lua.LuaSetTop(0);

        LuaBinder.Bind(lua);
    }


    public void Start()
    {
        InitLuaPath();

        this.lua.Start();    //启动LUAVM
        
        this.StartMain();
        this.StartLooper();
    }

    #region InitStart
    void InitLuaPath()
    {
        //debug mode
        //lua.AddSearchPath(Application.dataPath + "/Lua");
    }
    void StartMain()
    {
        lua.DoFile("Main.lua");

        LuaFunction main = lua.GetFunction("Main");
        main.Call();
        main.Dispose();
        main = null;
    }
    void StartLooper()
    {
        //loop = Main.Instance.gameObject.AddComponent<LuaLooper>();
        //loop.luaState = lua;
    } 
    #endregion





    void OpenLibs()
    {
        lua.OpenLibs(LuaDLL.luaopen_pb);
        lua.OpenLibs(LuaDLL.luaopen_sproto_core);
        lua.OpenLibs(LuaDLL.luaopen_protobuf_c);
        lua.OpenLibs(LuaDLL.luaopen_lpeg);
        lua.OpenLibs(LuaDLL.luaopen_bit);
        lua.OpenLibs(LuaDLL.luaopen_socket_core);

        this.OpenCJson();
    }

    protected void OpenCJson()
    {
        lua.LuaGetField(LuaIndexes.LUA_REGISTRYINDEX, "_LOADED");
        lua.OpenLibs(LuaDLL.luaopen_cjson);
        lua.LuaSetField(-2, "cjson");

        lua.OpenLibs(LuaDLL.luaopen_cjson_safe);
        lua.LuaSetField(-2, "cjson.safe");
    }

}

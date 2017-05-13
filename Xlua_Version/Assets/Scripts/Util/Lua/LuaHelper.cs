using UnityEngine;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using XLua.LuaDLL;

public class LuaHelper
{
    //public static void TestPbc(System.IntPtr L)
    //{
    //    UnityEngine.Debug.Log(" TestPbc ");
        
    //    //IntPtr strlen;
    //    //IntPtr str = Lua.lua_tolstring(L, index, out strlen);
    //}

    public static void TestPbc(System.IntPtr L)
    {
        UnityEngine.Debug.Log(" TestPbc ");
        //IntPtr strlen;
        //IntPtr str = Lua.lua_tolstring(L, 0, out strlen);
        //if (str != IntPtr.Zero)
        //{
        //    int len = strlen.ToInt32();
        //    byte[] buffer = new byte[len];
        //    Marshal.Copy(str, buffer, 0, len);
        //    UnityEngine.Debug.Log(" buffer.Length " + buffer.Length);
        //    return 1;
        //}
        //else
        //{
        //    UnityEngine.Debug.Log(" this ? ");
        //    return 0;
        //}
    }

}

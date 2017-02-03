#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace CSObjectWrap
{
    public class UnityEngineTimeWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Time), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Time), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Time), L, __CreateInstance, 1, 14, 4);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Time));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "time", get_time);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "timeSinceLevelLoad", get_timeSinceLevelLoad);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "deltaTime", get_deltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fixedTime", get_fixedTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "unscaledTime", get_unscaledTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "unscaledDeltaTime", get_unscaledDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "fixedDeltaTime", get_fixedDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "maximumDeltaTime", get_maximumDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "smoothDeltaTime", get_smoothDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "timeScale", get_timeScale);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "frameCount", get_frameCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "renderedFrameCount", get_renderedFrameCount);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "realtimeSinceStartup", get_realtimeSinceStartup);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "captureFramerate", get_captureFramerate);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "fixedDeltaTime", set_fixedDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "maximumDeltaTime", set_maximumDeltaTime);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "timeScale", set_timeScale);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "captureFramerate", set_captureFramerate);
            
			Utils.EndClassRegister(typeof(UnityEngine.Time), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Time __cl_gen_ret = new UnityEngine.Time();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Time constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_time(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.time);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_timeSinceLevelLoad(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.timeSinceLevelLoad);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_deltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.deltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_fixedTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.fixedTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_unscaledTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.unscaledTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_unscaledDeltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.unscaledDeltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_fixedDeltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.fixedDeltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_maximumDeltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.maximumDeltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_smoothDeltaTime(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.smoothDeltaTime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_timeScale(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.timeScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_frameCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Time.frameCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_renderedFrameCount(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Time.renderedFrameCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_realtimeSinceStartup(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushnumber(L, UnityEngine.Time.realtimeSinceStartup);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_captureFramerate(RealStatePtr L)
        {
            
            try {
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Time.captureFramerate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_fixedDeltaTime(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Time.fixedDeltaTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_maximumDeltaTime(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Time.maximumDeltaTime = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_timeScale(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Time.timeScale = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_captureFramerate(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Time.captureFramerate = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

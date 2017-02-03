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
    public class UnityEngineDebugWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Debug), L, translator, 0, 0, 0, 0);
			
			
			
			
			
			Utils.EndObjectRegister(typeof(UnityEngine.Debug), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Debug), L, __CreateInstance, 10, 2, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawLine", DrawLine_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DrawRay", DrawRay_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Break", Break_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DebugBreak", DebugBreak_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Log", Log_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogError", LogError_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearDeveloperConsole", ClearDeveloperConsole_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogException", LogException_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LogWarning", LogWarning_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Debug));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "developerConsoleVisible", get_developerConsoleVisible);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "isDebugBuild", get_isDebugBuild);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "developerConsoleVisible", set_developerConsoleVisible);
            
			Utils.EndClassRegister(typeof(UnityEngine.Debug), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Debug __cl_gen_ret = new UnityEngine.Debug();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int DrawLine_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    
                    UnityEngine.Debug.DrawLine( start, end );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    UnityEngine.Color color;translator.Get(L, 3, out color);
                    
                    UnityEngine.Debug.DrawLine( start, end, color );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    UnityEngine.Color color;translator.Get(L, 3, out color);
                    float duration = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    UnityEngine.Debug.DrawLine( start, end, color, duration );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 end;translator.Get(L, 2, out end);
                    UnityEngine.Color color;translator.Get(L, 3, out color);
                    float duration = (float)LuaAPI.lua_tonumber(L, 4);
                    bool depthTest = LuaAPI.lua_toboolean(L, 5);
                    
                    UnityEngine.Debug.DrawLine( start, end, color, duration, depthTest );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.DrawLine!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int DrawRay_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 dir;translator.Get(L, 2, out dir);
                    
                    UnityEngine.Debug.DrawRay( start, dir );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 dir;translator.Get(L, 2, out dir);
                    UnityEngine.Color color;translator.Get(L, 3, out color);
                    
                    UnityEngine.Debug.DrawRay( start, dir, color );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 dir;translator.Get(L, 2, out dir);
                    UnityEngine.Color color;translator.Get(L, 3, out color);
                    float duration = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    UnityEngine.Debug.DrawRay( start, dir, color, duration );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Color>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Vector3 start;translator.Get(L, 1, out start);
                    UnityEngine.Vector3 dir;translator.Get(L, 2, out dir);
                    UnityEngine.Color color;translator.Get(L, 3, out color);
                    float duration = (float)LuaAPI.lua_tonumber(L, 4);
                    bool depthTest = LuaAPI.lua_toboolean(L, 5);
                    
                    UnityEngine.Debug.DrawRay( start, dir, color, duration, depthTest );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.DrawRay!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Break_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.Debug.Break(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int DebugBreak_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.Debug.DebugBreak(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Log_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    
                    UnityEngine.Debug.Log( message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    UnityEngine.Debug.Log( message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.Log!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int LogError_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    
                    UnityEngine.Debug.LogError( message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    UnityEngine.Debug.LogError( message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogError!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int ClearDeveloperConsole_xlua_st_(RealStatePtr L)
        {
            
            
            
            try {
                
                {
                    
                    UnityEngine.Debug.ClearDeveloperConsole(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int LogException_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<System.Exception>(L, 1)) 
                {
                    System.Exception exception = (System.Exception)translator.GetObject(L, 1, typeof(System.Exception));
                    
                    UnityEngine.Debug.LogException( exception );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Exception>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    System.Exception exception = (System.Exception)translator.GetObject(L, 1, typeof(System.Exception));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    UnityEngine.Debug.LogException( exception, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogException!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int LogWarning_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<object>(L, 1)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    
                    UnityEngine.Debug.LogWarning( message );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<object>(L, 1)&& translator.Assignable<UnityEngine.Object>(L, 2)) 
                {
                    object message = translator.GetObject(L, 1, typeof(object));
                    UnityEngine.Object context = (UnityEngine.Object)translator.GetObject(L, 2, typeof(UnityEngine.Object));
                    
                    UnityEngine.Debug.LogWarning( message, context );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Debug.LogWarning!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_developerConsoleVisible(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Debug.developerConsoleVisible);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isDebugBuild(RealStatePtr L)
        {
            
            try {
			    LuaAPI.lua_pushboolean(L, UnityEngine.Debug.isDebugBuild);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_developerConsoleVisible(RealStatePtr L)
        {
            
            try {
			    UnityEngine.Debug.developerConsoleVisible = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

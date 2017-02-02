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
    public class UnityEngineAnimationClipWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.AnimationClip), L, translator, 0, 4, 4, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCurve", SetCurve);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnsureQuaternionContinuity", EnsureQuaternionContinuity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearCurves", ClearCurves);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddEvent", AddEvent);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "length", get_length);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "frameRate", get_frameRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wrapMode", get_wrapMode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localBounds", get_localBounds);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "frameRate", set_frameRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wrapMode", set_wrapMode);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localBounds", set_localBounds);
            
			Utils.EndObjectRegister(typeof(UnityEngine.AnimationClip), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.AnimationClip), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.AnimationClip));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.AnimationClip), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.AnimationClip __cl_gen_ret = new UnityEngine.AnimationClip();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.AnimationClip constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetCurve(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string relativePath = LuaAPI.lua_tostring(L, 2);
                    System.Type type = (System.Type)translator.GetObject(L, 3, typeof(System.Type));
                    string propertyName = LuaAPI.lua_tostring(L, 4);
                    UnityEngine.AnimationCurve curve = (UnityEngine.AnimationCurve)translator.GetObject(L, 5, typeof(UnityEngine.AnimationCurve));
                    
                    __cl_gen_to_be_invoked.SetCurve( relativePath, type, propertyName, curve );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int EnsureQuaternionContinuity(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.EnsureQuaternionContinuity(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int ClearCurves(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.ClearCurves(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int AddEvent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.AnimationEvent evt = (UnityEngine.AnimationEvent)translator.GetObject(L, 2, typeof(UnityEngine.AnimationEvent));
                    
                    __cl_gen_to_be_invoked.AddEvent( evt );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_length(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.length);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_frameRate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.frameRate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_wrapMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.wrapMode);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_localBounds(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineBounds(L, __cl_gen_to_be_invoked.localBounds);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_frameRate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.frameRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_wrapMode(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
                UnityEngine.WrapMode __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.wrapMode = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_localBounds(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.AnimationClip __cl_gen_to_be_invoked = (UnityEngine.AnimationClip)translator.FastGetCSObj(L, 1);
                UnityEngine.Bounds __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.localBounds = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

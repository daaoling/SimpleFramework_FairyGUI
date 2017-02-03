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
    public class UnityEngineSkinnedMeshRendererWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.SkinnedMeshRenderer), L, translator, 0, 3, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BakeMesh", BakeMesh);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetBlendShapeWeight", GetBlendShapeWeight);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetBlendShapeWeight", SetBlendShapeWeight);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "bones", get_bones);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rootBone", get_rootBone);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "quality", get_quality);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sharedMesh", get_sharedMesh);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "updateWhenOffscreen", get_updateWhenOffscreen);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localBounds", get_localBounds);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "bones", set_bones);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rootBone", set_rootBone);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "quality", set_quality);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "sharedMesh", set_sharedMesh);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "updateWhenOffscreen", set_updateWhenOffscreen);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localBounds", set_localBounds);
            
			Utils.EndObjectRegister(typeof(UnityEngine.SkinnedMeshRenderer), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.SkinnedMeshRenderer), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.SkinnedMeshRenderer));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.SkinnedMeshRenderer), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.SkinnedMeshRenderer __cl_gen_ret = new UnityEngine.SkinnedMeshRenderer();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.SkinnedMeshRenderer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int BakeMesh(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Mesh mesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
                    
                    __cl_gen_to_be_invoked.BakeMesh( mesh );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetBlendShapeWeight(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetBlendShapeWeight( index );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetBlendShapeWeight(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    float value = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SetBlendShapeWeight( index, value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_bones(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.bones);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_rootBone(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rootBone);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_quality(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.quality);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_sharedMesh(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.sharedMesh);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_updateWhenOffscreen(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.updateWhenOffscreen);
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
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineBounds(L, __cl_gen_to_be_invoked.localBounds);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_bones(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.bones = (UnityEngine.Transform[])translator.GetObject(L, 2, typeof(UnityEngine.Transform[]));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_rootBone(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.rootBone = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_quality(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.SkinQuality __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.quality = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_sharedMesh(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.sharedMesh = (UnityEngine.Mesh)translator.GetObject(L, 2, typeof(UnityEngine.Mesh));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_updateWhenOffscreen(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.updateWhenOffscreen = LuaAPI.lua_toboolean(L, 2);
            
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
			
                UnityEngine.SkinnedMeshRenderer __cl_gen_to_be_invoked = (UnityEngine.SkinnedMeshRenderer)translator.FastGetCSObj(L, 1);
                UnityEngine.Bounds __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.localBounds = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

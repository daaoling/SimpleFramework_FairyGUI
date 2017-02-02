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
    public class UnityEngineGameObjectWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.GameObject), L, translator, 0, 13, 22, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponent", GetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInChildren", GetComponentInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInParent", GetComponentInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponents", GetComponents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInChildren", GetComponentsInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInParent", GetComponentsInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetActive", SetActive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTag", CompareTag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessageUpwards", SendMessageUpwards);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessage", SendMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BroadcastMessage", BroadcastMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddComponent", AddComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SampleAnimation", SampleAnimation);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStatic", get_isStatic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "transform", get_transform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rigidbody", get_rigidbody);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rigidbody2D", get_rigidbody2D);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "camera", get_camera);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "light", get_light);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "animation", get_animation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "constantForce", get_constantForce);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "renderer", get_renderer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "audio", get_audio);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "guiText", get_guiText);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "guiTexture", get_guiTexture);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collider", get_collider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "collider2D", get_collider2D);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hingeJoint", get_hingeJoint);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "particleEmitter", get_particleEmitter);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "particleSystem", get_particleSystem);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layer", get_layer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeSelf", get_activeSelf);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeInHierarchy", get_activeInHierarchy);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tag", get_tag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gameObject", get_gameObject);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "isStatic", set_isStatic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "layer", set_layer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tag", set_tag);
            
			Utils.EndObjectRegister(typeof(UnityEngine.GameObject), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.GameObject), L, __CreateInstance, 6, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreatePrimitive", CreatePrimitive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindGameObjectWithTag", FindGameObjectWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindWithTag", FindWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindGameObjectsWithTag", FindGameObjectsWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Find", Find_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.GameObject));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.GameObject), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string name = LuaAPI.lua_tostring(L, 2);
					
					UnityEngine.GameObject __cl_gen_ret = new UnityEngine.GameObject(name);
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.GameObject __cl_gen_ret = new UnityEngine.GameObject();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<System.Type>(L, 3)))
				{
					string name = LuaAPI.lua_tostring(L, 2);
					System.Type[] components = translator.GetParams<System.Type>(L, 3);
					
					UnityEngine.GameObject __cl_gen_ret = new UnityEngine.GameObject(name, components);
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int CreatePrimitive_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.PrimitiveType type;translator.Get(L, 1, out type);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.GameObject.CreatePrimitive( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetComponent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.GetComponent( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string type = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.GetComponent( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetComponentInChildren(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentInChildren( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetComponentInParent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentInParent( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetComponents(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponents( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Component>>(L, 3)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Collections.Generic.List<UnityEngine.Component> results = (System.Collections.Generic.List<UnityEngine.Component>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Component>));
                    
                    __cl_gen_to_be_invoked.GetComponents( type, results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponents!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetComponentsInChildren(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentsInChildren( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool includeInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentsInChildren( type, includeInactive );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentsInChildren!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetComponentsInParent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentsInParent( type );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool includeInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        UnityEngine.Component[] __cl_gen_ret = __cl_gen_to_be_invoked.GetComponentsInParent( type, includeInactive );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentsInParent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetActive(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    bool value = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.SetActive( value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int CompareTag(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string tag = LuaAPI.lua_tostring(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.CompareTag( tag );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindGameObjectWithTag_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string tag = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.GameObject.FindGameObjectWithTag( tag );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindWithTag_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string tag = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.GameObject.FindWithTag( tag );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindGameObjectsWithTag_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string tag = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.GameObject[] __cl_gen_ret = UnityEngine.GameObject.FindGameObjectsWithTag( tag );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SendMessageUpwards(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.SendMessageUpwards( methodName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object value = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.SendMessageUpwards( methodName, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SendMessageOptions options;translator.Get(L, 3, out options);
                    
                    __cl_gen_to_be_invoked.SendMessageUpwards( methodName, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object value = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.SendMessageOptions options;translator.Get(L, 4, out options);
                    
                    __cl_gen_to_be_invoked.SendMessageUpwards( methodName, value, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.SendMessageUpwards!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SendMessage(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.SendMessage( methodName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object value = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.SendMessage( methodName, value );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SendMessageOptions options;translator.Get(L, 3, out options);
                    
                    __cl_gen_to_be_invoked.SendMessage( methodName, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object value = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.SendMessageOptions options;translator.Get(L, 4, out options);
                    
                    __cl_gen_to_be_invoked.SendMessage( methodName, value, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.SendMessage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int BroadcastMessage(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    
                    __cl_gen_to_be_invoked.BroadcastMessage( methodName );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object parameter = translator.GetObject(L, 3, typeof(object));
                    
                    __cl_gen_to_be_invoked.BroadcastMessage( methodName, parameter );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SendMessageOptions options;translator.Get(L, 3, out options);
                    
                    __cl_gen_to_be_invoked.BroadcastMessage( methodName, options );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
                {
                    string methodName = LuaAPI.lua_tostring(L, 2);
                    object parameter = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.SendMessageOptions options;translator.Get(L, 4, out options);
                    
                    __cl_gen_to_be_invoked.BroadcastMessage( methodName, parameter, options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.BroadcastMessage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int AddComponent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string className = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.AddComponent( className );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type componentType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        UnityEngine.Component __cl_gen_ret = __cl_gen_to_be_invoked.AddComponent( componentType );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.AddComponent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Find_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 1);
                    
                        UnityEngine.GameObject __cl_gen_ret = UnityEngine.GameObject.Find( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SampleAnimation(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.AnimationClip animation = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
                    float time = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.SampleAnimation( animation, time );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isStatic(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isStatic);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_transform(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.transform);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_rigidbody(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rigidbody);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_rigidbody2D(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.rigidbody2D);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_camera(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.camera);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_light(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.light);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_animation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.animation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_constantForce(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.constantForce);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_renderer(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.renderer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_audio(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.audio);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_guiText(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.guiText);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_guiTexture(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.guiTexture);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_collider(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.collider);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_collider2D(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.collider2D);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_hingeJoint(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.hingeJoint);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_particleEmitter(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.particleEmitter);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_particleSystem(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.particleSystem);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_layer(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.layer);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_activeSelf(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.activeSelf);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_activeInHierarchy(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.activeInHierarchy);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_tag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, __cl_gen_to_be_invoked.tag);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_gameObject(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.gameObject);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_isStatic(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.isStatic = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_layer(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.layer = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_tag(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.GameObject __cl_gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.tag = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

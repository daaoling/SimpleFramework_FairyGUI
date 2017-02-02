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
    public class UnityEngineVector4Wrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Vector4), L, translator, 6, 7, 7, 4);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__add", __AddMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__sub", __SubMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__unm", __UnmMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__mul", __MulMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__div", __DivMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Set", Set);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Scale", Scale);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Normalize", Normalize);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SqrMagnitude", SqrMagnitude);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "normalized", get_normalized);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "magnitude", get_magnitude);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sqrMagnitude", get_sqrMagnitude);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "x", get_x);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "y", get_y);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "z", get_z);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "w", get_w);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "x", set_x);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "y", set_y);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "z", set_z);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "w", set_w);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Vector4), L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Vector4), L, __CreateInstance, 13, 2, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "MoveTowards", MoveTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Scale", Scale_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Normalize", Normalize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Dot", Dot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Project", Project_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Distance", Distance_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Magnitude", Magnitude_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SqrMagnitude", SqrMagnitude_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Min", Min_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Max", Max_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "kEpsilon", UnityEngine.Vector4.kEpsilon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Vector4));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "zero", get_zero);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "one", get_one);
            
			
			Utils.EndClassRegister(typeof(UnityEngine.Vector4), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					float x = (float)LuaAPI.lua_tonumber(L, 2);
					float y = (float)LuaAPI.lua_tonumber(L, 3);
					float z = (float)LuaAPI.lua_tonumber(L, 4);
					float w = (float)LuaAPI.lua_tonumber(L, 5);
					
					UnityEngine.Vector4 __cl_gen_ret = new UnityEngine.Vector4(x, y, z, w);
					translator.PushUnityEngineVector4(L, __cl_gen_ret);
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					float x = (float)LuaAPI.lua_tonumber(L, 2);
					float y = (float)LuaAPI.lua_tonumber(L, 3);
					float z = (float)LuaAPI.lua_tonumber(L, 4);
					
					UnityEngine.Vector4 __cl_gen_ret = new UnityEngine.Vector4(x, y, z);
					translator.PushUnityEngineVector4(L, __cl_gen_ret);
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					float x = (float)LuaAPI.lua_tonumber(L, 2);
					float y = (float)LuaAPI.lua_tonumber(L, 3);
					
					UnityEngine.Vector4 __cl_gen_ret = new UnityEngine.Vector4(x, y);
					translator.PushUnityEngineVector4(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector4 constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				
				if (translator.Assignable<UnityEngine.Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
					int index = LuaAPI.xlua_tointeger(L, 2);
					LuaAPI.lua_pushboolean(L, true);
					LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<UnityEngine.Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					
					UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
					int key = LuaAPI.xlua_tointeger(L, 2);
					__cl_gen_to_be_invoked[key] = (float)LuaAPI.lua_tonumber(L, 3);
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __AddMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Vector4>(L, 1) && translator.Assignable<UnityEngine.Vector4>(L, 2))
				{
					UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Vector4 rightside;translator.Get(L, 2, out rightside);
					
					translator.PushUnityEngineVector4(L, leftside + rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Vector4!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __SubMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Vector4>(L, 1) && translator.Assignable<UnityEngine.Vector4>(L, 2))
				{
					UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Vector4 rightside;translator.Get(L, 2, out rightside);
					
					translator.PushUnityEngineVector4(L, leftside - rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Vector4!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __UnmMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            try {
                UnityEngine.Vector4 rightside;translator.Get(L, 1, out rightside);
                translator.PushUnityEngineVector4(L, - rightside);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __MulMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
					float rightside = (float)LuaAPI.lua_tonumber(L, 2);
					
					translator.PushUnityEngineVector4(L, leftside * rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
			try {
				if (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) && translator.Assignable<UnityEngine.Vector4>(L, 2))
				{
					float leftside = (float)LuaAPI.lua_tonumber(L, 1);
					UnityEngine.Vector4 rightside;translator.Get(L, 2, out rightside);
					
					translator.PushUnityEngineVector4(L, leftside * rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Vector4!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __DivMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Vector4>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
					float rightside = (float)LuaAPI.lua_tonumber(L, 2);
					
					translator.PushUnityEngineVector4(L, leftside / rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Vector4!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Vector4>(L, 1) && translator.Assignable<UnityEngine.Vector4>(L, 2))
				{
					UnityEngine.Vector4 leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Vector4 rightside;translator.Get(L, 2, out rightside);
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Vector4!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Set(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    float new_x = (float)LuaAPI.lua_tonumber(L, 2);
                    float new_y = (float)LuaAPI.lua_tonumber(L, 3);
                    float new_z = (float)LuaAPI.lua_tonumber(L, 4);
                    float new_w = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.Set( new_x, new_y, new_z, new_w );
                    
                    
                        translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Lerp_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 from;translator.Get(L, 1, out from);
                    UnityEngine.Vector4 to;translator.Get(L, 2, out to);
                    float t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Vector4 __cl_gen_ret = UnityEngine.Vector4.Lerp( from, to, t );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int MoveTowards_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 current;translator.Get(L, 1, out current);
                    UnityEngine.Vector4 target;translator.Get(L, 2, out target);
                    float maxDistanceDelta = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Vector4 __cl_gen_ret = UnityEngine.Vector4.MoveTowards( current, target, maxDistanceDelta );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Scale_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 a;translator.Get(L, 1, out a);
                    UnityEngine.Vector4 b;translator.Get(L, 2, out b);
                    
                        UnityEngine.Vector4 __cl_gen_ret = UnityEngine.Vector4.Scale( a, b );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Scale(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    UnityEngine.Vector4 scale;translator.Get(L, 2, out scale);
                    
                    __cl_gen_to_be_invoked.Scale( scale );
                    
                    
                        translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetHashCode(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Equals(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    object other = translator.GetObject(L, 2, typeof(object));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Equals( other );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Normalize_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 a;translator.Get(L, 1, out a);
                    
                        UnityEngine.Vector4 __cl_gen_ret = UnityEngine.Vector4.Normalize( a );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Normalize(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Normalize(  );
                    
                    
                        translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int ToString(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string format = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.ToString( format );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Vector4.ToString!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Dot_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 a;translator.Get(L, 1, out a);
                    UnityEngine.Vector4 b;translator.Get(L, 2, out b);
                    
                        float __cl_gen_ret = UnityEngine.Vector4.Dot( a, b );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Project_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 a;translator.Get(L, 1, out a);
                    UnityEngine.Vector4 b;translator.Get(L, 2, out b);
                    
                        UnityEngine.Vector4 __cl_gen_ret = UnityEngine.Vector4.Project( a, b );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Distance_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 a;translator.Get(L, 1, out a);
                    UnityEngine.Vector4 b;translator.Get(L, 2, out b);
                    
                        float __cl_gen_ret = UnityEngine.Vector4.Distance( a, b );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Magnitude_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 a;translator.Get(L, 1, out a);
                    
                        float __cl_gen_ret = UnityEngine.Vector4.Magnitude( a );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SqrMagnitude_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 a;translator.Get(L, 1, out a);
                    
                        float __cl_gen_ret = UnityEngine.Vector4.SqrMagnitude( a );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SqrMagnitude(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.SqrMagnitude(  );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Min_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 lhs;translator.Get(L, 1, out lhs);
                    UnityEngine.Vector4 rhs;translator.Get(L, 2, out rhs);
                    
                        UnityEngine.Vector4 __cl_gen_ret = UnityEngine.Vector4.Min( lhs, rhs );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Max_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector4 lhs;translator.Get(L, 1, out lhs);
                    UnityEngine.Vector4 rhs;translator.Get(L, 2, out rhs);
                    
                        UnityEngine.Vector4 __cl_gen_ret = UnityEngine.Vector4.Max( lhs, rhs );
                        translator.PushUnityEngineVector4(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_normalized(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.PushUnityEngineVector4(L, __cl_gen_to_be_invoked.normalized);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_magnitude(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.magnitude);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_sqrMagnitude(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.sqrMagnitude);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_zero(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineVector4(L, UnityEngine.Vector4.zero);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_one(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineVector4(L, UnityEngine.Vector4.one);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_x(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.x);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_y(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.y);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_z(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.z);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_w(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.w);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_x(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.x = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_y(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.y = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_z(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.z = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_w(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Vector4 __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.w = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineVector4(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

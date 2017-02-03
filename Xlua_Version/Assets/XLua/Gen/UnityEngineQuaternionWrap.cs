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
    public class UnityEngineQuaternionWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Quaternion), L, translator, 2, 7, 5, 5);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__mul", __MulMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Set", Set);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToAngleAxis", ToAngleAxis);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetFromToRotation", SetFromToRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLookRotation", SetLookRotation);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", Equals);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "eulerAngles", get_eulerAngles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "x", get_x);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "y", get_y);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "z", get_z);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "w", get_w);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "eulerAngles", set_eulerAngles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "x", set_x);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "y", set_y);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "z", set_z);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "w", set_w);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Quaternion), L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Quaternion), L, __CreateInstance, 12, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Dot", Dot_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AngleAxis", AngleAxis_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FromToRotation", FromToRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "LookRotation", LookRotation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Slerp", Slerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", Lerp_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "RotateTowards", RotateTowards_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Inverse", Inverse_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Angle", Angle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Euler", Euler_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "kEpsilon", UnityEngine.Quaternion.kEpsilon);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Quaternion));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "identity", get_identity);
            
			
			Utils.EndClassRegister(typeof(UnityEngine.Quaternion), L, translator);
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
					
					UnityEngine.Quaternion __cl_gen_ret = new UnityEngine.Quaternion(x, y, z, w);
					translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				
				if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
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
				
				if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					
					UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
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
        static int __MulMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && translator.Assignable<UnityEngine.Quaternion>(L, 2))
				{
					UnityEngine.Quaternion leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Quaternion rightside;translator.Get(L, 2, out rightside);
					
					translator.PushUnityEngineQuaternion(L, leftside * rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
			try {
				if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && translator.Assignable<UnityEngine.Vector3>(L, 2))
				{
					UnityEngine.Quaternion leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Vector3 rightside;translator.Get(L, 2, out rightside);
					
					translator.PushUnityEngineVector3(L, leftside * rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Quaternion!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Quaternion>(L, 1) && translator.Assignable<UnityEngine.Quaternion>(L, 2))
				{
					UnityEngine.Quaternion leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Quaternion rightside;translator.Get(L, 2, out rightside);
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Quaternion!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Set(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    float new_x = (float)LuaAPI.lua_tonumber(L, 2);
                    float new_y = (float)LuaAPI.lua_tonumber(L, 3);
                    float new_z = (float)LuaAPI.lua_tonumber(L, 4);
                    float new_w = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    __cl_gen_to_be_invoked.Set( new_x, new_y, new_z, new_w );
                    
                    
                        translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Dot_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Quaternion a;translator.Get(L, 1, out a);
                    UnityEngine.Quaternion b;translator.Get(L, 2, out b);
                    
                        float __cl_gen_ret = UnityEngine.Quaternion.Dot( a, b );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int AngleAxis_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    float angle = (float)LuaAPI.lua_tonumber(L, 1);
                    UnityEngine.Vector3 axis;translator.Get(L, 2, out axis);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.AngleAxis( angle, axis );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int ToAngleAxis(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    float angle;
                    UnityEngine.Vector3 axis;
                    
                    __cl_gen_to_be_invoked.ToAngleAxis( out angle, out axis );
                    LuaAPI.lua_pushnumber(L, angle);
                        
                    translator.PushUnityEngineVector3(L, axis);
                        
                    
                    
                        translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 2;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FromToRotation_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Vector3 fromDirection;translator.Get(L, 1, out fromDirection);
                    UnityEngine.Vector3 toDirection;translator.Get(L, 2, out toDirection);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.FromToRotation( fromDirection, toDirection );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetFromToRotation(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    UnityEngine.Vector3 fromDirection;translator.Get(L, 2, out fromDirection);
                    UnityEngine.Vector3 toDirection;translator.Get(L, 3, out toDirection);
                    
                    __cl_gen_to_be_invoked.SetFromToRotation( fromDirection, toDirection );
                    
                    
                        translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int LookRotation_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Vector3>(L, 1)) 
                {
                    UnityEngine.Vector3 forward;translator.Get(L, 1, out forward);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.LookRotation( forward );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 1)&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 forward;translator.Get(L, 1, out forward);
                    UnityEngine.Vector3 upwards;translator.Get(L, 2, out upwards);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.LookRotation( forward, upwards );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.LookRotation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetLookRotation(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 view;translator.Get(L, 2, out view);
                    
                    __cl_gen_to_be_invoked.SetLookRotation( view );
                    
                    
                        translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 view;translator.Get(L, 2, out view);
                    UnityEngine.Vector3 up;translator.Get(L, 3, out up);
                    
                    __cl_gen_to_be_invoked.SetLookRotation( view, up );
                    
                    
                        translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.SetLookRotation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Slerp_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Quaternion from;translator.Get(L, 1, out from);
                    UnityEngine.Quaternion to;translator.Get(L, 2, out to);
                    float t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.Slerp( from, to, t );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
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
                    UnityEngine.Quaternion from;translator.Get(L, 1, out from);
                    UnityEngine.Quaternion to;translator.Get(L, 2, out to);
                    float t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.Lerp( from, to, t );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int RotateTowards_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Quaternion from;translator.Get(L, 1, out from);
                    UnityEngine.Quaternion to;translator.Get(L, 2, out to);
                    float maxDegreesDelta = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.RotateTowards( from, to, maxDegreesDelta );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Inverse_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Quaternion rotation;translator.Get(L, 1, out rotation);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.Inverse( rotation );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int ToString(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string format = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.ToString( format );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.ToString!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Angle_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
            try {
                
                {
                    UnityEngine.Quaternion a;translator.Get(L, 1, out a);
                    UnityEngine.Quaternion b;translator.Get(L, 2, out b);
                    
                        float __cl_gen_ret = UnityEngine.Quaternion.Angle( a, b );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Euler_xlua_st_(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 1);
                    float y = (float)LuaAPI.lua_tonumber(L, 2);
                    float z = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.Euler( x, y, z );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 1&& translator.Assignable<UnityEngine.Vector3>(L, 1)) 
                {
                    UnityEngine.Vector3 euler;translator.Get(L, 1, out euler);
                    
                        UnityEngine.Quaternion __cl_gen_ret = UnityEngine.Quaternion.Euler( euler );
                        translator.PushUnityEngineQuaternion(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Quaternion.Euler!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetHashCode(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
                    
                    
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
            
            
            UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    object other = translator.GetObject(L, 2, typeof(object));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Equals( other );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_identity(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineQuaternion(L, UnityEngine.Quaternion.identity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_eulerAngles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.eulerAngles);
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
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
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
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
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
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
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
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.w);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_eulerAngles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.eulerAngles = __cl_gen_value;
            
                translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_x(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.x = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
            
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
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.y = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
            
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
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.z = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
            
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
			
                UnityEngine.Quaternion __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.w = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineQuaternion(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

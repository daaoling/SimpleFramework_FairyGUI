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
    public class UnityEngineColorWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Color), L, translator, 5, 3, 7, 4);
			Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__add", __AddMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__sub", __SubMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__mul", __MulMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__div", __DivMeta);
            Utils.RegisterFunc(L, Utils.OBJ_META_IDX, "__eq", __EqMeta);
            
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetHashCode", GetHashCode);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", Equals);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "grayscale", get_grayscale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "linear", get_linear);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gamma", get_gamma);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "r", get_r);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "g", get_g);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "b", get_b);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "a", get_a);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "r", set_r);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "g", set_g);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "b", set_b);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "a", set_a);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Color), L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Color), L, __CreateInstance, 2, 11, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Lerp", Lerp_xlua_st_);
            
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Color));
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "red", get_red);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "green", get_green);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "blue", get_blue);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "white", get_white);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "black", get_black);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "yellow", get_yellow);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "cyan", get_cyan);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "magenta", get_magenta);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "gray", get_gray);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "grey", get_grey);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "clear", get_clear);
            
			
			Utils.EndClassRegister(typeof(UnityEngine.Color), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 5 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					float r = (float)LuaAPI.lua_tonumber(L, 2);
					float g = (float)LuaAPI.lua_tonumber(L, 3);
					float b = (float)LuaAPI.lua_tonumber(L, 4);
					float a = (float)LuaAPI.lua_tonumber(L, 5);
					
					UnityEngine.Color __cl_gen_ret = new UnityEngine.Color(r, g, b, a);
					translator.PushUnityEngineColor(L, __cl_gen_ret);
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					float r = (float)LuaAPI.lua_tonumber(L, 2);
					float g = (float)LuaAPI.lua_tonumber(L, 3);
					float b = (float)LuaAPI.lua_tonumber(L, 4);
					
					UnityEngine.Color __cl_gen_ret = new UnityEngine.Color(r, g, b);
					translator.PushUnityEngineColor(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Color constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				
				if (translator.Assignable<UnityEngine.Color>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
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
				
				if (translator.Assignable<UnityEngine.Color>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					
					UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
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
				if (translator.Assignable<UnityEngine.Color>(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
				{
					UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
					
					translator.PushUnityEngineColor(L, leftside + rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of + operator, need UnityEngine.Color!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __SubMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Color>(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
				{
					UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
					
					translator.PushUnityEngineColor(L, leftside - rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of - operator, need UnityEngine.Color!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __MulMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Color>(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
				{
					UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
					
					translator.PushUnityEngineColor(L, leftside * rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
			try {
				if (translator.Assignable<UnityEngine.Color>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
					float rightside = (float)LuaAPI.lua_tonumber(L, 2);
					
					translator.PushUnityEngineColor(L, leftside * rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
			try {
				if (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
				{
					float leftside = (float)LuaAPI.lua_tonumber(L, 1);
					UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
					
					translator.PushUnityEngineColor(L, leftside * rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of * operator, need UnityEngine.Color!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __DivMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Color>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
					float rightside = (float)LuaAPI.lua_tonumber(L, 2);
					
					translator.PushUnityEngineColor(L, leftside / rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of / operator, need UnityEngine.Color!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __EqMeta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
			try {
				if (translator.Assignable<UnityEngine.Color>(L, 1) && translator.Assignable<UnityEngine.Color>(L, 2))
				{
					UnityEngine.Color leftside;translator.Get(L, 1, out leftside);
					UnityEngine.Color rightside;translator.Get(L, 2, out rightside);
					
					LuaAPI.lua_pushboolean(L, leftside == rightside);
					
					return 1;
				}
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            
            return LuaAPI.luaL_error(L, "invalid arguments to right hand of == operator, need UnityEngine.Color!");
            
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int ToString(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineColor(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string format = LuaAPI.lua_tostring(L, 2);
                    
                        string __cl_gen_ret = __cl_gen_to_be_invoked.ToString( format );
                        LuaAPI.lua_pushstring(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineColor(L, 1, __cl_gen_to_be_invoked);
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Color.ToString!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetHashCode(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetHashCode(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineColor(L, 1, __cl_gen_to_be_invoked);
                    
                    
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
            
            
            UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
            
            
            try {
                
                {
                    object other = translator.GetObject(L, 2, typeof(object));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Equals( other );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                        translator.UpdateUnityEngineColor(L, 1, __cl_gen_to_be_invoked);
                    
                    
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
                    UnityEngine.Color a;translator.Get(L, 1, out a);
                    UnityEngine.Color b;translator.Get(L, 2, out b);
                    float t = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        UnityEngine.Color __cl_gen_ret = UnityEngine.Color.Lerp( a, b, t );
                        translator.PushUnityEngineColor(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_red(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.red);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_green(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.green);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_blue(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.blue);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_white(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.white);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_black(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.black);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_yellow(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.yellow);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_cyan(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.cyan);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_magenta(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.magenta);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_gray(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.gray);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_grey(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.grey);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_clear(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			    translator.PushUnityEngineColor(L, UnityEngine.Color.clear);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_grayscale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.grayscale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_linear(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.linear);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_gamma(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.gamma);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_r(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.r);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_g(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.g);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_b(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.b);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_a(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.a);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_r(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.r = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineColor(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_g(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.g = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineColor(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_b(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.b = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineColor(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_a(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Color __cl_gen_to_be_invoked;translator.Get(L, 1, out __cl_gen_to_be_invoked);
                __cl_gen_to_be_invoked.a = (float)LuaAPI.lua_tonumber(L, 2);
            
                translator.UpdateUnityEngineColor(L, 1, __cl_gen_to_be_invoked);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

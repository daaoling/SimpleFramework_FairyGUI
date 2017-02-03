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
    public class SystemCollectionsGenericList_1SystemInt32Wrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(System.Collections.Generic.List<int>), L, translator, 0, 29, 2, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Add", Add);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddRange", AddRange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AsReadOnly", AsReadOnly);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BinarySearch", BinarySearch);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Contains", Contains);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyTo", CopyTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Exists", Exists);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Find", Find);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindAll", FindAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindIndex", FindIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindLast", FindLast);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindLastIndex", FindLastIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ForEach", ForEach);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRange", GetRange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IndexOf", IndexOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Insert", Insert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InsertRange", InsertRange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LastIndexOf", LastIndexOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAll", RemoveAll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveAt", RemoveAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveRange", RemoveRange);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Reverse", Reverse);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Sort", Sort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToArray", ToArray);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TrimExcess", TrimExcess);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TrueForAll", TrueForAll);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "Capacity", get_Capacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Count", get_Count);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Capacity", set_Capacity);
            
			Utils.EndObjectRegister(typeof(System.Collections.Generic.List<int>), L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(System.Collections.Generic.List<int>), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(System.Collections.Generic.List<int>));
			
			
			Utils.EndClassRegister(typeof(System.Collections.Generic.List<int>), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					System.Collections.Generic.List<int> __cl_gen_ret = new System.Collections.Generic.List<int>();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && translator.Assignable<System.Collections.Generic.IEnumerable<int>>(L, 2))
				{
					System.Collections.Generic.IEnumerable<int> collection = (System.Collections.Generic.IEnumerable<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<int>));
					
					System.Collections.Generic.List<int> __cl_gen_ret = new System.Collections.Generic.List<int>(collection);
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 2 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					int capacity = LuaAPI.xlua_tointeger(L, 2);
					
					System.Collections.Generic.List<int> __cl_gen_ret = new System.Collections.Generic.List<int>(capacity);
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int> constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				
				if (translator.Assignable<System.Collections.Generic.List<int>>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
					int index = LuaAPI.xlua_tointeger(L, 2);
					LuaAPI.lua_pushboolean(L, true);
					LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked[index]);
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
				
				if (translator.Assignable<System.Collections.Generic.List<int>>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					
					System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
					int key = LuaAPI.xlua_tointeger(L, 2);
					__cl_gen_to_be_invoked[key] = LuaAPI.xlua_tointeger(L, 3);
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
        static int Add(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.Add( item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int AddRange(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Collections.Generic.IEnumerable<int> collection = (System.Collections.Generic.IEnumerable<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IEnumerable<int>));
                    
                    __cl_gen_to_be_invoked.AddRange( collection );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int AsReadOnly(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        System.Collections.ObjectModel.ReadOnlyCollection<int> __cl_gen_ret = __cl_gen_to_be_invoked.AsReadOnly(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int BinarySearch(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.BinarySearch( item );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Collections.Generic.IComparer<int>>(L, 3)) 
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.IComparer<int> comparer = (System.Collections.Generic.IComparer<int>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IComparer<int>));
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.BinarySearch( item, comparer );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<System.Collections.Generic.IComparer<int>>(L, 5)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int count = LuaAPI.xlua_tointeger(L, 3);
                    int item = LuaAPI.xlua_tointeger(L, 4);
                    System.Collections.Generic.IComparer<int> comparer = (System.Collections.Generic.IComparer<int>)translator.GetObject(L, 5, typeof(System.Collections.Generic.IComparer<int>));
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.BinarySearch( index, count, item, comparer );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.BinarySearch!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Clear(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Contains(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Contains( item );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int CopyTo(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<int[]>(L, 2)) 
                {
                    int[] array = (int[])translator.GetObject(L, 2, typeof(int[]));
                    
                    __cl_gen_to_be_invoked.CopyTo( array );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<int[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int[] array = (int[])translator.GetObject(L, 2, typeof(int[]));
                    int arrayIndex = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.CopyTo( array, arrayIndex );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<int[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int[] array = (int[])translator.GetObject(L, 3, typeof(int[]));
                    int arrayIndex = LuaAPI.xlua_tointeger(L, 4);
                    int count = LuaAPI.xlua_tointeger(L, 5);
                    
                    __cl_gen_to_be_invoked.CopyTo( index, array, arrayIndex, count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.CopyTo!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Exists(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Exists( match );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Find(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.Find( match );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindAll(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 2);
                    
                        System.Collections.Generic.List<int> __cl_gen_ret = __cl_gen_to_be_invoked.FindAll( match );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Predicate<int>>(L, 2)) 
                {
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.FindIndex( match );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Predicate<int>>(L, 3)) 
                {
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 3);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.FindIndex( startIndex, match );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.Predicate<int>>(L, 4)) 
                {
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    int count = LuaAPI.xlua_tointeger(L, 3);
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 4);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.FindIndex( startIndex, count, match );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.FindIndex!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindLast(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.FindLast( match );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindLastIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<System.Predicate<int>>(L, 2)) 
                {
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.FindLastIndex( match );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<System.Predicate<int>>(L, 3)) 
                {
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 3);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.FindLastIndex( startIndex, match );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.Predicate<int>>(L, 4)) 
                {
                    int startIndex = LuaAPI.xlua_tointeger(L, 2);
                    int count = LuaAPI.xlua_tointeger(L, 3);
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 4);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.FindLastIndex( startIndex, count, match );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.FindLastIndex!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int ForEach(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Action<int> action = translator.GetDelegate<System.Action<int>>(L, 2);
                    
                    __cl_gen_to_be_invoked.ForEach( action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetEnumerator(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        System.Collections.Generic.List<int>.Enumerator __cl_gen_ret = __cl_gen_to_be_invoked.GetEnumerator(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetRange(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int count = LuaAPI.xlua_tointeger(L, 3);
                    
                        System.Collections.Generic.List<int> __cl_gen_ret = __cl_gen_to_be_invoked.GetRange( index, count );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int IndexOf(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.IndexOf( item );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.IndexOf( item, index );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    int count = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.IndexOf( item, index, count );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.IndexOf!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Insert(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int item = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.Insert( index, item );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int InsertRange(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    System.Collections.Generic.IEnumerable<int> collection = (System.Collections.Generic.IEnumerable<int>)translator.GetObject(L, 3, typeof(System.Collections.Generic.IEnumerable<int>));
                    
                    __cl_gen_to_be_invoked.InsertRange( index, collection );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int LastIndexOf(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.LastIndexOf( item );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.LastIndexOf( item, index );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    int index = LuaAPI.xlua_tointeger(L, 3);
                    int count = LuaAPI.xlua_tointeger(L, 4);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.LastIndexOf( item, index, count );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.LastIndexOf!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Remove(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int item = LuaAPI.xlua_tointeger(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.Remove( item );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int RemoveAll(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 2);
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.RemoveAll( match );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int RemoveAt(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.RemoveAt( index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int RemoveRange(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int count = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.RemoveRange( index, count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Reverse(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Reverse(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int count = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.Reverse( index, count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.Reverse!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Sort(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Sort(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Collections.Generic.IComparer<int>>(L, 2)) 
                {
                    System.Collections.Generic.IComparer<int> comparer = (System.Collections.Generic.IComparer<int>)translator.GetObject(L, 2, typeof(System.Collections.Generic.IComparer<int>));
                    
                    __cl_gen_to_be_invoked.Sort( comparer );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<System.Comparison<int>>(L, 2)) 
                {
                    System.Comparison<int> comparison = translator.GetDelegate<System.Comparison<int>>(L, 2);
                    
                    __cl_gen_to_be_invoked.Sort( comparison );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<System.Collections.Generic.IComparer<int>>(L, 4)) 
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    int count = LuaAPI.xlua_tointeger(L, 3);
                    System.Collections.Generic.IComparer<int> comparer = (System.Collections.Generic.IComparer<int>)translator.GetObject(L, 4, typeof(System.Collections.Generic.IComparer<int>));
                    
                    __cl_gen_to_be_invoked.Sort( index, count, comparer );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.Collections.Generic.List<int>.Sort!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int ToArray(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int[] __cl_gen_ret = __cl_gen_to_be_invoked.ToArray(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int TrimExcess(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.TrimExcess(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int TrueForAll(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    System.Predicate<int> match = translator.GetDelegate<System.Predicate<int>>(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.TrueForAll( match );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_Capacity(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.Capacity);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_Count(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.Count);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_Capacity(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                System.Collections.Generic.List<int> __cl_gen_to_be_invoked = (System.Collections.Generic.List<int>)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.Capacity = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

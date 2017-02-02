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
    public class UnityEngineTransformWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Transform), L, translator, 0, 21, 17, 12);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetParent", SetParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Translate", Translate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Rotate", Rotate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RotateAround", RotateAround);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "LookAt", LookAt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransformDirection", TransformDirection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InverseTransformDirection", InverseTransformDirection);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransformVector", TransformVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InverseTransformVector", InverseTransformVector);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TransformPoint", TransformPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InverseTransformPoint", InverseTransformPoint);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DetachChildren", DetachChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAsFirstSibling", SetAsFirstSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetAsLastSibling", SetAsLastSibling);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSiblingIndex", SetSiblingIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetSiblingIndex", GetSiblingIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Find", Find);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsChildOf", IsChildOf);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "FindChild", FindChild);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetEnumerator", GetEnumerator);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetChild", GetChild);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "position", get_position);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localPosition", get_localPosition);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "eulerAngles", get_eulerAngles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localEulerAngles", get_localEulerAngles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "right", get_right);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "up", get_up);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "forward", get_forward);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rotation", get_rotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localRotation", get_localRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localScale", get_localScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "parent", get_parent);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "worldToLocalMatrix", get_worldToLocalMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "localToWorldMatrix", get_localToWorldMatrix);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "root", get_root);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childCount", get_childCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "lossyScale", get_lossyScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "hasChanged", get_hasChanged);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "position", set_position);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localPosition", set_localPosition);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "eulerAngles", set_eulerAngles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localEulerAngles", set_localEulerAngles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "right", set_right);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "up", set_up);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "forward", set_forward);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rotation", set_rotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localRotation", set_localRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "localScale", set_localScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "parent", set_parent);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "hasChanged", set_hasChanged);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Transform), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Transform), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Transform));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Transform), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.Transform does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetParent(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    __cl_gen_to_be_invoked.SetParent( parent );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    bool worldPositionStays = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.SetParent( parent, worldPositionStays );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.SetParent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Translate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.Translate( x, y, z );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 translation;translator.Get(L, 2, out translation);
                    
                    __cl_gen_to_be_invoked.Translate( translation );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Space>(L, 5)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Space relativeTo;translator.Get(L, 5, out relativeTo);
                    
                    __cl_gen_to_be_invoked.Translate( x, y, z, relativeTo );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Transform>(L, 5)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 5, typeof(UnityEngine.Transform));
                    
                    __cl_gen_to_be_invoked.Translate( x, y, z, relativeTo );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Space>(L, 3)) 
                {
                    UnityEngine.Vector3 translation;translator.Get(L, 2, out translation);
                    UnityEngine.Space relativeTo;translator.Get(L, 3, out relativeTo);
                    
                    __cl_gen_to_be_invoked.Translate( translation, relativeTo );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Transform>(L, 3)) 
                {
                    UnityEngine.Vector3 translation;translator.Get(L, 2, out translation);
                    UnityEngine.Transform relativeTo = (UnityEngine.Transform)translator.GetObject(L, 3, typeof(UnityEngine.Transform));
                    
                    __cl_gen_to_be_invoked.Translate( translation, relativeTo );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.Translate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Rotate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float xAngle = (float)LuaAPI.lua_tonumber(L, 2);
                    float yAngle = (float)LuaAPI.lua_tonumber(L, 3);
                    float zAngle = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.Rotate( xAngle, yAngle, zAngle );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 eulerAngles;translator.Get(L, 2, out eulerAngles);
                    
                    __cl_gen_to_be_invoked.Rotate( eulerAngles );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Vector3 axis;translator.Get(L, 2, out axis);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    
                    __cl_gen_to_be_invoked.Rotate( axis, angle );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& translator.Assignable<UnityEngine.Space>(L, 5)) 
                {
                    float xAngle = (float)LuaAPI.lua_tonumber(L, 2);
                    float yAngle = (float)LuaAPI.lua_tonumber(L, 3);
                    float zAngle = (float)LuaAPI.lua_tonumber(L, 4);
                    UnityEngine.Space relativeTo;translator.Get(L, 5, out relativeTo);
                    
                    __cl_gen_to_be_invoked.Rotate( xAngle, yAngle, zAngle, relativeTo );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Space>(L, 3)) 
                {
                    UnityEngine.Vector3 eulerAngles;translator.Get(L, 2, out eulerAngles);
                    UnityEngine.Space relativeTo;translator.Get(L, 3, out relativeTo);
                    
                    __cl_gen_to_be_invoked.Rotate( eulerAngles, relativeTo );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Space>(L, 4)) 
                {
                    UnityEngine.Vector3 axis;translator.Get(L, 2, out axis);
                    float angle = (float)LuaAPI.lua_tonumber(L, 3);
                    UnityEngine.Space relativeTo;translator.Get(L, 4, out relativeTo);
                    
                    __cl_gen_to_be_invoked.Rotate( axis, angle, relativeTo );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.Rotate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int RotateAround(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Vector3 point;translator.Get(L, 2, out point);
                    UnityEngine.Vector3 axis;translator.Get(L, 3, out axis);
                    float angle = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    __cl_gen_to_be_invoked.RotateAround( point, axis, angle );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int LookAt(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Transform>(L, 2)) 
                {
                    UnityEngine.Transform target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    __cl_gen_to_be_invoked.LookAt( target );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 worldPosition;translator.Get(L, 2, out worldPosition);
                    
                    __cl_gen_to_be_invoked.LookAt( worldPosition );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Transform>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Transform target = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    UnityEngine.Vector3 worldUp;translator.Get(L, 3, out worldUp);
                    
                    __cl_gen_to_be_invoked.LookAt( target, worldUp );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Vector3 worldPosition;translator.Get(L, 2, out worldPosition);
                    UnityEngine.Vector3 worldUp;translator.Get(L, 3, out worldUp);
                    
                    __cl_gen_to_be_invoked.LookAt( worldPosition, worldUp );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.LookAt!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int TransformDirection(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.TransformDirection( x, y, z );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.TransformDirection( direction );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.TransformDirection!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int InverseTransformDirection(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.InverseTransformDirection( x, y, z );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 direction;translator.Get(L, 2, out direction);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.InverseTransformDirection( direction );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.InverseTransformDirection!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int TransformVector(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.TransformVector( x, y, z );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 vector;translator.Get(L, 2, out vector);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.TransformVector( vector );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.TransformVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int InverseTransformVector(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.InverseTransformVector( x, y, z );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 vector;translator.Get(L, 2, out vector);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.InverseTransformVector( vector );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.InverseTransformVector!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int TransformPoint(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.TransformPoint( x, y, z );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.TransformPoint( position );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.TransformPoint!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int InverseTransformPoint(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    float x = (float)LuaAPI.lua_tonumber(L, 2);
                    float y = (float)LuaAPI.lua_tonumber(L, 3);
                    float z = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.InverseTransformPoint( x, y, z );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.Vector3>(L, 2)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    
                        UnityEngine.Vector3 __cl_gen_ret = __cl_gen_to_be_invoked.InverseTransformPoint( position );
                        translator.PushUnityEngineVector3(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Transform.InverseTransformPoint!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int DetachChildren(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.DetachChildren(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetAsFirstSibling(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetAsFirstSibling(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetAsLastSibling(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                    __cl_gen_to_be_invoked.SetAsLastSibling(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetSiblingIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.SetSiblingIndex( index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetSiblingIndex(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetSiblingIndex(  );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
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
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Transform __cl_gen_ret = __cl_gen_to_be_invoked.Find( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int IsChildOf(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.Transform parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsChildOf( parent );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int FindChild(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    string name = LuaAPI.lua_tostring(L, 2);
                    
                        UnityEngine.Transform __cl_gen_ret = __cl_gen_to_be_invoked.FindChild( name );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetEnumerator(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    
                        System.Collections.IEnumerator __cl_gen_ret = __cl_gen_to_be_invoked.GetEnumerator(  );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetChild(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                        UnityEngine.Transform __cl_gen_ret = __cl_gen_to_be_invoked.GetChild( index );
                        translator.Push(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_position(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.position);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_localPosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.localPosition);
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
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.eulerAngles);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_localEulerAngles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.localEulerAngles);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_right(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.right);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_up(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.up);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_forward(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.forward);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_rotation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, __cl_gen_to_be_invoked.rotation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_localRotation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineQuaternion(L, __cl_gen_to_be_invoked.localRotation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_localScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.localScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_parent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.parent);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_worldToLocalMatrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.worldToLocalMatrix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_localToWorldMatrix(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.localToWorldMatrix);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_root(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.root);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_childCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.childCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_lossyScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, __cl_gen_to_be_invoked.lossyScale);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_hasChanged(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.hasChanged);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_position(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.position = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_localPosition(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.localPosition = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_eulerAngles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.eulerAngles = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_localEulerAngles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.localEulerAngles = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_right(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.right = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_up(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.up = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_forward(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.forward = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_rotation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.rotation = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_localRotation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Quaternion __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.localRotation = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_localScale(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.localScale = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_parent(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_hasChanged(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Transform __cl_gen_to_be_invoked = (UnityEngine.Transform)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.hasChanged = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

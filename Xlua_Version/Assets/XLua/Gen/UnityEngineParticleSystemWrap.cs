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
    public class UnityEngineParticleSystemWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.ParticleSystem), L, translator, 0, 10, 22, 16);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetParticles", SetParticles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetParticles", GetParticles);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetCollisionEvents", GetCollisionEvents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Simulate", Simulate);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Play", Play);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Stop", Stop);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Pause", Pause);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsAlive", IsAlive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Emit", Emit);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "startDelay", get_startDelay);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPlaying", get_isPlaying);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStopped", get_isStopped);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isPaused", get_isPaused);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "loop", get_loop);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playOnAwake", get_playOnAwake);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "time", get_time);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "duration", get_duration);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "playbackSpeed", get_playbackSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "particleCount", get_particleCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "safeCollisionEventSize", get_safeCollisionEventSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableEmission", get_enableEmission);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "emissionRate", get_emissionRate);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startSpeed", get_startSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startSize", get_startSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startColor", get_startColor);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startRotation", get_startRotation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startLifetime", get_startLifetime);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gravityModifier", get_gravityModifier);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "maxParticles", get_maxParticles);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "simulationSpace", get_simulationSpace);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "randomSeed", get_randomSeed);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "startDelay", set_startDelay);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "loop", set_loop);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playOnAwake", set_playOnAwake);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "time", set_time);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "playbackSpeed", set_playbackSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableEmission", set_enableEmission);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "emissionRate", set_emissionRate);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startSpeed", set_startSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startSize", set_startSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startColor", set_startColor);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startRotation", set_startRotation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startLifetime", set_startLifetime);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "gravityModifier", set_gravityModifier);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "maxParticles", set_maxParticles);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "simulationSpace", set_simulationSpace);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "randomSeed", set_randomSeed);
            
			Utils.EndObjectRegister(typeof(UnityEngine.ParticleSystem), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.ParticleSystem), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.ParticleSystem));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.ParticleSystem), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.ParticleSystem __cl_gen_ret = new UnityEngine.ParticleSystem();
					translator.Push(L, __cl_gen_ret);
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int SetParticles(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ParticleSystem.Particle[] particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
                    int size = LuaAPI.xlua_tointeger(L, 3);
                    
                    __cl_gen_to_be_invoked.SetParticles( particles, size );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetParticles(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.ParticleSystem.Particle[] particles = (UnityEngine.ParticleSystem.Particle[])translator.GetObject(L, 2, typeof(UnityEngine.ParticleSystem.Particle[]));
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetParticles( particles );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int GetCollisionEvents(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    UnityEngine.GameObject go = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
                    UnityEngine.ParticleSystem.CollisionEvent[] collisionEvents = (UnityEngine.ParticleSystem.CollisionEvent[])translator.GetObject(L, 3, typeof(UnityEngine.ParticleSystem.CollisionEvent[]));
                    
                        int __cl_gen_ret = __cl_gen_to_be_invoked.GetCollisionEvents( go, collisionEvents );
                        LuaAPI.xlua_pushinteger(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Simulate(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    float t = (float)LuaAPI.lua_tonumber(L, 2);
                    
                    __cl_gen_to_be_invoked.Simulate( t );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    float t = (float)LuaAPI.lua_tonumber(L, 2);
                    bool withChildren = LuaAPI.lua_toboolean(L, 3);
                    
                    __cl_gen_to_be_invoked.Simulate( t, withChildren );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    float t = (float)LuaAPI.lua_tonumber(L, 2);
                    bool withChildren = LuaAPI.lua_toboolean(L, 3);
                    bool restart = LuaAPI.lua_toboolean(L, 4);
                    
                    __cl_gen_to_be_invoked.Simulate( t, withChildren, restart );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Simulate!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Play(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Play(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Play( withChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Play!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Stop(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Stop(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Stop( withChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Stop!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Pause(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Pause(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Pause( withChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Pause!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Clear(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                    __cl_gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                    __cl_gen_to_be_invoked.Clear( withChildren );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Clear!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int IsAlive(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 1) 
                {
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsAlive(  );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                if(__gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool withChildren = LuaAPI.lua_toboolean(L, 2);
                    
                        bool __cl_gen_ret = __cl_gen_to_be_invoked.IsAlive( withChildren );
                        LuaAPI.lua_pushboolean(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.IsAlive!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int Emit(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
            
            
			int __gen_param_count = LuaAPI.lua_gettop(L);
            
            try {
                if(__gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int count = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.Emit( count );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 2&& translator.Assignable<UnityEngine.ParticleSystem.Particle>(L, 2)) 
                {
                    UnityEngine.ParticleSystem.Particle particle;translator.Get(L, 2, out particle);
                    
                    __cl_gen_to_be_invoked.Emit( particle );
                    
                    
                    
                    return 0;
                }
                if(__gen_param_count == 6&& translator.Assignable<UnityEngine.Vector3>(L, 2)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& translator.Assignable<UnityEngine.Color32>(L, 6)) 
                {
                    UnityEngine.Vector3 position;translator.Get(L, 2, out position);
                    UnityEngine.Vector3 velocity;translator.Get(L, 3, out velocity);
                    float size = (float)LuaAPI.lua_tonumber(L, 4);
                    float lifetime = (float)LuaAPI.lua_tonumber(L, 5);
                    UnityEngine.Color32 color;translator.Get(L, 6, out color);
                    
                    __cl_gen_to_be_invoked.Emit( position, velocity, size, lifetime, color );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.ParticleSystem.Emit!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startDelay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startDelay);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isPlaying(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isPlaying);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isStopped(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isStopped);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_isPaused(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.isPaused);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_loop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.loop);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_playOnAwake(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.playOnAwake);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_time(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.time);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_duration(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.duration);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_playbackSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.playbackSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_particleCount(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.particleCount);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_safeCollisionEventSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.safeCollisionEventSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_enableEmission(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.enableEmission);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_emissionRate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.emissionRate);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startSpeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startSize);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineColor(L, __cl_gen_to_be_invoked.startColor);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startRotation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startRotation);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_startLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.startLifetime);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_gravityModifier(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.gravityModifier);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_maxParticles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, __cl_gen_to_be_invoked.maxParticles);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_simulationSpace(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.simulationSpace);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int get_randomSeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushuint(L, __cl_gen_to_be_invoked.randomSeed);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startDelay(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startDelay = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_loop(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.loop = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_playOnAwake(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.playOnAwake = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_time(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.time = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_playbackSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.playbackSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_enableEmission(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.enableEmission = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_emissionRate(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.emissionRate = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startSpeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startSize(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startSize = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startColor(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                UnityEngine.Color __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.startColor = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startRotation(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startRotation = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_startLifetime(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.startLifetime = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_gravityModifier(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.gravityModifier = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_maxParticles(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.maxParticles = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_simulationSpace(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                UnityEngine.ParticleSystemSimulationSpace __cl_gen_value;translator.Get(L, 2, out __cl_gen_value);
				__cl_gen_to_be_invoked.simulationSpace = __cl_gen_value;
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int set_randomSeed(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.ParticleSystem __cl_gen_to_be_invoked = (UnityEngine.ParticleSystem)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.randomSeed = LuaAPI.xlua_touint(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}

using UnityEngine;
using System.Collections;

public delegate void Callback();
public delegate void Callback<T>(T arg1);
public delegate void Callback<T, U>(T arg1, U arg2);
public delegate void Callback<T, U, V>(T arg1, U arg2, V arg3);
public delegate void Callback<T, U, V, W>(T arg1, U arg2, V arg3, W arg4);

public delegate void CallbackArg(object[] args);

public delegate void CallbackWithArg(params object[] args);

public delegate void SkillStartEffectFunc(params object[] arg1);

public delegate void SkillEffectFunc(params object[] arg1);

public delegate void BeControlEffectFunc(params object[] arg1);

using UnityEngine;
using System.Collections;
using LuaFramework;
using LuaInterface;
public class testBehaviour : LuaBehaviour
{
    public delegate void VoidDelegate(GameObject go);

    public VoidDelegate onClick;



    [NoToLuaAttribute]
    void OnGUI()
    {
		if (GUI.Button(new Rect(10, 10, 150, 100), "I am a button")) 
			Util.CallMethod(name, "register", this);

		if (GUI.Button(new Rect(10, 200, 150, 100), "I am a button")) 
			if(onClick!=null) onClick(gameObject);
	}
}

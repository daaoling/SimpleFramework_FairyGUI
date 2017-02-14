using UnityEngine;
using System.Collections;
using XLua;
using FairyGUI;

public class fairygui_test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        UIConfig.defaultFont = "afont";

        GRoot.inst.SetContentScaleFactor(1152, 648);

        UIPackage.AddPackage("UI/Common");
        UIPackage.AddPackage("UI/DengLu");
        UIPackage.AddPackage("UI/Main");

        UIPackage.AddPackage("UI/DengLu");
        GComponent mainView = UIPackage.CreateObject("DengLu", "Main").asCom;
        mainView.SetSize(GRoot.inst.width, GRoot.inst.height);
        mainView.AddRelation(GRoot.inst, RelationType.Size);
        GRoot.inst.AddChild(mainView);

        GComponent mainCom = new GComponent();
        GComponent  n8 =  mainCom.GetChild("n8").asCom;
        GObject n9 =  n8.GetChild("n9").asLabel;


        n9.onClick.Add(Click);

        
        

        //UIObjectFactory.SetLoaderExtension()
	}

    void Click(EventContext context) 
    {

    }
}

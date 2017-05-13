using UnityEngine;
using System.Collections;
using System.Linq;

public class IllegalWordDetectionTest : MonoBehaviour
{


    void Start()
    {
        TextAsset binAsset = Resources.Load("MinGanCi", typeof(TextAsset)) as TextAsset;//本地
        basWords = binAsset.text.Split("|"[0]);
        
        //configMaskWordPool = new ConfigMaskWordPool();
        //configMaskWordPool.AddData(lineArray);

        //basWords = configMaskWordPool._datapool.Values.ToArray();
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 100), "TestV1"))
            InitTest();

        if (GUI.Button(new Rect(10, 200, 150, 100), "TestV2"))
            V2Test();
    }
    //ConfigMaskWordPool configMaskWordPool;
    string[] basWords;
    //string inputVale = "草 共产主义 猪 我是朱镕基 干你爸爸 刘伯承|陈毅|贺龙|聂荣臻|徐向前|罗荣桓|叶剑";
    string inputValue = "屄defg东正教dsa SofU  ckd臺灣青年獨立聯盟daoiuq 样什么J&    b玩意 日你先人";
    void InitTest()
    {
        IllegalWoirDetectionV1.Init(basWords);
        var timer = new System.Diagnostics.Stopwatch();
        timer.Start();
        UnityEngine.Debug.Log(IllegalWoirDetectionV1.Filter(inputValue));
        timer.Stop();
        UnityEngine.Debug.Log(timer.Elapsed.Milliseconds);
    }

    void V2Test() 
    {
        IllegalWordDetection.Init(basWords);
        var timer = new System.Diagnostics.Stopwatch();
        timer.Start();
        UnityEngine.Debug.Log(IllegalWordDetection.Filter(inputValue));
        timer.Stop();
        UnityEngine.Debug.Log(timer.Elapsed.Milliseconds);
    }
}

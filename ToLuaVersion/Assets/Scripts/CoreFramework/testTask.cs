using UnityEngine;
using System.Collections;

public class testTask : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	
	IEnumerator MyAwesomeTask()  
	 {  
	 while(true) {  
	     Debug.Log("Logcat iz in ur consolez, spammin u wif messagez.");  
	     yield return null;  
	}  
	}  
	
	IEnumerator TaskKiller(float delay, Task t)  
	{  
	 yield return new WaitForSeconds(delay);  
	 t.Stop();  
	}  
	
	void SomeCodeThatCouldBeAnywhereInTheUniverse()  
	{  
	 Task spam = new Task(MyAwesomeTask());  
	 new Task(TaskKiller(5, spam));  
	} 
}

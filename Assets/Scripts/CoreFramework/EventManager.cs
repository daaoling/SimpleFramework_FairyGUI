using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public delegate void CallBackFunctionWithObject(object param);
public class EventManager  {
    //public DictionaryArray dicArray=new DictionaryArray();


    public Dictionary<int, CallBackFunctionWithObject> eventTable
        = new Dictionary<int, CallBackFunctionWithObject>();
	public EventManager()
	{

	}

    //public void Clear()
    //{
    //    dicArray.Clear();
    //}

    public class ListenerException : Exception
    {
        public ListenerException(string msg)
            : base(msg)
        {
        }
    }
    public void AddListener(int id, CallBackFunctionWithObject listenerBeingAdded)
	{
        //dicArray.Add(id,df);

        if (!eventTable.ContainsKey(id))
        {
            eventTable.Add(id, null);
        }

        CallBackFunctionWithObject d = eventTable[id];
        if (d != null && d.GetType() != listenerBeingAdded.GetType())
        {
            throw new ListenerException(string.Format("Attempting to add listener with inconsistent signature for event type {0}. Current listeners have type {1} and listener being added has type {2}", id, d.GetType().Name, listenerBeingAdded.GetType().Name));
        }

        //if (eventTable[id] == null) Debug.Log(" NUL ?");

        eventTable[id] = (CallBackFunctionWithObject)eventTable[id] + listenerBeingAdded;
        
        //if (eventTable[id] != null) Debug.Log(" NOT NUL ?");
    }

	public void RemoveListener(int id,CallBackFunctionWithObject df)
	{
        //dicArray.Remove(id,df);

        if (eventTable.ContainsKey(id))
        {
            Delegate d = eventTable[id];

            if (d == null)
            {
                throw new ListenerException(string.Format("Attempting to remove listener with for event type \"{0}\" but current listener is null.", id));
            }
            else if (d.GetType() != df.GetType())
            {
                throw new ListenerException(string.Format("Attempting to remove listener with inconsistent signature for event type {0}. Current listeners have type {1} and listener being removed has type {2}", id, d.GetType().Name, df.GetType().Name));
            }
        }
        else
        {
            throw new ListenerException(string.Format("Attempting to remove listener for type \"{0}\" but Messenger doesn't know about this event type.", id));
        }


        eventTable[id] = (CallBackFunctionWithObject)eventTable[id] - df;

        if (eventTable[id] == null) {
            eventTable.Remove(id);
        }
	}


	public void CallEvent(int p_eventtype,object al)
	{

        CallBackFunctionWithObject d;
        if (eventTable.TryGetValue(p_eventtype, out d))
        {
            CallBackFunctionWithObject callback = d as CallBackFunctionWithObject;

            if (callback != null)
            {
                callback(al);
            }
            else
            {
                throw new Exception(p_eventtype + "");
            }
        }
	}
}

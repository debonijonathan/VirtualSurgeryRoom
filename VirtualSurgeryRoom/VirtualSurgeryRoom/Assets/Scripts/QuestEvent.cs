using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestEvent
{
    public enum EventStatus{WAITING, CURRENT, DONE};
    // Start is called before the first frame update
    
    public string name;
    public string description;
    public string id;
    public int order = -1;
    public EventStatus status;
    public QuestButtonScripts button;

    public List<QuestPathScripts> pathList = new List<QuestPathScripts>();

    public QuestEvent(string n, string d){
        id = Guid.NewGuid().ToString();
        name = n;
        description = d;
        status = EventStatus.WAITING;
    }

    public void UpdateQuestEvent(EventStatus es){
        status = es;
        button.UpdateButton(es);
    }

    public string GetId(){
        return id;
    }

}

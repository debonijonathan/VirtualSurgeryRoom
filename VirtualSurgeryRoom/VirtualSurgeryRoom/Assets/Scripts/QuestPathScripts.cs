using System.Collections;
using UnityEngine;

public class QuestPathScripts 
{
    public QuestEvent startEvent;
    public QuestEvent endEvent;

    public QuestPathScripts(QuestEvent from, QuestEvent to){
        startEvent = from;
        endEvent = to;
    }
}

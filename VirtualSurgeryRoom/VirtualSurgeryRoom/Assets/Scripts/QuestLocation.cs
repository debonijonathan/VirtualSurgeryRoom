using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestLocation : MonoBehaviour
{

    public QuestManagerScript qManager;
    public QuestEvent qEvent;
    public QuestButtonScripts qButton;

    void OnTriggerEnter(Collider col) //If you enter the trigger this will happen.
	{
		if(col.gameObject.tag != "Player") return;

        if(qEvent.status != QuestEvent.EventStatus.CURRENT)  return;

        qEvent.UpdateQuestEvent(QuestEvent.EventStatus.DONE);
        qButton.UpdateButton(QuestEvent.EventStatus.DONE);
        qManager.UpdateQuestsOnCompletion(qEvent);
	}
    public void Setup(QuestManagerScript qm, QuestEvent qe, QuestButtonScripts qb){
        qManager = qm;
        qEvent = qe;
        qButton = qb;
        qe.button = qButton;

    }

}

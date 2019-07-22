using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManagerScript : MonoBehaviour
{

    public Quest quest = new Quest();

    public GameObject questPrintBox;
    public GameObject buttonPrefab;
    // Start is called before the first frame update

    public GameObject A;
    public GameObject A1;

    public GameObject B;
    public GameObject B1;

    public GameObject C;
    public GameObject D;
    public GameObject D1;

    public GameObject E;

    void Start()
    {

        Cursor.visible = true;

         QuestEvent a = quest.AddQuestEvent("Task 1","Prendere lo shampoo");
         QuestEvent b = quest.AddQuestEvent("Task 2","Lavarsi le mani");
         QuestEvent c = quest.AddQuestEvent("Task 3","Asciugarsi le mani");
         QuestEvent d = quest.AddQuestEvent("Task 4","Cambiarsi");
         QuestEvent e = quest.AddQuestEvent("Task 5","Entrare in Sala Operatoria");

        quest.AddPath(a.GetId(), b.GetId());
        quest.AddPath(b.GetId(), c.GetId());

        quest.AddPath(c.GetId(), d.GetId());
        quest.AddPath(d.GetId(), e.GetId());

        quest.BFS(a.GetId());

        //QuestButtonScripts button = CreateButton(a).GetComponent<QuestButtonScripts>();

        GameObject b1 = CreateButton(a);
        GameObject b2 = CreateButton(b);
        GameObject b3 = CreateButton(c);
        GameObject b4 = CreateButton(d);
        GameObject b5 = CreateButton(e);

        QuestButtonScripts button1 = b1.GetComponent<QuestButtonScripts>();
        QuestButtonScripts button2 = b2.GetComponent<QuestButtonScripts>();
        QuestButtonScripts button3 = b3.GetComponent<QuestButtonScripts>();
        QuestButtonScripts button4 = b4.GetComponent<QuestButtonScripts>();
        QuestButtonScripts button5 = b5.GetComponent<QuestButtonScripts>();

        A.GetComponent<QuestLocation>().Setup(this,a,button1);
        A1.GetComponent<QuestLocation>().Setup(this,a,button1);

        B.GetComponent<QuestLocation>().Setup(this,b,button2);
        B1.GetComponent<QuestLocation>().Setup(this,b,button2);

        C.GetComponent<QuestLocation>().Setup(this,c,button3);
        D.GetComponent<QuestLocation>().Setup(this,d,button4);
                D1.GetComponent<QuestLocation>().Setup(this,d,button4);

        E.GetComponent<QuestLocation>().Setup(this,e,button5);



        quest.PrintPath();
    }

    GameObject CreateButton(QuestEvent e){
        GameObject b = Instantiate(buttonPrefab);
        b.GetComponent<QuestButtonScripts>().Setup(e,questPrintBox);
        if(e.order == 1){
            b.GetComponent<QuestButtonScripts>().UpdateButton(QuestEvent.EventStatus.CURRENT);
            e.status = QuestEvent.EventStatus.CURRENT;
        }
        return b;
    }
    public void UpdateQuestsOnCompletion(QuestEvent e){
        foreach(QuestEvent n in quest.questEvents){
            if(n.order == (e.order + 1)){
                n.UpdateQuestEvent(QuestEvent.EventStatus.CURRENT);
            }
        }
    }
}

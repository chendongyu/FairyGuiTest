using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
public class UIOneButtonLayout : MonoBehaviour
{
    public UIPanel panel;
    private GComponent ui;
    private Transition tranStart;
    private Transition tranStop;
    // Start is called before the first frame update
    void Start()
    {
        ui = panel.ui;
        tranStart = ui.GetTransition("start");
        tranStop = ui.GetTransition("stop");
        tranStart.timeScale = 2f;
        //ui.GetChild("n1").onClick.Add(()=> { ProcessButtonClick("n1"); });
        //ui.GetChild("n2").onClick.Add(()=> { ProcessButtonClick("n2"); });
        //ui.GetChild("n3").onClick.Add(()=> { ProcessButtonClick("n3"); });
        GObject[] objs = ui.GetChildren();
        foreach (var obj in objs)
        {
            if (obj as GButton!=null)
            {
                obj.onClick.Add(() => {
                    ProcessButtonClick(obj.name);
                });
            }
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            tranStart.Play();
        }
        if (Input.GetKeyDown("b"))
        {
            tranStop.Play();
        }
    }

    public void ProcessButtonClick(string name)
    {
        switch (name)
        {
            case "n1":
                print("hihi");
                break;
            case "n2":
                print("hello world");
                break;
            case "n3":
                print("good morning");
                break;
            default:break;

        }
    }
}

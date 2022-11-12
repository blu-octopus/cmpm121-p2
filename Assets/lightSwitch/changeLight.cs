using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
public class ChangingLight : MonoBehaviour{
   // create lights list that can be updated in the inspector
   public List<Light> Lights;
   //public lights : Light[];
   // create frame and button variables
   private VisualElement frame;
   private Button button;
   // This function is called when the object becomes enabled and active.
   void OnEnable(){
       // get the UIDocument component (make sure this name matches!)
       var uiDocument = GetComponent<UIDocument>();
       // get the rootVisualElement (the frame component)
       var rootVisualElement = uiDocument.rootVisualElement;
       frame = rootVisualElement.Q<VisualElement>("frame");
       // get the button, which is nested in the frame
       button = frame.Q<Button>("lightswitch");
       // create event listener that calls ChangeLight() when pressed
       button.RegisterCallback<ClickEvent>(ev => ChangeLight());
   }

   bool on = true;

   private void ChangeLight(){
     //clicked button
     //this.GetComponent<Light>().enabled = !on;
     Lights.ForEach(light => light.enabled = !on);
   }

  }

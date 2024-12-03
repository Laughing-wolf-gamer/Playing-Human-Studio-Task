using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class InputReciver : MonoBehaviour {
    
     protected IInputHandler[] inputHandlers;
     public abstract void OnInputReceives();
     private void Awake(){
          inputHandlers = GetComponents<IInputHandler>();
     }
}

using UnityEngine;
using UnityEngine.Events;
public class UIInputReciver : InputReciver {
     [SerializeField] private UnityEvent clickEvent;

     public override void OnInputReceives() {
          foreach(var handlers in inputHandlers){
               handlers.ProcessesInput(Input.mousePosition,gameObject,() => {
                    clickEvent?.Invoke();
               });
          }
     }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(UIInputReciver),typeof(UIInputHandler))]
public class UIButtonCustom : Button{
     private UIInputReciver receiver;
     protected override void Awake(){
          base.Awake();
          receiver = GetComponent<UIInputReciver>();
          onClick.AddListener(() =>{
               receiver.OnInputReceives();
               // AudioManager.Current?.PlayOneShotMusic(Sounds.SoundType.BtnClick);
          });
     }
    
}

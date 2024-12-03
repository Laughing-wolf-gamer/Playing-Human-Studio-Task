using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;
public class UIButtonToggles : MonoBehaviour {
    [SerializeField] private bool showHideToggle,changeColorToggle;
    [SerializeField] private Color activeColor = Color.white,deactivateColor = Color.gray;
    [SerializeField] private Sprite enableColor;
    [SerializeField] private Sprite disableColor;
    [SerializeField] private List<TextMeshProUGUI> toggleInsideText;


    [SerializeField] private Image graphics;

    private void Awake(){
        if(graphics == null){
            graphics = GetComponent<Image>();
        }
    }
    public void Toggle(bool on){

        if(showHideToggle){
            graphics.gameObject.SetActive(on);
        }
        else if(changeColorToggle){
            if(on){
                graphics.color = activeColor;
            }else{
                graphics.color = deactivateColor;
            }
        }
        else{
            if(on){
                graphics.sprite = enableColor;
                if(toggleInsideText.Count > 0){
                    toggleInsideText.ForEach(t => t.color = activeColor);
                }
            }else{
                graphics.sprite = disableColor;
                if(toggleInsideText.Count > 0){
                    toggleInsideText.ForEach(t => t.color = deactivateColor);
                }
            }
        }
    }
    
}

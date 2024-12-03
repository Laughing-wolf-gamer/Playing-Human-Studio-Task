using TMPro;
using DG.Tweening;
using UnityEngine;

public class WindowView : MonoBehaviour {
    [SerializeField] private float popViewTime = 1;
    [SerializeField] private Ease popViewEase = Ease.OutBack,popCloseEase = Ease.InBack;
    [SerializeField] private Vector2 popScaleAmount;
    [SerializeField] private RectTransform windowRect;
    [SerializeField] private GameObject backShadow;

    [SerializeField] private TextMeshProUGUI titleTmp,bodyTmp;
    private bool isOpen;
    private void Start() {
        CloseWindow();
    }
    public void SetData(string title,string body){
        titleTmp.SetText(title);
        bodyTmp.SetText(body);
    }
    public void OpenWindow(){
        if(!isOpen){
            isOpen = true;
            windowRect.gameObject.SetActive(true);
            windowRect.DOSizeDelta(popScaleAmount, popViewTime).SetEase(popViewEase);
            backShadow.SetActive(true);
        }
    }
    public void CloseWindow(){
        isOpen = false;
        windowRect.DOSizeDelta(Vector2.zero, popViewTime).SetEase(popCloseEase).onComplete += ()=>{
            windowRect.gameObject.SetActive(false);
            backShadow.SetActive(false);
        };
    }


}

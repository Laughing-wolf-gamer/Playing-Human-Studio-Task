using UnityEngine;

public class SideBarBtn : MonoBehaviour {
    [SerializeField] private WindowView windowView;

    [SerializeField] private string title;
    [SerializeField] private string body;

    public void OpenWindow(){
        windowView.OpenWindow();
        windowView.SetData(title, body);
    }
    public void CloseWindow(){
        windowView.CloseWindow();
    }
    
}

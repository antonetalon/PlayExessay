using FriendsGamesTools;
using TMPro;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public TextMeshProUGUI label;
    public void OnLeft() => label.text = "left";
    public void OnRight() => label.text = "right";
    public void OnSliderChanged(float val) => label.text = val.ToShownPercents();
}

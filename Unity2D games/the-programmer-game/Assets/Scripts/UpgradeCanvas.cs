using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class UpgradeCanvas : MonoBehaviour
{
    public Sprite upgradeImage;
    private Image currentImage;

    public void ChangeColor()
    {
        string name = EventSystem.current.currentSelectedGameObject.name;
        currentImage = GameObject.Find(name).GetComponent<Image>();
        currentImage.sprite = upgradeImage;
    }
}

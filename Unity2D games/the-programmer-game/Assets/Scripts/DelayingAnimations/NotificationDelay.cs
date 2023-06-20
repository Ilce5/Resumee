using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationDelay : MonoBehaviour
{
    public GameObject notification;
    private Animator anim;

     void Start()
    {
        anim = notification.GetComponent<Animator>();
        anim.Play("NotificationAnimationEntry");
        Invoke("OffAnim", 5f);
    }
    public void OffAnim()
    {
        anim.Play("NotificationAnimationClose");
        Invoke("Iskluci", 1f);

    }
    void Iskluci()
    {
        notification.SetActive(false);
    }
}

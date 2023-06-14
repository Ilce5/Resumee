using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardTurnOff : MonoBehaviour
{
    private float clock;
    public GameObject rewardImage;
    // Update is called once per frame
    void Update()
    {
        if (rewardImage.activeSelf)
        {
            clock += Time.deltaTime;
            if (clock > 4f)
            {
                rewardImage.SetActive(false);
                clock = 0f;
            }
        }
    }
}

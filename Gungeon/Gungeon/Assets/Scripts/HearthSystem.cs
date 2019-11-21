using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HearthSystem : MonoBehaviour
{
    private int maxHearthAmount = 5;
    public int startHearths = 3;
    public int curHealth;
    private int maxHealth;
    private int healthPerHearth = 3;

    public Image[] healthImages;
    public Sprite[] healthSprites;

    void Start()
    {
        curHealth = startHearths * healthPerHearth;
        maxHealth = maxHearthAmount * healthPerHearth;
        checkHealthAmount();
    }

    void checkHealthAmount()
    {
        for (int i = 0; i < maxHearthAmount; i++)
        {
            if (startHearths <= i)
            {
                healthImages[i].enabled = false;
            }
            else 
            {
                healthImages[i].enabled = true;
            }
        }
        UpdateHearths();
    }

    void UpdateHearths()
    {
        bool empty = false;
        int i = 0;

        foreach (Image image in healthImages)
        {
            if (empty)
            {
                image.sprite = healthSprites[0];
            }
            else 
            {
                i++;
                if (curHealth >= i * healthPerHearth)
                {
                    image.sprite = healthSprites[healthSprites.Length - 1];
                }
                else 
                {
                    int currentHeartHealth = (int)(healthPerHearth - (healthPerHearth * i - curHealth));
                    int healthPerImage = healthPerHearth / (healthSprites.Length - 1);
                    int imageIndex = currentHeartHealth / healthPerImage;
                    image.sprite = healthSprites[imageIndex];
                    empty = true;
                }
            }
        }
    }


    public void TakeDamage(int amount)
    {
        curHealth += amount;
        curHealth = Mathf.Clamp(curHealth, 0, startHearths * healthPerHearth);
        UpdateHearths ();
    }

    public void AddHearthContainer()
    {
        startHearths++;
        startHearths = Mathf.Clamp(startHearths, 0, maxHearthAmount);

        //curHealth = startHearths * healthPerHearth;
        //maxHealth = maxHearthAmount * healthPerHearth;

        checkHealthAmount();
    }
}

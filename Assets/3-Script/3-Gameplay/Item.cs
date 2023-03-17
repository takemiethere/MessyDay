using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item : MonoBehaviour
{
    public int maxClicks = 5;
    public static int numDestroyed = 0;
    public static int maxToDestroy = 5;
    public TextMeshProUGUI uiText;

    public ParticleSystem clickParticle;
    public AudioSource clickSound;

    private int currentClicks = 0;
    private ToolSwitcher toolSwitcher;

    public int totalDust;
    public int doneDust;

    void Start()
    {
        uiText.text = "Clear the dust 0/" + maxToDestroy.ToString();
        toolSwitcher = FindObjectOfType<ToolSwitcher>();
    }

    private void Update()
    {
        totalDust = maxToDestroy;
        doneDust = numDestroyed;
    }

    void OnMouseDown()
    {
        if (currentClicks < maxClicks)
        {
            currentClicks++;

            if (clickParticle != null)
            {
                clickParticle.Play();
            }

            if (clickSound != null)
            {
                clickSound.Play();
            }
        }
        else
        {
            Destroy(gameObject);
            numDestroyed++;
        }

        uiText.text = "Wiped " + numDestroyed.ToString() + "/" + maxToDestroy.ToString();

        if (toolSwitcher.GetActiveToolIndex() == 0)
        {
            // Perform the action for taking the trash to the bin
        }
    }

    void OnMouseUp()
    {
        if (clickParticle != null)
        {
            clickParticle.Stop();
        }

        if (clickSound != null)
        {
            clickSound.Stop();
        }
    }
}

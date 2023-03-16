using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DestroyChild : MonoBehaviour
{
    public GameObject target;
    public Material redMaterial;
    public Material defaultMaterial;
    public TextMeshProUGUI countText;

    private bool isInZone = false;
    private int destroyedCount = 0;
    private int maxdestroyedCount = 2;

    private ToolSwitcher toolSwitcher;
    //public Success scoreManager;

    public int totalBin;
    public int doneBin;

    private void Start()
    {
        toolSwitcher = FindObjectOfType<ToolSwitcher>();        
        totalBin = maxdestroyedCount;
        doneBin = destroyedCount;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Check if the target has at least one child before turning the zone red
            if (target.transform.childCount > 0)
            {
                isInZone = true;
                Debug.Log("Player entered zone");
                GetComponent<Renderer>().material = redMaterial;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInZone = false;
            Debug.Log("Player exited zone");
            GetComponent<Renderer>().material = defaultMaterial;
        }
    }

    private void Update()
    {




        if (isInZone && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Destroying child objects");
            foreach (Transform child in target.GetComponentsInChildren<Transform>())
            {
                if (child.gameObject != target.gameObject)
                {
                    Destroy(child.gameObject);
                    destroyedCount++;
                }
            }
            doneBin = destroyedCount;
            
            //countText.text = "Throw the trash  " + destroyedCount + "/" + maxdestroyedCount;
            countText.text = "Throw the trash  " + doneBin + "/" + totalBin;
        }

        /*if (destroyedCount == maxdestroyedCount) //add 15/3
        {
            scoreManager.AddScore(5);
        }*/



    }

    private void OnMouseDown()
    {
        if (toolSwitcher.GetActiveToolIndex() == 0) // Check if the active tool is the first tool
        {
            // Perform the action for taking the trash to the bin
        }
    }
}
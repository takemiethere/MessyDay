/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolSwitcher : MonoBehaviour
{
    public GameObject destroyBugTool;
    public GameObject destroyMouseTool;
    public GameObject cleaningTool;
    public GameObject sprayCan;
    public GameObject handObject;
    public GameObject bloomObject;

    private KeyCode[] toolSwitchKeys = { KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3 };

    private int currentToolIndex = 0;

    void Start()
    {
        // Set the cleaning tool to be active and the destroy bug and mouse tools to be inactive at the start of the game
        cleaningTool.SetActive(true);
        destroyBugTool.SetActive(false);
        destroyMouseTool.SetActive(false);
    }

    void Update()
    {
        // Check if a tool switch key is pressed and switch to the corresponding tool
        for (int i = 0; i < toolSwitchKeys.Length; i++)
        {
            if (Input.GetKeyDown(toolSwitchKeys[i]))
            {
                SwitchToTool(i);
            }
        }
    }

    public void SwitchToCleaningTool()
    {
        // Set the cleaning tool to be active and the destroy bug and mouse tools to be inactive
        destroyBugTool.SetActive(false);
        destroyMouseTool.SetActive(false);
        cleaningTool.SetActive(true);

        currentToolIndex = 0;
    }

    public void SwitchToDestroyBugTool()
    {
        // Set the destroy bug tool to be active and the cleaning and destroy mouse tools to be inactive

        cleaningTool.SetActive(false);
        destroyMouseTool.SetActive(false);
        destroyBugTool.SetActive(true);

        currentToolIndex = 1;
    }


    public void SwitchToDestroyMouseTool()
    {
        // Set the destroy mouse tool to be active and the cleaning and destroy bug tools to be inactive
        destroyBugTool.SetActive(false);
        cleaningTool.SetActive(false);
        destroyMouseTool.SetActive(true);

        currentToolIndex = 2;
    }

    private void SwitchToTool(int index)
    {
        switch (index)
        {
            case 0:
                SwitchToCleaningTool();
                break;
            case 1:
                SwitchToDestroyBugTool();
                break;
            case 2:
                SwitchToDestroyMouseTool();
                break;
        }
    }
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] tools; // An array of the tool game objects to be switched

    private int activeTool = 0; // Index of the currently active tool

    private void Start()
    {
        // Deactivate all tools except the first one at the start of the game
        for (int i = 1; i < tools.Length; i++)
        {
            tools[i].SetActive(false);
        }
    }

    private void Update()
    {
        // Switch between tools when 1, 2, or 3 keys are pressed
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchTool(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchTool(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchTool(2);
        }
    }

    private void SwitchTool(int index)
    {
        // Deactivate all tools except the one at the specified index
        for (int i = 0; i < tools.Length; i++)
        {
            if (i != index)
            {
                tools[i].SetActive(false);
            }
        }

        // Activate the tool at the specified index
        tools[index].SetActive(true);

        activeTool = index;
    }

    public int GetActiveToolIndex()
    {
        return activeTool;
    }
}

using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Sys_ScreenSize : MonoBehaviour
{
    public Toggle fullScreenToggle;
    public TMPro.TMP_Dropdown resolutionDropdown;
    public Resolution[] resolutions;

    void Start()
    {
        fullScreenToggle.isOn = Screen.fullScreen;
        resolutionDropdown.ClearOptions();
        resolutions = Screen.resolutions;
        resolutionDropdown.AddOptions(resolutions.Select(r => r.ToString()).ToList());
        resolutionDropdown.onValueChanged.AddListener(SetResolution);
    }

    public void SetFullScreen()
    {
        Screen.fullScreen = fullScreenToggle.isOn;
    }

    public void SetResolution(int index)
    {
        Resolution resolution = resolutions[index];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
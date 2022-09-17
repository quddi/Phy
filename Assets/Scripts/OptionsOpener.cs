using UnityEngine;

public class OptionsOpener : MonoBehaviour
{
    [SerializeField] private GameObject _optionsWindow;

    public void SetOptionsActive(bool active)
    {
        _optionsWindow.SetActive(active);
    }
}

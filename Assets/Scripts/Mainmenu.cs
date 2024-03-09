using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    public TMP_InputField joinText, createText;
    public Button join, create, userNameButton;
    public TMP_InputField nameInput;
    public GameObject mainMenu, inputScreen;
    [ContextMenu("Delete")]
    public void DeletePP()
    {
        PlayerPrefs.DeleteAll();
    }
    private void Start()
    {
        join.onClick.AddListener(() =>
        {
            LobbyManager._instance.StartRoom(joinText.text);
        });
        create.onClick.AddListener(() =>
        {
            LobbyManager._instance.StartRoom(createText.text);
        });
        userNameButton.onClick.AddListener(() => { Enter(); });
        if (PlayerPrefs.GetString("username", string.Empty) != string.Empty)
        {
            mainMenu.gameObject.SetActive(true);
            inputScreen.gameObject.SetActive(false);
        }
    }
    public void Enter()
    {
        if (string.IsNullOrEmpty(nameInput.text) || nameInput.text == string.Empty) return;
        PlayerPrefs.SetString("username", nameInput.text);
        mainMenu.gameObject.SetActive(true);
        inputScreen.gameObject.SetActive(false);
    }

}

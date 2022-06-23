using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    [SerializeField] Button Button;
    // Start is called before the first frame update
    void Start()
    {
        Button.onClick.AddListener(OnButtonClick);
    }

    
    void OnButtonClick() 
    {
        SceneManager.LoadScene(1);
    }
}

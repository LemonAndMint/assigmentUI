using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//button aksiyonlarında gerçekleşecek olan fonksiyonlar

public class CanvasButtonManager : MonoBehaviour
{
  public GameObject panel1;
  public GameObject panel2;

  //panelleri active - deactive eder.
  public void managePanelVisibility()
  { 
    GameObject tempPanel = _checkButtonName();
    
    if(tempPanel.activeSelf == true)
    {
      tempPanel.SetActive(false); 
    }
    else{
      tempPanel.SetActive(true); 
    }
  
  }

  //hangi butona basıldığını, ona göre hangi panelin açılacağını belirler.
  private GameObject _checkButtonName(){
    switch (EventSystem.current.currentSelectedGameObject.name)
    {
      case "1Button":
        return panel1;
      case "2Button":
        return panel2;
      default:
        return null;
    }
  }
}

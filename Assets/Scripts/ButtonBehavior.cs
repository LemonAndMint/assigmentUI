using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//parent button behavior
public class ButtonBehavior : MonoBehaviour
{
  private bool isShown;
  public Person person;
  public CanvasPanelManager cpm;
  private void Start() {
    isShown = false;
  }
  public void manageVisibilityChilds(){
    if(isShown != true){cpm.InsListOfChilds(person.getChilds()); isShown = true;}
    else
    {
      for(int i = 1; i < gameObject.transform.childCount; i++){
        Destroy(gameObject.transform.GetChild(i).gameObject);
      }
      isShown = false;
    }
  }
}

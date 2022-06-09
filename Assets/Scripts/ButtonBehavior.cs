using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//parent button behavior
public class ButtonBehavior : MonoBehaviour
{
  private bool isShown;
  public Person person;
  public GameObject childPanel;
  public PersonButtonManager pbm;
  private void Start() {
    isShown = false;
  }
  public void manageVisibilityChilds(){
    if(isShown != true){pbm.InsListOfChilds(person.getChilds()); isShown = true;}
    else
    {
      for(int i = 0; i < childPanel.transform.childCount; i++){
        Destroy(childPanel.transform.GetChild(i).gameObject);
      }
      isShown = false;
    }
  }
}

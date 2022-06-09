using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ButtonBehavior : MonoBehaviour
{
  public Person person;
  public CanvasPanelManager cpm;
  public void showChilds(){
    cpm.InsListOfChilds(person.getChilds());
  }
}

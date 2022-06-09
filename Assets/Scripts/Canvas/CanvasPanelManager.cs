using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//hem person hem de child buttonların yaratımında kullanılan metod. Canvas objesinde bir tane, person buttonlarında da birer tane vardır. 
//Canvas person buttonları, InsListOfPersons(persons), person buttonları child buttonları, InsListOfChilds(childs) oluşturur.
public class CanvasPanelManager : MonoBehaviour
{
  //child özelliklerinin gösterimi için gerekli olan Text componenti
  public Text desc;
  //yaratılacak button, person ya da child olabilir
  public GameObject PersonButton;
  public GameObject PersonGridSystem;
  public GameObject ChildGridSystem;
  public Vector2 startPoint; //Listenin başlayacağı yeri belirler, görsel olarak ayarlamalar daha rahat yapılabilir.
  //butonlar arası boşluk
  public float space;

  public void InsListOfPersons(List<Person> persons){ 

    Vector3 tempPosition = startPoint;
    GameObject tempButton = null;

    foreach(Person person in persons){
      
      tempButton = Instantiate(PersonButton, tempPosition, Quaternion.identity, PersonGridSystem.GetComponent<RectTransform>());
      
      //InsListOfChilds metodunu kullanmak için tekrardan CanvasPanelManager ekledik, değişen tek şey panel, bu noktada buton, ve başlangıç noktası 
      tempButton.GetComponent<PersonButtonManager>().PersonGridSystem = ChildGridSystem;
      tempButton.GetComponent<PersonButtonManager>().startPoint = startPoint;
      tempButton.GetComponent<PersonButtonManager>().space = space;
      tempButton.GetComponent<PersonButtonManager>().desc = desc;
      //butonla ona atanmış person nesnesiyle bağdaştırıyoruz
      tempButton.GetComponent<ButtonBehavior>().person = person;
      tempButton.GetComponent<ButtonBehavior>().childPanel = ChildGridSystem;
      //butonun textini person nesnesiyle bağdaştırıyoruz
      tempButton.transform.GetChild(0).GetComponent<Text>().text = tempButton.GetComponent<ButtonBehavior>().person.getName();  

      //prefabdan buttonun genişliğini alır ve belirli bir aralık ekleyerek butonların hizalı görünmesini sağlar
      //buttonların iç içe geçmesini önler
      tempPosition += new Vector3(PersonButton.GetComponent<RectTransform>().sizeDelta.x / 2 + space, 0, 0);
    
    }
  }


}

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
  public GameObject panel1;
  public Vector2 startPoint; //Listenin başlayacağı yeri belirler, görsel olarak ayarlamalar daha rahat yapılabilir.
  //butonlar arası boşluk
  public float space;

  public void InsListOfPersons(List<Person> persons){ 

    Vector3 tempPosition = startPoint;
    GameObject tempButton = null;

    foreach(Person person in persons){
      
      tempButton = Instantiate(PersonButton, tempPosition, Quaternion.identity, panel1.GetComponent<RectTransform>());
      
      //InsListOfChilds metodunu kullanmak için tekrardan CanvasPanelManager ekledik, değişen tek şey panel, bu noktada buton, ve başlangıç noktası 
      tempButton.GetComponent<CanvasPanelManager>().panel1 = tempButton;
      tempButton.GetComponent<CanvasPanelManager>().startPoint = tempButton.transform.position;
      tempButton.GetComponent<CanvasPanelManager>().space = space;
      tempButton.GetComponent<CanvasPanelManager>().desc = desc;
      //butonla ona atanmış person nesnesiyle bağdaştırıyoruz
      tempButton.GetComponent<ButtonBehavior>().person = person;
      //butonun textini person nesnesiyle bağdaştırıyoruz
      tempButton.transform.GetChild(0).GetComponent<Text>().text = tempButton.GetComponent<ButtonBehavior>().person.getName();  

      //prefabdan buttonun genişliğini alır ve belirli bir aralık ekleyerek butonların hizalı görünmesini sağlar
      //buttonların iç içe geçmesini önler
      tempPosition += new Vector3(PersonButton.GetComponent<RectTransform>().sizeDelta.x / 2 + space, 0, 0);
    
    }
  }

//#TODO you can make it better, merge those two metods
    public void InsListOfChilds(List<Child> childs){

    Vector3 tempPosition = startPoint;
    GameObject tempButton = null;

    foreach(Child child in childs){
      
      tempButton = Instantiate(PersonButton, tempPosition, Quaternion.identity, panel1.GetComponent<RectTransform>());

      tempButton.GetComponent<ShowChildAttributes>().desc = desc;
      tempButton.GetComponent<ShowChildAttributes>().child = child;

      tempButton.transform.GetChild(0).GetComponent<Text>().text = tempButton.GetComponent<ShowChildAttributes>().child.getName();  
      //prefabdan buttonun genişliğini alır ve belirli bir aralık ekleyerek butonların hizalı görünmesini sağlar
      //buttonların iç içe geçmesini önler
      tempPosition += new Vector3(PersonButton.GetComponent<RectTransform>().sizeDelta.x / 2 + space, 0, 0);
    
    }

  }
}

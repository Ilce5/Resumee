using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class WorkPlace : MonoBehaviour
{
    public static WorkPlace Instance { get; private set; } 
    
   [Header("INTERWORKS")]
   [SerializeField] private Text firmNameText;
   [SerializeField] private Text firmLanguageText;
   [SerializeField] private Text jobLevelText;
  
   [Header("IMPORTS")]
   [SerializeField] private CodeSupply codeSupply;
   [SerializeField] private WorkConsoletext codeScript;
  
   
   [SerializeField] private Sprite[] sprites;
   
   [SerializeField] private Image image;
   [SerializeField] private Image bannerImage;
   
   [Header("UI CHANGE")]
   [SerializeField] public Text dashboardActiveCodeText;
   
   [Header("BUTTON")]
   [SerializeField] private GameObject work_Button;
   [SerializeField] private Text button_Text;
   
  
   private string GET_LANG;
   private string GET_LANG_LEVEL;
   private string GET_ACTIVE_FIRM_NAME;

   private Global global;
   
  
       
   private List<string> firms = new List<string>()
   {
       "AMD", "Nvidia" , "Intel","Epic Games" , "Amazon" , "Mojang" , "Adobe" , "Electronic Arts", "SAP" , "Ubisoft" ,
       "IBM","Rockstar Games","Symantec","Blizzard","Oracle","Bethesda","Tesla","Microsoft","Google","NASA","Valve",
       "CD Projekt"
   };
   
  
   
   private List<string> JobLevel = new List<string>(){"Easy","Medium","Hard","Very Hard"};

   public void Awake() {
       Instance = this;
   }

   public void Start()
   {
     
       SetNewJob();
       global = Global.Instance;
       
   }

   public void SetNewJob()
   {
       if (button_Text.text == "Active") {
           return;
       }
       work_Button.GetComponent<Image>().color = Color.white;
       button_Text.text = "Get Job";
       button_Text.color = Color.black;
       
       int random = UnityEngine.Random.Range(0, firms.Count);   // changing firm name
       firmNameText.text = firms[random];
       GET_ACTIVE_FIRM_NAME = firmNameText.text.ToLower();
       
       random = UnityEngine.Random.Range(0, Global.Instance.GetKnwonLanguages().Count);   // changing langangue
       firmLanguageText.text = Global.Instance.GetKnwonLanguages()[random];
       GET_LANG = firmLanguageText.text.ToLower(); 
   
        ChangeTexture(); // changing photo
        firmLanguageText.text = ChangeNameStyle(firmLanguageText.text);
        
       int randomdiff = UnityEngine.Random.Range(0, 100); 
       
       if (Global.Instance.GetLevel() <= 5)
       {
           Debug.Log("0 - 5 lvl");
           if (randomdiff <= 85)
           {
                string ITOADD = "Easy";
                jobLevelText.text = "<color=green>" + ITOADD + "</color>";
                GET_LANG_LEVEL = "ez";


           }
           else
           {
               string ITOADD = "Medium";
               jobLevelText.text = "<color=yellow>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "me";
           }
       }
       else if (Global.Instance.GetLevel() <= 10)
       {
           Debug.Log("6 - 10 lvl");
           if (randomdiff < 30)
           {
               string ITOADD = "Easy";
               jobLevelText.text = "<color=green>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "ez";

           }
           else if (randomdiff < 90)
           {
               string ITOADD = "Medium";
               jobLevelText.text = "<color=yellow>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "me";

           }
           else
           {
               string ITOADD = "Hard";
               jobLevelText.text = "<color=red>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "ha";
           }
       }
       else  if (Global.Instance.GetLevel()<= 15)
       {
           Debug.Log("11 - 15 lvl");
           if (randomdiff <= 10)
           {
               string ITOADD = "Easy";
               jobLevelText.text = "<color=green>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "ez";

           }
           else if (randomdiff < 60)
           {
               string ITOADD = "Medium";
               jobLevelText.text = "<color=yellow>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "me";

           }
           else if (randomdiff < 85)
           {
               string ITOADD = "Hard";
               jobLevelText.text = "<color=red>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "ha";
           }
           else
           {
               string ITOADD = "Very Hard";
               jobLevelText.text = "<color=#69181A>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "vh";
           }
       }
       else if (Global.Instance.GetLevel() <= 20)
       {
           Debug.Log("16 - 20 lvl");
           if (randomdiff <= 10)
           {
               string ITOADD = "Easy";
               jobLevelText.text = "<color=green>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "ez";

           }
           else if (randomdiff < 40)
           {
               string ITOADD = "Medium";
               jobLevelText.text = "<color=yellow>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "me";

           }
           else if (randomdiff < 70)
           {
               string ITOADD = "Hard";
               jobLevelText.text = "<color=red>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "ha";
           }
           else
           {
               string ITOADD = "Very Hard";
               jobLevelText.text = "<color=#69181A>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "vh";
           }
       }
       else  
       {
           Debug.Log("20+ lvl");
           if (randomdiff <= 10)
           {
               string ITOADD = "Easy";
               jobLevelText.text = "<color=green>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "ez";

           }
           else if (randomdiff < 30)
           {
               string ITOADD = "Medium";
               jobLevelText.text = "<color=yellow>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "me";

           }
           else if (randomdiff < 50)
           {
               string ITOADD = "Hard";
               jobLevelText.text = "<color=red>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "ha";
           }
           else
           {
               string ITOADD = "Very Hard";
               jobLevelText.text = "<color=#69181A>" + ITOADD + "</color>";
               GET_LANG_LEVEL = "vh";
           }
       }


   }

   public void GetJob()   
   {
       if (global.GetJobStatus()) {
           PopUpController.Instance.UsePopUp_AlreadyHaveJob();
           return;
       }
       if (button_Text.text == "Completed") {
           return;
       }
       
       global.Job_Started(button_Text);
       
       work_Button.GetComponent<Image>().color = Color.Lerp(Color.white, new Color(0, 0.7f, 0), 0.9f);
       button_Text.text = "Active";
       button_Text.color = Color.white;
       
       string str = GET_LANG + GET_LANG_LEVEL;
       string newActiveCode = codeSupply.getNewCode(str);
       codeScript.changeActiveCode(newActiveCode);
       changeActiveJobText(GET_ACTIVE_FIRM_NAME);
       Global.Instance.updateActiveLang(GET_LANG);
   }
 
   public void ChangeTexture()
   {
       switch (GET_ACTIVE_FIRM_NAME)
       {
          case"amd":
           {
               image.GetComponent<Image>().sprite = sprites[0];
               bannerImage.GetComponent<Image>().sprite = sprites[0];
               break;
           }
          case"nvidia":
          {
              image.GetComponent<Image>().sprite = sprites[1];
              bannerImage.GetComponent<Image>().sprite = sprites[1];
              break;
          }
          case"intel":
          {
              image.GetComponent<Image>().sprite = sprites[2];
              bannerImage.GetComponent<Image>().sprite = sprites[2];
              break;
          }
          case"epic games":
          {
              image.GetComponent<Image>().sprite = sprites[3];
              bannerImage.GetComponent<Image>().sprite = sprites[3];
              break;
          }
          case"amazon":
          {
              image.GetComponent<Image>().sprite = sprites[4];
              bannerImage.GetComponent<Image>().sprite = sprites[4];
              break;
          }
          case"mojang":
          {
              image.GetComponent<Image>().sprite = sprites[5];
              bannerImage.GetComponent<Image>().sprite = sprites[5];
              break;
          }
          case"adobe":
          {
              image.GetComponent<Image>().sprite = sprites[6];
              bannerImage.GetComponent<Image>().sprite = sprites[6];
              break;
          }
          case"electronic arts":
          {
              image.GetComponent<Image>().sprite = sprites[7];
              bannerImage.GetComponent<Image>().sprite = sprites[7];
              break;
          }
          case"sap":
          {
              image.GetComponent<Image>().sprite = sprites[8];
              bannerImage.GetComponent<Image>().sprite = sprites[8];
              break;
          }
          case"ubisoft":
          {
              image.GetComponent<Image>().sprite = sprites[9];
              bannerImage.GetComponent<Image>().sprite = sprites[9];
              break;
          }
          case"ibm":
          {
              image.GetComponent<Image>().sprite = sprites[10];
              bannerImage.GetComponent<Image>().sprite = sprites[10];
              break;
          }
          case"rockstar games":
          {
              image.GetComponent<Image>().sprite = sprites[11];
              bannerImage.GetComponent<Image>().sprite = sprites[11];
              break;
          }
          case"symantec":
          {
              image.GetComponent<Image>().sprite = sprites[12];
              bannerImage.GetComponent<Image>().sprite = sprites[12];
              break;
          }
          case"blizzard":
          {
              image.GetComponent<Image>().sprite = sprites[13];
              bannerImage.GetComponent<Image>().sprite = sprites[13];
              break;
          }
          case"oracle":
          {
              image.GetComponent<Image>().sprite = sprites[14];
              bannerImage.GetComponent<Image>().sprite = sprites[14];
              break;
          }
          case"bethesda":
          {
              image.GetComponent<Image>().sprite = sprites[15];
              bannerImage.GetComponent<Image>().sprite = sprites[15];
              break;
          }
          case"tesla":
          {
              image.GetComponent<Image>().sprite = sprites[16];
              bannerImage.GetComponent<Image>().sprite = sprites[16];
              break;
          }
          case"microsoft":
          {
              image.GetComponent<Image>().sprite = sprites[17];
              bannerImage.GetComponent<Image>().sprite = sprites[17];
              break;
          }
          case"google":
          {
              image.GetComponent<Image>().sprite = sprites[18];
              bannerImage.GetComponent<Image>().sprite = sprites[18];
              break;
          }
          case"nasa":
          {
              image.GetComponent<Image>().sprite = sprites[19];
              bannerImage.GetComponent<Image>().sprite = sprites[19];
              break;
          }
          case"valve":
          {
              image.GetComponent<Image>().sprite = sprites[20];
              bannerImage.GetComponent<Image>().sprite = sprites[20];
              break;
          }
          case"cd projekt":
          {
              image.GetComponent<Image>().sprite = sprites[21];
              bannerImage.GetComponent<Image>().sprite = sprites[21];
              break;
          }
          
          default:  {
              image.GetComponent<Image>().sprite = sprites[0];
              break;
          }
       }
     
       
   }
   
   public void changeActiveJobText(string newActiveJob)
   {
       this.dashboardActiveCodeText.text = ("Current Job - " + newActiveJob );
   }

   public string ChangeNameStyle(string str ) // because they are passed like CPlus instead of c++
   {
       if (str == "Cplus")
       {
           return "C++";
       }
       if (str == "Python")
       {
           return "Python";
       }
       if (str == "Html")
       {
           return "Html / CSS";
       }
       if (str == "CSharp")
       {
           return "C#";
       }
       if (str == "JavaScript")
       {
           return "JavaScript";
       }
       if (str == "Pascal")
       {
           return "Pascal";
       }
       return "Java";
   }

   public string GetbuttonText() {
       return button_Text.text;
   }
}

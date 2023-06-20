using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkConsoletext : MonoBehaviour {
    [Header("Control Content")] [SerializeField]
    private Text codeText; // text for the screen

    [SerializeField] private int currentCodeIndex = 0; // reset every code
    [SerializeField] private bool flagforLoop = false; // reset at every code
    [SerializeField] private string addedWhiteSpace = ""; // reset at every code
    [SerializeField] private bool flagString = false; // reset every code
    [SerializeField] private RectTransform scrollContent; //Scroll content for text

    // private int lines = 0; // lines of code for scroll content to grow
    private int upp = 45;

    [SerializeField] private int nowGrow = 0;
    //[SerializeField] private RectTransform consoleText; //Size for text

    private bool dollarSignSkipflag = false; // reset to 0
    
    private bool flagLastStringChar = false;
    private bool pythonSkip = false;

    
    private string activeCode = "";

    private Global global;

    
    
    public void Start() {
        global = Global.Instance;
    }

    IEnumerator ClickAsync() {
        for (int i = 0; i < 300; i++) { 
            Code_Click();
            yield return  null;
        }

        isasyncPrinting = false;
        yield return null;
    }

    private bool isasyncPrinting = false;
    private void Update() {
        if (Input.GetKeyDown(KeyCode.T) && !isasyncPrinting) {
            isasyncPrinting = true;
            startAsync();
        }
    }

    public void startAsync() {
        StartCoroutine(ClickAsync());
    }
    public void Code_Click() {
        
        if (activeCode.Length < 10) {
            PopUpController.Instance.UsePopUp_NoActiveJobSeleted();
            return;
        } // no active code 

        if (currentCodeIndex == activeCode.Length - 1) {
            int moneyReward = Calculate_Money_Reward();
            int experienceReward = Calculate_Experience_Reward();
            PopUpController.Instance.UsePopUp_JobCompleted(moneyReward,experienceReward);
            global.JobFinished(moneyReward,experienceReward);

            currentCodeIndex = 0;
            changeActiveCode(" ");
            codeText.text = " ";
            nowGrow = 0;
            dollarSignSkipflag = false;
            flagLastStringChar = false;
            pythonSkip = false;
            flagforLoop = false;
            addedWhiteSpace = "";
            flagString = false;
            return;
        }

        if (global.getActiveLang() == "java") {
            if (activeCode[currentCodeIndex] == '{') {
                codeText.text += activeCode[currentCodeIndex];

                codeText.text += "\n";
                if (flagforLoop) {
                    flagforLoop = false;
                }

                addedWhiteSpace += "        ";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
                return;
            }
            else if (activeCode[currentCodeIndex] == '}') {
                addedWhiteSpace = addedWhiteSpace.Remove(addedWhiteSpace.Length - 8);
                codeText.text += activeCode[currentCodeIndex];
                codeText.text += "\n";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
            }
            else if (activeCode[currentCodeIndex] == ';' && !flagforLoop) {
                codeText.text += activeCode[currentCodeIndex];
                codeText.text += "\n";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
                return;
            }

            if (currentCodeIndex > 12) {
                string sub;
               //  Debug.Log(codeText.text.Substring(currentCodeIndex-11));
                sub = codeText.text.Substring(currentCodeIndex - 11);

                foreach (string str in JavaKeywords) {
                    if (sub.Contains(str)) {
                        // ---------
                        if (sub.Substring(sub.Length - str.Length) == str) {
                            codeText.text = codeText.text.Substring(0, codeText.text.Length - str.Length);
                            codeText.text += $"<color={CFC.GetFillColor(str,ProgrammingLang.Java)}>" + str + "</color>";
                            break;
                        }
                    }
                }
            }

            if (activeCode[currentCodeIndex] == '\"' || activeCode[currentCodeIndex] == '\'') {
                if (flagString) {
                    flagString = false;
                    flagLastStringChar = true;
                }
                else {
                    flagString = true;
                }
            } // check for string

            if (flagString || flagLastStringChar) {
                char Add = activeCode[currentCodeIndex];
                codeText.text += $"<color={"green"}>" + Add + "</color>";
                flagLastStringChar = false;
            } // if string is active
            else {
                codeText.text += activeCode[currentCodeIndex];
            } // just print


            if (activeCode[currentCodeIndex] == 'f') {
                if (activeCode[currentCodeIndex + 1] == 'o' && activeCode[currentCodeIndex + 2] == 'r') {
                    flagforLoop = true;
                }
            } // for loop fix

            currentCodeIndex++;
        }

        else if (global.getActiveLang() == "cplus") {
            if (activeCode[currentCodeIndex] == '{') {
                codeText.text += activeCode[currentCodeIndex];

                codeText.text += "\n";
                if (flagforLoop) {
                    flagforLoop = false;
                }

                addedWhiteSpace += "        ";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
                return;
            }
            else if (activeCode[currentCodeIndex] == '}') {
                addedWhiteSpace = addedWhiteSpace.Remove(addedWhiteSpace.Length - 8);
                codeText.text += activeCode[currentCodeIndex];
                codeText.text += "\n";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
            }
            else if (activeCode[currentCodeIndex] == ';' && !flagforLoop) {
                codeText.text += activeCode[currentCodeIndex];
                codeText.text += "\n";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
                return;
            }

            if (currentCodeIndex > 12) {
                string sub;
                // Debug.Log(codeText.text.Substring(currentCodeIndex-11));
                sub = codeText.text.Substring(currentCodeIndex - 11);

                foreach (string str in CPlusKeywords) {
                    if (sub.Contains(str)) {
                        // ---------
                        if (sub.Substring(sub.Length - str.Length) == str) {
                            codeText.text = codeText.text.Substring(0, codeText.text.Length - str.Length);
                            codeText.text += $"<color={CFC.GetFillColor(str,ProgrammingLang.Default)}>" + str + "</color>";
                            break;
                        }
                    }
                }
            }

            if (activeCode[currentCodeIndex] == '\"' || activeCode[currentCodeIndex] == '\'') {
                if (flagString) {
                    flagString = false;
                    flagLastStringChar = true;
                }
                else {
                    flagString = true;
                }
            } // check for string

            if (flagString || flagLastStringChar) {
                char Add = activeCode[currentCodeIndex];
                codeText.text += $"<color={"green"}>" + Add + "</color>";
                flagLastStringChar = false;
            } // if string is active
            else {
                codeText.text += activeCode[currentCodeIndex];
            } // just print


            if (activeCode[currentCodeIndex] == 'f') {
                if (activeCode[currentCodeIndex + 1] == 'o' && activeCode[currentCodeIndex + 2] == 'r') {
                    flagforLoop = true;
                }
            } // for loop fix

            currentCodeIndex++;
        }

        else if (global.getActiveLang() == "python") {
            // string nextText = "";
            // while (activeCode.Length < currentCodeIndex + 1 && activeCode[currentCodeIndex + 1] != ' ') {
            //     nextText += " ";
            //     currentCodeIndex++;
            // }
            // codeText.text += nextText;

            if (activeCode[currentCodeIndex] == '`') {
                codeText.text += "\n";
                pythonSkip = true;
            }


            if (activeCode[currentCodeIndex] == '\"' || activeCode[currentCodeIndex] == '\'') {
                if (flagString) {
                    flagString = false;
                    flagLastStringChar = true;
                }
                else {
                    flagString = true;
                }
            } // check for string

            if (flagString || flagLastStringChar) {
                char Add = activeCode[currentCodeIndex];
                codeText.text += $"<color={"green"}>" + Add + "</color>";
                flagLastStringChar = false;
            } // if string is active
            else {
                if (!pythonSkip) {
                    codeText.text += activeCode[currentCodeIndex];
                }
                else {
                    pythonSkip = false;
                }
            } // just print

            if (currentCodeIndex > 12) {
                string sub;
                // Debug.Log(codeText.text.Substring(currentCodeIndex-11));
                sub = codeText.text.Substring(currentCodeIndex - 11);

                foreach (string str in PythonKeywords) {
                    if (sub.Contains(str)) {
                        // ---------
                        if (sub.Substring(sub.Length - str.Length) == str) {
                            codeText.text = codeText.text.Substring(0, codeText.text.Length - str.Length);
                            codeText.text += $"<color={CFC.GetFillColor(str,ProgrammingLang.Default)}>" + str + "</color>";
                            break;
                        }
                    }
                }
            }

            currentCodeIndex++;
        }
        else if (global.getActiveLang() == "csharp") {
            if (activeCode[currentCodeIndex] == '{') {
                codeText.text += activeCode[currentCodeIndex];

                codeText.text += "\n";
                if (flagforLoop) {
                    flagforLoop = false;
                }

                addedWhiteSpace += "        ";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
                return;
            }
            else if (activeCode[currentCodeIndex] == '}') {
                addedWhiteSpace = addedWhiteSpace.Remove(addedWhiteSpace.Length - 8);
                codeText.text += activeCode[currentCodeIndex];
                codeText.text += "\n";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
            }
            else if (activeCode[currentCodeIndex] == ';' && !flagforLoop) {
                codeText.text += activeCode[currentCodeIndex];
                codeText.text += "\n";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
                return;
            }

            if (currentCodeIndex > 12) {
                string sub;
                // Debug.Log(codeText.text.Substring(currentCodeIndex-11));
                sub = codeText.text.Substring(currentCodeIndex - 11);

                foreach (string str in CSharpKeywords) {
                    if (sub.Contains(str)) {
                        // ---------
                        if (sub.Substring(sub.Length - str.Length) == str) {
                            codeText.text = codeText.text.Substring(0, codeText.text.Length - str.Length);
                            codeText.text += $"<color={CFC.GetFillColor(str,ProgrammingLang.Default)}>" + str + "</color>";
                            break;
                        }
                    }
                }
            }

            if (activeCode[currentCodeIndex] == '\"' || activeCode[currentCodeIndex] == '\'') {
                if (flagString) {
                    flagString = false;
                    flagLastStringChar = true;
                }
                else {
                    flagString = true;
                }
            } // check for string

            if (flagString || flagLastStringChar) {
                char Add = activeCode[currentCodeIndex];
                codeText.text += $"<color={"green"}>" + Add + "</color>";
                flagLastStringChar = false;
            } // if string is active
            else {
                codeText.text += activeCode[currentCodeIndex];
            } // just print


            if (activeCode[currentCodeIndex] == 'f') {
                if (activeCode[currentCodeIndex + 1] == 'o' && activeCode[currentCodeIndex + 2] == 'r') {
                    flagforLoop = true;
                }
            } // for loop fix

            currentCodeIndex++;
        }
        else if (global.getActiveLang() == "javascript") {

            if (currentCodeIndex > 2 && activeCode[currentCodeIndex] == '$') {
                dollarSignSkipflag = true;
                codeText.text += activeCode[currentCodeIndex];
                currentCodeIndex++;
            }  
              if (currentCodeIndex > 3 && activeCode[currentCodeIndex] == '{' && activeCode[currentCodeIndex-1] != '$' ) {
                codeText.text += activeCode[currentCodeIndex];

                codeText.text += "\n";
                if (flagforLoop) {
                    flagforLoop = false;
                }

                addedWhiteSpace += "        ";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
                return;
            }
            else if (activeCode[currentCodeIndex] == '}') {

                  if (dollarSignSkipflag) {
                      codeText.text += activeCode[currentCodeIndex];
                      currentCodeIndex++;
                      dollarSignSkipflag = false;
                      return;
                  }
                  
                addedWhiteSpace = addedWhiteSpace.Remove(addedWhiteSpace.Length - 8);
                codeText.text += activeCode[currentCodeIndex];
                codeText.text += "\n";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
            }
            else if (activeCode[currentCodeIndex] == ';' && !flagforLoop) {
                codeText.text += activeCode[currentCodeIndex];
                codeText.text += "\n";
                codeText.text += addedWhiteSpace;
                currentCodeIndex++;
                SizeOfScroll();
                return;
            }
              
            if (currentCodeIndex > 12) {
                string sub;
               //  Debug.Log(codeText.text.Substring(currentCodeIndex-11));
                sub = codeText.text.Substring(currentCodeIndex - 11);

                foreach (string str in JavaScriptKeywords) {
                    if (sub.Contains(str)) {
                        // ---------
                        if (sub.Substring(sub.Length - str.Length) == str) {
                            codeText.text = codeText.text.Substring(0, codeText.text.Length - str.Length);
                            codeText.text += $"<color={CFC.GetFillColor(str,ProgrammingLang.JavaScript)}>" + str + "</color>";
                            break;
                        }
                    }
                }
            }

            if (activeCode[currentCodeIndex] == '\"' || activeCode[currentCodeIndex] == '\'') {
                if (flagString) {
                    flagString = false;
                    flagLastStringChar = true;
                }
                else {
                    flagString = true;
                }
            } // check for string

            if (flagString || flagLastStringChar) {
                char Add = activeCode[currentCodeIndex];
                codeText.text += $"<color={"green"}>" + Add + "</color>";
                flagLastStringChar = false;
            } // if string is active
            else {
                codeText.text += activeCode[currentCodeIndex];
            } // just print


            if (activeCode[currentCodeIndex] == 'f') {
                if (activeCode[currentCodeIndex + 1] == 'o' && activeCode[currentCodeIndex + 2] == 'r') {
                    flagforLoop = true;
                }
            } // for loop fix

            currentCodeIndex++;
        } 
         
    }

    private List<string> CSharpKeywords = new List<string>()
        {"for", "int", "public", "private", "float", "if", "else", "while"};

    private List<string> JavaKeywords = new List<string>()
        {"int", "for", "string", "if", "public", "class", "else", "static", "void"};

    private List<string> CPlusKeywords = new List<string>() {
        "int", "for", "string", "if", "public", "class", "else", "static", "void", "cout", "cin", "endl", "return",
        "char", "double", "break"
    };

    private List<string> PythonKeywords = new List<string>()
        {"print", "def", "elif", "if", "else", "break", "return", "for",  "var"};
    
    private List<string> JavaScriptKeywords = new List<string>()
        {"const", "let", "Math", "if", "else", "console", "return", "for",  "var","map"};

    private List<string> HtmlKeyWords = new List<string>()
        {"<h1", "<h2", "<h3", "<h4", "<h5", "<h6", "<body", "<head",  "<html","<link","<style",
            "<title","<p","<ul","<li","<div","<header","<main","<nav","<b","<br"};
    
    private List<string> HtmlEndKeyWords = new List<string>()
    {"</h1>", "</h2>", "</h3>", "</h4>", "</h5>", "</h6>", "</body>", "</head>",  "</html>","</link>","</style>",
        "</title>","</p>","</ul>","</li>","</div>","</header>","</main>","</nav>","</b>","</br>"};
    
    private int index;


    public void changeActiveCode(string newCode) {
        this.activeCode = newCode;
    }

    public void SizeOfScroll() {
        nowGrow++;
        if (nowGrow > 20) {
            //lines += upp;
            //scrollContent.offsetMin = new Vector2(0, lines);
            scrollContent.sizeDelta = new Vector2(scrollContent.sizeDelta.x, scrollContent.sizeDelta.y + upp);
        }
    }

    private int Calculate_Money_Reward() {
        return activeCode.Length / 3;
    }
    private int Calculate_Experience_Reward() {
        return activeCode.Length / 5;
    }
}



// Added green text work console
// popups
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LearnConsoleText : MonoBehaviour
{
    public Text textToDisplay = null;
    private int stringAt = 0;
    public GameObject finished;
    public GameObject shineOff;
    public GameObject errorMessage;

    public GameObject javaFinished1;
    public GameObject javaFinished2;
    public GameObject javaFinished3;
    public GameObject javaFinished4;
    public GameObject javaFinished5;
    public GameObject javaFinished6;

    public GameObject pythonFinished1;
    public GameObject pythonFinished2;
    public GameObject pythonFinished3;
    public GameObject pythonFinished4;
    public GameObject pythonFinished5;
    public GameObject pythonFinished6;

    public GameObject cPlusFinished1;
    public GameObject cPlusFinished2;
    public GameObject cPlusFinished3;
    public GameObject cPlusFinished4;
    public GameObject cPlusFinished5;
    public GameObject cPlusFinished6;

    public GameObject scriptFinished1;
    public GameObject scriptFinished2;
    public GameObject scriptFinished3;
    public GameObject scriptFinished4;
    public GameObject scriptFinished5;
    public GameObject scriptFinished6;

    public GameObject htmlFinished1;
    public GameObject htmlFinished2;
    public GameObject htmlFinished3;
    public GameObject htmlFinished4;
    public GameObject htmlFinished5;
    public GameObject htmlFinished6;

    public GameObject cSharpFinished1;
    public GameObject cSharpFinished2;
    public GameObject cSharpFinished3;
    public GameObject cSharpFinished4;
    public GameObject cSharpFinished5;
    public GameObject cSharpFinished6;

    public GameObject reactFinished1;
    public GameObject reactFinished2;
    public GameObject reactFinished3;
    public GameObject reactFinished4;
    public GameObject reactFinished5;
    public GameObject reactFinished6;

    private bool cPlus = false;
    private bool musicPlayer = false;
    private bool atm = false;
    private bool calendar = false;
    private bool contacts = false;
    private bool encryptedmessage = false;
    private bool cPlusGameDev = false;

    public void ResetCode() {
        textToDisplay.text = "";
        
    }

    private string musicPlayerString = "#include <iostream>" + "\n" +
"#include <vector>" + "\n" +
"#include <algorithm>" + "\n" +
"using namespace std;" + "\n" +
"int main()" + "\n" +
"{" + "\n" +
    "int enterNumber = 0;" + "\n" +
    "bool check = false;" + "\n" +
    "string nameOfSong;" + "\n" +
    "vector<string> Names;" + "\n" +
    "do{" + "\n" +
    "int total = Names.size();" + "\n" +
    "cout<<'1. Add song'<<endl;" + "\n" +
    "cout<<'2. Remove song'<<endl;" + "\n" +
    "cout<<'3. Search for song'<<endl;" + "\n" +
    "cout<<'4. Exit'<<endl;" + "\n" +
    "cin>>enterNumber;" + "\n" +
    "}if(enterNumber == 1){" + "\n" +
        "cout<<'Enter the name of the song'<<endl;" + "\n" +
        "cin>>nameOfSong;" + "\n" +
        "for(int i = 0; i<total; i++){" + "\n" +
            "if(Names.size() > 0 && Names.at(i) == nameOfSong){" + "\n" +
                "check = true;" + "\n" +
                "cout<<'You already have that song'<<endl;" + "\n" +
                "break;" + "\n" +
        "}}if(check == false){" + "\n" +
                "Names.push_back(nameOfSong);" + "\n" +
                "cout<<'Song '<<nameOfSong<<' is added to your list!'<<endl;" + "\n" +
        "}check = false;" + "\n" +

   "}else if(enterNumber == 2){" + "\n" +
        "for(int i = 0; i<total; i++){" + "\n" +
            "cout<<i<<'. '<<Names.at(i)<<endl;" + "\n" +
        "}if(Names.size() > 0){" + "\n" +
        "cout<<'Enter the number of the song you want to remove or enter '<<total<<' or higher to exit'<<endl;" + "\n" +
        "cin>>remove;" + "\n" +
        "if(remove >= total){" + "\n" +
        "}else{" + "\n" +
            "auto song = find(begin(Names), end(Names), Names.at(remove));" + "\n" +
"cout<<Names.at(remove)<<' is removed!'<<endl;" + "\n" +
            "Names.erase(song);" + "\n" +
        "}}else{" + "\n" +
                "cout<<'You don't have any songs in your playlist yet!'<<endl;" + "\n" +
    "}}else if(enterNumber == 3){" + "\n" +
        "if(Names.size() > 0){" + "\n" +
        "cout<<'Enter the name of song or enter display to display all songs'<<endl;" + "\n" +
        "cin>>nameOfSong;" + "\n" +
        "if(nameOfSong == 'display'){" + "\n" +
            "for(int i = 0; i<total; i++){" + "\n" +
                "cout<<i<<'. '<<Names.at(i)<<endl;" + "\n" +
        "}}else{" + "\n" +
                "for(int i = 0; i<total; i++){" + "\n" +
                    "if(Names.at(i) == nameOfSong){" + "\n" +
                       "cout<<nameOfSong<<' is number '<<i<<' on your list'<<endl;" + "\n" +
                        "break;" + "\n" +
                    "}else if(i+1 == total){" + "\n" +
                        "cout<<'You dont have that song in your list.'<<endl;" + "\n" +
        "}}}}else{" + "\n" +
               "cout<<'You don't have any songs in your playlist yet!'<<endl;" + "\n" +
    "}}else if(enterNumber > 4 || enterNumber == 0){" + "\n" +
    "    cout<<'Enter a valid number!'<<endl;" + "\n" +
    "}}while(enterNumber != 4);" + "\n" +
    "cout<<'Bye!'<<endl;" + "\n" +
   " return 0;}";

    private string calendarString = "#include <iostream>" + "\n" +
"#include <string.h>" + "\n" +
"#ifdef MSDOS" + "\n" +
"#include <conio.h>" + "\n" +
"#endif" + "\n" +
"using namespace std;" + "\n" +
"void Calendar(int year, int month);" + "\n" +
"int GetUserInput(const char* name, int from = 0, int to = 0);" + "\n" +
"int main(){" + "\n" +
    "int year, month;" + "\n" +
    "char control = 0;" + "\n" +
    "char menu[]='< P > - Previous, < N > - Next< D > - New date,  < E > - Exit';" + "\n" +
    "year = GetUserInput('Year');" + "\n" +
    "month = GetUserInput('Month', 1, 12);" + "\n" +
    "Calendar(year, month);" + "\n" +
    "cout<<menu;" + "\n" +
    "do" + "\n" +
   "{" + "\n" +
        "bool Proceed = false;" + "\n" +
"#ifdef MSDOS" + "\n" +
        "Proceed = _kbhit();" + "\n" +
"#else" + "\n" +
        "Proceed = true;" + "\n" +
"#endif" + "\n" +
       "if(Proceed){" + "\n" +
"#ifdef MSDOS" + "\n" +
            "control = _getch();" + "\n" +
"#else" + "\n" +
            "cin.get(control);" + "\n" +
            "cin.get();" + "\n" +
"#endif" + "\n" +
           "system('cls');" + "\n" +
            "switch (control){" + "\n" +
               "case -32:" + "\n" +
                    "continue;" + "\n" +
                    "break;" + "\n" +
                "case 'P':" + "\n" +
                "case 'p':" + "\n" +
                "case 72:" + "\n" +
                "case 75:" + "\n" +
                    "month--;" + "\n" +
                    "if (month < 1){" + "\n" +
                        "month += 12;" + "\n" +
                        "year -= 1;" + "\n" +
                    "}break;" + "\n" +
                "case 'N':" + "\n" +
                "case 'n':" + "\n" +
                "case 13:" + "\n" +
                "case 77:" + "\n" +
                   "month++;" + "\n" +
                    "if(month > 12){" + "\n" +
                       "month -= 12;" + "\n" +
                        "year += 1;" + "\n" +
                    "}break;" + "\n" +
               "case 'D':" + "\n" +
               "case 'd':" + "\n" +
                   "year = GetUserInput('Year');" + "\n" +
                    "month = GetUserInput('Month, 1, 12);" + "\n" +
                    "break;" + "\n" +
                "case 'E':" + "\n" +
                "case 'e':" + "\n" +
                   " cout<<'Bye!;" + "\n" +
                    "break;" + "\n" +
               " default:" + "\n" +
                   " cout<<'Wrong input!';" + "\n" +
                   " cout << menu;" + "\n" +
                   " continue;" + "\n" +
                    "break;" + "\n" +
            "}Calendar(year, month);" + "\n" +
            "cout<<menu;" + "\n" +
    "}}while(control != 'e' && control != 'E');" + "\n" +
    "return 0;" + "\n" +
"}int GetUserInput(const char* name, int from, int to){" + "\n" +
   "bool succeed = false;" + "\n" +
   "int value = 0;" + "\n" +
   "char buffer[10];" + "\n" +
   "do{" + "\n" +
       "cout<<'Enter '<<name<<' : '; " + "\n" +
        "cin.getline(buffer, 10);" + "\n" +
        "value = atoi(buffer);" + "\n" +
        "if(from == to || value >= from && value <= to)" + "\n" +
            "succeed = true;" + "\n" +
    "}while(!succeed);" + "\n" +
    "return value;}" + "\n" +
"void Calendar(int year, int month){" + "\n" +
   " char monthName[][10]{" + "\n" +
       "'January', 'February', 'March', 'April', 'May', 'June'," + "\n" +
        "'July', 'August', 'September', 'October', 'November', 'December'};" + "\n" +
"int numberOfDaysInMonth, shift, empty;" + "\n" +
"int daysInMonth[]{ 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };" + "\n" +
   " numberOfDaysInMonth = (month == 2 && year % 4 == 0) ? 29 : daysInMonth[month - 1];" + "\n" +
    "const int fixedYear = 2008;" + "\n" +
"const int fixedEmpty[]{ 1, 4, 5, 1, 3, 6, 1, 4, 0, 2, 5, 0 };" + "\n" +
    "int yearDiff = year - fixedYear;" + "\n" +
   "if (yearDiff > 0){" + "\n" +
        "shift = yearDiff + yearDiff / 4;" + "\n" +
       "if (month <= 2 && year % 4 != 0)" + "\n" +
            "shift++;" + "\n" +
   "}else{" + "\n" +
        "shift = yearDiff - yearDiff / 4;" + "\n" +
       "if(month > 2 && year % 4 != 0)" + "\n" +
            "shift--;" + "\n" +
    "}empty = fixedEmpty[month - 1] + shift;" + "\n" +
    "empty = empty % 7;" + "\n" +
    "if(empty< 0)" + "\n" +
        "empty += 7;" + "\n" +
    "cout<<' ................... '<<monthName[month - 1]<<' '<<year<<' ';" + "\n" +
    "int dots = 23 - strlen(monthName[month - 1]);" + "\n" +
    "for(int i = 0; i<dots; i++)" + "\n" +
        "cout<<'.';" + "\n" +
    "cout<<' Mo Tu We Th Fr Sa Su';" + "\n" +
    "for(int e = 0; e<empty; e++)" + "\n" +
        "cout<<'/t';" + "\n" +
   "for(int d = 1; d <= numberOfDaysInMonth; d++)" + "\n" +
        "cout<<d<<((empty + d) % 7 == 0 ? '/n' : '/t');" + "\n" +
    "cout<<'/n/n';}";

    private string atmString = "#include <iostream>" + "\n" +
"#include <vector>" + "\n" +
"#include <algorithm>" + "\n" +

"using namespace std;" + "\n" +
"int main(){" + "\n" +
   "string name;" + "\n" +
  "string password;" + "\n" +
   "vector<string> accName;" + "\n" +
   "vector<string> accPass;" + "\n" +
   "vector<double> accBalance;" + "\n" +
   "int enter = 0;" + "\n" +
   "bool check = false;" + "\n" +
   "bool check2 = false;" + "\n" +
   "bool check3 = false;" + "\n" +
   "int number = 0;" + "\n" +
   "double balance = 0;" + "\n" +
   "double sum = 0;" + "\n" +
   "int ranNumber = 0;" + "\n" +
   "int current = 0;" + "\n" +
   "do{" + "\n" +
       "int totalAcc = accName.size();" + "\n" +
       "cout<<'1. Add account'<<endl;" + "\n" +
       "cout<<'2. Remove account'<<endl;" + "\n" +
        "cout<<'3. Login'<<endl;" + "\n" +
       "cout<<'4. Exit'<<endl;" + "\n" +
        "cin>>enter;" + "\n" +

       "while(cin.fail()){" + "\n" +
          "cin.clear();" + "\n" +
          "cin.ignore(numeric_limits <::streamsize >::max(), '/n'); " + "\n" +
           "cout<<'1. Add account'<<endl; " + "\n" +
          "cout<<'2. Remove account'<<endl; " + "\n" +
          "cout<<'3. Login'<<endl;" + "\n" +
           "cout<<'4. Exit'<<endl;" + "\n" +
           "cout<<'Enter a valid number!'<<endl;" + "\n" +
          "cin>>enter;" + "\n" +
       "}if(enter == 1){" + "\n" +
           "cout<<'Enter nickname and password'<<endl; " + "\n" +
           "cin>>name>>password;" + "\n" +
           "if(accName.size() != 0)" + "\n" +
          "{for(int i = 0; i < totalAcc; i++){" + "\n" +
                   "if(accName.at(i) == name){" + "\n" +
                       "cout<<'That nickname is already taken!'<<endl;" + "\n" +
                       "check3 = true;" + "\n" +
                       "break;" + "\n" +
                   "}}}if(check3 == false){" + "\n" +
               "accName.push_back(name);" + "\n" +
               "accPass.push_back(password);" + "\n" +
                "cout<<'A new accout is successfully added!'<<endl;" + "\n" +
               "accBalance.push_back(current);" + "\n" +
            "}check3 = false;" + "\n" +
       "}else if(enter == 2){" + "\n" +
           "if(accName.size() != 0){" + "\n" +
               "for(int i = 0; i < totalAcc; i++){" + "\n" +
                "cout<<i<<'. '<<accName.at(i)<<endl;" + "\n" +
               "}cout<<'Enter the nickname of the acc you want to remove or enter exit to exit.'<<endl;" + "\n" +
                "cin>>name;" + "\n" +
               "if(name != 'exit'" + "\n" +
               "{for(int i = 0; i < totalAcc; i++)" + "\n" +
                  "{if(accName.at(i) == name){" + "\n" +
                           "check = true;" + "\n" +
                           "cout<<'Enter the password: '; " + "\n" +
                            "cin>>password;" + "\n" +
                           "if(accPass.at(i) == password){" + "\n" +
                               "cout<<'Are you sure you want to remove this acc? Y-yes N-no'<<endl;" + "\n" +
                               "cin>>name;" + "\n" +
                               "if(name == 'Y' || name == 'y'){" + "\n" +
                                  "name == accName.at(i);" + "\n" +
                                  "auto findAcc = find(begin(accName), end(accName), name);" + "\n" +
                                  "auto findPass = find(begin(accPass), end(accPass), password);" + "\n" +
                                  "accName.erase(findAcc);" + "\n" +
                                  "accPass.erase(findPass);" + "\n" +
                               "}else{" + "\n" +
                               "}}else{" + "\n" +
                                "cout<<'Wrong password'<<endl;" + "\n" +
                            "}}}if(check == false){" + "\n" +
                       " cout<<'You don't have acc with that nickname. Make sure you spelled right the nickname and password first!'<<endl;" + "\n" +
                    "}}}else{" + "\n" +
               "cout<<'Add an account first!'<<endl;" + "\n" +
            "}}else if(enter == 3){" + "\n" +
            "cout<<'Enter nickname: '<<endl;" + "\n" +
           "cin>>name;" + "\n" +
            "cout<<'Enter password: '<<endl; " + "\n" +
           "cin>>password;" + "\n" +
            "if(accName.size() != 0){" + "\n" +
               "for(int i = 0; i < totalAcc; i++){" + "\n" +
                   "if(name == accName.at(i))" + "\n" +
                   "{if(password == accPass.at(i)){" + "\n" +
                          "cout<<'You successfully logged in!'<<endl; " + "\n" +
                          "ranNumber = i;" + "\n" +
                          "check2 = true;" + "\n" +
                           "break;" + "\n" +
                        "}}}}if(check2 == true){" + "\n" +
                "balance = accBalance.at(ranNumber);" + "\n" +
               " do{" + "\n" +
                    "cout<<'1. Deposit'<<endl;" + "\n" +
                    "cout<<'2. Withdraw'<<endl;" + "\n" +
                    "cout<<'3. Check balance'<<endl;" + "\n" +
                    "cout<<'4. Log out'<< endl;" + "\n" +
                   "cin>>number;" + "\n" +

                   "while(cin.fail()){" + "\n" +
                        "cin.clear();" + "\n" +
                        "cin.ignore(numeric_limits <::streamsize >::max(), '/n');" + "\n" +
                        "cout<<'1. Deposit'<<endl;" + "\n" +
                        "cout<<'2. Withdraw'<<endl;" + "\n" +
                        "cout<<'3. Check balance'<<endl;" + "\n" +
                       " cout<<'4. Log out'<<endl;" + "\n" +
                        "cout<<'Enter a valid number!'<<endl;" + "\n" +
                        "cin >> number;" + "\n" +
                   "}if(number == 1){" + "\n" +
                      "cout<<'Enter the sum you want to deposit: ';" + "\n" +
                      "cin>>sum;" + "\n" +
                       "balance += sum;" + "\n" +
                  "}else if(number == 2){" + "\n" +
                      "cout<<'Enter the sum you want to withdraw: ';" + "\n" +
                       "cin>>sum;" + "\n" +
                       "if(sum <= balance){" + "\n" +
                        "balance -= sum;" + "\n" +
                       "}else{" + "\n" +
                       "cout<<'Your balance is '<<balance<<' and you can't withdraw '<<sum<<endl;" + "\n" +
                       "}}else if(number == 3){" + "\n" +
                      "cout<<'Your balance is '<<balance<<endl;" + "\n" +
                    "}}while(number != 4);" + "\n" +
                "cout<<'You successfully logged out'<<endl; " + "\n" +
               "accBalance.at(ranNumber) = balance;" + "\n" +
                "check2 = false;" + "\n" +
            "}else if(check2 == false){" + "\n" +
                "cout<<'Your nickname or password is incorrect!'<<endl;" + "\n" +
            "}}}while(enter != 4);" + "\n" +
    "cout<<'Bye!'<<endl; " + "\n" +
    "return 0;}";

    private string contactString = "#include <iostream>" + "\n" +
"#include <vector>" + "\n" +
"#include <algorithm>" + "\n" +
"using namespace std;" + "\n" +
"int main(){" + "\n" +
    "vector<int> ContactNumb;" + "\n" +
    "vector<string> ContactName;" + "\n" +
    "string name, name2, name3, name4;" + "\n" +
    "int ContactsizeNumb = 0;" + "\n" +
    "int ContactsizeName = 0;" + "\n" +
    "int num, num3, num4 = 0;" + "\n" +
    "char A, da;" + "\n" +
    "do{" + "\n" +
        "cout<<'A - Enter number to save it'<<endl;" + "\n" +
        "cout<<'B - See all saved numbers'<<endl;" + "\n" +
        "cout<<'C - Change already saved number/name'<<endl;" + "\n" +
        "cout<<'D - Check if you already have a specific number/name'<<endl;" + "\n" +
        "cout<<'Q - Quit'<<endl;" + "\n" +
        "cin>>A;" + "\n" +
        "if(A == 'A' || A == 'a'){" + "\n" +
            "cout<<'Enter a number to save'<<endl;" + "\n" +
            "cin>>num;" + "\n" +
            "cout<<'Enter the name'<<endl;" + "\n" +
            "cin>>name;" + "\n" +
            "ContactName.push_back(name);" + "\n" +
            "ContactNumb.push_back(num);" + "\n" +
            "}else if(A == 'B' || A == 'b'){" + "\n" +
            "ContactsizeName = ContactName.size();" + "\n" +
            "ContactsizeNumb = ContactNumb.size();" + "\n" +
            "for(int i = 0; i < ContactsizeName; i++){" + "\n" +
                "cout<<i<<'-'<<ContactName.at(i)<<'-'<<ContactNumb.at(i)<<endl;" + "\n" +
                "}cout<<endl;" + "\n" +
        "}else if(A == 'C' || A == 'c'){" + "\n" +
            "cout<<'Do you want to change number? Y or y- yes, N or n - for no'<<endl;" + "\n" +
            "cin>>da;" + "\n" +
            "if(da == 'Y' || da == 'y'){" + "\n" +
                "ContactsizeName = ContactName.size();" + "\n" +
                "ContactsizeNumb = ContactNumb.size();" + "\n" +
                "for(int i = 0; i < ContactsizeName; i++){" + "\n" +
                    "cout<<i<<'-'<<ContactName.at(i)<<' '<<ContactNumb.at(i)<<endl;" + "\n" +
               "}cout<<'Chose a number you want to change'<<endl;" + "\n" +
                "cin>>num3;" + "\n" +
                "if(find(ContactNumb.begin(), ContactNumb.end(), num3) == ContactNumb.end()){" + "\n" +
                    "cout<<'The number doesen't exesist in your list try another one'<<endl;" + "\n" +
                    "for(int i = 0; i < ContactsizeName; i++){" + "\n" +
                        "cout<<i<<'-'<<ContactName.at(i)<<' '<<ContactNumb.at(i)<<endl;" + "\n" +
                        "}}else if(find(ContactNumb.begin(), ContactNumb.end(), broj3) != ContactNumb.end()){" + "\n" +
                    "cout<<'Enter the number you want to change it to '<<broj3<<endl;" + "\n" +
                    "cin>>num;" + "\n" +
                    "replace(ContactNumb.begin(), ContactNumb.end(), num3, num);" + "\n" +
                    "cout<<'The number '<<num3<<' is successfully changed to '<<num<<endl;" + "\n" +
                "}}else if(da == 'N' || da == 'n'){" + "\n" +
                "cout<<'Which name you want to change?'<<endl;" + "\n" +
                "for(int i = 0; i < ContactsizeName; i++){" + "\n" +
                    "cout<<i<<'-'<<ContactName.at(i)<<' '<<ContactNumb.at(i)<<endl;" + "\n" +
                "}cin>>name2;" + "\n" +
                "cout<<'In which name you want to change '<<ime2<<<endl;" + "\n" +
                "cin>>name3;" + "\n" +
                "if(find(ContactName.begin(), ContactName.end(), name3) != ContactName.end()){" + "\n" +
                    "cout<<'That name doesen't exesist in your list of saved numbers'<<'endl;" + "\n" +
                    "for(int i = 0; i < ContactsizeName; i++){" + "\n" +
                        "cout<<i<<'-'<<ContactName.at(i)<<' '<<ContactNumb.at(i)<<endl;" + "\n" +
                    "}}else if(find(ContactName.begin(), ContactName.end(), name3) == ContactName.end()){" + "\n" +
                    "replace(ContactName.begin(), ContactName.end(), name2, name3);" + "\n" +
                    "cout<<'The name '<<ime2<<' is successfully changed to '<<ime3<<endl;" + "\n" +
                "}}}else if(A == 'D' || A == 'd'){" + "\n" +
            "cout<<'If you want to check if an number exesist enter 1 or 2 for name'<<endl;" + "\n" +
            "cin>>num4;" + "\n" +
            "if(num4 == 1){" + "\n" +
                "cout<<'Enter the number you want to check'<<endl;" + "\n" +
                "cin>>num4;" + "\n" +
                "if(find(ContactNumb.begin(), ContactNumb.end(), num4) != ContactNumb.end()){" + "\n" +
                    "cout<<'The number '<<num4<<' exesist in your contact list! '<<endl;" + "\n" +
                "}else if(find(ContactNumb.begin(), ContactNumb.end(), num4) == ContactNumb.end()){" + "\n" +
                    "cout<<'The number '<<num4<<' doesen't exesist in your contact list!'<<endl;" + "\n" +
                "}}else if(num4 == 2){" + "\n" +
                "cout<<'Enter the name you want to check'<<endl;" + "\n" +
                "cin>>name4;" + "\n" +
                "if(find(ContactName.begin(), ContactName.end(), name4) != ContactName.end()){" + "\n" +
                     "cout<<'The name '<<ime4<<' exesist in your contact list!'<<endl;" + "\n" +
                "}else if(find(ContactName.begin(), ContactName.end(), name4) == ContactName.end()){" + "\n" +
                    "cout<<'The name '<<ime4<<' doesen't exesist in your contact list!'<<endl;" + "\n" +
                "}}}}while(A != 'Q' && A != 'q');" + "\n" +
    "cout<<'Bye!'<<endl; " + "\n" +
    "return 0;}";

    private string encryptedmessageString = "#include <iostream>" + "\n" +

   "using namespace std;" + "\n" +
  "int main(){" + "\n" +
    "string a {'qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM'};" + "\n" +
    "string b {'mnbvcxzlkjhgfdsapoiuytrewqMNBVCXZLKJHGFDSAPOIUYTREWQ'};" + "\n" +
    "string c;" + "\n" +
    "cout<<'Enter a secret message: ';" + "\n" +
    "getline(cin, c);" + "\n" +

    "string encrypted { };" + "\n" +
    "cout<<'Encrypting...'<<endl;" + "\n" +

    "for(char d: c){" + "\n" +
        "size_t lol = a.find(d);" + "\n" +
        "if(lol != string::npos){" + "\n" +
            "char new_char{ b.at(lol)};" + "\n" +
            "encrypted += new_char;" + "\n" +
        "}else{" + "\n" +
            "encrypted += d;" + "\n" +
    "}}cout<<'Encrypted message is: '<<encrypted<<endl;" + "\n" +
    "string decrypted{ };" + "\n" +
    "decrypted = c;" + "\n" +
    "cout<<'Decrypted message is: '<<decrypted<<endl;" + "\n" +
    "return 0;}";

    private string cPlusGamedevString = "//Unreal character movement.h" + "\n" +
        "#pragma once" + "\n" +
        "#include 'CoreMinimal.h'" + "\n" +
        "#include 'GameFramework/Character.h'" + "\n" +
        "#include 'Components/InputComponent.h'" + "\n" +
        "#include 'GameFramework/Controller.h'" + "\n" +
        "#include 'GameFramework/CharacterMovementComponent.h'" + "\n" +
        "#include 'Camera/CameraComponent.h'" + "\n" +
        "#include 'GameFramework/SpringArmComponent.h'" + "\n" +
        "#include 'CharacterMovement.generated.h'" + "\n" +
        "UCLASS()" + "\n" +
        "class CHARMOVEMENT_API ACharacterMovement : public ACharacter{" + "\n" +
        "GENERATED_BODY()" + "\n" +
        "public:" + "\n" +
        "ACharacterMovement();" + "\n" +
        "UPROPERTY(VisibleAnywhere, BlueprintReadOnly, Category = camera" + "\n" +
        "USpringArmComponent* CameraBloom;" + "\n" +
        "UPROPERTY(VisibleAnywhere, BlueprintReadOnly, Category = camera" + "\n" +
        "USpringArmComponent* FollowCamera;" + "\n" +
        "void MoveForward(float Axis);" + "\n" +
        "void MoveRight(float Axis);" + "\n" +
        "protected:" + "\n" +
        "virtual void BeginPlay() override;" + "\n" +
        "public:" + "\n" +
        "virtual void Tick(float DeltaTime) override;" + "\n" +
        "virtual void SetupPlayerInputComponent(class UInputComponent* PlayerInputComponent) override;}" + "\n" +
        "//CharacterMovement.cpp" + "\n" +
        "#include 'CharacterMovement.h'" + "\n" +
        "ACharacterMovement::ACharacterMovement(){" + "\n" +
        "PrimaryActorTick.bCanEverTick = true;" + "\n" +
        "bUseControllerRotationPitch = false;" + "\n" +
        "bUseControllerRotationYaw = false;" + "\n" +
        "bUseControllerRotationRoll = false;" + "\n" +
        "GetCharacterMovement()->bOrientRotationToMovement= true;" + "\n" +
        "GetCharacterMovement()->RotationRate = FRotator(0.0f, 540.0f, 0.0f);" + "\n" +
        "GetCharacterMovement()->JumpZVelocity = 600.0f;" + "\n" +
        "GetCharacterMovement()->AirControl = 0.2f;" + "\n" +
        "CameraBoom = CreateDefaultSubobject<USpringArmComponent>(TEXT('CameraBoom'));" + "\n" +
        "CameraBoom->SetupAttachment(RootComponent);" + "\n" +
        "CameraBoom->TargetArmLenght = 300.0f;" + "\n" +
        "CameraBoom->bUsePawnControlRotation = true;" + "\n" +
        "FollowCamera = CreateDefaultSubobject<UCameraComponent>(TEXT('FollowCamera));" + "\n" +
        "FollowCamera->SetupAttachment(CameraBoom, USpringArmComponent::SocketName);" + "\n" +
        "FollowCamera->bUsePawnControlRotation = false;}" + "\n" +
        "void ACharacterMovement::BeginPlay(){" + "\n" +
        "Super::BeginPlay()}" + "\n" +
        "void ACharacterMovement::Tick(float DeltaTime){" + "\n" +
        "Super::Tick(DeltaTime);]" + "\n" +
        "void AcharacterMovement::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent){" + "\n" +
        "Super::SetupPlayerInputComponent(PlayerInputComponent);" + "\n" +
        "PlayerInputComponent->BlindAxis('Turn', this, &APawn:AddControllerYawInput);" + "\n" +
        "PlayerInputComponent->BlindAxis('LookUp', this, &APawn::AddControllerPitchInput);" + "\n" +
        "PlayerInputComponent->BlindAction('Jump', IE_Pressed, this, &ACharacter::Jump);" + "\n" +
        "PlayerInputComponent->BlindAction('Jump', IE_Released, this, &ACharacter::StopJumping);" + "\n" +
        "PlayerInputComponent->BlindAxis('MoveRight', this, &ACharacterMovement::MoveRight);}" + "\n" +
        "void ACharacterMovement::MoveForward(floatAxis){" + "\n" +
        "FRotator Rotation = Controller->GetControlRotation();" + "\n" +
        "FRotator YawRotation(0.0f, Rotation.Yaw, 0.0f);" + "\n" +
        "FVector Direction = FRotationMatrix(YawRotation).GetUnitAxis(EAxis::X);" + "\n" +
        "AddMovementInput(Direction, Axis);}" + "\n" +
        "void ACharacterMovement::MoveRight(float Axis){" + "\n" +
        "FRotator Rotation = Controller->GetControlRotation();" + "\n" +
        "FRotator YawRotation(0.0f, Rotation.Yaw, 0.0f);" + "\n" +
        "FVector Direction = FRotationMatrix(YawRotation).GetUnitAxis(EAxis::Y);" + "\n" +
        "AddMovementInput(Direction, Axis);}";

    //java
    private bool java = false;
    private bool palindrome = false;
    private bool countWords = false;
    private bool reverse = false;
    private bool javaGame = false;
    private bool downloadSpeed = false;
    private bool supermarket = false;

    private string palindromeString = "class PalindromeExample{" + "\n" +
   "public static void main(String args[])" + "\n" +
    "{" + "\n" +
        "int r, sum = 0, temp;" + "\n" +
        "int n = 454;" + "\n" +
        "temp = n;" + "\n" +
        "while(n > 0){" + "\n" +
            "r = n % 10;" + "\n" +
            "sum = (sum * 10) + r;" + "\n" +
            "n = n / 10;" + "\n" +
        "}" + "\n" +
        "if(temp == sum)" + "\n" +
            "System.out.println('palindrome number ');" + "\n" +
  "else" + "\n" +
            "System.out.println('not palindrome');" + "\n" +
        "}}";

    private string countWordsString = "import java.util.Scanner;" + "\n" +
"public class Exercise5" + "\n" +
    "{" + "\n" +
        "public static void main(String[] args){" + "\n" +
            "Scanner in = new Scanner(System.in);" + "\n" +
            "System.out.print('Input words with one space between them: ');" + "\n" +
            "String str = in.nextLine();" + "\n" +
            "System.out.print('Number of words in the string: ' + count_Words(str));" + "\n" +
        "}" + "\n" +
        "public static int count_Words(String str){" + "\n" +
            "int count = 0;" + "\n" +
            "if(!(' '.equals(str.substring(0, 1))) || !(' '.equals(str.substring(str.length() - 1)))){" + "\n" +
                "for(int i = 0; i < str.length(); i++){" + "\n" +
                    "if(str.charAt(i) == ' '){" + "\n" +
                        "count++;" + "\n" +
                    "}}" + "\n" +
                "count = count + 1;" + "\n" +
            "}" + "\n" +
            "return count;" + "\n" +
        "}}";

    private string reverseString = "import java.util.*;" + "\n" +
"class ReverseString" + "\n" +
    "{" + "\n" +
        "public static void main(String args[])" + "\n" +
        "{" + "\n" +
            "String original, reverse = '';" + "\n" +
            "Scanner in = new Scanner(System.in);" + "\n" +
            "System.out.println('Enter a string to reverse');" + "\n" +
            "original = in.nextLine();" + "\n" +
            "int length = original.length();" + "\n" +
            "for (int i = length - 1; i >= 0; i--)" + "\n" +
                "reverse = reverse + original.charAt(i);" + "\n" +
            "System.out.println('Reverse of the string: ' + reverse);" + "\n" +
        "}}";

    private string javaGameString = "import java.util.Random;" + "\n" +
"import java.util.Scanner;" + "\n" +
    "public class CoinFlip" + "\n" +
    "{" + "\n" +
        "public static void main(String[] args)" + "\n" +
        "{" + "\n" +
            "Scanner keyboard = new Scanner(System.in);" + "\n" +
            "Random rand = new Random();" + "\n" +
            "int count;" + "\n" +
            "System.out.println('How many times would you like to flip a coin?');" + "\n" +
            "count = keyboard.nextInt();" + "\n" +
            "int lastSide = -1;" + "\n" +
            "int consecutive = 1;" + "\n" +
            "int longestRunHeads = 0;" + "\n" +
            "int longestRunTails = 0;" + "\n" +
            "int oddsHeads = 2;" + "\n" +
            "int oddsTails = 2;" + "\n" +
            "for(int i = 0; i < count; i++){" + "\n" +
                "int coin = rand.nextInt(2);" + "\n" +
                "System.out.println(headsOrTails(coin));" + "\n" +
                "if(coin == lastSide){" + "\n" +
                    "consecutive++;" + "\n" +
                    "if(consecutive > longestRunHeads && coin == 0){" + "\n" +
                        "longestRunHeads = consecutive;" + "\n" +
                        "oddsHeads = longestRunHeads * 2;" + "\n" +
                    "}else if(consecutive > longestRunTails && coin == 1){" + "\n" +
                        "longestRunTails = consecutive;" + "\n" +
                        "oddsTails = longestRunTails * 2;" + "\n" +
                    "}" + "\n" +
                "}else{" + "\n" +
                    "consecutive = 1;" + "\n" +
                "}" + "\n" +
                "lastSide = coin;" + "\n" +
            "}" + "\n" +
            "System.out.println('The longest run of heads was ' + longestRunHeads + ' The odds of that are 1 in ' + oddsHeads + ' ' +" + "\n" +
                              "'The longest run of tails was ' + longestRunTails + ' The odds of that are 1 in ' + oddsTails);" + "\n" +
        "}" + "\n" +
        "private static String headsOrTails(int i)" + "\n" +
        "{" + "\n" +
            "if(i == 0){" + "\n" +
                "return 'heads';" + "\n" +
            "}else" + "\n" +
            "{" + "\n" +
                "return 'tails';" + "\n" +
            "}}}";

    private string downloadSpeedString = "import java.util.Scanner;" + "\n" +
"import java.text.DecimalFormat;" + "\n" +
    "public class VipCustomer" + "\n" +
    "{" + "\n" +
        "public static void main(String[] args)" + "\n" +
        "{" + "\n" +
            "double size, speed, total, sec = 0;" + "\n" +
            "int hrs = 0;" + "\n" +
            "int min = 0;" + "\n" +
            "Scanner s = new Scanner(System.in);" + "\n" +
            "System.out.println('Enter the file size in MB: ');" + "\n" +
            "size = s.nextDouble();" + "\n" +
            "System.out.println('Enter your download speed in mb/s: ');" + "\n" +
            "speed = s.nextDouble();" + "\n" +
            "while (size <= 0 || speed <= 0){" + "\n" +
                "System.out.println('Invalid value!');" + "\n" +
                "System.out.println('Enter the file size in MB: ');" + "\n" +
                "size = s.nextDouble();" + "\n" +
                "System.out.println('Enter your download speed in mb/s: ');" + "\n" +
                "speed = s.nextDouble();" + "\n" +
            "}" + "\n" +
            "total = size / speed;" + "\n" +
            "while (total >= 3600){" + "\n" +
                "total -= 3600;" + "\n" +
                "hrs++;" + "\n" +
            "}" + "\n" +
            "while (total >= 60){" + "\n" +
                "total -= 60;" + "\n" +
                "min++;" + "\n" +
            "}" + "\n" +
            "DecimalFormat df = new DecimalFormat('#.#');" + "\n" +
            "sec = total;" + "\n" +
            "sec = Double.valueOf(df.format(sec));" + "\n" +
            "System.out.println('Your file will be downloaded in: ' + hrs + ' hours, ' + min + ' minutes, ' + sec + 'seconds');" + "\n" +
        "}}";

    private string supermarketString = "import java.util.Scanner;" + "\n" +
"import java.util.*;" + "\n" +
    "public class SuperMarket{" + "\n" +
        "public static void main(String[] args){" + "\n" +
            "int number = 0;" + "\n" +
            "double price = 0;" + "\n" +
            "double finalPrice = 0;" + "\n" +
            "String item;" + "\n" +
            "Vector<String> allItems = new Vector<String>();" + "\n" +
            "Vector<Double> totalPrice = new Vector<Double>();" + "\n" +
            "boolean check = false;" + "\n" +
            "int allItemsSize = 0;" + "\n" +
            "Scanner s = new Scanner(System.in);" + "\n" +
            "do{" + "\n" +
                "allItemsSize = allItems.size();" + "\n" +
                "System.out.println('1. Add an item.');" + "\n" +
                "System.out.println('2. Check your items.');" + "\n" +
                "System.out.println('3. Pay now.');" + "\n" +
                "number = s.nextInt();" + "\n" +
                "if(number == 1){" + "\n" +
                    "System.out.println('Enter the item: ');" + "\n" +
                    "item = s.next();" + "\n" +
                    "System.out.println('Enter the price: ');" + "\n" +
                    "price = s.nextDouble();" + "\n" +
                    "if(price > 0){" + "\n" +
                        "for(int i = 0; i < allItemsSize; i++){" + "\n" +
                            "if(allItems.elementAt(i).equals(item)){" + "\n" +
                                "System.out.println('You already have that item.');" + "\n" +
                                "check = true;" + "\n" +
                                "break;" + "\n" +
                            "}}" + "\n" +
                        "if(!check){" + "\n" +
                            "allItems.add(item);" + "\n" +
                            "totalPrice.add(price);" + "\n" +
                        "}" + "\n" +
                        "check = false;" + "\n" +
                    "}else{" + "\n" +
                        "System.out.println('Invalid price try again!');" + "\n" +
                    "}}" + "\n" +
                "else if(number == 2){" + "\n" +
                    "for(int i = 0; i < allItemsSize; i++){" + "\n" +
                        "System.out.println(allItems.elementAt(i) + ' = ' + totalPrice.elementAt(i));" + "\n" +
                    "}}" + "\n" +
            "}while(number != 3);" + "\n" +
            "do{" + "\n" +
                "System.out.println('Chose your payment metod: ');" + "\n" +
                "System.out.println('1. Cash ');" + "\n" +
                "System.out.println('2. Credit card');" + "\n" +
                "number = s.nextInt();" + "\n" +
            "}while(number > 2 || number < 0);" + "\n" +
            "for(int i = 0; i < allItems.size(); i++)" + "\n" +
            "{" + "\n" +
                "System.out.println(allItems.elementAt(i) + ' = ' + totalPrice.elementAt(i));" + "\n" +
                "finalPrice += totalPrice.elementAt(i);" + "\n" +
            "}" + "\n" +
            "System.out.println('Total price is: ' + finalPrice);" + "\n" +
            "System.out.println('Thanks!');" + "\n" +
        "}}";
    //python
    private bool python = false;
    private bool guessTheNumber = false;
    private bool binarySearch = false;
    private bool rockPaper = false;
    private bool passwordGenerator = false;
    private bool timer = false;
    private bool acronym = false;
    private string guessTheNumberString = "import random" + "\n" +
"number = random.randint(1, 10)" + "\n" +
"player_name = input('Hello, What's your name?')" + "\n" +
"number_of_guesses = 0" + "\n" +
"print('okay! '+ player_name+ ' I am Guessing a number between 1 and 10:')" + "\n" +
"while number_of_guesses< 5:" + "\n" +
    "guess = int(input())" + "\n" +
    "number_of_guesses += 1" + "\n" +
    "if guess<number:" + "\n" +
        "print('Your guess is too low')" + "\n" +
    "if guess > number:" + "\n" +
        "print('Your guess is too high')" + "\n" +
    "if guess == number:" + "\n" +
        "break" + "\n" +
"if guess == number:" + "\n" +
    "print('You guessed the number in ' + str(number_of_guesses) + ' tries!')" + "\n" +
"else:" + "\n" +
    "print('You did not guess the number, The number was ' + str(number))";

    private string binarySearchString = "def binary_search(arr, low, high, x):" + "\n" +
    "if high >= low: " + "\n" +
        "mid = (high + low) // 2" + "\n" +
        "if arr[mid] == x: " + "\n" +
            "return mid" + "\n" +
        "elif arr[mid] > x: " + "\n" +
            "return binary_search(arr, low, mid - 1, x)" + "\n" +
        "else:" + "\n" +
            "return binary_search(arr, mid + 1, high, x)" + "\n" +
    "else:" + "\n" +
        "return -1" + "\n" +
"arr = [ 2, 3, 4, 10, 40 ]" + "\n" +
    "x = 10" + "\n" +
"result = binary_search(arr, 0, len(arr)-1, x)" + "\n" +
"if result != -1:" + "\n" +
    "print('Element is present at index', str(result))" + "\n" +
"else:" + "\n" +
    "print('Element is not present in array')";

    private string rockPaperString = "from random import randint" + "\n" +
"t = ['Rock', 'Paper', 'Scissors']" + "\n" +
    "computer = t[randint(0, 2)]" + "\n" +
"player = False" + "\n" +
"while player == False:" + "\n" +
    "player = input('Rock, Paper, Scissors?')" + "\n" +
    "if player == computer:" + "\n" +
        "print('Tie!')" + "\n" +
    "elif player == 'Rock':" + "\n" +
        "if computer == 'Paper':" + "\n" +
            "print('You lose!', computer, 'covers', player)" + "\n" +
        "else:" + "\n" +
            "print('You win!', player, 'smashes', computer)" + "\n" +
    "elif player == 'Paper':" + "\n" +
        "if computer =='Scissors':" + "\n" +
            "print('You lose!', computer, 'cut', player)" + "\n" +
        "else:" + "\n" +
            "print('You win!', player, 'covers', computer)" + "\n" +
    "elif player == 'Scissors':" + "\n" +
        "if computer == 'Rock':" + "\n" +
            "print('You lose...', computer,'smashes', player)" + "\n" +
        "else:" + "\n" +
            "print('You win!', player, 'cut', computer)" + "\n" +
    "else:" + "\n" +
        "print('That's not a valid play. Check your spelling!')" + "\n" +
    "player = False" + "\n" +
    "computer = t[randint(0, 2)]";
    private string passwordGeneratorString = "import random" + "\n" +
"print('''" + "\n" +
"Password Generator" + "\n" +
"''')" + "\n" +
"chars = 'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@£$%^&*().,?0123456789'" + "\n" +
"number = input('number of passwords?')" + "\n" +
"number = int(number)" + "\n" +
"length = input('password length?')" + "\n" +
"length = int(length)" + "\n" +
"print('here are your passwords:')" + "\n" +
"for pwd in range(number):" + "\n" +
  "password = ''" + "\n" +
  "for c in range(length):" + "\n" +
    "password += random.choice(chars)" + "\n" +
  "print(password)";
    
    private string timerString = "import time" + "\n" +
"import sys" + "\n" +
"time_start = time.time()" + "\n" +
"seconds = 0" + "\n" +
"minutes = 0" + "\n" +
"while True:" + "\n" +
    "try:" + "\n" +
        "sys.stdout.write('\r{minutes} Minutes {seconds} Seconds'.format(minutes= minutes, seconds= seconds))" + "\n" +
        "sys.stdout.flush()" + "\n" +
        "time.sleep(1)" + "\n" +
        "seconds = int (time.time() - time_start) - minutes* 60" + "\n" +
        "if seconds >= 60:" + "\n" +
            "minutes += 1" + "\n" +
            "seconds = 0" + "\n" +
    "except KeyboardInterrupt, e:" + "\n" +
        "break";
    
    private string acronymString = "def user_input():" + "\n" +
    "return input('Enter the phrase: ')" + "\n" +
"def acronym(words):" + "\n" +
    "return ''.join(word[0] for word in words).upper()" + "\n" +
"def main():" + "\n" +
    "words = user_input().split()" + "\n" +
    "print(f'The acronym for your phrase is {acronym(words)}.')" + "\n" +
"if __name__ == '__main__':" + "\n" +
    "main()";
    //javascript
    private bool javaScript = false;
    private bool todo = false;
    private bool clock = false;
    private bool showcase = false;
    private bool jsgame = false;
    private bool bgcolor = false;
    private bool quiz = false;
    private string todoString = "var enterButton = document.getElementById('enter');" + "\n" +
"var input = document.getElementById('userInput');" + "\n" +
"var ul = document.querySelector('ul');" + "\n" +
"var item = document.getElementsByTagName('li');" + "\n" +
"function inputLength(){" + "\n" +
"return input.value.length;}" + "\n" +
"function listLength(){" + "\n" +
"return item.length;}" + "\n" +
"function createListElement(){" + "\n" +
"var li = document.createElement('li');" + "\n" +
"li.appendChild(document.createTextNode(input.value));" + "\n" +
"ul.appendChild(li);" + "\n" +
"input.value = '';" + "\n" +
"function crossOut(){" + "\n" +
    "li.classList.toggle('done');}" + "\n" +
"li.addEventListener('click',crossOut);" + "\n" +
    "var dBtn = document.createElement('button');" + "\n" +
    "dBtn.appendChild(document.createTextNode('X'));" + "\n" +
"li.appendChild(dBtn);" + "\n" +
"dBtn.addEventListener('click', deleteListItem);" + "\n" +
    "function deleteListItem(){" + "\n" +
        "li.classList.add('delete')}}" + "\n" +
"function addListAfterClick(){" + "\n" +
    "if(inputLength() > 0){" + "\n" +
        "createListElement();}}" + "\n" +
"function addListAfterKeypress(event){" + "\n" +
"if(inputLength() > 0 && event.which ===13){" + "\n" +
    "createListElement();}}" + "\n" +
"enterButton.addEventListener('click',addListAfterClick);" + "\n" +
"input.addEventListener('keypress', addListAfterKeypress);";

    private string clockString = "var canvas = document.getElementById('canvas');" + "\n" +
"var ctx = canvas.getContext('2d');" + "\n" +
    "var radius = canvas.height / 2;" + "\n" +
    "ctx.translate(radius, radius);" + "\n" +
"radius = radius* 0.90;" + "\n" +
"setInterval(drawClock, 1000);" + "\n" +
    "function drawClock(){" + "\n" +
        "drawFace(ctx, radius);" + "\n" +
        "drawNumbers(ctx, radius);" + "\n" +
        "drawTime(ctx, radius);" + "\n" +
    "}function drawFace(ctx, radius){" + "\n" +
        "var grad;" + "\n" +
        "ctx.beginPath();" + "\n" +
        "ctx.arc(0, 0, radius, 0, 2 * Math.PI);" + "\n" +
        "ctx.fillStyle = 'White';" + "\n" +
        "ctx.fill();" + "\n" +
        "grad = ctx.createRadialGradient(0, 0, radius * 0.95, 0, 0, radius * 1.05);" + "\n" +
        "grad.addColorStop(0, '#333');" + "\n" +
        "grad.addColorStop(0.5, 'white');" + "\n" +
        "grad.addColorStop(1, '#333');" + "\n" +
        "ctx.strokeStyle = grad;" + "\n" +
        "ctx.lineWidth = radius * 0.1;" + "\n" +
        "ctx.stroke();" + "\n" +
        "ctx.beginPath();" + "\n" +
        "ctx.arc(0, 0, radius * 0.1, 0, 2 * Math.PI);" + "\n" +
        "ctx.fillStyle = '#333';" + "\n" +
        "ctx.fill();" + "\n" +
    "}function drawNumbers(ctx, radius){" + "\n" +
        "var ang;" + "\n" +
        "var num;" + "\n" +
        "ctx.font = radius * 0.15 + 'px arial';" + "\n" +
        "ctx.textBaseline = 'middle';" + "\n" +
        "ctx.textAlign = 'center';" + "\n" +
        "for(num = 1; num < 13; num++){" + "\n" +
            "ang = num * Math.PI / 6;" + "\n" +
            "ctx.rotate(ang);" + "\n" +
            "ctx.translate(0, -radius * 0.85);" + "\n" +
            "ctx.rotate(-ang);" + "\n" +
            "ctx.fillText(num.toString(), 0, 0);" + "\n" +
            "ctx.rotate(ang);" + "\n" +
            "ctx.translate(0, radius * 0.85);" + "\n" +
            "ctx.rotate(-ang);" + "\n" +
        "}}function drawTime(ctx, radius){" + "\n" +
        "var now = new Date();" + "\n" +
        "var hour = now.getHours();" + "\n" +
        "var minute = now.getMinutes();" + "\n" +
        "var second = now.getSeconds();" + "\n" +
        "hour = hour % 12;" + "\n" +
        "hour = (hour * Math.PI / 6) + (minute * Math.PI / (6 * 60)) + (second * Math.PI / (360 * 60));" + "\n" +
        "drawHand(ctx, hour, radius * 0.5, radius * 0.07);" + "\n" +
        "minute = (minute * Math.PI / 30) + (second * Math.PI / (30 * 60));" + "\n" +
        "drawHand(ctx, minute, radius * 0.8, radius * 0.07);" + "\n" +
        "second = (second * Math.PI / 30);" + "\n" +
        "drawHand(ctx, second, radius * 0.9, radius * 0.02);}" + "\n" +
    "function drawHand(ctx, pos, length, width){" + "\n" +
        "ctx.beginPath();" + "\n" +
        "ctx.lineWidth = width;" + "\n" +
        "ctx.lineCap = 'round';" + "\n" +
        "ctx.moveTo(0, 0);" + "\n" +
        "ctx.rotate(pos);" + "\n" +
        "ctx.lineTo(0, -length);" + "\n" +
        "ctx.stroke();" + "\n" +
        "ctx.rotate(-pos);}";

    private string showcaseString = "(function() {" + "\n" +
  "const pictures = [" + "\n" +
    "'contBcg-0'," + "\n" +
    "'contBcg-1'," + "\n" +
    "'contBcg-2'," + "\n" +
    "'contBcg-3'," + "\n" +
    "'contBcg-4'" + "\n" +
  "];" + "\n" +
    "const buttons = document.querySelectorAll('.btn')" + "\n" +
  "const imageDIV = document.querySelector('.img-container')" + "\n" +
  "let counter = 0" + "\n" +
  "buttons.forEach(function(button){" + "\n" +
    "button.addEventListener('click', function(e){" + "\n" +
        "if(button.classList.contains('btn-left')){" + "\n" +
            "counter--" + "\n" +
          "if(counter < 0){" + "\n" +
                "counter = pictures.length - 1}" + "\n" +
            "imageDIV.style.backgroundImage = `url('./img/${pictures[counter]}.jpeg')`}" + "\n" +
        "if(button.classList.contains('btn-right')){" + "\n" +
            "counter++" + "\n" +
          "if(counter > pictures.length - 1){" + "\n" +
                "counter = 0" + "\n" +
        "}imageDIV.style.backgroundImage = `url('./img/${pictures[counter]}.jpeg')`" + "\n" +
      "}})})})();";

    private string jsgameString = "let canvas = document.getElementById('mycanvas');" + "\n" +
"let ctx = canvas.getContext('2d');" + "\n" +
    "let ballRadius = 10;" + "\n" +
    "let x = canvas.width / 2;" + "\n" +
    "let y = canvas.height - 30;" + "\n" +
    "let dx = 2;" + "\n" +
    "let dy = -2;" + "\n" +
    "let paddleHeight = 12;" + "\n" +
    "let paddleWidth = 72;" + "\n" +
    "let paddleX = (canvas.width - paddleWidth) / 2;" + "\n" +
    "let rightPressed = false;" + "\n" +
    "let leftPressed = false;" + "\n" +
    "let brickRowCount = 4;" + "\n" +
    "let brickColumnCount = 7;" + "\n" +
    "let brickWidth = 72;" + "\n" +
    "let brickHeight = 24;" + "\n" +
    "let brickPadding = 12;" + "\n" +
    "let brickOffsetTop = 32;" + "\n" +
    "let brickOffsetLeft = 32;" + "\n" +
    "let score = 0;" + "\n" +
    "let bricks = [];" + "\n" +
"for(c =0; c<brickColumnCount; c++){" + "\n" +
    "bricks[c] = [];" + "\n" +
    "for(r=0; r<brickRowCount; r++){" + "\n" +
        "bricks[c][r] = { x: 0, y: 0, status: 1};" + "\n" +
    "}}" + "\n" +
"document.addEventListener('keydown', keyDownHandler, false);" + "\n" +
"document.addEventListener('keyup', keyUpHandler, false);" + "\n" +
"document.addEventListener('mousemove', mouseMoveHandler, false);" + "\n" +
"function mouseMoveHandler(e){" + "\n" +
    "var relativeX = e.clientX - canvas.offsetLeft;" + "\n" +
    "if(relativeX > 0 && relativeX < canvas.width){" + "\n" +
        "paddleX = relativeX - paddleWidth / 2;" + "\n" +
    "}}" + "\n" +
"function keyDownHandler(e){" + "\n" +
    "if(e.keyCode === 39){" + "\n" +
        "rightPressed = true;" + "\n" +
    "}else if(e.keyCode === 37){" + "\n" +
        "leftPressed = true;" + "\n" +
    "}}" + "\n" +
"function keyUpHandler(e){" + "\n" +
    "if (e.keyCode === 39){" + "\n" +
        "rightPressed = false;" + "\n" +
    "}else if(e.keyCode === 37){" + "\n" +
        "leftPressed = false;" + "\n" +
    "}}" + "\n" +
"function drawBall(){" + "\n" +
    "ctx.beginPath();" + "\n" +
    "ctx.arc(x, y, ballRadius, 0, Math.PI * 2);" + "\n" +
    "ctx.fillStyle = 'red';" + "\n" +
    "ctx.fill();" + "\n" +
    "ctx.closePath();" + "\n" +
"}" + "\n" +
"function drawPaddle(){" + "\n" +
    "ctx.beginPath();" + "\n" +
    "ctx.rect(paddleX, canvas.height - paddleHeight, paddleWidth, paddleHeight);" + "\n" +
    "ctx.fillStyle = 'blue';" + "\n" +
    "ctx.fill();" + "\n" +
    "ctx.closePath();" + "\n" +
"}" + "\n" +
"function drawBricks(){" + "\n" +
    "for(c = 0; c < brickColumnCount; c++){" + "\n" +
        "for(r = 0; r < brickRowCount; r++){" + "\n" +
            "if(bricks[c][r].status === 1){" + "\n" +
                "let brickX = (c * (brickWidth + brickPadding)) + brickOffsetLeft;" + "\n" +
                "let brickY = (r * (brickHeight + brickPadding)) + brickOffsetTop;" + "\n" +
                "bricks[c][r].x = brickX;" + "\n" +
                "bricks[c][r].y = brickY;" + "\n" +
                "ctx.beginPath();" + "\n" +
                "ctx.rect(brickX, brickY, brickWidth, brickHeight);" + "\n" +
                "ctx.fillStyle = '#6600cc';" + "\n" +
                "ctx.fill();" + "\n" +
                "ctx.closePath();" + "\n" +
            "}}}}" + "\n" +
"function drawScore(){" + "\n" +
    "ctx.font = '18px Arial';" + "\n" +
    "ctx.fillStyle = 'brown';" + "\n" +
    "ctx.fillText('score: ' + score, 8, 20);" + "\n" +
"}" + "\n" +
"function collisionDetection(){" + "\n" +
    "for(c = 0; c < brickColumnCount; c++){" + "\n" +
        "for(r = 0; r < brickRowCount; r++){" + "\n" +
            "let b = bricks[c][r];" + "\n" +
            "if(b.status === 1){" + "\n" +
                "if(x > b.x && x < b.x + brickWidth && y > b.y && y < b.y + brickHeight){" + "\n" +
                    "dy = -dy;" + "\n" +
                    "b.status = 0;" + "\n" +
                    "score++;" + "\n" +
                    "if(score === brickRowCount * brickColumnCount){" + "\n" +
                        "alert('Congratulations!! You\'ve won!');" + "\n" +
                        "document.location.reload();" + "\n" +
                    "}}}}}}" + "\n" +
"function draw(){" + "\n" +
    "ctx.clearRect(0, 0, canvas.width, canvas.height);" + "\n" +
    "drawScore();" + "\n" +
    "drawBricks();" + "\n" +
    "drawBall();" + "\n" +
    "drawPaddle();" + "\n" +
    "collisionDetection();" + "\n" +
    "if(x + dx > canvas.width - ballRadius || x + dx < ballRadius){" + "\n" +
        "dx = -dx;" + "\n" +
    "}if(y + dy < ballRadius){" + "\n" +
        "dy = -dy;" + "\n" +
    "}else if(y + dy > canvas.height - ballRadius){" + "\n" +
        "if(x > paddleX && x < paddleX + paddleWidth){" + "\n" +
            "dy = -dy;" + "\n" +
        "}else{" + "\n" +
            "alert('GAME OVER!!');" + "\n" +
            "document.location.reload();" + "\n" +
    "}}if(y + dy > canvas.height - ballRadius || y + dy < ballRadius){" + "\n" +
        "dy = -dy;" + "\n" +
    "}if(rightPressed && paddleX < canvas.width - paddleWidth){" + "\n" +
        "paddleX += 7;" + "\n" +
    "}else if(leftPressed && paddleX > 0){" + "\n" +
        "paddleX -= 7;" + "\n" +
    "}" + "\n" +
    "x += dx;" + "\n" +
    "y += dy;" + "\n" +
"}setInterval(draw, 10) ";

    private string bgcolorString = "const buttons = document.querySelectorAll('.button');" + "\n" +
"const body = document.querySelector('body');" + "\n" +
    "console.log(buttons);" + "\n" +
"buttons.forEach(function(button){" + "\n" +
    "button.addEventListener('click', function(e){" + "\n" +
        "console.log(e.target);" + "\n" +
        "if(e.target.id === 'grey'){" + "\n" +
            "body.style.backgroundColor = e.target.id;" + "\n" +
        "}if(e.target.id === 'white'){" + "\n" +
            "body.style.backgroundColor = e.target.id;" + "\n" +
        "}if(e.target.id === 'blue'){" + "\n" +
            "body.style.backgroundColor = e.target.id;" + "\n" +
        "}if(e.target.id === 'yellow'){" + "\n" +
            "body.style.backgroundColor = e.target.id;" + "\n" +
        "}})})";

    private string quizString = "var questions = [" + "\n" +
    "{" + "\n" +
        "question: '2 + 2 = ?'," + "\n" +
        "choices: ['2', '22', '5', '4']," + "\n" +
        "correctAnswer: 3" + "\n" +
    "}," + "\n" +
    "{" + "\n" +
        "question: 'What is the iphones software called?'," + "\n" +
        "choices: ['MacOs', 'windows', 'ios', 'android']," + "\n" +
        "correctAnswer: 2" + "\n" +
    "}," + "\n" +
    "{" + "\n" +
        "question: 'How many letters are in the english alphabet'," + "\n" +
        "choices: ['26', '24', '31', '30']," + "\n" +
        "correctAnswer: 0" + "\n" +
    "}," + "\n" +
    "{" + "\n" +
        "question: 'What color does mixing blue and green make?'," + "\n" +
        "choices: ['purple', 'cyan', 'red', 'white']," + "\n" +
        "correctAnswer: 1" + "\n" +
    "}," + "\n" +
    "{" + "\n" +
        "question: 'What is AMD graphics card driver called?'," + "\n" +
        "choices: ['android', 'adrenalin', 'windows', 'directX']," + "\n" +
        "correctAnswer: 1" + "\n" +
"}" + "\n" +
"];" + "\n" +
"var currentQuestion = 0;" + "\n" +
"var correctAnswers = 0;" + "\n" +
"var quizOver = false;" + "\n" +
"window.addEventListener('DOMContentLoaded', function(e){" + "\n" +
    "displayCurrentQuestion();" + "\n" +
    "var quizMessage = document.querySelector('.quizMessage');" + "\n" +
    "quizMessage.style.display = 'none';" + "\n" +
    "document.querySelector('.nextButton').addEventListener('click', function(){" + "\n" +
        "if (!quizOver){" + "\n" +
            "var radioBtnsChecked = document.querySelector('input[type=radio]:checked');" + "\n" +
            "if (radioBtnsChecked === null){" + "\n" +
                "quizMessage.innerText = 'Please select an answer';" + "\n" +
                "quizMessage.style.display = 'block';" + "\n" +
            "}else{" + "\n" +
                "console.log(radioBtnsChecked.value);" + "\n" +
                "quizMessage.style.display = 'none';" + "\n" +
                "if (parseInt(radioBtnsChecked.value) === questions[currentQuestion].correctAnswer){" + "\n" +
                    "correctAnswers++;}" + "\n" +
                "currentQuestion++;" + "\n" +
                "if (currentQuestion < questions.length){" + "\n" +
                    "displayCurrentQuestion();" + "\n" +
                "}else{" + "\n" +
                    "displayScore();" + "\n" +
                    "document.querySelector('.nextButton').innerText = 'Play Again?';" + "\n" +
                    "quizOver = true;" + "\n" +
                "}}}" + "\n" +
        "else{" + "\n" +
            "quizOver = false;" + "\n" +
            "document.querySelector('.nextButton').innerText = 'Next Question';" + "\n" +
            "resetQuiz();" + "\n" +
            "displayCurrentQuestion();" + "\n" +
            "hideScore();}" + "\n" +
    "});" + "\n" +
"});" + "\n" +
"function displayCurrentQuestion(){" + "\n" +
    "console.log('In display current Questions');" + "\n" +
    "var question = questions[currentQuestion].question;" + "\n" +
    "var questionClass = document.querySelector('.quizContainer > .question');" + "\n" +
    "var choiceList = document.querySelector('.quizContainer > .choiceList');" + "\n" +
    "var numChoices = questions[currentQuestion].choices.length;" + "\n" +
    "questionClass.innerText = question;" + "\n" +
    "choiceList.innerHTML = '';" + "\n" +
    "var choice;" + "\n" +
    "for(i = 0; i < numChoices; i++){" + "\n" +
        "choice = questions[currentQuestion].choices[i];" + "\n" +
        "var li = document.createElement('li');" + "\n" +
        "li.innerHTML = '<li><input type='radio' value='' + i + '' name='dynradio' />' + choice + '</li>'" + "\n" +
        "choiceList.appendChild(li);" + "\n" +
    "}}" + "\n" +
"function resetQuiz(){" + "\n" +
    "currentQuestion = 0;" + "\n" +
   "correctAnswers = 0;" + "\n" +
    "hideScore();}" + "\n" +
"function displayScore(){" + "\n" +
    "document.querySelector('.quizContainer > .result').innerText = 'You scored: ' + correctAnswers + ' out of ' + questions.length;" + "\n" +
    "document.querySelector('.quizContainer > .result').style.display = 'block';}" + "\n" +
"function hideScore(){" + "\n" +
    "document.querySelector('.result').style.display = 'none';}";

    //htmlcss
    private bool htmlCss = false;
    private bool survey = false;
    private bool parallax = false;
    private bool website = false;
    private bool typewriter = false;
    private bool bubble = false;
    private bool counter = false;

    private string surveyString = "<div class='container'>" + "\n" +
  "<header class='header'>" + "\n" +
    "<h1 id = 'title' class='text-center'>Website Survey</h1>" + "\n" +
    "<p id = 'description' class='description text-center'>" + "\n" +
      "Enjoy the survey" + "\n" +
    "</p>" + "\n" +
  "</header>" + "\n" +
  "<form id = 'survey-form'>" + "\n" +
    "<div class='form-group'>" + "\n" +
      "<label id = 'name-label' for='name'>Name</label>" + "\n" +
      "<input" + "\n" +
        "type = 'text'" + "\n" +
        "name='name'" + "\n" +
        "id='name'" + "\n" +
        "class='form-control'" + "\n" +
        "placeholder='Enter your name here'" + "\n" +
        "required" + "\n" +
      "/>" + "\n" +
    "</div>" + "\n" +
    "<div class='form-group'>" + "\n" +
      "<label id = 'email-label' for='email'>Email</label>" + "\n" +
      "<input" + "\n" +
        "type = 'email'" + "\n" +
        "name='email'" + "\n" +
        "id='email'" + "\n" +
        "class='form-control'" + "\n" +
        "placeholder='Enter your Email'" + "\n" +
        "required" + "\n" +
      "/>" + "\n" +
    "</div>" + "\n" +
    "<div class='form-group'>" + "\n" +
      "<label id = 'number-label' for='number'" + "\n" +
        ">Age<span class='clue'>(optional)</span></label" + "\n" +
      ">" + "\n" +
      "<input" + "\n" +
        "type = 'number'" + "\n" +
        "name='age'" + "\n" +
        "id='number'" + "\n" +
        "min='10'" + "\n" +
        "max='99'" + "\n" +
        "class='form-control'" + "\n" +
        "placeholder='Age'" + "\n" +
      "/>" + "\n" +
    "</div>" + "\n" +
    "<div class='form-group'>" + "\n" +
      "<p>Which option best describes your current role?</p>" + "\n" +
      "<select id = 'dropdown' name='role' class='form-control' required>" + "\n" +
        "<option disabled selected value>Select current role</option>" + "\n" +
        "<option value = 'student' > Student </ option >" + "\n" +
        "< option value='job'>Full Time Job</option>" + "\n" +
        "<option value = 'learner' > Full Time Learner</option>" + "\n" +
        "<option value = 'preferNo' > Prefer not to say</option>" + "\n" +
            "<option value = 'other' > Other </ option >" + "\n" +
          "</ select >" + "\n" +
        "</ div >" + "\n" +
        "< div class='form-group'>" + "\n" +
      "<p>Would you recommend this site to friends?</p>" + "\n" +
      "<label>" + "\n" +
        "<input" + "\n" +
          "name = 'user-recommend'" + "\n" +
          "value='definitely'" + "\n" +
          "type='radio'" + "\n" +
          "class='input-radio'" + "\n" +
          "checked" + "\n" +
        "/>Definitely</label" + "\n" +
      ">" + "\n" +
      "<label>" + "\n" +
        "<input" + "\n" +
          "name = 'user-recommend'" + "\n" +
          "value='maybe'" + "\n" +
          "type='radio'" + "\n" +
          "class='input-radio'" + "\n" +
        "/>Maybe</label" + "\n" +
      ">" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'user-recommend'" + "\n" +
          "value='not-sure'" + "\n" +
          "type='radio'" + "\n" +
          "class='input-radio'" + "\n" +
        "/>Not sure</label" + "\n" +
      ">" + "\n" +
    "</div>" + "\n" +
    "<div class='form-group'>" + "\n" +
      "<p>" + "\n" +
        "Have any favorite features ?" + "\n" +
      "</p>" + "\n" +
      "<select id = 'most-like' name='mostLike' class='form-control' required>" + "\n" +
        "<option disabled selected value>Select an option</option>" + "\n" +
        "<option value = 'challenges' > Challenges </ option >" + "\n" +
        "< option value='projects'>Projects</option>" + "\n" +
        "<option value = 'community' > Community </ option >" + "\n" +
        "< option value='openSource'>Open Source</option>" + "\n" +
      "</select>" + "\n" +
    "</div>" + "\n" +
    "<div class='form-group'>" + "\n" +
      "<p>" + "\n" +
        "What else should we add?" + "\n" +
        "<span class='clue'>(Check all that apply)</span>" + "\n" +
      "</p>" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value='front-end-projects'" + "\n" +
          "type='checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Front-end Projects</label" + "\n" +
      ">" + "\n" +
      "<label>" + "\n" +
        "<input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value= 'back-end-projects" + "\n" +
          "type= 'checkbox" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Back-end Projects</label" + "\n" +
      ">" + "\n" +
      "<" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value= 'data-visualization'" + "\n" +
          "type= 'checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Data Visualization</label" + "\n" +
      ">" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value= 'challenges'" + "\n" +
          "type= 'checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Challenges</label" + "\n" +
      ">" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value='open-source-community'" + "\n" +
          "type='checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Open Source Community</label" + "\n" +
      ">" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value='gitter-help-rooms'" + "\n" +
          "type='checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Gitter help rooms</label" + "\n" +
      ">" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value='videos'" + "\n" +
          "type='checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Videos</label" + "\n" +
      ">" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value='city-meetups'" + "\n" +
          "type='checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>City Meetups</label" + "\n" +
      ">" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value= 'wiki'" + "\n" +
          "type= 'checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Wiki</label" + "\n" +
      ">" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value='forum'" + "\n" +
          "type='checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Forum</label" + "\n" +
      ">" + "\n" +
      "<label" + "\n" +
        "><input" + "\n" +
          "name = 'prefer'" + "\n" +
          "value='additional-courses'" + "\n" +
          "type='checkbox'" + "\n" +
          "class='input-checkbox'" + "\n" +
        "/>Additional Courses</label" + "\n" +
      ">" + "\n" +
    "</div>" + "\n" +
    "<div class='form-group'>" + "\n" +
      "<p>Any comments or suggestions?</p>" + "\n" +
      "<textarea" + "\n" +
        "id = 'comments'" + "\n" +
        "class='input-textarea'" + "\n" +
        "name='comment'" + "\n" +
        "placeholder='Enter your comment here...'" + "\n" +
      "></textarea>" + "\n" +
    "</div>" + "\n" +
    "<div class='form-group'>" + "\n" +
      "<button type = 'submit' id='submit' class='submit-button'>" + "\n" +
        "Submit" + "\n" +
      "</button>" + "\n" +
    "</div>" + "\n" +
  "</form>" + "\n" +
"</div>";
    private string parallaxString = "<!DOCTYPE html>" + "\n" +
"<html> " + "\n" +
"<head> " + "\n" +
"<meta name='viewport' content='width=device-width, initial-scale=1'>" + "\n" +
"<style>" + "\n" +
".parallax {" + "\n" +
  "background-image: url('img_parallax.jpg');" + "\n" +
    "min-height: 500px; " + "\n" +
  "background-attachment: fixed;" + "\n" +
    "background-position: center;" + "\n" +
  "background-repeat: no-repeat;" + "\n" +
  "background-size: cover;" + "\n" +
"}" + "\n" +
"</style>" + "\n" +
"</head>" + "\n" +
"<body>" + "\n" +
"<div class='parallax'></div>" + "\n" +
"<div style = 'height:1000px;background-color:red;font-size:36px' > " + "\n" +
"Scroll Up and Down this page to see the parallax scrolling effect." + "\n" +
"</div>" + "\n" +
"</body>" + "\n" +
"</html>";
    private string htmlwebsiteString = "<!DOCTYPE html>" + "\n" +
"<html lang='en'>" + "\n" +
"<head>" + "\n" +
  "<meta charset = 'UTF-8' > " + "\n" +
  "<meta name='viewport' content='width=device-width, initial-scale=1.0'>" + "\n" +
  "<link rel = 'stylesheet' href='assets/style.css'>" + "\n" +
  "<link rel = 'stylesheet' href='style.css'>" + "\n" +
  "<title>Responsive Website!</title>" + "\n" +
"</head>" + "\n" +
"<body>" + "\n" +
  "<div class='wrapper'>" + "\n" +
      "<nav class='menu'>" + "\n" +
          "<button aria-expanded='false' aria-controls='menu-list'>" + "\n" +
           "<span class='open'>☰</span>" + "\n" +
            "<span class='close'>×</span>" + "\n" +
            "Menu" + "\n" +
          "</button>" + "\n" +
          "<ul id = 'menu-list' > " + "\n" +
            "<li>" + "\n" +
              "<a href=''>Tacos</a>" + "\n" +
            "</li>" + "\n" +
            "<li>" + "\n" +
              "<a href =''> Beers </ a > " + "\n" +
            "</li > " + "\n" +
            "<li > " + "\n" +
              "<a href=''>Wines</a>" + "\n" +
            "</li>" + "\n" +
            "<li>" + "\n" +
              "<a href =''> Desserts </ a > " + "\n" +
            "</li> " + "\n" +
            "<li> " + "\n" +
              "<a href=''>Reservations</a>" + "\n" +
           "</li>" + "\n" +
          "</ul>" + "\n" +
        "</nav>" + "\n" +
    "<div class='top'>" + "\n" +
      "<header class='hero'>" + "\n" +
        "<h1>Terry's Taco Joint</h1>" + "\n" +
        "<p>Pretty Good Tacos!</p>" + "\n" +
     "</header>" + "\n" +
      "<div class='cta cta1'>" + "\n" +
        "<p class='price'>$1.99</p>" + "\n" +
        "<p>Tacos</p>" + "\n" +
      "</div>" + "\n" +
      "<div class='cta cta2'>" + "\n" +
        "<p class='price'>$3.99</p>" + "\n" +
        "<p>Kombucha</p>" + "\n" +
      "</div>" + "\n" +
    "</div>" + "\n" +
    "<section class='features'>" + "\n" +
      "<div class='feature'>" + "\n" +
        "<span class='icon'>🌮</span>" + "\n" +
        "<h3>Tacos</h3>" + "\n" +
        "<p>We are known as taco masters!</p>" + "\n" +
      "</div>" + "\n" +
      "<div class='feature'>" + "\n" +
        "<span class='icon'>🍺</span>" + "\n" +
        "<h3>Beer</h3>" + "\n" +
       "<p>We have all the popular beers!</p>" + "\n" +
      "</div>" + "\n" +
      "<div class='feature'>" + "\n" +
        "<span class='icon'>🍷</span>" + "\n" +
        "<h3>Wine</h3>" + "\n" +
        "<p>Pick one of the greatest wines and enjoy!</p>" + "\n" +
      "</div>" + "\n" +
      "<div class='feature'>" + "\n" +
        "<span class='icon'>🎵</span>" + "\n" +
        "<h3>Music</h3>" + "\n" +
        "<p>Chose your favorite music!</p>" + "\n" +
      "</div>" + "\n" +
    "</section>" + "\n" +
    "<section class='about'>" + "\n" +
      "<img src ='images/queso-taco.png' alt='Yummy Taco' class='about__mockup'>" + "\n" +
      "<div class='about__details'>" + "\n" +
        "<h2>Featured Taco</h2>" + "\n" +
        "<p>Slim Profile, easy to hold and loaded with cheese.</p>" + "\n" +
        "<p>This is the one you have been waiting for</p>" + "\n" +
        "<button>Learn More →</button>" + "\n" +
     "</div>" + "\n" +
    "</section>" + "\n" +
    "<section class='gallery'>" + "\n" +
      "<h2>Instant Grams</h2>" + "\n" +
      "<img src = 'https://source.unsplash.com/random/201x201' alt= '' > " + "\n" +
      "<img src= 'https://source.unsplash.com/random/202x201' alt= '' > " + "\n" +
      "<img src= 'https://source.unsplash.com/random/203x201' alt= '' > " + "\n" +
      "<img src= 'https://source.unsplash.com/random/204x201' alt= '' > " + "\n" +
      "<img src= 'https://source.unsplash.com/random/205x201' alt= '' > " + "\n" +
      "<img src= 'https://source.unsplash.com/random/206x201' alt= '' > " + "\n" +
      "<img src= 'https://source.unsplash.com/random/207x201' alt= '' > " + "\n" +
      "<img src= 'https://source.unsplash.com/random/207x20' alt= '' > " + "\n" +
      "<img src= 'https://source.unsplash.com/random/207x209' alt= '' > " + "\n" +
      "<img src= 'https://source.unsplash.com/random/207x210' alt= '' > " + "\n" +
    "</section> " + "\n" +
  "</div> " + "\n" +
  "<script> " + "\n" +
    "const navButton = document.querySelector('button[aria-expanded]');" + "\n" +
    "function toggleNav({ target }) {" + "\n" +
      "const expanded = target.getAttribute('aria-expanded') === 'true' || false;" + "\n" +
    "navButton.setAttribute('aria-expanded', !expanded);" + "\n" +
    "}" + "\n" +
"navButton.addEventListener('click', toggleNav);" + "\n" +
  "</script>" + "\n" +
"</body>" + "\n" +
"</html>";
    private string typewriterString = "/* Google Fonts */" + "\n" +
"@import url(https://fonts.googleapis.com/css?family=Anonymous+Pro);" + "\n" +
"html{" + "\n" +
        "min - height: 100 %;" + "\n" +
    "overflow: hidden;" + "\n" +
    "}" + "\n" +
    "body{" + "\n" +
  "height: calc(100vh - 8em);" + "\n" +
    "padding: 4em;" + "\n" +
  "color: rgba(255,255,255,.75);" + "\n" +
    "font-family: 'Anonymous Pro', monospace;" + "\n" +
  "background-color: rgb(25,25,25);" + "\n" +
"}" + "\n" +
".line-1{" + "\n" +
    "position: relative;" + "\n" +
    "top: 50%;" + "\n" +
    "width: 24em;" + "\n" +
    "margin: 0 auto;" + "\n" +
    "border-right: 2px solid rgba(255,255,255,.75);" + "\n" +
"font-size: 180%;" + "\n" +
    "text-align: center;" + "\n" +
    "white-space: nowrap;" + "\n" +
    "overflow: hidden;" + "\n" +
    "transform: translateY(-50%);    " + "\n" +
"}" + "\n" +
".anim-typewriter{" + "\n" +
  "animation: typewriter 4s steps(44) 1s 1 normal both," + "\n" +
             "blinkTextCursor 500ms steps(44) infinite normal;" + "\n" +
"}" + "\n" +
"@keyframes typewriter" + "\n" +
"{" + "\n" +
    "from { width: 0; }" + "\n" +
    "to { width: 24em; }" + "\n" +
"}" + "\n" +
"@keyframes blinkTextCursor" + "\n" +
"{" + "\n" +
    "from { border - right - color: rgba(255, 255, 255, .75); }" + "\n" +
    "to { border - right - color: transparent; }" + "\n" +
"}";
    private string bubbleString = ".wrapper {" + "\n" +
  "max-width: 900px;" + "\n" +
  "margin: 0 auto;" + "\n" +
  "padding: 30px;" + "\n" +
"}" + "\n" +
".content {" + "\n" +
  "padding-right: 210px;" + "\n" +
"}" + "\n" +
".bubble {" + "\n" +
  "position: fixed;" + "\n" +
"top: 20px;" + "\n" +
  "right: calc(50% - 450px + 30px);" + "\n" +
"}" + "\n" +
"@media all and(max-width: 900px)" + "\n" +
"{" + "\n" +
  ".bubble {" + "\n" +
    "right: 20px;" + "\n" +
    "}" + "\n" +
"}" + "\n" +
"* {" + "\n" +
  "box-sizing: border-box;" + "\n" +
"}" + "\n" +
"body {" + "\n" +
  "background: #ecf0f1;" + "\n" +
"}" + "\n" +
"h1 {" + "\n" +
  "font-size: 50px;" + "\n" +
"}" + "\n" +
"p {" + "\n" +
  "font-size: 25px;" + "\n" +
  "line-height: 1.4;" + "\n" +
"}" + "\n" +
"a {" + "\n" +
  "color: #128b98;" + "\n" +
  "text-decoration: none;" + "\n" +
"}" + "\n" +
"a:hover {" + "\n" +
  "border-bottom: solid 1px #128b98;" + "\n" +
"}" + "\n" +
".wrapper {" + "\n" +
  "background: #fff;" + "\n" +
"}" + "\n" +
".bubble {" + "\n" +
  "width: 180px;" + "\n" +
  "height: 180px;" + "\n" +
  "background: #128b98;" + "\n" +
  "color: #fff;" + "\n" +
  "border-radius: 50%;" + "\n" +
  "text-align: center;" + "\n" +
  "padding: 50px 30px;" + "\n" +
  "font-size: 20px;" + "\n" +
"}";
    private string counterString = "<!DOCTYPE html>" + "\n" +
"<html > " + "\n" +
"<head >" + "\n" +
"<style >" + "\n" +
"body {" + "\n" +
  "counter-reset: section;" + "\n" +
"}" + "\n" +
"h2::before {" + "\n" +
  "counter-increment: section;" + "\n" +
  "content: 'Section ' counter(section) ': ';" + "\n" +
"}" + "\n" +
"</style>" + "\n" +
"</head>" + "\n" +
"<body>" + "\n" +
"<h1>Using CSS Counters:</h1>" + "\n" +
"<h2>Part2</h2>" + "\n" +
"<h2>And again</h2>" + "\n" +
"<h2>Last time</h2>" + "\n" +
"<p><b>Note:</b> IE8 supports these properties only if a !DOCTYPE is specified.</p>" + "\n" +
"</body>" + "\n" +
"</html>";

    //c#
    private bool cSharp = false;
    private bool movement = false;
    private bool displayText = false;
    private bool spawner = false;
    private bool collision = false;
    private bool shooting = false;
    private bool ai = false;
    private string movementString = "using System.Collections;" + "\n" +
        "using System.Collections.Generic" + "\n" +
        "using UnityEngine;" + "\n" +
        "public class PlayerMovement : MonoBehaviour" + "\n" +
        "{" + "\n" +
        "public CharacterController controller;" + "\n" +
        "public float speed = 12f;" + "\n" +
        "public float gravity = -9.81f;" + "\n" +
        "public float jumpHeight = 3f;" + "\n" +
        "public Transform ground check;" + "\n" +
        "public float groundDistance = 0.4f;" + "\n" +
        "public LayerMask groundMask;" + "\n" +
        "Vector3 velocity" + "\n" +
        "bool isGrounded" + "\n" +
        "void Update(){" + "\n" +
        "isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);" + "\n" +
        "if(isGrounded && velocity.y < 0){" + "\n" +
        "velocity.y = -2f;}" + "\n" +
        "float x = Input.GetAxis('Horizontal');" + "\n" +
        "float z = Input.GetAxis('Vertical');" + "\n" +
        "Vector3 move = transform.right * x + transform.forward * z;" + "\n" +
        "controller.Move(move * speed * Time.deltaTime);" + "\n" +
        "if(Input.GetButtonDown('Jump') && isGrounded){" + "\n" +
        "velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity)}" + "\n" +
        "velocity.y += gravity * Time.deltaTime;" + "\n" +
        "controller.Move(velocity * Time.deltaTime);";

    private string displayTextString = "using System.Collections;" + "\n" +
"using System.Collections.Generic;" + "\n" +
"using UnityEngine;" + "\n" +
"using UnityEngine.UI;" + "\n" +
"public class WorkConsoletext : MonoBehaviour" + "\n" +
"{" + "\n" +
    "private string helloWorld = 'Hello World';" + "\n" +
    "public Text displayText = null;" + "\n" +
    "private int stringAt = 0;" + "\n" +
    "public GameObject finished;" + "\n" +
    "public void CodeIsWorking(){" + "\n" +
        "displayText.text += helloWorld[stringAt]; " + "\n" +
        "stringAt += 1; " + "\n" +
        "if(stringAt >= helloWorld.Length){" + "\n" +
            "finished.SetActive(true); " + "\n" +
            "stringAt = 0;}}";

    private string spawnerString = "using System.Collections;" + "\n" +
"using System.Collections.Generic;" + "\n" +
"using UnityEngine;" + "\n" +
"public class SpawnerScript : MonoBehaviour" + "\n" +
"{" + "\n" +
    "public GameObject enemy;" + "\n" +
    "float randX;" + "\n" +
    "Vector2 whereToSpawn;" + "\n" +
    "public float spawnRate = 4f;" + "\n" +
    "float nextSpawn = 0.0f;" + "\n" +
    "void Update(){" + "\n" +
        "if(Time.time > nextSpawn){" + "\n" +
            "nextSpawn = Time.time + spawnRate; " + "\n" +
            "randX = Random.Range(-2.4f, 2.4f); " + "\n" +
            "whereToSpawn = new Vector2(randX, transform.position.y); " + "\n" +
            "Instantiate(enemy, whereToSpawn, Quaternion.identity);}}}";

    private string collisionString = "using System.Collections;" + "\n" +
"using System.Collections.Generic;" + "\n" +
"using UnityEngine;" + "\n" +
"public class DestroyByContact : MonoBehaviour" + "\n" +
"{" + "\n" +
    "public GameObject restartButton;" + "\n" +
    "void OnCollisionEnter2D(Collision2D col){" + "\n" +
        "if(col.gameObject.name == 'Enemy'){" + "\n" +
            "Destroy(col.gameObject);" + "\n" +
        "}}}";

    private string shootingString = "using System.Collections;" + "\n" +
        "using System.Collections.Generic;" + "\n" +
        "using UnityEngine;" + "\n" +
        "public class Weapon : MonoBehaviour {" + "\n" +
        "public Transform firepoint;" + "\n" +
        "public int damage = 40;" + "\n" +
        "public GameObject impactEffect;" + "\n" +
        "public LineRenderer lineRenderer;" + "\n" +
        "void Update(){" + "\n" +
        "if(Input.GetButtonDown('Fire1')){" + "\n" +
        "StartCoroutine(Shoot());}}" + "\n" +
        "IEnumerator Shoot(){" + "\n" +
        "RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);" + "\n" +
        "if(hitInfo){" + "\n" +
        "Enemy enemy = hitInfo.transform.GetComponent<Enemy>();" + "\n" +
        "if(enemy != null){" + "\n" +
        "enemy.TakeDamage(damage);}" + "\n" +
        "Instantiate(impactEffect, hitInfo.point, Quaternion.identity);" + "\n" +
        "lineRenderer.SetPosition(0, firePoint.position);" + "\n" +
        "lineRenderer.SetPosition(1, hitInfo.point);" + "\n" +
        "}else{" + "\n" +
        "lineRenderer.SetPosition(0, firePoint.position);" + "\n" +
        "lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);}" + "\n" +
        "lineRenderer.enabled = true;" + "\n" +
        "yield return new WaitForSeconds(0.02f);" + "\n" +
        "lineRenderer.enabled = false;}";

    private string aiString = "using System.Collections;" + "\n" +
"using System.Collections.Generic;" + "\n" + 
    "using UnityEngine;" + "\n" + 
    "using UnityEngine.AI;" + "\n" + 
"public class EnemyController : MonoBehaviour" + "\n" + 
"{" + "\n" + 
    "public float lookRadius = 10f;" + "\n" + 
    "Transform target;" + "\n" + 
    "NavMeshAgent agent;" + "\n" + 
    "CharacterCombat combatManager;" + "\n" + 
    "void Start(){" + "\n" + 
        "target = Player.instance.transform; " + "\n" + 
        "agent = GetComponent<NavMeshAgent>(); " + "\n" + 
        "combatManager = GetComponent<CharacterCombat>();}" + "\n" + 
    "void Update(){" + "\n" + 
        "float distance = Vector3.Distance(target.position, transform.position); " + "\n" + 
        "if(distance <= lookRadius){" + "\n" + 
            "agent.SetDestination(target.position); " + "\n" + 
            "if(distance <= agent.stoppingDistance){" + "\n" + 
                "combatManager.Attack(Player.instance.playerStats); " + "\n" + 
                "FaceTarget();" + "\n" + 
            "}}}" + "\n" + 
    "void FaceTarget(){" + "\n" + 
        "Vector3 direction = (target.position - transform.position).normalized; " + "\n" + 
        "Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z)); " + "\n" + 
        "transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);}" + "\n" + 
    "void OnDrawGizmosSelected(){" + "\n" + 
        "Gizmos.color = Color.red; " + "\n" + 
        "Gizmos.DrawWireSphere(transform.position, lookRadius);" + "\n" + 
    "}}";
    //pascal
    private bool pascal = false;
    //private bool musicPlayer = false;
    //private bool purchasing = false;
    //private bool calendar = false;
    //private bool contacts = false;
    //private bool gameDev = false;
    //private bool periodicTab = false;

    //unity
    private bool unity = false;
    //private bool musicPlayer = false;
    //private bool purchasing = false;
    //private bool calendar = false;
    //private bool contacts = false;
    //private bool gameDev = false;
    //private bool periodicTab = false;

    //react
    private bool react = false;
    private bool carousel = false;
    private bool compass = false;
    private bool voting = false;
    private bool search = false;
    private bool reactGame = false;
    private bool bill = false;
    private string carouselString = "import React from 'react';" + "\n" +
"import { Carousel }from 'react-responsive-carousel';" + "\n" +
"import 'react-responsive-carousel/lib/styles/carousel.min.css';" + "\n" +
"let styles = {" + "\n" +
    "margin: 'auto'," + "\n" +
    "width: '500px'" + "\n" +
  "};" + "\n" +
"function App()" + "\n" +
"{" + "\n" +
    "return (" + "\n" +
      "<div style ={ styles}>" + "\n" +
     "<Carousel>" + "\n" +
    "<div>" + "\n" +
   "<img src = 'Hong Kong' alt = 'Hong Kong'/>" + "\n" +
   "<p className = 'legend'> Hong Kong </ p>" + "\n" +
   "</div>" + "\n" +
   "<div>" + "\n" +
   "<img src = 'Singapore' alt = 'Singapore' />" + "\n" +
  "<p className = 'legend'></ p > " + "\n" +
  "</div> " + "\n" +
    "<div>" + "\n" +
   "<img src = 'Japan' alt = 'Japan'/>" + "\n" +
   "<p className = 'legend'> Japan </ p > " + "\n" +         
  "</div>" + "\n" +
   "<div>" + "\n" +
   "<img src = 'Las Vegas' alt = 'Las Vegas'/>" + "\n" +   
    "<p className = 'legend'> Las Vegas </p>" + "\n" +                     
    "</div>" + "\n" +                     
   "</Carousel>" + "\n" +                     
  "</div >" + "\n" +
  ");}" + "\n" +
"export default App;";

    private string compassString = "import React, { Component } from 'react';" + "\n" +
"import './App.css';" + "\n" +
"class App extends Component" + "\n" +
    "{" + "\n" +
        "constructor(){" + "\n" +
    "super()" + "\n" +
    "this.state=({" + "\n" +
      "year:2019," + "\n" +
      "M_month:'Mar'," + "\n" +
      "month:1," + "\n" +
      "day:1," + "\n" +
      "week:1," + "\n" +
      "hour:12," + "\n" +
      "Minute:1," + "\n" +
      "second:1," + "\n" +
      "Zodiac:'Aries, Taurus, Gemini, Cancer, Leo, Virgo, Libra, Scorpio, Sagittarius, Capricorn, Aquarius, Pisces'.split(',')," + "\n" +
      "M_months:['Jan','Feb','Mar','Apr','May','Jun','Jul','Aug','Spt','Oct','Nov','Dec']," + "\n" +
    "})" + "\n" +
  "}" + "\n" +
 "componentWillMount(){" + "\n" +
    "setInterval(() => {" + "\n" +
    "let time = new Date()" + "\n" +
      "this.setState({" + "\n" +
    "year: this.state.Zodiac[time.getUTCFullYear() % 12]," + "\n" +
      "M_month: this.state.M_months[time.getUTCMonth()]," + "\n" +
      "month: time.getMonth() + 1," + "\n" +
      "day: time.getDate()," + "\n" +
     "week: time.getDay()," + "\n" +
      "hour: time.getHours()," + "\n" +
      "Minute: time.getMinutes()," + "\n" +
      "second: time.getSeconds()" + "\n" +
     "})" + "\n" +
   "},1000)" + "\n" +
 "}" + "\n" +
  "array = length => Array.from({length}).map((v, k) => k).map(x=>x+1);" + "\n" +
"addPreZero = num =>{" + "\n" +
    "if(num>=10)return num" + "\n" +
    "return '0'+num" + "\n" +
  "}" + "\n" +
  "render(){" + "\n" +
    "return (" + "\n" +
      "<div className = 'App' >" + "\n" +
         "<header className = 'App-header' >" + "\n" +
            "<div className = 'msg' >" + "\n" +
               "<div  className = 'year' >" + "\n" +
                "<span >" + "\n" +
            "{ this.state.year}</span> / Year" + "\n" +
             "</div>" + "\n" +
           "</div>" + "\n" +
           "<div className = 'M_month'>" + "\n" +
          "{`${ this.state.M_month}`}" + "\n" +
          "</div>" + "\n" +
          "<div className = 'box'>" + "\n" +
            "{" + "\n" +
        "this.array(12).map((x, index) => {" + "\n" +
        "return (" + "\n" +
          "<div key ={ index}" + "\n" +
        "className ={`month item ${ index === (this.state.month - 1) ? 'active' : ''}`}" + "\n" +
        "style ={ { transform: `rotate(${ index * 30 - 30 * (this.state.month - 1)} deg)`}" + "\n" +
"}>" + "\n" +
                  "{`${x} month`}" + "\n" +
                "</div>" + "\n" +
              ")" + "\n" +
            "})}" + "\n" +
            "{this.array(30).map((x,index)=>{" + "\n" +
    "return (" + "\n" +
      "<div key ={ index}" + "\n" +
    "className ={`day item ${ index === (this.state.day - 1) ? 'active' : ''}`}" + "\n" +
    "style ={ { transform: `rotate(${ index * 12 - 12 * (this.state.day - 1)} deg)`} }>" + "\n" +
                  "{`${ x} day`}" + "\n" +
                "</ div >" + "\n" +
              ")" + "\n" +
            "})}" + "\n" +
            "{this.array(7).map((x,index)=>{" + "\n" +
    "return (" + "\n" +
      "<div key ={ index}" + "\n" +
    "className ={`week item ${ index === (this.state.week - 1) ? 'active' : ''}`}" + "\n" +
    "style ={ { transform: `rotate(${ index * (360 / 21) - (360 / 21) * (this.state.week - 1)} deg)`} }>" + "\n" +
                  "{`week ${ x}`}" + "\n" +
                "</div>" + "\n" +
              ")" + "\n" +
            "})}" + "\n" +
            "{this.array(24).map((x,index)=>{" + "\n" +
    "return (" + "\n" +
      "<div key ={ index}" + "\n" +
    "className ={`hour item ${ index === (this.state.hour - 1) ? 'active' : ''}`}" + "\n" +
    "style ={ { transform: `rotate(${ index * (360 / 24) - (360 / 24) * (this.state.hour - 1)} deg)`} }>" + "\n" +
                  "{`${ x} hr`}" + "\n" +
                "</div>" + "\n" +
              ")" + "\n" +
            "})}" + "\n" +
            "{this.array(60).map((x,index)=>{" + "\n" +
    "return (" + "\n" +
      "<div key ={ index}" + "\n" +
    "className ={`Minute item ${ index === (this.state.Minute - 1) ? 'active' : ''}`}" + "\n" +
    "style ={ { transform: `rotate(${ index * (360 / 60) - (360 / 60) * (this.state.Minute - 1)} deg)`} }>" + "\n" +
                  "{`${ x} min`}" + "\n" +
                "</div>" + "\n" +
              ")" + "\n" +
            "})}" + "\n" +
            "{this.array(60).map((x,index)=>{" + "\n" +
    "return (" + "\n" +
      "<div key ={ index}" + "\n" +
    "className ={`second item ${ index === (this.state.second - 1) ? 'active' : ''}`}" + "\n" +
    "style ={ { transform: `rotate(${ index * (360 / 60) - (360 / 60) * (this.state.second - 1)} deg)`} }>" + "\n" +
                  "{`${ x} sec`}" + "\n" +
                "</ div >" + "\n" +
              ")" + "\n" +
            "})}" + "\n" +
          "</div>" + "\n" +
        "</header>" + "\n" +
      "</div>" + "\n" +
    ");" + "\n" +
  "}}" + "\n" +
"export default App; ";
    private string votingString = "import React,{Component} from 'react';" + "\n" +
"import './App.css';" + "\n" +
"class App extends Component" + "\n" +
    "{" + "\n" +
        "constructor(props){" + "\n" +
        "super(props);" + "\n" +
        "this.state = {" + "\n" +
            "languages : [" + "\n" +
                "{name: 'Php', votes: 0}," + "\n" +
                "{name: 'Python', votes: 0}," + "\n" +
                "{name: 'Go', votes: 0}," + "\n" +
                "{name: 'Java', votes: 0}" + "\n" +
            "]}}" + "\n" +
    "vote(i)" + "\n" +
"{" + "\n" +
    "let newLanguages = [...this.state.languages];" + "\n" +
    "newLanguages[i].votes++;" + "\n" +
    "function swap(array, i, j)" + "\n" +
    "{" + "\n" +
        "var temp = array[i];" + "\n" +
        "array[i] = array[j];" + "\n" +
        "array[j] = temp;" + "\n" +
    "}" + "\n" +
    "this.setState({ languages: newLanguages});" + "\n" +
"}" + "\n" +
"render()" + "\n" +
"{" + "\n" +
    "return (" + "\n" +
        "<>" + "\n" +
            "<h1> Vote Your Language!</h1>" + "\n" +
               "<div className = 'languages'>" + "\n" +
                    "{" + "\n" +
        "this.state.languages.map((lang, i) =>" + "\n" +
            "<div key ={ i}" + "\n" +
        "className = 'language'>" + "\n" +
 "<div className = 'voteCount'>" + "\n" +
                                    "{lang.votes}" + "\n" +
                                "</div>" + "\n" +
                                "<div className = 'languageName'>" + "\n" +
                                   "{lang.name}" + "\n" +
                                "</div>" + "\n" +
                                "< button onClick ={ this.vote.bind(this, i)}> Click Here </ button >" + "\n" +
                                "</ div >" + "\n" +
						")" + "\n" +
					"}" + "\n" +
                "</div>" + "\n" +
            "</>" + "\n" +
		");" + "\n" +
"}}" + "\n" +
"export default App;";

    private string searchString = "import React from 'react';" + "\n" +
"import countries from './Countries';" + "\n" +
"import './App.css';" + "\n" +
"export default class AutoCompletedText extends React.Component" + "\n" +
    "{" + "\n" +
        "constructor(props){" + "\n" +
        "super(props)" + "\n" +
        "this.state = {" + "\n" +
            "suggestions: []," + "\n" +
            "text: ''" + "\n" +
        "}}" + "\n" +
    "onTextChange = (e) => {" + "\n" +
        "const value = e.target.value;" + "\n" +
"let suggestions = [];" + "\n" +
        "if(value.length > 0){" + "\n" +
            "const regex = new RegExp(`^${value}`, 'i');" + "\n" +
            "suggestions = countries.sort().filter(v => regex.test(v))" + "\n" +
        "}" + "\n" +
        "this.setState(() => ({" + "\n" +
            "suggestions," + "\n" +
            "text: value" + "\n" +
        "}))" + "\n" +
    "}" + "\n" +
    "selectedText(value)" + "\n" +
"{" + "\n" +
    "this.setState(() => ({" + "\n" +
    "text: value," + "\n" +
            "suggestions: []," + "\n" +
        "}))" + "\n" +
    "}" + "\n" +
"renderSuggestions = () => {" + "\n" +
        "let { suggestions } = this.state;" + "\n" +
        "if(suggestions.length === 0){" + "\n" +
    "return null;" + "\n" +
"}" + "\n" +
        "return (" + "\n" +
            "<ul>" + "\n" +
                "{" + "\n" +
    "suggestions.map((item, index) => (< li key ={ index}" + "\n" +
    "onClick ={ () => this.selectedText(item)}>{ item}</ li >))" + "\n" +
                "}" + "\n" +
            "</ul>" + "\n" +
        ");" + "\n" +
"}" + "\n" +
"render()" + "\n" +
"{" + "\n" +
    "const { text, suggestions } = this.state;" + "\n" +
    "return (" + "\n" +
        "<div id = 'notebooks'>" + "\n" +
             "<h2> Auto Completed </h2>" + "\n" +
                "<input id = 'query' type = 'text' onChange ={ this.onTextChange}" + "\n" +
    "value ={ text}/>" + "\n" +
                "{ this.renderSuggestions()}" + "\n" +
                "<span>Suggestions: { suggestions.length}</span>    " + "\n" +
                "</div>" + "\n" +
        ");" + "\n" +
"}}";

    private string reactGameString = "import React, { Component } from 'react';" + "\n" +
"import CharacterCard from './CharacterCard';" + "\n" +
"import Wrapper from './Wrapper';" + "\n" +
"import Navbar from './Navbar';" + "\n" +
"import Jumbotron from './Jumbotron';" + "\n" +
"import characters from './characters.json';" + "\n" +
"import './App.css';" + "\n" +
"class App extends Component" + "\n" +
    "{" + "\n" +
        "state = {" + "\n" +
            "characters," + "\n" +
    "highScore: 0," + "\n" +
    "currentScore: 0," + "\n" +
    "Clicked: false" + "\n" +
        "};" + "\n" +
        "handleClick = id => {" + "\n" +
            "this.shuffleArray();" + "\n" +
            "this.handleScore(id);" + "\n" +
            "console.log(this.state.timesClicked);" + "\n" +
        "};" + "\n" +
        "handleScore = id => {" + "\n" +
            "this.state.characters.forEach(element => {" + "\n" +
            "if (id === element.id && element.clicked === false)" + "\n" +
            "{" + "\n" +
                "element.clicked = true;" + "\n" +
                "this.setState({ Clicked: false });" + "\n" +
            "this.handleIncrement();" + "\n" +
        "}else if (id === element.id && element.clicked === true) {" + "\n" +
        "if (this.state.currentScore > this.state.highScore) {" + "\n" +
        "this.setState({ highScore: this.state.currentScore });" + "\n" +
    "}" + "\n" +
        "this.setState({ currentScore: 0 });" + "\n" +
        "this.setState({ Clicked: true });" + "\n" +
        "this.state.characters.forEach(element => (element.clicked = false));" + "\n" +
"console.log(this.state.characters);" + "\n" +
"}" + "\n" +
    "});" + "\n" +
  "};" + "\n" +
  "shuffleArray = () => {" + "\n" +
    "const shuffledArr = this.shuffle(this.state.characters);" + "\n" +
    "this.setState({ shuffledArr });" + "\n" +
  "};" + "\n" +
  "handleIncrement = () => {" + "\n" +
    "this.setState({ currentScore: this.state.currentScore + 1 });" + "\n" +
  "};" + "\n" +
  "shuffle = array => {" + "\n" +
    "var currentIndex = array.length," + "\n" +
      "temporaryValue," + "\n" +
      "randomIndex;" + "\n" +
    "while (0 !== currentIndex) {" + "\n" +
      "randomIndex = Math.floor(Math.random() * currentIndex);" + "\n" +
      "currentIndex -= 1;" + "\n" +
      "temporaryValue = array[currentIndex];" + "\n" +
      "array[currentIndex] = array[randomIndex];" + "\n" +
      "array[randomIndex] = temporaryValue;" + "\n" +
    "}" + "\n" +
    "return array;" + "\n" +
  "};" + "\n" +
  "render()" + "\n" +
"{" + "\n" +
    "return (" + "\n" +
      "<Wrapper >" + "\n" +
        "<Navbar" + "\n" +
          "currentScore ={ this.state.currentScore}" + "\n" +
    "highScore ={ this.state.highScore}" + "\n" +
        "/>" + "\n" +
        "<Jumbotron />" + "\n" +
        "{" + "\n" +
        "this.state.characters.map(character => (" + "\n" +
         "<CharacterCard" + "\n" +
           "Clicked ={ this.state.Clicked}" + "\n" +
        "handleClick ={ this.handleClick}" + "\n" +
        "id ={ character.id}" + "\n" +
        "key ={ character.id}" + "\n" +
        "name ={ character.name}" + "\n" +
        "image ={ character.image}" + "\n" +
        "occupation ={ character.occupation}" + "\n" +
          "/>" + "\n" +
        "))}" + "\n" +
      "</ Wrapper >" + "\n" +
    ");" + "\n" +
"}}" + "\n" +
"export default App;";

    private string billString = "import React, { Component } from 'react';" + "\n" +
"import Results from './Results';" + "\n" +
"import Inputs from './Inputs';" + "\n" +
"import Buttons from './Buttons';" + "\n" +
"const btnsValue = [9, 8, 7, 6, 5, 4, 3, 2, 1, '.', 0, 'DEL'];" + "\n" +
    "const tipPercentages = [.05, .10, .15, .20];" + "\n" +
    "class Calculator extends Component" + "\n" +
    "{" + "\n" +
        "constructor(props) {" + "\n" +
        "super(props);" + "\n" +
        "this.state = {" + "\n" +
            "buttons: btnsValue," + "\n" +
            "clickedBtn: ''," + "\n" +
            "billTotal: ''," + "\n" +
            "numberOfPeople: 1," + "\n" +
            "percentages: tipPercentages," + "\n" +
            "tipPercent: tipPercentages[0]," + "\n" +
            "tipTotal: 0," + "\n" +
            "costPP: 0" + "\n" +
        "};" + "\n" +
        "this.onClickButton = this.onClickButton.bind(this);" + "\n" +
        "this.updateBillTotal = this.updateBillTotal.bind(this);" + "\n" +
        "this.updatePartyCount = this.updatePartyCount.bind(this);" + "\n" +
        "this.getTipPercentage = this.getTipPercentage.bind(this);" + "\n" +
    "}" + "\n" +
"onClickButton(i){" + "\n" +
    "this.setState({" + "\n" +
    "clickedBtn: this.state.buttons[i]" + "\n" +
        "}, function() {" + "\n" +
        "this.updateBillTotal(i);" + "\n" +
   "});" + "\n" +
"}" + "\n" +
"updateBillTotal(i)" + "\n" +
"{" + "\n" +
    "let newState;" + "\n" +
    "if (this.state.clickedBtn === '.' && this.state.billTotal.includes('.'))" + "\n" +
    "{" + "\n" +
        "return null;" + "\n" +
    "}" + "\n" +
    "if (this.state.clickedBtn !== 'DEL'){" + "\n" +
        "newState = this.state.billTotal + this.state.clickedBtn;" + "\n" +
        "this.setState({" + "\n" +
        "billTotal: newState" + "\n" +
            "}, function() {" + "\n" +
            "this.calculateCosts();" + "\n" +
        "}" + "\n" +
            ");" + "\n" +
   "}" + "\n" +
    "else{" + "\n" +
        "newState = '';" + "\n" +
        "this.setState({" + "\n" +
       "billTotal: newState," + "\n" +
                "numberOfPeople: 2," + "\n" +
                "tipTotal: 0," + "\n" +
                "costPP: 0" + "\n" +
            "}, function() {" + "\n" +
            "this.calculateCosts();" + "\n" +
        "});" + "\n" +
    "}}" + "\n" +
"updatePartyCount(sum){" + "\n" +
    "let newState;" + "\n" +
    "if(sum === 'add'){" + "\n" +
        "newState = this.state.numberOfPeople + 1;" + "\n" +
        "this.setState({" + "\n" +
        "numberOfPeople: newState" + "\n" +
            "}, function() {" + "\n" +
            "this.calculateCosts();" + "\n" +
        "});" + "\n" +
    "}" + "\n" +
    "else if (sum === 'minus' && this.state.numberOfPeople > 1){" + "\n" +
        "newState = this.state.numberOfPeople - 1;" + "\n" +
        "this.setState({" + "\n" +
        "numberOfPeople: newState" + "\n" +
            "}, function() {" + "\n" +
            "this.calculateCosts();" + "\n" +
        "});" + "\n" +
    "}" + "\n" +
    "else{" + "\n" +
        "this.setState({" + "\n" +
        "numberOfPeople: this.state.numberOfPeople" + "\n" +
                "}, function() {" + "\n" +
            "this.calculateCosts();" + "\n" +
        "});" + "\n" +
    "}}" + "\n" +
"getTipPercentage(i){" + "\n" +
    "let newState = this.state.percentages[i];" + "\n" +
    "this.setState({" + "\n" +
    "tipPercent: newState" + "\n" +
        "}, function() {" + "\n" +
        "this.calculateCosts();" + "\n" +
    "}" + "\n" +
        ");" + "\n" +
"}" + "\n" +
"calculateCosts(){" + "\n" +
    "let newBillTotal = parseFloat(this.state.billTotal);" + "\n" +
    "if (!Number.isNaN(newBillTotal)){" + "\n" +
        "let newTipTotal, newCostPP;" + "\n" +
        "newTipTotal = parseFloat(newBillTotal * this.state.tipPercent);" + "\n" +
        "newCostPP = newBillTotal + newTipTotal;" + "\n" +
        "newCostPP = newCostPP / this.state.numberOfPeople;" + "\n" +
        "this.setState({" + "\n" +
        "tipTotal: newTipTotal," + "\n" +
            "costPP: newCostPP" + "\n" +
        "});" + "\n" +
    "}}" + "\n" +
"render(){" + "\n" +
    "return (" + "\n" +
        "<div>" + "\n" +
            "< Results" + "\n" +
    "costPerPerson ={ this.state.costPP}" + "\n" +
    "billTotal ={ this.state.billTotal}" + "\n" +
    "tipTotal ={ this.state.tipTotal}" + "\n" +
    "partyCount ={ this.state.numberOfPeople} />" + "\n" +
      "< Inputs" + "\n" +
    "billTotal ={ this.state.billTotal}" + "\n" +
    "tipTotal ={ this.state.tipTotal}" + "\n" +
    "getPartyCount ={ this.updatePartyCount}" + "\n" +
    "partyCount ={ this.state.numberOfPeople}" + "\n" +
    "getTipPercentage ={ this.getTipPercentage}" + "\n" +
    "handleInputChange ={ this.handleInputChange} />" + "\n" +
  "<Buttons onClickButton ={ this.onClickButton}" + "\n" +
    "buttons ={ this.state.buttons} />" + "\n" +
"</div>" + "\n" +
        ")" + "\n" +
    "}}" + "\n" +
"export default Calculator;";

    public void CodeIsWorking()
    {
        if (cPlus == true)
        {
            if (musicPlayer == true)
            {
                textToDisplay.text += musicPlayerString[stringAt];
                stringAt += 1;
                if (stringAt >= musicPlayerString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    musicPlayer = false;
                    cPlus = false;
                    cPlusFinished1.SetActive(true);
                }
            }
            else if (atm == true)
            {
                textToDisplay.text += atmString[stringAt];
                stringAt += 1;
                if (stringAt >= atmString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    atm = false;
                    cPlus = false;
                    cPlusFinished2.SetActive(true);
                }
            }
            else if (calendar == true)
            {
                textToDisplay.text += calendarString[stringAt];
                stringAt += 1;
                if (stringAt >= calendarString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    calendar = false;
                    cPlus = false;
                    cPlusFinished3.SetActive(true);
                }
            }
            else if (contacts == true)
            {
                textToDisplay.text += contactString[stringAt];
                stringAt += 1;
                if (stringAt >= contactString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    contacts = false;
                    cPlus = false;
                    cPlusFinished4.SetActive(true);
                }
            }
            else if (cPlusGameDev == true)
            {
                textToDisplay.text += cPlusGamedevString[stringAt];
                stringAt += 1;
                if (stringAt >= cPlusGamedevString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    cPlusGameDev = false;
                    cPlus = false;
                    cPlusFinished5.SetActive(true);
                }

            }
            else if (encryptedmessage == true)
            {
                textToDisplay.text += encryptedmessageString[stringAt];
                stringAt += 1;
                if (stringAt >= encryptedmessageString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    encryptedmessage = false;
                    cPlus = false;
                    cPlusFinished6.SetActive(true);
                }
            }
        }
        else if (java == true)
        {
            if (palindrome == true)
            {
                textToDisplay.text += palindromeString[stringAt];
                stringAt += 1;
                if (stringAt >= palindromeString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    palindrome = false;
                    java = false;
                    javaFinished1.SetActive(true);
                }
            }else if (countWords == true)
            {
                textToDisplay.text += countWordsString[stringAt];
                stringAt += 1;
                if (stringAt >= countWordsString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    countWords = false;
                    java = false;
                    javaFinished2.SetActive(true);
                }
            }else if (reverse == true)
            {
                textToDisplay.text += reverseString[stringAt];
                stringAt += 1;
                if (stringAt >= reverseString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    reverse = false;
                    java = false;
                    javaFinished3.SetActive(true);
                }
            }else if (javaGame == true)
            {
                textToDisplay.text += javaGameString[stringAt];
                stringAt += 1;
                if (stringAt >= javaGameString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    javaGame = false;
                    java = false;
                    javaFinished4.SetActive(true);
                }
            }else if (downloadSpeed == true)
            {
                textToDisplay.text += downloadSpeedString[stringAt];
                stringAt += 1;
                if (stringAt >= downloadSpeedString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    downloadSpeed = false;
                    java = false;
                    javaFinished5.SetActive(true);
                }
            }else if (supermarket == true)
            {
                textToDisplay.text += supermarketString[stringAt];
                stringAt += 1;
                if (stringAt >= supermarketString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    supermarket = false;
                    java = false;
                    javaFinished6.SetActive(true);
                }
            }
        }
        else if (python == true)
        {
            if (guessTheNumber == true)
            {
                textToDisplay.text += guessTheNumberString[stringAt];
                stringAt += 1;
                if (stringAt >= guessTheNumberString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    guessTheNumber = false;
                    python = false;
                    pythonFinished1.SetActive(true);
                }
            }else if (binarySearch == true)
            {
                textToDisplay.text += binarySearchString[stringAt];
                stringAt += 1;
                if (stringAt >= binarySearchString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    binarySearch = false;
                    python = false;
                    pythonFinished2.SetActive(true);
                }
            }else if (rockPaper == true)
            {
                textToDisplay.text += rockPaperString[stringAt];
                stringAt += 1;
                if (stringAt >= rockPaperString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    rockPaper = false;
                    python = false;
                    pythonFinished3.SetActive(true);
                }
            }else if (passwordGenerator == true)
            {
                textToDisplay.text += passwordGeneratorString[stringAt];
                stringAt += 1;
                if (stringAt >= passwordGeneratorString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    passwordGenerator = false;
                    python = false;
                    pythonFinished4.SetActive(true);
                }
            }else if (timer == true)
            {
                textToDisplay.text += timerString[stringAt];
                stringAt += 1;
                if (stringAt >= timerString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    timer = false;
                    python = false;
                    pythonFinished5.SetActive(true);
                }
            }else if (acronym == true)
            {
                textToDisplay.text += acronymString[stringAt];
                stringAt += 1;
                if (stringAt >= acronymString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    acronym = false;
                    python = false;
                    pythonFinished6.SetActive(true);
                }
            }
        }
        else if (javaScript == true)
        {
            if (todo == true)
            {
                textToDisplay.text += todoString[stringAt];
                stringAt += 1;
                if (stringAt >= todoString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    todo = false;
                    javaScript = false;
                    scriptFinished1.SetActive(true);
                }
            }
            else if (clock == true)
            {
                textToDisplay.text += clockString[stringAt];
                stringAt += 1;
                if (stringAt >= clockString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    clock = false;
                    javaScript = false;
                    scriptFinished2.SetActive(true);
                }
            }
            else if (showcase == true)
            {
                textToDisplay.text += showcaseString[stringAt];
                stringAt += 1;
                if (stringAt >= showcaseString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    showcase = false;
                    javaScript = false;
                    scriptFinished3.SetActive(true);
                }
            }
            else if (jsgame == true)
            {
                textToDisplay.text += jsgameString[stringAt];
                stringAt += 1;
                if (stringAt >= jsgameString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    jsgame = false;
                    javaScript = false;
                    scriptFinished4.SetActive(true);
                }
            }
            else if (bgcolor == true)
            {
                textToDisplay.text += bgcolorString[stringAt];
                stringAt += 1;
                if (stringAt >= bgcolorString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    bgcolor = false;
                    javaScript = false;
                    scriptFinished5.SetActive(true);
                }
            }
            else if (quiz == true)
            {
                textToDisplay.text += quizString[stringAt];
                stringAt += 1;
                if (stringAt >= quizString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    quiz = false;
                    javaScript = false;
                    scriptFinished6.SetActive(true);
                }
            }
        }
        else if (htmlCss == true)
        {
            if (survey == true)
            {
                textToDisplay.text += surveyString[stringAt];
                stringAt += 1;
                if (stringAt >= surveyString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    survey = false;
                    htmlCss = false;
                    htmlFinished1.SetActive(true);
                }
            }
            else if (parallax == true)
            {
                textToDisplay.text += parallaxString[stringAt];
                stringAt += 1;
                if (stringAt >= parallaxString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    parallax = false;
                    htmlCss = false;
                    htmlFinished2.SetActive(true);
                }
            }
            else if (website == true)
            {
                textToDisplay.text += htmlwebsiteString[stringAt];
                stringAt += 1;
                if (stringAt >= htmlwebsiteString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    website = false;
                    htmlCss = false;
                    htmlFinished3.SetActive(true);
                }
            }
            else if (typewriter == true)
            {
                textToDisplay.text += typewriterString[stringAt];
                stringAt += 1;
                if (stringAt >= typewriterString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    typewriter = false;
                    htmlCss = false;
                    htmlFinished4.SetActive(true);
                }
            }
            else if (bubble == true)
            {
                textToDisplay.text += bubbleString[stringAt];
                stringAt += 1;
                if (stringAt >= bubbleString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    bubble = false;
                    htmlCss = false;
                    htmlFinished5.SetActive(true);
                }
            }
            else if (counter == true)
            {
                textToDisplay.text += counterString[stringAt];
                stringAt += 1;
                if (stringAt >= counterString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    counter = false;
                    htmlCss = false;
                    htmlFinished6.SetActive(true);
                }
            }
        }
        else if (cSharp == true)
        {
            if (movement == true)
            {
                textToDisplay.text += movementString[stringAt];
                stringAt += 1;
                if (stringAt >= movementString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    movement = false;
                    cSharp = false;
                    cSharpFinished1.SetActive(true);
                }
            }
            else if (displayText == true)
            {
                textToDisplay.text += displayTextString[stringAt];
                stringAt += 1;
                if (stringAt >= displayTextString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    displayText = false;
                    cSharp = false;
                    cSharpFinished2.SetActive(true);
                }
            }
            else if (spawner == true)
            {
                textToDisplay.text += spawnerString[stringAt];
                stringAt += 1;
                if (stringAt >= spawnerString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    spawner = false;
                    cSharp = false;
                    cSharpFinished3.SetActive(true);
                }
            }
            else if (collision == true)
            {
                textToDisplay.text += collisionString[stringAt];
                stringAt += 1;
                if (stringAt >= collisionString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    collision = false;
                    cSharp = false;
                    cSharpFinished4.SetActive(true);
                }
            }
            else if (shooting == true)
            {
                textToDisplay.text += shootingString[stringAt];
                stringAt += 1;
                if (stringAt >= shootingString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    shooting = false;
                    cSharp = false;
                    cSharpFinished5.SetActive(true);
                }
            }
            else if (ai == true)
            {
                textToDisplay.text += aiString[stringAt];
                stringAt += 1;
                if (stringAt >= aiString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    ai = false;
                    cSharp = false;
                    cSharpFinished6.SetActive(true);
                }
            }
        }
        else if (pascal == true)
        {

        }
        else if (unity == true)
        {

        }
        else if (react == true)
        {
            if (carousel == true)
            {
                textToDisplay.text += carouselString[stringAt];
                stringAt += 1;
                if (stringAt >= carouselString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    carousel = false;
                    react = false;
                    reactFinished1.SetActive(true);
                }
            }else if (compass == true)
            {
                textToDisplay.text += compassString[stringAt];
                stringAt += 1;
                if (stringAt >= compassString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    compass = false;
                    react = false;
                    reactFinished2.SetActive(true);
                }
            }else if (voting == true)
            {
                textToDisplay.text += votingString[stringAt];
                stringAt += 1;
                if (stringAt >= votingString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    voting = false;
                    react = false;
                    reactFinished3.SetActive(true);
                }
            }else if (search == true)
            {
                textToDisplay.text += searchString[stringAt];
                stringAt += 1;
                if (stringAt >= searchString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    search = false;
                    react = false;
                    reactFinished4.SetActive(true);
                }
            }else if (reactGame == true)
            {
                textToDisplay.text += reactGameString[stringAt];
                stringAt += 1;
                if (stringAt >= reactGameString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    reactGame = false;
                    react = false;
                    reactFinished5.SetActive(true);
                }
            }else if (bill == true)
            {
                textToDisplay.text += billString[stringAt];
                stringAt += 1;
                if (stringAt >= billString.Length)
                {
                    shineOff.SetActive(false);
                    finished.SetActive(true);
                    stringAt = 0;
                    bill = false;
                    react = false;
                    reactFinished6.SetActive(true);
                }
            }
        }
  }

    //C++
    public void MusicPlayerEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cPlus = true;
            musicPlayer = true;
        }else
        {
            errorMessage.SetActive(true);
        }
    }
    public void CalendarEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cPlus = true;
            calendar = true;
        }else
        {
            errorMessage.SetActive(true);
        }
    }
    public void ATMEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cPlus = true;
            atm = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void ContactEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cPlus = true;
            contacts = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void EncryptedMessageEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cPlus = true;
            encryptedmessage = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void CPlusGameDevEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cPlus = true;
            cPlusGameDev = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }

    //javascript
    public void TodoEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            javaScript = true;
            todo = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void ClockEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            javaScript = true;
            clock = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void ShowcaseEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            javaScript = true;
            showcase = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void JsGameEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            javaScript = true;
            jsgame = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void BgColorEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            javaScript = true;
            bgcolor = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void QuizEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            javaScript = true;
            quiz = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }

    //html_Css
    public void SurveyEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            htmlCss = true;
            survey = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void ParallaxEnable()
    {
        if(cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            htmlCss = true;
            parallax = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void HtmlWebsiteEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            htmlCss = true;
            website = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void TypewriterEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            htmlCss = true;
            typewriter = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void BubbleEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            htmlCss = true;
            bubble = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void CounterEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            htmlCss = true;
            counter = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }

    //CSharp
    public void MovementEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cSharp = true;
            movement = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void DisplayTextEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cSharp = true;
            displayText = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void SpawnerEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cSharp = true;
            spawner = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void CollisionEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cSharp = true;
            collision = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void ShootingEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cSharp = true;
            shooting = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }public void AiEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            cSharp = true;
            ai = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }

    //react
    public void CarouselEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            react = true;
            carousel = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void CompassEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            react = true;
            compass = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void VotingEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            react = true;
            voting = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void SearchEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            react = true;
            search = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void GameReactEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            react = true;
            reactGame = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void BillEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            react = true;
            bill = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }

    //java
    public void PalindromeEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            java = true;
            palindrome = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void CountWordsEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            java = true;
            countWords = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void ReverseEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            java = true;
            reverse = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void JavaGameEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            java = true;
            javaGame = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void DownloadSpeedEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            java = true;
            downloadSpeed = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void SupermarketEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            java = true;
            supermarket = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }

    //python
    public void GuessTheNumberEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            python = true;
            guessTheNumber = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void BinarySearchEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            python = true;
            binarySearch = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void RockPaperEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            python = true;
            rockPaper = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void PasswordGeneratorEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            python = true;
            passwordGenerator = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void TimerEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            python = true;
            timer = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
    public void AcronymEnable()
    {
        if (cPlus == false && java == false && python == false && javaScript == false && htmlCss == false && cSharp == false && pascal == false && unity == false && react == false)
        {
            python = true;
            acronym = true;
        }
        else
        {
            errorMessage.SetActive(true);
        }
    }
}

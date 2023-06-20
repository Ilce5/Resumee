using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeSupply : MonoBehaviour
{
    // Easy 100-500 (ez) // medium 500-1200  (me) // hard 1200-2000   (ha) // 2000 + very hard (vh)
    
    private static string javaez0 = "public class Main string if {static Scanner s = new Scanner(System.in);public static void main(String[] args) { ArrayList<Integer> arr = new ArrayList<>();int len = s.nextInt();for(int i =0;i<len;i++){ arr.add(s.nextInt()); }Collections.sort(arr);Collections.reverse(arr);int sum = 0;int test for(int i =0;i<arr.size();i++){sum+=arr.get(i);test = 0;for(int j = i+1;j<arr.size();j++){test+=arr.get(j);}if(sum>len){System.out.println(i);return;}}System.out.println(arr.size());}}";
    private static string javaez1 = "import java.util.ArrayList;import java.util.Collections; import java.util.Scanner; public class Main { public static void main(String[] args) { Scanner scanner = new Scanner(System.in); ArrayList<Integer> array = new ArrayList<>(); String s = scanner.nextLine(); char lastchar ; int counter =0; lastchar = s.charAt(0); for (int i =1;i<s.length();i++){ if ((lastchar != 'a' && lastchar != 'e' && lastchar != 'i' && lastchar != 'o' && lastchar != 'u') && (s.charAt(i) !='a' && s.charAt(i) != 'e'&& s.charAt(i) != 'i' && s.charAt(i) != 'o'&& s.charAt(i) != 'u')){ counter++; } lastchar = s.charAt(i); } System.out.println(counter); } }";
    private static string javaez2 = "import java.util.ArrayList;import java.util.Collections; import java.util.Scanner; public class Main { static Scanner scanner = new Scanner(System.in); public static void main(String[] args) { int len_horz, len_vert; len_horz = scanner.nextInt(); len_vert = scanner.nextInt(); ArrayList<Integer> arr = new ArrayList<>(); int[][] mat = new int[len_horz][len_vert]; for (int i = 0; i < len_horz; i++) { for (int y = 0; y < len_vert; y++) { mat[i][y] = scanner.nextInt(); } } boolean istrue; for (int i = 0; i < len_horz; i++) { for (int y = 0; y < len_vert; y++) { arr_to_keep.clear(); istrue = true; if (i + 1 < len_horz) { if (mat[i][y] < mat[i + 1][y]) { arr_to_keep.add(mat[i + 1][y]); }else { istrue = false; } } if (i - 1 >= 0 && istrue) { if (mat[i][y] < mat[i - 1][y]) { istrue = true; arr_to_keep.add(mat[i - 1][y]); }else { istrue = false; } } if (y + 1 < len_vert && istrue) { if (mat[i][y] < mat[i][y + 1]) { istrue = true; arr_to_keep.add(mat[i][y + 1]); }else { istrue = false; } } if (y - 1 >= 0) { if (mat[i][y] < mat[i][y - 1] && istrue) { istrue = true; arr_to_keep.add(mat[i][y - 1]); }else { istrue = false; } } if (istrue) { Collections.sort(arr_to_keep); arr.add (arr_to_keep.get(0) - mat[i][y]); } } } Collections.sort(arr); Collections.reverse(arr); for(int item : arr){ System.out.println(item); } } }";
    private static string javaez3 = "import \"blandasdasdas\" java.util.ArrayList;import java.util.Collections;\"blandasdasdas\" import java.util.Scanner; public class Main { public static void main(String[] args) {Scanner scanner = new Scanner(System.in); ArrayList<Integer> array = new ArrayList<>(); int input = scanner.nextInt();\"blandasdasdas\" String s= \"\"; for(int i =2;i<Math.sqrt(input)+1;i++){ int counter = 0; while (input%i == 0){ counter++; input/=i; } if (counter>0){ s+=\"(\"+i+\"^\"+counter+ \")*\"; } }if (input>1){ s+=\"(\"+input+\"^1)\"; }else s = s.substring(0,s.length()-1);\"blandasdasdas\" System.out.println(s); } }";

    private static string cPlusez1 = "#include <iostream>using namespace std;int main() { int n, t1 = 0, t2 = 1, nextTerm = 0; cout << \"Enter the number of terms: \"; cin >> n; cout << \"Fibonacci Series: \"; for (int i = 1; i <= n; ++i) { .if(i == 1) { cout << t1 << \", \"; continue; } if(i == 2) { cout << t2 << \", \"; continue; } nextTerm = t1 + t2; t1 = t2; t2 = nextTerm; cout << nextTerm << \", \"; } return 0; }";

    private static string pythonez0 = "num = int(input(\"Enter a number: \"))`    if (num % 2) == 0:`    print(\"{0} is Even\".format(num))`       else:`    print(\"{0} is Odd\".format(num))";

    private static string csharpez0 = "public static void start just testing int float random for int  public, private,float else while"  ;

    private static string javascriptez0 =
        "let hcf;const number1 = prompt(\'Enter a first positive integer: \');const number2 = prompt(\'Enter a second positive integer: \');for (let i = 1; i <= number1 && i <= number2; i++) { if( number1 % i == 0 && number2 % i == 0) { hcf = i; } } console.log(\'HCF of ${number1} and ${number2} is ${hcf}.\');";
    
    private string[] javaEasy = {javaez1};
    private string[] javaMedium = {javaez1};
    private string[] javaHard= {javaez1};
    private string[] javaVeryHard = {javaez1};
    
    private string[] cPlusEasy = {cPlusez1};
    private string[] cPlusMedium = {cPlusez1};
    private string[] cPlusHard= {cPlusez1};
    private string[] cPlusVeryHard = {cPlusez1};

    private string[] PythonEasy = {pythonez0};
    private string[] PythonMedium = {pythonez0};
    private string[] PythonHard= {pythonez0};
    private string[] PythonVeryHard = {pythonez0};
    
    private string[] HtmlEasy = {};
    private string[] HtmlMedium = {};
    private string[] HtmlHard= {};
    private string[] HtmlVeryHard = {};
    
    private string[] JavaScriptEasy = {javascriptez0};
    private string[] JavaScriptMedium = {javascriptez0};
    private string[] JavaScriptHard= {javascriptez0};
    private string[] JavaScriptVeryHard = {javascriptez0};
    
    
    private string[] PascalEasy = {};
    private string[] PascalMedium = {};
    private string[] PascalHard= {};
    private string[] PascalVeryHard = {};
    
    private string[] CSharplEasy = {csharpez0};
    private string[] CSharpMedium = {csharpez0};
    private string[] CSharpHard= {csharpez0};
    private string[] CSharpVeryHard = {csharpez0};
  
    public string getNewCode (string level)
    {

        
        if (level == "javaez")
        {
            int number = UnityEngine.Random.Range(0, javaEasy.Length);
            return javaEasy[number];
        }
       else if (level == "javame")
        {
            int number = UnityEngine.Random.Range(0, javaMedium.Length);
            return javaMedium[number];
        }
       else if (level == "javaha")
        {
            int number = UnityEngine.Random.Range(0, javaHard.Length);
            return javaHard[number];
        }
       else if (level == "javavh")
        {
            int number = UnityEngine.Random.Range(0, javaVeryHard.Length);
            return javaVeryHard[number];
        }
        
        if (level == "cplusez")
        {
            int number = UnityEngine.Random.Range(0, cPlusEasy.Length);
            return cPlusEasy[number];
        }
        else if (level == "cplusme")
        {
            int number = UnityEngine.Random.Range(0, cPlusMedium.Length);
            return cPlusMedium[number];
        }
        else if (level == "cplusha")
        {
            int number = UnityEngine.Random.Range(0, cPlusHard.Length);
            return cPlusHard[number];
        }
        else if (level == "cplusvh")
        {
            int number = UnityEngine.Random.Range(0, cPlusVeryHard.Length);
            return cPlusVeryHard[number];
        }
        
        if (level == "pythonez")
        {
            int number = UnityEngine.Random.Range(0, PythonEasy.Length);
            return PythonEasy[number];
        }
        else if (level == "pythonme")
        {
            int number = UnityEngine.Random.Range(0, PythonMedium.Length);
            return PythonMedium[number];
        }
        else if (level == "pythonha")
        {
            int number = UnityEngine.Random.Range(0, PythonHard.Length);
            return PythonHard[number];
        }
        else if (level == "pythonvh")
         {
            int number = UnityEngine.Random.Range(0, PythonVeryHard.Length);
            return PythonVeryHard[number];
        }

        if (level == "htmlez")
        {
            int number = UnityEngine.Random.Range(0, HtmlEasy.Length);
            return HtmlEasy[number];
        }
        else if (level == "htmlme")
        {
            int number = UnityEngine.Random.Range(0, HtmlMedium.Length);
            return HtmlMedium[number];
        }
        else if (level == "htmlha")
        {
            int number = UnityEngine.Random.Range(0, HtmlHard.Length);
            return HtmlHard[number];
        }
        else if (level == "htmlvh")
        {
            int number = UnityEngine.Random.Range(0, HtmlVeryHard.Length);
            return HtmlVeryHard[number];
        }

        if (level == "javascriptez")
        {
            int number = UnityEngine.Random.Range(0, JavaScriptEasy.Length);
            return JavaScriptEasy[number];
        }
        else if (level == "javascriptme")
        {
            int number = UnityEngine.Random.Range(0, JavaScriptMedium.Length);
            return JavaScriptMedium[number];
        }
        else if (level == "javascriptha")
        {
            int number = UnityEngine.Random.Range(0, JavaScriptHard.Length);
            return JavaScriptHard[number];
        }
        else if (level == "javascriptvh")
        {
            int number = UnityEngine.Random.Range(0, JavaScriptVeryHard.Length);
            return JavaScriptVeryHard[number];
        }

        if (level == "pascalez")
        {
            int number = UnityEngine.Random.Range(0, PascalEasy.Length);
            return PascalEasy[number];
        }
        else if (level == "pascalme")
        {
            int number = UnityEngine.Random.Range(0, PascalMedium.Length);
            return PascalMedium[number];
        }
        else if (level == "pascalha")
        {
            int number = UnityEngine.Random.Range(0, PascalHard.Length);
            return PascalHard[number];
        }
        else if (level == "pascalvh")
        {
            int number = UnityEngine.Random.Range(0, PascalVeryHard.Length);
            return PascalVeryHard[number];
        }

        if (level == "csharpez")
        {
            int number = UnityEngine.Random.Range(0, CSharplEasy.Length);
            return CSharplEasy[number];
        }
        else if (level == "csharpme")
        {
            int number = UnityEngine.Random.Range(0, CSharpMedium.Length);
            return CSharpMedium[number];
        }
        else if (level == "csharpha")
        {
            int number = UnityEngine.Random.Range(0, CSharpHard.Length);
            return CSharpHard[number];
        }
        else if (level == "csharpvh")
        {
            int number = UnityEngine.Random.Range(0, CSharpVeryHard.Length);
            return CSharpVeryHard[number];
        }

        return null;
    }
   
    
}

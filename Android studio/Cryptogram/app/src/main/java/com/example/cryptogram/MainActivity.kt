package com.example.cryptogram

import android.graphics.PorterDuff
import android.graphics.PorterDuffColorFilter
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.TextView
import androidx.appcompat.app.AppCompatActivity
import androidx.core.content.ContextCompat
import org.w3c.dom.Text
import java.util.*
import kotlin.collections.ArrayList
import kotlin.math.log
import java.util.Random


class MainActivity : AppCompatActivity() {
    val numberOfSentence : Int = 0
    //val txt : TextView
    var charOfSentence = Vector<Char>()
    var tvID : ArrayList<TextView> = arrayListOf()
    var hintID : ArrayList<TextView> = arrayListOf()
    var allSentences : Array<String> = arrayOf()
    var sameLetters : ArrayList<Int> = arrayListOf()
    val encryptedLetters : ArrayList<Char> = arrayListOf('Ж','Ќ', 'Ч', 'Ѓ', 'Ш', 'П', 'М', 'Н', 'Б', 'Л', 'К', 'Ј', 'О', 'И', 'У', 'В', 'Џ', 'Ц', 'Х', 'Г', 'Ф', 'Ѕ', 'Т', 'Р', 'Џ', 'З', 'Д', 'С', 'А', 'Е', 'Њ', 'Љ')
    var numberOfLetter : Int = 0

    override fun onCreate(savedInstanceState: Bundle?) {

        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)


        //Taking sentences from string folder
        allSentences =  resources.getStringArray(R.array.sentences)

        //Identifying all textviews
        for(i in 1 until 61){
            tvID.add(findViewById<TextView>(resources.getIdentifier(
                "letter$i", "id", this.packageName)))
            hintID.add(findViewById<TextView>(resources.getIdentifier(
                "hint$i", "id", this.packageName)))
        }

        newSentence()
        encryptSentence()

    }

    //Set the drawable color of the selected textview
    private fun setTextViewDrawableColor(textView: TextView, color: Int) {

        for (drawable in textView.compoundDrawables) {

            if (drawable != null) {

                drawable.colorFilter =
                    PorterDuffColorFilter(
                        ContextCompat.getColor(textView.context, color),
                        PorterDuff.Mode.SRC_IN)

            }
        }
    }

    //Initializing a new sentence
    private fun newSentence(){

        val sentence = allSentences[numberOfSentence]
        charOfSentence.clear()

        for (i in sentence.indices) {

            charOfSentence.add(sentence[i])

            if(sentence[i].isWhitespace()){
                setTextViewDrawableColor(tvID[i], R.color.red)
            }else{
                setTextViewDrawableColor(tvID[i], R.color.cyan_dark)
            }
        }

        for(i in sentence.length until tvID.size){

            setTextViewDrawableColor(tvID[i], R.color.gray_dark)

        }
    }

    //Find and initialize same letters
    private fun findSameTV(num : Int) {

        sameLetters.clear()

        if(num <= charOfSentence.size) {
            if (!charOfSentence[num].isWhitespace()) {

                //Finding same letters
                for (i in 0 until charOfSentence.size) {

                    if (charOfSentence[i] == charOfSentence[num]) {

                        setTextViewDrawableColor(tvID[i], R.color.white)
                        sameLetters.add(i)
                    }

                }
            }
        }
    }

    //Encrypting sentence - hint
    private fun encryptSentence(){

        val usedLetters = encryptedLetters
        val newSentence : ArrayList<Char> = arrayListOf()
        newSentence.addAll(charOfSentence)
        var randNum : Int

            for(i in 0 until newSentence.size) {

                if(newSentence[i] != '1') {

                    randNum = (0 until usedLetters.size).random()
                    //charString = usedLetters[randNum].toString()
                    hintID[i].text = usedLetters[randNum].toString()

                    for (j in i + 1 until newSentence.size) {

                        if (newSentence[i] == newSentence[j]) {

                            hintID[j].text = usedLetters[randNum].toString()
                            newSentence[j] = '1'

                        }
                    }
                    newSentence[i] = '1'
                        usedLetters.removeAt(randNum)
                }
            }
    }

    //Removes previously initialized letters
    private fun removeInitializedLetters(){

        if(sameLetters.size > 0) {
            if (tvID[sameLetters[0]].text.toString().isEmpty()) {

                for (i in 0 until sameLetters.size) {

                    setTextViewDrawableColor(tvID[sameLetters[i]], R.color.cyan_dark)

                }

            } else {

                for (i in 0 until sameLetters.size) {

                    setTextViewDrawableColor(tvID[sameLetters[i]], R.color.cyan)

                }
            }
        }

    }

    //TextView onClick
    fun charToEnter(view: View) {

        removeInitializedLetters()
        findSameTV(tvID.indexOf(view))
        numberOfLetter =  tvID.indexOf(view)

    }

    //Keyboards onClick
    fun keyboardClick(view: View) {

        if(sameLetters.size > 0) {
            for (i in 0 until sameLetters.size) {

                tvID[sameLetters[i]].text = (view as TextView).text

            }
        }
    }

    fun nextLetter(view: View) {
        if(sameLetters.size > 0){
            removeInitializedLetters()
            findSameTV(numberOfLetter+1)
            numberOfLetter++
        }
    }

    fun deleteLetter(view: View) {
        if(sameLetters.size > 0) {
            for (i in 0 until sameLetters.size) {

                tvID[sameLetters[i]].text = ""

            }
        }
    }
}
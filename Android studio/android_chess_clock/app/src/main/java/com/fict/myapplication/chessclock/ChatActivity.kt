package com.fict.myapplication.chessclock

import android.content.Intent
import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.platform.LocalContext
import androidx.compose.ui.res.stringResource
import androidx.compose.ui.tooling.preview.Preview
import com.fict.example.componentsplayground.activities.tempates.ClockModel
import com.fict.myapplication.chessclock.ui.theme.ChessClockTheme
import io.getstream.chat.android.client.ChatClient
import io.getstream.chat.android.client.logger.ChatLogLevel
import io.getstream.chat.android.client.models.User
import io.getstream.chat.android.compose.ui.channels.ChannelsScreen
import io.getstream.chat.android.compose.ui.theme.ChatTheme
import kotlinx.coroutines.flow.MutableStateFlow
import kotlinx.coroutines.flow.asStateFlow
import kotlinx.coroutines.flow.update

data class ChatData(
    //val messages : HashMap<Int, String> = HashMap<Int, String>()
    //val messages: MutableList<Pair<Int, String>> = mutableListOf<Pair<Int,String>>()
    var messages: ArrayList<String> = ArrayList<String>()
        )
private val _uiState2 = MutableStateFlow<ChatData>(ChatData())
val uiState2 = _uiState2.asStateFlow()
class ChatActivity : ComponentActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        setContent {
            ChessClockTheme {
                // A surface container using the 'background' color from the theme
                Surface(
                    modifier = Modifier.fillMaxSize(),
                    color = MaterialTheme.colors.background
                ) {
                    MainScreen()
                }
            }
        }
    }
}

@Composable
fun MainScreen(){
    var messages: MutableState<ArrayList<Pair<Int, String>>> = remember {
        mutableStateOf(ArrayList())
    }
    var textToSend by remember {
        mutableStateOf("")
    }
    val idOfUser = 1234

    Column(modifier = Modifier.fillMaxSize()) {
        Row(modifier = Modifier
            .weight(10f)
            .fillMaxSize(), horizontalArrangement = Arrangement.SpaceBetween, verticalAlignment = Alignment.CenterVertically){
            BackButton()
            Text(text = "Name")
            Button(onClick = { /*TODO*/ }) {

            }
        }
            LazyColumn(modifier = Modifier
                .weight(80f)
                .fillMaxSize()) {
                items(messages.value.size) { index ->
                   Text(text = messages.value[index].toString())
                }
            }

            Row(modifier = Modifier
                .weight(10f)
                .fillMaxSize(), horizontalArrangement = Arrangement.SpaceBetween, verticalAlignment = Alignment.CenterVertically){
            Button(onClick = { /*TODO*/ }) {
            }
            OutlinedTextField(value = textToSend, label = {Text(text = "Send Message")}, onValueChange = {textToSend = it})
            Button(onClick = {
                messages.value.add(Pair(idOfUser, textToSend))
                textToSend = ""
                println("SIZEEEE ${uiState2.value.messages.size}")
                }) {
            }
        }
    }
}
@Composable
fun BackButton(){
    val context = LocalContext.current
    Button(onClick = {
        context.startActivity(Intent(context, ClockModel::class.java)) },
    ) {
    }
}

@Composable
fun Greeting(name: String) {
    Text(text = "Hello $name!")
}

@Preview(showBackground = true)
@Composable
fun DefaultPreview2() {
    ChessClockTheme {
        Greeting("Android")
    }
}
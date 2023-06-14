package com.example.firstapplication;

import androidx.appcompat.app.AppCompatActivity;
import androidx.constraintlayout.widget.ConstraintLayout;

import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Toast;

import com.google.android.material.snackbar.Snackbar;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    boolean missingInput = false;
    boolean samePassword = false;
    private ConstraintLayout parent;
    private EditText editName;
    private EditText editEmail;
    private EditText editPassword;
    private EditText editPassword2;
    private CheckBox checkBox;
   // Button registerButton = findViewById(R.id.registerButton);
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        parent = findViewById(R.id.parent);
        editName = findViewById(R.id.editName);
        editEmail = findViewById(R.id.editEmail);
        editPassword = findViewById(R.id.editPassword);
        editPassword2 = findViewById(R.id.editPassword2);
        checkBox = findViewById(R.id.checkBox);
    }

    public void onClickAction(View view){
        CheckRegistration();
            if (!missingInput) {
                if(samePassword) {
                    Snackbar.make(parent, "Successfully registered", Snackbar.LENGTH_INDEFINITE)
                            .setAction("Undo", view1 -> {
                                editName.setText("");
                                editEmail.setText("");
                                editPassword.setText("");
                                editPassword2.setText("");
                                checkBox.setChecked(false);
                            }).show();
                }else{
                    Toast.makeText(this, "Passwords doesn't match", Toast.LENGTH_SHORT).show();
                }
            } else {
                Toast.makeText(this, "You have empty fields", Toast.LENGTH_SHORT).show();
            }
    }

    public void CheckRegistration(){
        missingInput = false;
        samePassword = false;

        ArrayList<String> checkEdit = new ArrayList<>();
        checkEdit.add(editName.getText().toString());
        checkEdit.add(editEmail.getText().toString());
        checkEdit.add(editPassword.getText().toString());
        checkEdit.add(editPassword2.getText().toString());

        samePassword = editPassword.getText().toString().equals(editPassword2.getText().toString());
        
        int number = 0;
        if(checkBox.isChecked()) {
            while (number < checkEdit.size() && !missingInput) {
                if (checkEdit.get(number).equals("")) {
                    missingInput = true;
                }
                number++;
            }
        }else{
            missingInput = true;
        }

    }


}
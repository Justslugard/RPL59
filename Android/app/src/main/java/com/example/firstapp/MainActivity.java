package com.example.firstapp;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        EditText username = findViewById(R.id.username);
        EditText pw = findViewById(R.id.pass);
        Button btn = findViewById(R.id.button);

        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String input = username.getText().toString();
                String ps = pw.getText().toString();

                if (input.equals("Wok") && ps.equals("admin#123")) {
                    Intent intent = new Intent(MainActivity.this, Home.class);
                    startActivity(intent);
                    Toast.makeText(MainActivity.this, "Welcome Aboard Captain", Toast.LENGTH_SHORT).show();

                } else {
                    Toast.makeText(MainActivity.this, "Who?", Toast.LENGTH_SHORT).show();
                }
            }
        });

    }
}